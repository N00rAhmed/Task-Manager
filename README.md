<h2>Task Manager Information</h2>

This Application can create user accounts who can login and perform operations such as adding, deleting, updating data as well as marking tasks completed or incompleted.

<!-- <br/> -->
<h3>Tech Stack:</h6>
C# | Windows Forms App (.NET Framwork) | CockroachDB | Visual Studio

<h3>Development Process:</h3>
In the beginning I was using SQLITE for the database on my local system and my main focus was more on functionality than form but since this is an ongoing project I will be continuously making improvements to the user interface and also the backend. 

<h3>Hosting Service:</h3>
For the database hosting I am using a free hosting service called CockroachDB which basically performs querys and other operations similar to normal SQL syntax but in the command line. For the .NET Application, I have published it as a .exe file using a Nuget Package called Costura.Fody.

<h3>Run Task Manager on Local System</h3>
Fork this repo and copy the link in the your Forked repo and then open Visual Studio, click clone repository and paste the link. Also you will need to create a DB.cs file with your own connection by using cockroachDB to creat the database and tables required. 

<h3>Download Task Manager</h3>
In order to download the Task Manager you can go to my website https://p0rtf0li0-noor.netlify.app/#projects and download the project called Worklist Manager :)

<h3>Disclaimer</h3>

The exe file provided works on home networks but on more secure networks there is a chance that the file wont work because it is detected as malicious software or a security risk when the app attempts at accessing the database.

<h3>Task Manager ERD</h3>

![TASK-APP ERD Diagram](https://github.com/N00rAhmed/Task-Manager/assets/86896171/0341d834-00bf-4706-bb6e-2b9d9593abc6)

<h3>Task Manager Use Case Diagram</h3>

![TASK-APP Use Case Diagram](https://github.com/N00rAhmed/Task-Manager/assets/86896171/9e8e2245-aafd-4050-b1d3-adf4564d9b2c)
