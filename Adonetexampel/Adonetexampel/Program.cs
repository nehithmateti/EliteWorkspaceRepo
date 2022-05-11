using System;
using AdoNetSP;
using System.Data.SqlClient;
using System.Globalization;

List<Adonetexampel> listEmployees = new List<Adonetexampel>();

string connectionString = "Data Source=JEEVAN;Initial Catalog=Employee;Integrated Security=true;";
string sqlQueryInsert = "INSERT INTO tbl_employeedetails VALUES('Praveen',29, 200000)";
string sqlQueryUpdate = "update tbl_employeedetails set age = 33 where empid  = 3";
string sqlQurryDelete = "delete from tbl_employeedetails where Id=4";
string sqlSelect = "select Id,Name,Age,Salary from tbl_employeedetails";

SqlConnection connection = new SqlConnection(connectionString);
connection.Open();

// execute queries

//Insert query
SqlCommand cmd = new SqlCommand(sqlQueryInsert, connection);
cmd.ExecuteNonQuery();

// Update query
SqlCommand md = new SqlCommand(sqlQueryUpdate, connection);
md.ExecuteNonQuery();

//Delete query
SqlCommand cm = new SqlCommand(sqlQurryDelete, connection);
int numberOfRowsAffected = cm.ExecuteNonQuery();

//Select Query
SqlCommand cd = new SqlCommand(sqlSelect, connection);
SqlDataReader reader = cd.ExecuteReader();

while (reader.Read())

{
    Adonetexampel employee = new Adonetexampel();
        //employee.Id = Convert.ToInt64(reader["Id"]);
        employee.Name = Convert.ToString(reader["Name"]);
        employee.Age = Convert.ToInt32(reader["Age"]);
        employee.Gender = Convert.ToChar(reader["Gender"]);

        DateTime dateOfBirth = DateTime.ParseExact(reader["DOB"]
            .ToString(), "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        employee.DOB = dateOfBirth;

        DateTime dateOfJoining = DateTime.ParseExact(reader["DOJ"]
            .ToString(), "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        employee.DOJ = dateOfJoining;

        employee.Salary = Convert.ToInt64(reader["Salary"]);

       /* employee.PresentAddress = reader["PresentAddress"].ToString();
        employee.PermanentAddress = reader["PermanentAddress"].ToString();
        employee.Salary = Convert.ToDecimal(reader["Salary"]);
        employee.IsActive = Convert.ToBoolean(reader["IsActive"]);

        DateTime joiningDate = DateTime.ParseExact(reader["JoiningDate"].ToString(), "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        employee.JoiningDate = joiningDate;

        employee.ManagerId = Convert.ToInt64(reader["ManagerId"]);
        employee.Dept = reader["Dept"].ToString();*/

        listEmployees.Add(employee);
    
}
connection.Close();

Console.ReadLine();


