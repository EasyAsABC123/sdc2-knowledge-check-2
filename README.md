# Knowledge Check 2 for Software Course 1

1. Create a new Repository by clicking the green ["Use this Template"](https://github.com/CodeLouisville/sdc1-knowledge-check-2/generate) button and setup a new repository in your account.
1. Create a new project in Visual Studio, into the cloned repo.
1. Create a new object and then create another object that inherits from it.  Each object should have at least 1 property.
   1. Example from the [pet store](https://github.com/CodeLouisville/Software-Pet-Store): first class is [Product](https://github.com/CodeLouisville/Software-Pet-Store/blob/main/PetStore/PetStore/Models/Product.cs), second class is [CatFood](https://github.com/CodeLouisville/Software-Pet-Store/blob/main/PetStore/PetStore/Models/CatFood.cs) and it inherits from [Product](https://github.com/CodeLouisville/Software-Pet-Store/blob/main/PetStore/PetStore/Models/Product.cs).
1. Paste the following template in the `Program.cs` file:
	```csharp
	Console.WriteLine("How many records do you want to add? ");
	var numberOfRecords = int.Parse(Console.ReadLine());

	var recordList = new List<MyClass>();
	for (int i = 0; i < numberOfRecords; i++)
	{
		// In this loop, populate the object's properties using Console.ReadLine()
		var myClass = new MyClass();

		Console.WriteLine("Enter the value for ");
		myClass.YourProperty = Console.ReadLine();
			

		recordList.Add(myClass);
	}

	// Print out the list of records using Console.WriteLine()
	```

1. Replace `MyClass` with the child class that you made in step 2.
1. Replace `MyClass.YourProperty` witht he child class property you made in step 2.
1. You should allow the user to add data for every property in your class.  
   1. So with the [CatFood](https://github.com/CodeLouisville/Software-Pet-Store/blob/main/PetStore/PetStore/Models/CatFood.cs) example, the user should be able to add values for every property of [CatFood](https://github.com/CodeLouisville/Software-Pet-Store/blob/main/PetStore/PetStore/Models/CatFood.cs) (KittenFood) which includes the properties from [Product](https://github.com/CodeLouisville/Software-Pet-Store/blob/main/PetStore/PetStore/Models/Product.cs) (Price, Name, Quantity, Description).
4. Print the objects in recordList to the screen
   1. Hint: Look into class `ToString()` method.
5. Upload to the repository we created earlier on your Github account.
   1. Either through Add file > upload files
   2. Or via git commands
      1. `cd <to-the-project-folder>`
      2. `git init`
      3. `git remote add origin <url-to-repo>`
      4. `git pull`
      5. `git add .`
      6. `git commit -m"I did it!"`
      7. `git push`
6. Turn in the knowledge check in Google Classroom. Make sure you include the link to your new GitHub repository when you "Turn In" the assignment.
