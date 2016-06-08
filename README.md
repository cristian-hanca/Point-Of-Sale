# Point Of Sale API

The idea of this project is not to provide a Program ready for production, but rather a complex API that can be used to create the final Production Product.
To this end, there are multiple components to this project, as described bellow.

Note: .NET 4.5 was used.
Note: Since it is very hard to demo a project designed to be a Class Library I recommend 2 methods of viewing the Data:
	- Debugging View: Just run the Test Project in Debug mode, breackpoint locations should be provided.
	- LINQPad is a great (and free) application to execute LINQ-to-SQL Calls providing the DLL containing the Entity Framework Context.
		- Please use the DababaseConnection.dll Assembly and DababaseConnection.dll.config Config File.
			- Please note taht due to the way LINQPad works regarding Relative Paths, you must either:
			- Place database.sdf in where LINQPad.exe exists.
		- Edit the Connection String in DababaseConnection.dll.config to use an Absolute path to the Dtabase.
		
#Componets:

- Models: 
	- Stores the "Table Definitions" of the objects stored by the program.
	- This component does not define a Database connection, rather it defines fields using Entity Framework Code First.
	- One can simply ignore the EF:CF definitions and use these classes as pute Models.	
	
- DarabseConnection
	- Defines the required Context for Entity Framework Code First.
	- Also defines a complex Mock Data Seeding system executed on Migration Success:
		- A Seeder Interface provides methods for adding Data to the Database.
		- Specialized implementations of this interface are provided for each Table.
		- The Mock System creates a complex Data Base with predefined Categories and Products but Rnadom Customers, Orders and Events.
	- The databse is stored in a SQL Compact Edition 4 Database, encrypted by default.
	
- DataForms	
	- Profides specialized "Forms" used to Insert and Edit Models.
	- These interfaces are highly customizable and can be adapted for numerous interactions with the Data Context.
	- One can with ease include more complex Validation at this step than what could be done database-side using Entity Framework.
	- Creation end Edits are provided using the Builder Pattern, thuss it is very easy to use.
	- The idea of "Forms" is to, at a later date, provide a transparent Interface to the API to be used in a RESTful envirovment, for example, where thessse Forms would be encoded in JSON with ease.

- DataAccessExtensions
	- Defines a set of Extension Methods for the Data Context that allows the user to easily:
		- Find a Category, Customer, Product or Currency by Name (or CNP for Customer)
		- Sample the Tables to randomly select a number of entries (Perfect for Statistical Work)
	- These are provided as a convenient wrapper over the Entity Framework LINQ-to-SQL Interface.
	- One can very easily extend these methods to define Filters and Sorting options (just like Views, but Dtabase idependent)	
- PointOfSaleTest
	- More like an Example of the API in action.
	- No UI, just code (as you requested :) )

#Objects:

- Currencies are difined.
- Currencies have a Conversion Value to the "Base Currency" (defined in the Settings Table), thus one can simply keep an up-to-date value here by using http://fixer.io/
- Categories can have ParentCategoriess, thus creating a Nested Tree Structure.
- Products have a single Category.
- Orders have a single Customer and Currency.
- Orders have multiple OrderItems.
- OrderItems have only one Product.
- OrderItems inherit the Product Price, but it has an override field!
- Orders have multiple States defined in Events: Created, Invoiced, Payed, Canceled
- Events remember the Order, their Date and Time and the new State.
- Orders can change from State to State in a Finite Automata fashion (defined in code).
- Orders have to have at least one OrderItem, and have to have the Created Event defined.
- There are many Relationships defined:
	- Category to Products (and vice-versa)
	- Customer to Orders (and vice-versa)
	- Order to Events (and vice-versa)
 - Orders remember their Last Status.
 - Orders compute the Total cost.
 - Orders determine themselves the Type (Normal, Refund or Exchange), no User Input required!
 
#How To:

- Database file is stored in the executable location.
- In order to get a fresh DataBase with new Mock Data do:
	- Enter Package Management Console in Visual Studio.
	- Select the DarabseConnection Project.
	- Run: Update-Database
	