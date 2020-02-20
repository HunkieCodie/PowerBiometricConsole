# PowerBiometric Console Application - Version 1.0.0

The Biometrics Synchronization Console App is a console application that moves the attendance data of employees from a Biometric App database to a specific database.
We should note that this console app does NOT synchronize the attendance list for employees with:
- Empty or null UserID value
- 'Unknown' UserID value

This application comes with an API which requires a token to make it work.
The token fetches the company details of the employee doing this synchronization.

## GUIDE ON USAGE
### Firstly: 
Make sure the API is set up on the Internet Information services (IIS) and the link shows up on a browser.

### Secondly: 
User must insert values into the APIToken table using the script in the file ‘RunningApp_Querires.txt’ which can be seen in the figure below too. This is done by inserting preferred values into the single quotation marks (‘ ’) in  the script.
The values inserted in the ‘Token’ Column will enable us to consume the API. 

### Thirdly: 
The token inserted in the token column above is replaced with the default token value in the ‘Config.txt’ file. Also, the link gotten from the browser in the initial step of this guide is replaced with the API link in the ‘Token.txt’ file.
The token and API link is separated by the pipe sign ‘|’ as seen below:

### Fourthly:
The user changes the database name in the ‘Config.txt’ file as seen below:

### Lastly:
The user launches the application and the application works. This is seen in 3 stages:
 
First stage:


Second stage:


Third stage:

