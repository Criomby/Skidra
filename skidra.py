# Copyright 2022 Braum
# philippebraum@pm.me
# www.philippebraum.de

import pandas as pd
from pandas.api.types import CategoricalDtype
import xlsxwriter
from distutils import util
import datetime
import os
import sys


class App:

    def __init__(self):
        # self.table_savestate1 = pd.DataFrame()
        self.tb_width = 127
        self.company_data_filepath = sys.argv[1]
        self.new_filepath = self.company_data_filepath[:-48] + f'Hubspool_{datetime.date.today()}.xlsx'
        self.excel = bool(util.strtobool(sys.argv[2]))
        self.allchk = bool(util.strtobool(sys.argv[3]))
        self.ind = bool(util.strtobool(sys.argv[4]))
        self.lds = bool(util.strtobool(sys.argv[5]))
        self.ldsind = bool(util.strtobool(sys.argv[6]))
        self.top = bool(util.strtobool(sys.argv[7]))
        self.pit = bool(util.strtobool(sys.argv[8]))
        self.res = bool(util.strtobool(sys.argv[9]))
        self.checks()

    def checks(self):
        print('-'*self.tb_width)
        if self.excel and os.path.isfile(self.new_filepath):
            try:
                os.remove(self.new_filepath)
                print('Existing Excel file overwritten.')
                print('-'*self.tb_width)
            except PermissionError:
                print(f'Existing savefile in use by another process.\nClose the file and try again.\n({self.new_filepath})')
                print('-'*self.tb_width)
                sys.exit()
        if self.excel:
            print(f'Excel file generated and saved:\n{self.new_filepath}')
            print('-' * self.tb_width)
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

    def get_leads(self):
        leads = lead_count(self.company_data_filepath)
        print(f'Leads:\n\n{leads}')
        print('-'*self.tb_width)
        return leads

    def get_industries(self):
        industries = industry_count(self.company_data_filepath)
        print(f'Industries:\n\n{industries}')
        print('-'*self.tb_width)
        return industries

    def get_leadsbyindustry(self):
        ldsbyind = leadsbyindustry(self.company_data_filepath)
        print(f'Leads per Industry:\n\n{ldsbyind}')
        print('-'*self.tb_width)
        return ldsbyind

    def get_topleads(self):
        topleads = get_topleads(self.company_data_filepath)
        print(f'Topleads:\n\n{topleads}')
        print('-'*self.tb_width)
        return topleads

    def get_pitches(self):
        pitches = get_pitches(self.company_data_filepath)
        print(f'Pitchlist:\n\n{pitches}')
        print('-'*self.tb_width)
        return pitches

    def get_reasons(self):
        reasons = reject_reasons(self.company_data_filepath)
        print(f'Rejection reasons:\n\n{reasons}')
        print('-'*self.tb_width)
        return reasons


def lead_count(inputfile):
    hubspot_org = pd.read_csv(inputfile)
    csv1 = hubspot_org[['Company name', 'Lead Status', 'Industry']].groupby(
        'Lead Status').size().to_frame().reset_index()
    csv1 = csv1.rename(columns={'Lead Status': 'Description', 0: 'Count'})
    lead_cat_order = CategoricalDtype(['Cold', 'Cold Contacted', 'Warm', 'Follow-up', 'Qualified Lead',
                                       'Contract', 'Rejected', 'Ineligible'], ordered=True)
    csv1['Description'] = csv1['Description'].astype(lead_cat_order)
    leads_inorder = csv1.sort_values('Description')
    return leads_inorder


def industry_count(inputfile):
    hubspot_org = pd.read_csv(inputfile)
    csv1 = hubspot_org[['Company name', 'Lead Status', 'Industry']].groupby('Industry').size().to_frame().reset_index()
    csv1 = csv1.rename(columns={'Industry': 'Description', 0: 'Count'})
    cats_disordered = csv1.sort_values(by='Count', ascending=False)
    return cats_disordered


def get_topleads(inputfile):
    hubspot_org = pd.read_csv(inputfile)
    csv1 = hubspot_org[['Company name', 'Lead Status', 'Industry', 'Company owner']]
    tanalysis_topleads_followup = csv1[csv1['Lead Status'] == 'Follow-up']
    tanalysis_topleads_qualified = tanalysis_topleads_followup.append(csv1[csv1['Lead Status'] == 'Qualified Lead'])
    tanalysis_topleads = tanalysis_topleads_qualified.append(csv1[csv1['Lead Status'] == 'Contract'])
    return tanalysis_topleads


def printall_org_table(inputfile):
    hubspot_org = pd.read_csv(inputfile)
    csv1 = hubspot_org[['Company name', 'Lead Status', 'Industry', 'Create Date']]
    return csv1


def leadsbyindustry(inputfile):
    hubspot_org = pd.read_csv(inputfile)
    csv1 = hubspot_org[['Lead Status', 'Industry']]
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


def get_pitches(inputfile):
    hubspot_org = pd.read_csv(inputfile)
    csv1 = hubspot_org[['Company name', 'Pitch']]
    filtered_csv1 = csv1[csv1['Pitch'].notnull()]
    result = filtered_csv1.sort_values(by='Pitch')
    return result


def reject_reasons(inputfile):
    hubspot_org = pd.read_csv(inputfile)
    csv1 = hubspot_org[['Company name', 'Industry', 'Lead Status', 'Reason for rejection / unsuitability']]
    filtered_csv1 = csv1[csv1['Reason for rejection / unsuitability'].notnull()]
    result = filtered_csv1.sort_values(by='Lead Status')
    return result


if __name__ == '__main__':
    App()
