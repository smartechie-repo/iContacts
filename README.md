
  <h1>iContacts</h1>
  <h4>An Online Contacts  Manager ... </h4>

<hr/>

  This project showcases a web application called `iContacts`, designed to manage your contacts efficiently.

> Features:
  - `Effortless Contact Management`: Easily create, read, update, and delete contacts within the system.
  
  - `Comprehensive Contact View`: Access detailed information for each contact stored within the application.
  
  - `Intuitive Interface`: Enjoy a user-friendly interface that adapts to any device for optimal usability.
  - `Robust Data Persistence`: Leverage Entity Framework to ensure reliable storage and retrieval of your contact information.
  - `Scalable Database`: Utilize the power of SQL Server as the backend for secure and scalable storage of your contacts.
  - `Modern Design`: Experience a clean and modern user interface powered by the Bootswatch Lux theme.


> Technologies Used:

- `ASP.NET Core Web`: Provides the foundation for building the dynamic web application.
- `Entity Framework`: Offers a seamless framework for data access and manipulation in relation to the SQL Server database.
- `SQL Server`: Acts as the robust database engine for storing and managing your contact information.
- `Bootswatch Lux (Bootstrap Theme)`: Contributes to the application's sleek and contemporary design.


> Getting Started (For Developers):

- `Clone the Repository`: Start by cloning the project repository using the following command:\
git clone https://github.com/smartechie-repo/iContacts.git
-  `Open the Project`: Launch the project within your preferred code editor, such as VSCode.
- `Configure Database Connection`: Locate the appsettings.json file and update the connection string to point to your existing SQL Server database.
- `Database Setup`: Utilize SQL Server Management Studio or a similar tool to execute the provided DatabaseScript.sql file. This script creates the necessary tables within your database.
- `Build the Solution`: To restore NuGet packages and compile the project, simply build the solution using your preferred development environment.
- `Clean and Build project`: execute command \

      $ dotnet clean && dotnet build

- `Run project`: execute command \

      $ run --project ContactsLibrary.Web

- Follow the package installation instruction if not installed like `dotnet` , `Asp.Net Runtime` etc ...

By following these steps, you can set up and explore the functionalities of the iContacts web application.



> Running the Application:

- There are `two ways` to run the iContacts App:

  - `Directly from your code editor`: This method might be specific to VSCode IDE. Check your editor's documentation for instructions on running applications directly.
  - `Using F5 in VSCode`: If you're using VSCode IDE, simply press F5 to launch the application.

- `Accessing the iContacts`:

  - Once you've started the application, open your web browser and navigate to `http://localhost:<port></port>`.  Replace `<port>` with the actual port number assigned by your development environment.

- Managing Your Contacts:

  - The iContacts allows you to:

    - `Create` new contacts
    - `Edit` existing contacts
    - `Delete` contacts
    - `View` detailed information for each contact simply by clicking on it.

> Contributing to the Project:

  We welcome contributions to the iContacts project! If you encounter any issues (bugs) or have ideas for improvement, please don't hesitate to contribute in one of two ways:

> Open an issue: 

Report any bugs or problems you find.
Submit a pull request: Share your code improvements with the project.

> License:

This project is open-source and licensed under the MIT License.

> Contact:

For any questions or inquiries, please reach out to the project owner: `codemate.io`