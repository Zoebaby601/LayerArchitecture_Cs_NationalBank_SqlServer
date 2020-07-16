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
        /// <summary>
        /// In thid class we get all the elemnts from the bank
        /// </summary>
    public class clsElementsRepository : IElementsRepository
    {
        // 1. Obj clsConnection
        private clsConnection Connection = new clsConnection();
        // 2. fnc.IEnumerable Load getAdmins()
        // implementacion concreta define lo que hace
        public IEnumerable<clsAdmin> GetAdmins(string filter)
        {
           try
            {
                // 1. Read Rows
                SqlDataReader LeerFilas;
                // 2. Execute SQL
                SqlCommand Comando = new SqlCommand();
                // 3. Execute open connection
                Comando.Connection = Connection.OpenConnection();
                // 4. Executre stored procedure
                Comando.CommandText = "selectAdminByCondition";
                // 5. Execute speify the command type
                Comando.CommandType = CommandType.StoredProcedure;
                // 6. Execute condition
                Comando.Parameters.AddWithValue("@aCondition", filter);
                // 7. Execute the reader
                LeerFilas= Comando.ExecuteReader();
                // 8. Lista generica lista de admins
                List<clsAdmin> ListAdmins = new List<clsAdmin>();
                // 9. Load the List
                while (LeerFilas.Read())
                {
                    ListAdmins.Add(new clsAdmin
                        (
                        LeerFilas.GetInt32(LeerFilas.GetOrdinal("idadmin")),
                        LeerFilas.GetString(LeerFilas.GetOrdinal("adminNumber")),
                        LeerFilas.GetString(LeerFilas.GetOrdinal("name")),
                        LeerFilas.GetString(LeerFilas.GetOrdinal("lastName")),
                        LeerFilas.GetString(LeerFilas.GetOrdinal("email")),
                        LeerFilas.GetString(LeerFilas.GetOrdinal("img")),
                        LeerFilas.GetString(LeerFilas.GetOrdinal("active")),
                        LeerFilas.GetString(LeerFilas.GetOrdinal("sexe")),
                        LeerFilas.GetString(LeerFilas.GetOrdinal("password"))
                        ));
                }
                // 10. Close read connection
                LeerFilas.Close();
                Connection.CloseConnection();
                // 11. Make return
                return ListAdmins; 
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public IEnumerable<clsAgency> GetAgencies(string filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<clsDirector> GetDirectors(string filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<clsDirectorAgency> GetDirectorsAgency(string filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<clsEmployee> GetEmployees(string filter)
        {
            throw new NotImplementedException();
        }
    }
}
