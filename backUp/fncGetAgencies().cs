       /// <summary>
		/// 1. Obj clsConnection -> object connection with the data base
		/// </summary>
		clsConnection Connection = new clsConnection();
		// 2. Execute SQl
		SqlCommand Command = new SqlCommand();
		// 3 . Read Rows
		SqlDataReader Read;

	   

        // AGENCIES
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
                    int idagencies, idbank, idtdirectorAgencie;
                    // SqlDataReader.GetOrdinal(String) Method
                    // Gets the column ordinal, given the name of the column.
                    IDagencies = Read.GetOrdinal("idagencies");
                    Number = Read.GetOrdinal("Number");
                    Agency = Read.GetOrdinal("Agency");
                    Address = Read.GetOrdinal("Address");
                    IDbank = Read.GetOrdinal("idbank");
                    IDtdirectorAgencie = Read.GetOrdinal("idtdirectorAgencie");
                    // SqlDataReader.GetInt32(Int32) Method
                    // Gets the value of the specified column as a 32-bit signed integer.
                    idagencies = Read.GetInt32(IDagencies);
                    // SqlDataReader.GetString(Int32) Method
                    // Gets the value of the specified column as a string.
                    number = Read.GetString(Number);
                    agency = Read.GetString(Agency);
                    address = Read.GetString(Address);
                    idbank = Read.GetInt32(IDbank);
                    idtdirectorAgencie = Read.GetInt32(IDtdirectorAgencie);
                    // ListAgencies.fncAdd(new clsAgency( number, agency, address ));
                    ListAgencies.fncAdd(new clsAgency(idagencies, number, agency, address, idbank, idtdirectorAgencie));
                }
                // 7. Close Read Connection
                Read.Close();
                // 8. Make the return
                return ListAgencies;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting the list in Model getting the agency list from data base : " + ex.Message);
                return null;
            }
        }