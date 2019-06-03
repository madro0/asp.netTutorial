# asp.netTutorial

Asp.net is a framework that allows us to perform simple applications 
in a very complete way implementing the MVC design pattern.

To create our first CRUD in asp.net it is necessary to download visual studio, which we can easily download from the official 
website: https://visualstudio.microsoft.com/es/downloads/Once downloaded and installed, when we open our visual studio for the 
first time, our work interface will appear.


![Sin título](https://user-images.githubusercontent.com/50094407/58774678-3e5f7300-8588-11e9-8b1e-8fe429827696.png)


To create a project, let's go to the option: File/New/Project

![imagen](https://user-images.githubusercontent.com/50094407/58774752-af9f2600-8588-11e9-802f-497b33527603.png)


Visual studio will show a window like this.


![3](https://user-images.githubusercontent.com/50094407/58774842-16bcda80-8589-11e9-97d4-5f58557a9a70.png)


In the left part we choose the option: Installed/Visual C#/Web and in the right part we choose ASP.NET Web Aplication (.Net Framework).
In the part of the name we put the name we want, and then we give in ok.


In the following table

![4](https://user-images.githubusercontent.com/50094407/58774876-45d34c00-8589-11e9-82d8-4cf87d8b5666.png)

In the templates section we choose Emty, and in the folders and core references part Select the MVC box, finally we give in ok.
We have already created our project, now we are going to create our database in sql server.


For this we are going to:  Vew/SQL Server Object Explorer.

![5](https://user-images.githubusercontent.com/50094407/58775142-b8dcc280-8589-11e9-9e8c-b97febcb0633.png)


 Then let's add a served
 
 ![6](https://user-images.githubusercontent.com/50094407/58775170-e1fd5300-8589-11e9-9c42-e2a9b1d05752.png)
 
 We select MSSQLLocalDB and connect.
 
 ![7](https://user-images.githubusercontent.com/50094407/58775212-107b2e00-858a-11e9-9898-d6fa8ac32678.png)
 
 Then in the server locar we give right click and add new database
 
 ![8](https://user-images.githubusercontent.com/50094407/58775233-2557c180-858a-11e9-8d24-b5048ef25f66.png)
 
 Then we write the name of the database, and the location, we give in OK. 
 
 ![9](https://user-images.githubusercontent.com/50094407/58775299-6e0f7a80-858a-11e9-9d80-795a9b8829a4.png)
 
 We create a new table
 
 ![10](https://user-images.githubusercontent.com/50094407/58775328-7f588700-858a-11e9-8b6d-908abb5b8137.png)
 
 We create the fields, change the name of the table and give in Update 
 
![11](https://user-images.githubusercontent.com/50094407/58775339-9303ed80-858a-11e9-99b0-14d551595355.png)

We have already created our database now we are going to create the model within our project so we go to the solution window that is on the left side and in the models folder and create a folder called Data Model.
Then, inside the Data Model folder we will add a new item

![12](https://user-images.githubusercontent.com/50094407/58775356-aadb7180-858a-11e9-8429-ec7598b189c3.png)

Then we select Data and ADO.NET Entity Data Model and we add in. 

![13](https://user-images.githubusercontent.com/50094407/58775394-e2e2b480-858a-11e9-9359-41dc812dda9f.png)

click on next

![14](https://user-images.githubusercontent.com/50094407/58775415-fa21a200-858a-11e9-8198-d08e0878bc94.png)

click on new conexión

![15](https://user-images.githubusercontent.com/50094407/58775426-132a5300-858b-11e9-8f29-3d14aae49dbf.png)

In Browse we select the database that we created previously

![16](https://user-images.githubusercontent.com/50094407/58775446-289f7d00-858b-11e9-9ab9-56418315e794.png)


And if we find this warning:

![17](https://user-images.githubusercontent.com/50094407/58775482-54bafe00-858b-11e9-888f-8a148c27ae92.png)


We go to the task manager, to the details tab, we look for the process of sqlserver.exe and we finish the task.

![18](https://user-images.githubusercontent.com/50094407/58775511-7320f980-858b-11e9-94b7-4142c98d9fb3.png)

click on next

![19](https://user-images.githubusercontent.com/50094407/58775565-b1b6b400-858b-11e9-981b-7645347dcd59.png)

We select tables and click on Finish.

![20](https://user-images.githubusercontent.com/50094407/58775596-d7dc5400-858b-11e9-84f4-afebc495dadb.png)

Then inside the Models folder and add a class. 

![21](https://user-images.githubusercontent.com/50094407/58775610-edea1480-858b-11e9-8004-618aca5b4b73.png)

We already created our first model. Within this class we are going to create each of the access variables according to the fields that we create within the database.

![22](https://user-images.githubusercontent.com/50094407/58775620-03f7d500-858c-11e9-8262-a77bfb32b6df.png)

Then, in the same class we create this methods.

![23](https://user-images.githubusercontent.com/50094407/58775633-196cff00-858c-11e9-8c5d-4e0a9a90965f.png)

Then in the models folder we created the DataAccess folder and then inside this folder we created the PersonDao class.

![23](https://user-images.githubusercontent.com/50094407/58775655-30abec80-858c-11e9-9f2d-2db761557def.png)

In this class we create the action knows and write the following.
(Do not forget to import the model from the database, using Using) 

![24](https://user-images.githubusercontent.com/50094407/58775671-4ae5ca80-858c-11e9-8a6c-ba49b3953c6d.png)

Then we create the Show method to list all the people that exist in the database. 

![25](https://user-images.githubusercontent.com/50094407/58775690-651fa880-858c-11e9-811a-77639d9900d1.png)

We create the Delite action to delete a specific record using the id

![26](https://user-images.githubusercontent.com/50094407/58775707-7d8fc300-858c-11e9-9d32-ddee474ae15f.png)

Then the UpdatePerson action as follows.

![27](https://user-images.githubusercontent.com/50094407/58775722-94ceb080-858c-11e9-9414-80336392f302.png)

Finally we create the GetPerson action that will help us in the selection of a record of the person table when we are going to edit their data. 

![28](https://user-images.githubusercontent.com/50094407/58775738-aadc7100-858c-11e9-9c0e-4add79a925dd.png)

After completing our PersonDao class, we return to the PersonModel class that is located in the root of the Models folder. Here we will call the methods that we created previously in PersonDao, and for this we need to instantiate the class and call the save action.

![29](https://user-images.githubusercontent.com/50094407/58775752-be87d780-858c-11e9-8462-8d506ff4fbbe.png)

We do the same in the show method

![30](https://user-images.githubusercontent.com/50094407/58775774-d8291f00-858c-11e9-97ac-a78724b39668.png)

With the delete method the same is done but this time within the action we send the id.
 
![31](https://user-images.githubusercontent.com/50094407/58775791-f000a300-858c-11e9-9b14-4b3d1b436b35.png)

In the UpdatePerson method we do the same process, but we send an instance of PersonModel type this time.

![32](https://user-images.githubusercontent.com/50094407/58775814-0b6bae00-858d-11e9-9884-f7f0501f0416.png)

Finally in GetPerson, in its corresponding action we send the id.

![33](https://user-images.githubusercontent.com/50094407/58775825-1c1c2400-858d-11e9-8a88-3327fc380ee0.png)

We already have our Model complete, Now we go to the controller, in this we are going to create our controller in the Controllers folder, then in: Add / Controller

![34](https://user-images.githubusercontent.com/50094407/58775853-3229e480-858d-11e9-9c36-d608a5cb5423.png)

Then in add and choose the name of our controller.

![35](https://user-images.githubusercontent.com/50094407/58775873-45d54b00-858d-11e9-8f2f-dcf74b46d4f7.png)

In the default action Index we create the corresponding action by right clicking on the line and choosing the option Add View.

![36](https://user-images.githubusercontent.com/50094407/58775890-5eddfc00-858d-11e9-9d0c-c748bd43e53a.png)

And in the View Index we wrote: 

![37](https://user-images.githubusercontent.com/50094407/58775898-774e1680-858d-11e9-9c6d-d168a6dfef4c.png)

In the controller we write: 

![38](https://user-images.githubusercontent.com/50094407/58775912-8d5bd700-858d-11e9-92b8-5475924c09e1.png)

It is necessary to create the Success action in advance.

![39](https://user-images.githubusercontent.com/50094407/58775925-a49ac480-858d-11e9-83bd-4be417ac08dc.png)

Then we will create the Show action within our controller like this:

![40](https://user-images.githubusercontent.com/50094407/58775937-b7ad9480-858d-11e9-9c43-6a6e6e1bc2c1.png)

We create its corresponding action and paint the data of the person matrix using an html table like this:

![41](https://user-images.githubusercontent.com/50094407/58775951-cbf19180-858d-11e9-9db5-184d25d148a0.png)

