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
    public class clsClientRepository : clsConnectionSQL, IClientRepository
    {
        // 1. Obj clsConnection
        private clsConnection Connection = new clsConnection();
        // 4. fnc.IEnumerable Load getClients()
        // implementacion concreta define lo que hace
        public IEnumerable<clsClient> GetClients(string filter)
        {
            try
            {
                // 1. Read Rows
                SqlDataReader LeerFilas;
                // 2. Execute SQL
                SqlCommand Comando = new SqlCommand();
                // 3. Execute open connection
                Comando.Connection = Connection.OpenConnection();
                // 4. Execute stored procedure
                Comando.CommandText = "selectClientByCondition";
                // 5. Execute specify the command type
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@aCondition", filter);
                // 6. Execute open connection
                // Conexion.Open();

                // 7. Execute the Reader
                LeerFilas = Comando.ExecuteReader();
                // 8. List generic ListClients
                List<clsClient> ListClients = new List<clsClient>();
                // 9. Load the list
                while (LeerFilas.Read())
                {
                    // variables 
                    string number, name, lastName, email, img, address, cardNumber, nip, sexe, active;
                    int idclient, idagencies, idemployee;
                    // attributes
                    idclient = LeerFilas.GetInt32(LeerFilas.GetOrdinal("idclient"));
                    number = LeerFilas.GetString(LeerFilas.GetOrdinal("clientNumber"));
                    name = LeerFilas.GetString(LeerFilas.GetOrdinal("name"));
                    lastName = LeerFilas.GetString(LeerFilas.GetOrdinal("lastName"));
                    email = LeerFilas.GetString(LeerFilas.GetOrdinal("email"));
                    img = LeerFilas.GetString(LeerFilas.GetOrdinal("img"));

                    active = LeerFilas.GetString(LeerFilas.GetOrdinal("active"));
                    sexe = LeerFilas.GetString(LeerFilas.GetOrdinal("sexe"));

                    address = LeerFilas.GetString(LeerFilas.GetOrdinal("address"));
                    cardNumber = LeerFilas.GetString(LeerFilas.GetOrdinal("cardNumber"));
                    nip = LeerFilas.GetString(LeerFilas.GetOrdinal("nip"));
                    
                    idagencies = LeerFilas.GetInt32(LeerFilas.GetOrdinal("idagencies"));
                    idemployee = LeerFilas.GetInt32(LeerFilas.GetOrdinal("idemployee"));
                    ListClients.Add(new clsClient(idclient, number, name, lastName, email, img, active, sexe, address, cardNumber, nip, idagencies, idemployee));
                }
                // 10. Close Read Connection
                LeerFilas.Close();
                // Conexion.Close();
                Connection.CloseConnection();
                // 11. Make the return
                return ListClients;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in the Model getting the client list from data base " + e.Message);
                return null;
            }
        }
    }
}
