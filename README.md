<p align='center'><img src="https://user-images.githubusercontent.com/86114549/148660875-6ba0a22e-668e-4efb-9bf9-df6935add889.png" alt="Skidra_Logo_comp" width="300">

<p align='center'>A program to generate quantivative &amp; qualitative statistics from .csv database files to Excel via a simple UI<br>
<i>(Successor of <a href='https://github.com/Criomby/hubspool'>Hubspool</a>)</i><br>
<br>

<p align='center'><img width="591" alt="Screenshot 2022-01-08 233034" src="https://user-images.githubusercontent.com/86114549/148700854-585f62be-f07f-4c67-849b-e8b7716e0049.png"></p>
<br>

## Download Info: <br>
<h3> Latest ready-to-use version (Windows only):</h3>
<h3><a href='https://github.com/Criomby/Skidra/releases/tag/v1.2.1'>Download Skidra</a><br></h3>
<br>
Download the .exe and execute it as an administrator.<br>
<br>
If you have issues running the program, see the manual or the FAQ below.<br>
<h3>Be reassured: It's open source and safe for you and your data!</h3><br>

Verify your download:<br>
(SHA256sum) 539a98b830001c4b6b41eac15cc8dae40d7d13b6804df1d0d3db0e3492d6c35b<br>
(To verify your download you can use the <a href='https://github.com/Criomby/AutoHasher'>AutoHasher</a>)
<br>
<br>

## Getting started:
<i>Skidra requires you to have Python installed.<br>
For more information of the initial setup see user manual below.</i><br>

<strong>Action!</strong><br>
> 
> <strong>1. Select file:</strong> Select the .csv data file you want to analyze.<br>
> <strong>2. Options:</strong> Check the desired functions (see below).<br>
> <strong>3. Process:</strong> Execute checked functions.<br>
<br>

<strong>Options</strong><br>
> <strong>Generate Excel:</strong> Saves the output into an Excel file (see below)<br>
> <strong>ALL:</strong> Executes all analyzes mentioned below<br>
> 
> <strong>Industries:</strong> How many companies are in each industry.<br>
> <strong>Leads:</strong> How many leads are in each lead category.<br>
> <strong>Leads/ind.:</strong> How many leads in lead categories per industry.<br>
> <strong>Topleads:</strong> All companies with lead status 'Qualified Lead', 'Follow-up' or 'Contract'.<br>
> <strong>Pitches:</strong> All companies with pitch data and the respective data.<br>
> <strong>Reasons:</strong> All companies with reasons data and the respective data.<br>
<br>

## User manual:
### Initial setup
When starting Skidra for the first time, you have to select the location of your Python distribution & Skidra Python script.<br>

<i><b>Notice:</b> You have to have Python installed.<br>
If you do not have Python installed, you can get it on the <a href='https://www.python.org/downloads/'>official Website</a> or the <a href='https://www.microsoft.com/store/productId/9PJPW5LDXLZ5'>Windows Store</a>.</i><br>

<img width="350" alt="Screenshot 2022-01-08 232136" src="https://user-images.githubusercontent.com/86114549/148699791-ef1705a7-9126-4e3a-bea7-ff2f916c24dc.png">
<br>

Select the Python.exe:<br>
<img width="600" alt="Screenshot 2022-01-08 232136" src="https://user-images.githubusercontent.com/86114549/148700089-20da7134-b99d-4291-804e-74c7b62a8f4c.png">
<br>
<br>
Then select the location of the Skidra Python script:<br>
<img width="350" alt="Screenshot 2022-01-08 232302" src="https://user-images.githubusercontent.com/86114549/148700220-179f8acb-a276-428b-9b66-1d1bbad5820f.png">
<br>
<img width="600" alt="Screenshot 2022-01-08 232431" src="https://user-images.githubusercontent.com/86114549/148700223-e2a8e713-e2d6-479e-82cb-e7f5184cc165.png">
<br>
<br>
After that, the program will start right up each time, unless the Python.exe or Python script is moved.<br>
<br>
<br>

### Operation

<i>Buttons and checkboxes are explained <a href='https://github.com/Criomby/Skidra#getting-started'>above</a> already, so here are some examples of operation:</i><br>
<br>
Select a .csv file: (For informations regarding file requirements see below).<br>
<br>
<img width="650" alt="Screenshot 2022-01-08 232451" src="https://user-images.githubusercontent.com/86114549/148700942-2741a9ab-5220-41b5-8226-7a920bb7257d.png">
<br>
<img width="650" alt="Screenshot 2022-01-08 232602" src="https://user-images.githubusercontent.com/86114549/148700974-7183225e-73c2-4416-8551-a4dfde5a7026.png">
<br>
<br>
If you select 'ALL' every check will be processed, alternatively you can also select checks individually.<br>

The output will be displayed in the textbox.<br>

<img width="650" alt="Screenshot 2022-01-08 233034" src="https://user-images.githubusercontent.com/86114549/148701179-8617e831-2079-481f-9ec4-9ece53d8931e.png">


If you select 'Generate Excel', the Excel file will be saved next to your source .csv file.<br>
Also, the filepath of the Excel is shown on top.<br>
<br>
<img width="181" alt="Screenshot 2022-01-03 204804" src="https://user-images.githubusercontent.com/86114549/148701167-1a83433d-37eb-4540-ba28-e5585dc437b4.png">
<br>

The Excel file will contain the following sheets (depending on your selection of options):<br>
<br>
<img width="700" alt="Screenshot 2022-01-04 101417" src="https://user-images.githubusercontent.com/86114549/148701265-6709fed5-2946-44b6-bfd6-d5ecb3d92af5.png">
<br>
Leads:<br>
<img width="644" alt="Screenshot 2022-01-03 204853" src="https://user-images.githubusercontent.com/86114549/148701344-4922457c-9037-4e6e-972a-6d7580d16978.png">
<br>
<br>
Industries:<br>
<img width="685" alt="Screenshot 2022-01-03 204914" src="https://user-images.githubusercontent.com/86114549/148701361-abc11d78-5300-4f67-bb62-905de90cc299.png">
<br>
<br>
Leads_by_industries (only excerpt of list displayed here):<br>
![Screenshot 2022-01-03 222332](https://user-images.githubusercontent.com/86114549/148701384-5c10d01f-45b3-4956-80bf-3c6dbb8d4c6c.png)
<br>
<br>
Pitches:<br>
tbd<br>
Rejection reasons:<br>
tbd<br>
Topleads:<br>
tbd<br>





<br>
<br>

## Recommendations: <br>
The program gets every industry and lead status from HubSpot without any changes to the initial setup required.<br>
Should you import data from a different tool, read below for the requirements.<br>
<br>
However, some functions can perform additional analyses through changes to the HubSpot data structure / setup.<br>
The function 'Counts' automatically gets every industry and lead status from HubSpot and counts their occurrence.<br>
Additionally, with the following lead status categories configured in HubSpot, the function puts out a custom sorted table that can be exported:<br>
<br>
<strong>(If you use different lead categories, they will still be analyzed, but sorted by size and not custom sorted as shown below)</strong><br>

<br>
<strong>Lead status:</strong>
<ul>
  <li>Cold</li>
  <li>Cold Contacted</li>
  <li>Warm</li>
  <li>Follow-up</li>
  <li>Qualified Lead</li>
  <li>Contract</li>
  <li>Rejected</li>
  <li>Ineligible</li>
</ul>
<br>
Of course you are free to change the categories for custom sort in the source code should you require different ones.<br>
<br>
<strong>Pitches:</strong><br>
For the function 'Pitches', a company information entry has to be set up in HubSpot, where the pitch information is inserted with the following structure:<br>
<br>

> (Closed / Open) YYYY.MM.DD, time, location

(again, you are free to enter whatever you like here and the function still works, the output just might not be ideal without changes to the sort command)<br>
<br>
<strong>Rejection:</strong><br>
If a company / contact person rejects your offer, the reason for the rejection must be entered under "Company Information" under "Reason for rejection / unsuitability"
within HubSpot.<br>
This category has to be manually added to the HubSpot database default configuration.<br>
<br>

<h2>FAQ:</h2><br>
Regarding questions or other inquiries message me at:<br>
<br>
<strong>philippebraum@pm.me</strong><br>
<br>
<br>
<ul><li><strong>Data import requirements for database files:</strong><br></ul></li>
The imported data has to be in the .csv file format.<br>
When exporting the database file from from HubSpot select the following options:<br>
<br>
<img width="293" alt="Screenshot 2022-01-04 103955" src="https://user-images.githubusercontent.com/86114549/148040649-c8fdf626-d23f-46d6-951c-bba83a0b6f6d.png">
<br>
<img width='450' alt='HubSpot_export_view_settings' src='https://user-images.githubusercontent.com/86114549/148040296-97d8de17-5f73-4bcc-b23b-4eccf7dc8671.png'>
<br>
<i>For files not from HubSpot:</i><br>
The file has to contain the following columns:<br>
<ul>
  <li>Name (of the company)</li>
  <li>Lead Status</li>
  <li>Create Date</li>
  <li>Industry</li>
  <li>Company owner (internally responsible person)</li>
  <li>Pitch</li>
  <li>Reason for rejection / unsuitability.</li>
</ul>
<br>
<ul><li><strong>I have an Apple computer, can I use the ready-to-use release, too?</strong><br></ul></li>
The ready-to-use-version is Windows only atm.<br>
To run the program on MacOS, download the two scripts and run them in your local Python distribution, IDE or compile them yourself.<br>
<br>
<br>
<ul><li><strong>Windows Defender doesn't let me run the program:</strong><br></ul></li>
MS Windows' built-in antivirus Windows Defender automatically blocks any kind of unknown programs by default.<br>
<br>
<b>&nbsp&nbsp&nbsp&nbsp&nbspBe reassured:</b> Everything takes place on your local machine without connection to the internet.<br>
<br>
You can still check the source code of the executable yourself if you want to: https://github.com/Criomby/hubspool/archive/refs/tags/v2.5.2.zip<br>
<br>

To run the program, follow the process below:<br>

<img src="https://user-images.githubusercontent.com/86114549/141657595-cb6240a0-5fc0-4dd0-969f-70d4a958207e.png" alt="defender_run"></a>

<img src="https://user-images.githubusercontent.com/86114549/141657566-c661a1bd-5918-43c5-b8e3-3b61f14e79e0.png" alt="defender_more_details"></a>

<br>
<ul><li><strong>Dependencies for Python distribution?</strong><br></ul></li>
See requirements.txt.<br>
<br>

<h2>Support the project:</h2><br>
<p float='left'>
<a href='https://ethereum.org/en/stablecoins/'>
<img src="https://user-images.githubusercontent.com/86114549/123052110-be243880-d402-11eb-9f0b-77df24874278.png" alt="tether-usdt-logo" height="50"></a>
<a href='https://ethereum.org/en/stablecoins/'>
<img src="https://user-images.githubusercontent.com/86114549/122908329-4a2b5700-d354-11eb-8ba9-4fa8d2c76ed6.png" alt="usdc-large" height="50"></a>
<a href='https://ethereum.org/en/stablecoins/'>
<img src="https://user-images.githubusercontent.com/86114549/122908250-35e75a00-d354-11eb-8be1-243fcecc93c6.png" alt="dai-large" height="50"></a>
<a href='https://basicattentiontoken.org/'>
<img src="https://user-images.githubusercontent.com/86114549/132904922-1921973e-13f0-40e5-a912-2180fe2b1485.png" alt="bat_token" height="50"></a>
<a href='https://ethereum.org/en/stablecoins/'>
<img src="https://user-images.githubusercontent.com/86114549/122967139-7235ad00-d38a-11eb-86e9-b6e634a5fc75.png" alt="ETH-logo-round" height="50"></a>
</p>
Wallet adress:<br> 
0xfC56bfc44E5671fD689331490D8e6Fa5B121474F<br>
<br>
<img width="116" alt="ether_wallet_qr_code" src="https://user-images.githubusercontent.com/86114549/122909208-3f24f680-d355-11eb-88b9-c49afb867a98.png"><br>
Supported currencies: USDT, USDC, DAI, BAT, ETH <br>
<br>
<br>
© 2022 Braum
