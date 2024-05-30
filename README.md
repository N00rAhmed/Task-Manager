<h1>Task Manager Documentation</h2>

<h2>Table of Contents</h2>

- [Introduction](#introduction)
- [Tech Stack](#tech-stack)
- [Development Process](#development-process)
- [Task Manager ERD](#task-manager-erd)
- [Hosting Services](#hosting-services)
- [Run Task Manager on Local System](#run-task-manager-on-local-system)
- [Download Task Manager](#download-task-manager)
- [Demo Video](#demo-video)
- [Disclaimer](#disclaimer)

<hr />

<h3>Introduction</h3>
This Task Manager Application can create user accounts who can login and perform operations such as adding, deleting, updating data, marking tasks completed or incompleted and searching through tasks. There is also an admin who can view every users account information and also view the tasks created. Currently this is an ongoing project and commits/pushes are made regularly.

<!-- <br/> -->
<h3>Tech Stack</h6>
C# | Windows Forms App (.NET Framwork) | CockroachDB | Visual Studio

<h3>Development Process</h3>
In the beginning when developing locally I was using SQLITE for the database and my main focus was more on functionality, since this is an ongoing project I will be continuously making improvements to the user interface and also the backend.

<h3>Task Manager ERD<!-- + Use Case Diagram --></h3>
<img src="https://github.com/N00rAhmed/Task-Manager/assets/86896171/0ba11e02-38b4-46d0-8c32-1c573ff82b3b" width="600" height="400">

<!-- <img src="https://github.com/N00rAhmed/Task-Manager/assets/86896171/0341d834-00bf-4706-bb6e-2b9d9593abc6" width="500" height="400"> --> <!-- <img src="https://github.com/N00rAhmed/Task-Manager/assets/86896171/9e8e2245-aafd-4050-b1d3-adf4564d9b2c" width="500" height="680"> -->
<h3>Hosting Services</h3>
For the database hosting I am using a free hosting service called CockroachDB which basically performs querys and creates tables similar to normal SQL syntax but in the command line. For the .NET Application, I have published it as a .exe file using a Nuget Package called Costura.Fody.

<h3>Run Task Manager on Local System</h3>
Fork this repo and copy the link in the your Forked repo and then open Visual Studio, click clone repository and paste the link. Also you will need to create a DB.cs file with your own connection string by using cockroachDB to create the database and tables required. 

<h3>Download Task Manager</h3>
In order to download the Task Manager you can go to this link and download the exe: https://github.com/N00rAhmed/Task-Manager/releases/ <br />

<img src="https://github.com/N00rAhmed/Task-Manager/assets/86896171/f26930ef-55e1-450e-9aa5-2e4a715005f7" width="900">

<br />

You can also go to my website https://p0rtf0li0-noor.netlify.app/#projects and download the project from there :)


<img src="https://github.com/N00rAhmed/Task-Manager/assets/86896171/f5feb785-765d-467b-927e-df17bb89ca39" width="500" height="250">

<br />
<br />

When opening the exe file you will get a popup similar to the one below. In order to bypass this you click more info and then run anyway which will the application.

<img src="https://github.com/N00rAhmed/Task-Manager/assets/86896171/d6c10d09-e89b-48e5-b748-11076175288d" width="410" height="350">

<img src="https://github.com/N00rAhmed/Task-Manager/assets/86896171/d80f91c9-c6ab-40da-993c-b6da7e9adf09" width="410" height="350">

<h3>Demo Video</h3>

https://github.com/N00rAhmed/Task-Manager/assets/86896171/0193cee5-a1f4-4f1b-906d-3ebb0a2f85e2


<h3>Disclaimer</h3>

The exe file provided works on home networks but on more secure networks there is a chance that the file wont work because it is detected as malicious software or a security risk when the app attempts at accessing the database. Also if you have installed any anti virus software there is a chance that it will also stop the application from running and being downloaded.


