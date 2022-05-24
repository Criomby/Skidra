# Copyright 2022 Braum
# philippebraum@pm.me
# www.philippebraum.de

# version 1.3

import pandas as pd
from pandas.api.types import CategoricalDtype
import xlsxwriter
from distutils import util
import json
import datetime
import os
import sys


class App:

    def __init__(self):
        self.WIDTH = 127  # width of textbox in Skidra interface
        print(sys.argv[1])
        args = json.loads(sys.argv[1])
        print('args:', args)
        sys.exit(0)

        self.company_data_filepath = args['filepath']
        self.data_file_directory = args['fileDir']
        self.new_filepath = self.data_file_directory + f'\\Skidra_export_{datetime.date.today()}.xlsx'

        try:
            self.hubspot_org = pd.read_csv(self.company_data_filepath)
        except FileNotFoundError as e:
            print(repr(e))
            print(f'\nFile could not be found:\n{self.company_data_filepath}\n\nPlease remove any whitespace in the filename and try again.')
        
        COLUMNS = ['Company name', 'Lead Status', 'Industry', 'Company owner', 'Create Date', 'Pitch', 'Reason for rejection / unsuitability']
        self.check_column_names(COLUMNS)

        self.excel = bool(util.strtobool(args['excel']))
        self.allchk = bool(util.strtobool(args['all']))
        self.ind = bool(util.strtobool(args['ind']))
        self.lds = bool(util.strtobool(args['lds']))
        self.ldsind = bool(util.strtobool(args['ldsind']))
        self.top = bool(util.strtobool(args['top']))
        self.pit = bool(util.strtobool(args['pit']))
        self.res = bool(util.strtobool(args['res']))

        self.process()

    def process(self):
        print('-'*self.WIDTH)
        if self.excel and os.path.isfile(self.new_filepath):
            try:
                os.remove(self.new_filepath)
                print('Existing Excel file overwritten.')
                print('-'*self.WIDTH)
            except PermissionError:
                print(f'Existing savefile in use by another process.\nClose the file and try again.\n({self.new_filepath})')
                print('-'*self.WIDTH)
                sys.exit()
        if self.excel:
            print(f'Excel file generated and saved:\n{self.new_filepath}')
            print('-' * self.WIDTH)
        if self.ind or self.allchk:
            inds = self.get_industries()
        if self.lds or self.allchk:
            leads = self.get_leads()
        if self.ldsind or self.allchk:
            ldsbyind = self.get_leadsbyindustry()
        if self.top or self.allchk:
            topleads = self.get_topleads()
        if self.pit or self.allchk:
            pitches = self.get_pitches()
        if self.res or self.allchk:
            reasons = self.get_reasons()
        if self.excel:
            with pd.ExcelWriter(self.new_filepath) as writer:
                if self.lds or self.allchk:
                    leads.reset_index(drop=True, inplace=True)
                    leads.to_excel(writer, sheet_name='Leads', index=False)
                    workbook = writer.book
                    worksheet_leads = writer.sheets['Leads']
                    chart_leads = workbook.add_chart({'type': 'bar'})
                    chart_leads.add_series({
                        'categories': '=Leads!$A$2:$A$9',
                        'values': '=Leads!$B$2:$B$9',
                        'data_labels': {'value': True},
                        'points': [
                            {'fill': {'color': '#9da7b2'}},
                            {'fill': {'color': '#5c7f90'}},
                            {'fill': {'color': '#005778'}},
                            {'fill': {'color': '#f2a007'}},
                            {'fill': {'color': '#5b7b63'}},
                            {'fill': {'color': '#8c0410'}},
                            {'fill': {'color': '#a55b75'}},
                        ]
                    })
                    chart_leads.set_x_axis({'name': 'Number of companies'})
                    chart_leads.set_y_axis({'name': 'Status', 'reverse': True})
                    chart_leads.set_legend({'none': True})
                    chart_leads.set_title({'name': 'All lead categories'})
                    worksheet_leads.insert_chart('E2', chart_leads)
                    worksheet_leads.set_column(0, 0, 15)
                if self.ind or self.allchk:
                    inds.reset_index(drop=True, inplace=True)
                    inds.to_excel(writer, sheet_name='Industries', index=False)
                    workbook = writer.book
                    worksheet_industries = writer.sheets['Industries']
                    chart_industries = workbook.add_chart({'type': 'pie'})
                    chart_industries.add_series({
                    'categories': '=Industries!$A$2:$A$16',
                    'values': '=Industries!$B$2:$B$16',
                    'data_labels': {'value': True},
                    })
                    chart_industries.set_title({'name': 'All industries'})
                    worksheet_industries.insert_chart('E2', chart_industries)
                    worksheet_industries.set_column(0, 0, 22)
                if self.ldsind or self.allchk:
                    ldsbyind.reset_index(drop=True, inplace=True)
                    ldsbyind.to_excel(writer, sheet_name='Leads_by_industries', index=False)
                    worksheet_leadsbyindustries = writer.sheets['Leads_by_industries']
                    worksheet_leadsbyindustries.set_column(0, 0, 19)
                if self.top or self.allchk:
                    topleads.reset_index(drop=True, inplace=True)
                    topleads.to_excel(writer, sheet_name='Topleads', index=False)
                    worksheet_topleads = writer.sheets['Topleads']
                    worksheet_topleads.set_column(0, 0, 34)
                    worksheet_topleads.set_column(1, 1, 14)
                    worksheet_topleads.set_column(2, 2, 18)
                    worksheet_topleads.set_column(3, 3, 20)
                if self.pit or self.allchk:
                    pitches.reset_index(drop=True, inplace=True)
                    pitches.to_excel(writer, sheet_name='Pitches', index=False)
                    worksheet_pitches = writer.sheets['Pitches']
                    worksheet_pitches.set_column(0, 0, 21)
                    worksheet_pitches.set_column(1, 1, 39)
                if self.res or self.allchk:
                    reasons.reset_index(drop=True, inplace=True)
                    reasons.to_excel(writer, sheet_name='Rejection reasons', index=False)
                    worksheet_reasons = writer.sheets['Rejection reasons']
                    worksheet_reasons.set_column(0, 0, 37)
                    worksheet_reasons.set_column(1, 1, 18)
                    worksheet_reasons.set_column(2, 2, 12)
                    worksheet_reasons.set_column(3, 3, 70)

    def check_column_names(self, columns):
        columns_file = self.hubspot_org.columns.values.tolist()
        error = False
        missing = list()
        for i in range(0, len(columns), 1):
            if columns[i] not in columns_file:
                error = True
                missing.append(columns[i])
        if error:
            print('The following column(s) and corresponding data is missing from the database file:\n')
            for i in missing:
                print(f'--- {i} ---')
            print('\nPlease add the missing data and try again.\n\nFor additional information on file requirements see GitHub.')
            sys.exit()        

    def get_leads(self):
        leads = self.lead_count()
        print(f'Leads:\n\n{leads}')
        print('-'*self.WIDTH)
        return leads

    def lead_count(self):
        csv1 = self.hubspot_org[['Company name', 'Lead Status', 'Industry']].groupby(
            'Lead Status').size().to_frame().reset_index()
        csv1 = csv1.rename(columns={'Lead Status': 'Description', 0: 'Count'})
        lead_cat_order = CategoricalDtype(['Cold', 'Cold Contacted', 'Warm', 'Follow-up', 'Qualified Lead',
                                           'Contract', 'Rejected', 'Ineligible'], ordered=True)
        csv1['Description'] = csv1['Description'].astype(lead_cat_order)
        leads_inorder = csv1.sort_values('Description')
        return leads_inorder

    def get_industries(self):
        industries = self.industry_count()
        print(f'Industries:\n\n{industries}')
        print('-'*self.WIDTH)
        return industries

    def industry_count(self):
        csv1 = self.hubspot_org[['Company name', 'Lead Status', 'Industry']].groupby('Industry').size().to_frame().reset_index()
        csv1 = csv1.rename(columns={'Industry': 'Description', 0: 'Count'})
        cats_disordered = csv1.sort_values(by='Count', ascending=False)
        return cats_disordered

    def get_leadsbyindustry(self):
        ldsbyind = self.leadsbyindustry()
        print(f'Leads per Industry:\n\n{ldsbyind}')
        print('-'*self.WIDTH)
        return ldsbyind

    def leadsbyindustry(self):
        csv1 = self.hubspot_org[['Lead Status', 'Industry']]
        total = pd.DataFrame([['', '']], columns=pd.Index(['Lead Status', 0], dtype='object'))
        empt = pd.DataFrame([['', '']], columns=pd.Index(['Lead Status', 0], dtype='object'))
        industries = csv1['Industry'].unique().tolist()
        for i in industries:
            x = csv1[csv1['Industry'] == i].groupby(
                'Lead Status').size().to_frame().reset_index().sort_values(by=[0], ascending=False)
            dfx = pd.DataFrame([[i, '']], columns=x.columns)
            total = total.append(dfx).append(x).append(empt)
        total.rename(columns={'Lead Status': 'Description', 0: 'Count'}, inplace=True)
        return total

    def get_topleads(self):
        topleads = self.topleads()
        print(f'Topleads:\n\n{topleads}')
        print('-'*self.WIDTH)
        return topleads

    def topleads(self):
        csv1 = self.hubspot_org[['Company name', 'Lead Status', 'Industry', 'Company owner']]
        tanalysis_topleads_followup = csv1[csv1['Lead Status'] == 'Follow-up']
        tanalysis_topleads_qualified = tanalysis_topleads_followup.append(csv1[csv1['Lead Status'] == 'Qualified Lead'])
        tanalysis_topleads = tanalysis_topleads_qualified.append(csv1[csv1['Lead Status'] == 'Contract'])
        return tanalysis_topleads

    def get_pitches(self):
        pitches = self.pitches()
        print(f'Pitchlist:\n\n{pitches}')
        print('-'*self.WIDTH)
        return pitches

    def pitches(self):
        csv1 = self.hubspot_org[['Company name', 'Pitch']]
        filtered_csv1 = csv1[csv1['Pitch'].notnull()]
        result = filtered_csv1.sort_values(by='Pitch')
        return result

    def get_reasons(self):
        reasons = self.reasons()
        print(f'Rejection reasons:\n\n{reasons}')
        print('-'*self.WIDTH)
        return reasons

    def reasons(self):  # reject reasons
        csv1 = self.hubspot_org[['Company name', 'Industry', 'Lead Status', 'Reason for rejection / unsuitability']]
        filtered_csv1 = csv1[csv1['Reason for rejection / unsuitability'].notnull()]
        result = filtered_csv1.sort_values(by='Lead Status')
        return result

    def printall_org_table(self):
        csv1 = self.hubspot_org[['Company name', 'Lead Status', 'Industry', 'Create Date']]
        return csv1


if __name__ == '__main__':
    App()
