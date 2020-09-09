# ToDoOnSteps

A simple todo list app built in Xamarin.Forms using C# and XAML. Provides festures such as adding, editing, deleting a task, deleting all tasks at a time, splash screen. Used as on-hands demo during Microsoft Wednesday Workshop - The Many Ways of Mobile: Xamarin.

![](https://github.com/cristysandu/ToDoOnSteps/blob/master/Images/Demo.PNG)


* The project is comprised of the following pages:
  * Mainpage - the starting page of the app 
  * Todolist - a page of all the tasks of an user
  * AddTask - a page for configuring a task; this is used both for adding a new entry, and for editing an existing one
  
* Each task is represented as on object of the Task.cs class. An SqLite database is used for storing them, so that nothing is lost after editing the Todolist page. Data binding is used for synchronizing the title and the "checked" property for each element of the list. By using an Observable Collection, there is no need to implement a refreshing function.
