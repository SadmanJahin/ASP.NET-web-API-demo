# ASP.NET-web-API-demo
#### Web API Assignment
Author: Sadman Jahin
<br>
Post and Get Request Send with XHTTP from Index.cshtml, Api Controller handles requests.
<br>
#### Migrations
Open Package Manager
<br>
PM> Enable-Migrations
<br>
PM> Add-Migration
#### API Endpoints: 
1. /post <br>
a. Request type: POST
b. Request header: page-size
c. Data: List of string
d. Response status code: 201 <br>

2. /get <br>
a. Request type: GET
b. Response: List of lines
c. Response status code: 200

#### Details
Requst POST
  ```
  https://localhost:44312/api/text/post
  ```
  ```
  https://localhost:****/api/text/post
  ```

  Requst GET
  ```
  https://localhost:44312/api/text/get
  ```
   ```
  https://localhost:*****/api/text/get
  ```
  
  #### Preview
  
  ![image](https://user-images.githubusercontent.com/54625061/179644604-9976d14c-d17a-4193-b228-ed409b682640.png)

