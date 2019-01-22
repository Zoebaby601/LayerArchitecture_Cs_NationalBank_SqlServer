using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // MsgBox
// Data
using System.Data;
using System.Data.SqlClient;
using _4.Items;

namespace _3.DataAccesLayer
{
    /*
     * This project uses the following licenses:
     *  MIT License
     *  Copyright (c) 2018 Ricardo Mendoza 
     *  Montréal Québec Canada
    */
    public class clsDataSource
    {
        // 1. Obj clsConnection
        private clsConnection Connection = new clsConnection();
        // 2. Execute SQL
        private SqlCommand Command = new SqlCommand();
        // 3. Read Rows
        private SqlDataReader Read;

        // 4 fnc.Load Durectors
        public clsListDirectors fncGetDirectors()
        {
            try
            {
                // 1. Objet clsListDirectors
                clsListDirectors ListDirectors = new clsListDirectors();
                // 2. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 3. Execute stored procedure
                Command.CommandText = "selectDirectors";
                // 4. Execute specify the command type
                Command.CommandType = CommandType.StoredProcedure;
                // 5. Execute the Reader
                Read = Command.ExecuteReader();
                // 6. Load the list
                while (Read.Read())
                {
                    // variables 
                    string number, name, lastName, email, img, sexe, active;
                    int iddirector, idbank;
                    decimal salary;
                    iddirector = Read.GetInt32(Read.GetOrdinal("iddirector"));
                    idbank = Read.GetInt32(Read.GetOrdinal("idbank"));
                    number = Read.GetString(Read.GetOrdinal("Number"));
                    name = Read.GetString(Read.GetOrdinal("Name"));
                    lastName = Read.GetString(Read.GetOrdinal("Last Name"));
                    email = Read.GetString(Read.GetOrdinal("Email"));
                    img = Read.GetString(Read.GetOrdinal("img"));
                    salary = Read.GetDecimal(Read.GetOrdinal("salary"));
                    sexe = Read.GetString(Read.GetOrdinal("sexe"));
                    active = Read.GetString(Read.GetOrdinal("active"));
                    ListDirectors.fncAdd(new clsDirector(iddirector, number, name, lastName, email, img, active, sexe, salary, idbank));
                }
                // 7. Close Read Connection
                Read.Close();
                Connection.CloseConnection();
                // 8. Make the return
                return ListDirectors;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model getting the director list from data base " + ex.Message);
                return null;
            }
        }

        // 4 fnc.Load Admins
        public clsListAdmins fncGetAdmins()
        {
            try
            {
                // 1. Objet clsListAdmins
                clsListAdmins ListAdmins = new clsListAdmins();
                // 2. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 3. Execute stored procedure
                Command.CommandText = "selectAdmins";
                // 4. Execute specify the command type
                Command.CommandType = CommandType.StoredProcedure;
                // 5. Execute the Reader
                Read = Command.ExecuteReader();
                // 6. Load the list
                while (Read.Read())
                {
                    // variables 
                    string number, name, lastName, email, img, password, sexe, active;
                    int idadmin;
                    idadmin = Read.GetInt32(Read.GetOrdinal("idadmin"));
                    number = Read.GetString(Read.GetOrdinal("Number"));
                    name = Read.GetString(Read.GetOrdinal("Name"));
                    lastName = Read.GetString(Read.GetOrdinal("Last Name"));
                    email = Read.GetString(Read.GetOrdinal("Email"));
                    img = Read.GetString(Read.GetOrdinal("img"));
                    password = Read.GetString(Read.GetOrdinal("Password"));
                    sexe = Read.GetString(Read.GetOrdinal("sexe"));
                    active = Read.GetString(Read.GetOrdinal("active"));
                    ListAdmins.fncAdd(new clsAdmin(idadmin, number, name, lastName, email, img, active, sexe, password));
                }
                // 7. Close Read Connection
                Read.Close();
                // 8. Make the return
                return ListAdmins;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model getting the admin list from data base " + ex.Message);
                return null;
            }
        }

        // 5. fnc. Get agencies
        public clsListAgencies fncGetAgencies()
        {
            try
            {
                // 1. Object clsListAgencies
                clsListAgencies ListAgencies = new clsListAgencies();
                // 2. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 3.Execute stored procedure
                Command.CommandText = "selectAgencies";
                // 4.Execute specify the command type
                Command.CommandType = CommandType.StoredProcedure;
                // 5.Execute reader
                Read = Command.ExecuteReader();
                // 6. Load the list
                while (Read.Read())
                {
                    // variables
                    int IDagencies, Number, Agency, Address, IDbank, IDtdirectorAgencie;
                    string number, agency, address;
                    int idagencies, idbank, iddirectorAgency;
                    // SqlDataReader.GetOrdinal(String) Method
                    // Gets the column ordinal, given the name of the column.
                    IDagencies = Read.GetOrdinal("idagencies");
                    Number = Read.GetOrdinal("Number");
                    Agency = Read.GetOrdinal("Agency");
                    Address = Read.GetOrdinal("Address");
                    IDbank = Read.GetOrdinal("idbank");
                    IDtdirectorAgencie = Read.GetOrdinal("iddirectorAgency");
                    // SqlDataReader.GetInt32(Int32) Method
                    // Gets the value of the specified column as a 32-bit signed integer.
                    idagencies = Read.GetInt32(IDagencies);
                    // SqlDataReader.GetString(Int32) Method
                    // Gets the value of the specified column as a string.
                    number = Read.GetString(Number);
                    agency = Read.GetString(Agency);
                    address = Read.GetString(Address);
                    idbank = Read.GetInt32(IDbank);
                    iddirectorAgency = Read.GetInt32(IDtdirectorAgencie);
                    // ListAgencies.fncAdd(new clsAgency( number, agency, address ));
                    ListAgencies.fncAdd(new clsAgency(idagencies, number, agency, address, idbank, iddirectorAgency));
                }
                // 7. Close Read Connection
                Read.Close();
                // 8. Make the return
                return ListAgencies;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model getting the agency list from data base : " + ex.Message);
                return null;
            }
        }

        // 6 fnc.Load Directors Agency
        public clsListDirectorsAgency fncGetDirectorsAgency()
        {
            try
            {
                // 1. Objet clsListDirectors
                clsListDirectorsAgency ListDirectorsAgency = new clsListDirectorsAgency();
                // 2. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 3. Execute stored procedure
                Command.CommandText = "selectDirectorsAgency";
                // 4. Execute specify the command type
                Command.CommandType = CommandType.StoredProcedure;
                // 5. Execute the Reader
                Read = Command.ExecuteReader();
                // 6. Load the list
                while (Read.Read())
                {
                    // variables 
                    string number, name, lastName, email, img, sexe, active;
                    int iddirectorAgency;
                    decimal salary;
                    iddirectorAgency = Read.GetInt32(Read.GetOrdinal("iddirectorAgency"));
                    //idbank = Read.GetInt32(Read.GetOrdinal("idbank"));
                    number = Read.GetString(Read.GetOrdinal("Number"));
                    name = Read.GetString(Read.GetOrdinal("Name"));
                    lastName = Read.GetString(Read.GetOrdinal("Last Name"));
                    email = Read.GetString(Read.GetOrdinal("Email"));
                    img = Read.GetString(Read.GetOrdinal("img"));
                    salary = Read.GetDecimal(Read.GetOrdinal("salary"));
                    sexe = Read.GetString(Read.GetOrdinal("sexe"));
                    active = Read.GetString(Read.GetOrdinal("active"));
                    ListDirectorsAgency.fncAdd(new clsDirectorAgency(iddirectorAgency, number, name, lastName, email, img, active, sexe, salary));
                }
                // 7. Close Read Connection
                Read.Close();
                // 8. Make the return
                return ListDirectorsAgency;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model getting the director agency list from data base " + ex.Message);
                return null;
            }
        }

        // 7 fnc.Load Employees
        public clsListEmployees fncGetEmployees()
        {
            try
            {
                // 1. Objet clsListEmployees
                clsListEmployees ListEmployees = new clsListEmployees();
                // 2. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 3. Execute stored procedure
                Command.CommandText = "selectEmployees";
                // 4. Execute specify the command type
                Command.CommandType = CommandType.StoredProcedure;
                // 5. Execute the Reader
                Read = Command.ExecuteReader();
                // 6. Load the list
                while (Read.Read())
                {
                    // variables 
                    string number, name, lastName, email, img, sexe, active;
                    DateTime hiringDate;
                    int idemployee, idagencies;
                    decimal salary;
                    idemployee = Read.GetInt32(Read.GetOrdinal("idemployee"));
                    number = Read.GetString(Read.GetOrdinal("Number"));
                    name = Read.GetString(Read.GetOrdinal("Name"));
                    lastName = Read.GetString(Read.GetOrdinal("Last Name"));
                    email = Read.GetString(Read.GetOrdinal("Email"));
                    img = Read.GetString(Read.GetOrdinal("img"));
                    hiringDate = Read.GetDateTime(Read.GetOrdinal("Hiring Date"));
                    salary = Read.GetDecimal(Read.GetOrdinal("salary"));
                    sexe = Read.GetString(Read.GetOrdinal("sexe"));
                    active = Read.GetString(Read.GetOrdinal("active"));
                    idagencies = Read.GetInt32(Read.GetOrdinal("idagencies"));
                    ListEmployees.fncAdd(new clsEmployee(idemployee, number, name, lastName, email, img, active, sexe, salary, idagencies, hiringDate));
                }
                // 7. Close Read Connection
                Read.Close();
                // 8. Make the return
                return ListEmployees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model getting the employees list from data base : " + ex.Message);
                return null;
            }
        }





        // 4. fnc.Load agencies
        public DataTable AgenciesList()
        {
            try
            {
                // 1. Object DataTable
                DataTable Table = new DataTable();
                // 2. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 3. Execute stored procedure
                Command.CommandText = "selectAgencies";
                // 4. Execute the command type
                Command.CommandType = CommandType.StoredProcedure;
                // 5. Execute read agencies from the database
                Read = Command.ExecuteReader();
                // 6. Load the table
                Table.Load(Read);
                // 7. Close connection
                Connection.CloseConnection();
                // 8. Make the return
                return Table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model loading AgenciesList from the data base : " + " " + ex.Message);
                return null;
            }
        }// end agencies list

        // 5. fnc.Load clients
        public DataTable ClientsList()
        {
            try
            {
                // 1. Object DataTable
                DataTable Table = new DataTable();
                // 2. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 3. Execute stored procedure
                Command.CommandText = "selectClients";
                // 4. Execute the command type
                Command.CommandType = CommandType.StoredProcedure;
                // 5. Execute read agencies from the database
                Read = Command.ExecuteReader();
                // 6. Load the table
                Table.Load(Read);
                // 7. Close connection
                Connection.CloseConnection();
                // 8. Make the return
                return Table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model loading ClientsList from the data base : " + " " + ex.Message);
                return null;
            }
        }// end clients list





        // 6. fnc.LoadClient by agency
        public DataTable selectqClientByAgency(string Agency)
        {
            try
            {
                // 1. Object Table
                DataTable Table = new DataTable();
                // 2. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 3. Execute stored procedure
                Command.CommandText = "selectqClientByAgency";
                // 4. Execute specify the command type
                Command.CommandType = CommandType.StoredProcedure;
                // 5. Execute parametre
                Command.Parameters.AddWithValue("@aAgency", Agency);
                // 6. Execute read the rows from stored procedires
                Read = Command.ExecuteReader();
                // 7. Load the Table
                Table.Load(Read);
                // 8. Close connection
                Connection.CloseConnection();
                // 9. Make return
                return Table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model loading selectqClientByAgency the data base : " + " " + ex.Message);
                return null;
            }
        } // end Load Client by Agency

        // 6. fnc.LoadClient by Number
        public DataTable selectqClientByNumber(string Number)
        {
            try
            {
                // 1. Object Table
                DataTable Table = new DataTable();
                // 2. Execute open connection
                Command.Connection = Connection.OpenConnection();
                // 3. Execute stored procedure
                Command.CommandText = "selectqClientByNumber";
                // 4. Execute specify the command type
                Command.CommandType = CommandType.StoredProcedure;
                // 5. Execute parameters
                Command.Parameters.AddWithValue("@aNumber", Number);
                // 6. Execute read the rows from stored procedure
                Read = Command.ExecuteReader();
                // 7. Load the Table
                Table.Load(Read);
                // 8. Close connection
                Connection.CloseConnection();
                // 9. Make return
                return Table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the Model loading selectqClientByNumber the data base : " + " " + ex.Message);
                return null;
            }
        } // end client by number







        //public string ReaderClient(string Number)
        //{
        //    try
        //    {
        //        // 1. Execute Open connection
        //        Command.Connection = Connection.OpenConnection();
        //        // 2. Execute store procedure
        //        Command.CommandText = "selectqClientByAgency";
        //        // 3. Execute command type
        //        Command.CommandType = CommandType.StoredProcedure;
        //        // 4. Execute parameter
        //        Command.Parameters.AddWithValue("@aNumber", Number);
        //        // 5. Read Rows
        //        SqlDataReader Read;
        //        // 6. Execute read the Rows from stored procedure
        //        Read = Command.ExecuteReader(); // to read rows - return rows
        //        // 7. Execute Load Reader
        //        string reader;
        //        if(Read.Read()==true)
        //        {
        //            reader=Read.GetString(Read.GetOrdinal())
        //        }
        //        // 8. Execute reuse the object SqlCpmmad command
        //        // 9. Close connection
        //        // 10. Make return
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("Error in the Model executing the function ReaderClient : " + " " + ex.Message);
        //        return null;
        //    }
        //}
    }
}
