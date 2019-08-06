using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// DATA
using System.Data;
using System.Data.SqlClient;

namespace _3.DataAccesLayer
{
    /*
    * This project uses the following licenses:
    *  MIT License
    *  Copyright (c) 2018 Ricardo Mendoza
    *  Montréal Québec Canada
    *  */
    public class clsConnectionSQL
    {
        // Error 40: Could not open a connection to SQL Server fixed with  http://msdn.microsoft.com/en-us/library/ms174212.aspx
        // in My computer : C:\Windows\SysWOW64\SQLServerManager14.msc
        protected SqlConnection Conexion = new SqlConnection("Data Source = .; DataBase = bd_NationalBank; Integrated Security = true");
    }
}
