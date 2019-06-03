using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // MsgBox
// Data
using System.Data;
using System.Data.SqlClient;
// Handle Data
using _3.DataAccesLayer;
// Handle Items
using _4.Items;

namespace _2.BusinessLayer
{
    /*
    * This project uses the following licenses:
    *  MIT License
    *  Copyright (c) 2018 Ricardo Mendoza 
    *  Montréal Québec Canada
   */
    public class clsBusiness
    {
        /// <summary>
        /// 1. Obj Model -> object with the interactions with the data base
        /// </summary>
        private clsDataSource Model = new clsDataSource();

        /// <summary>
        /// 1. Obj myBank -> interactions with the data base
        /// </summary>
        clsBank myBank = new clsBank();
        /// <summary>
        /// 2. Obj myAgency -> interactions with the data base
        /// </summary>
        clsAgency myAgency = new clsAgency();

        // DIRECTORS
        //3. fnc.load directors list
        public clsListDirectors fncHandleListDirectors()
        {
            myBank.vListDirectors = Model.fncGetDirectors();
            return myBank.vListDirectors;
        }

        // ADMINS
        // 4. fnc. load admin list
        public clsListAdmins fncHandleListAdmins()
        {
            myBank.vListAdmins = Model.fncGetAdmins();
            return myBank.vListAdmins;
        }

        // AGENCIES
        // 5. fnc.Load agency List
        public clsListAgencies fncHandleListAgencies()
        {
            myBank.vListAgencies = Model.fncGetAgencies();
            return myBank.vListAgencies;
        }

        // DIRECTORS AGENCY
        // 6. fnc. load directors agency list
        public clsListDirectorsAgency fncHandleListDirectorsAgency()
        {
            myAgency.vListDirectorsAgency = Model.fncGetDirectorsAgency();
            return myAgency.vListDirectorsAgency;
        }

        // EMPLOYEES
        // 6. fnc. load directors agency list
        public clsListEmployees fncHandleListEmployees()
        {
            myAgency.vListEmployees = Model.fncGetEmployees();
            return myAgency.vListEmployees;
        }






        // 2. fnc.LoadAgenciesList
        public DataTable AgenciesList()
        {
            // 1. Onj DataTable
            DataTable Table = new DataTable();
            // 2. Info Agencies in Table Object
            Table = Model.AgenciesList();
            // 3. Make return
            return Table;
        } // end LoadAgenciesList

        // 3. fnc.LoadClientsList
        public DataTable ClientsList()
        {
            // 1. Onj DataTable
            DataTable Table = new DataTable();
            // 2. Info Clients in Table Object
            Table = Model.ClientsList();
            // 3. Make return
            return Table;
        } // end LoadAgenciesList

        // 4. fnc.LoadClients By Agency
        public DataTable sselectqClientByAgency(string Agency)
        {
            // 1. Obj Data Table
            DataTable Table = new DataTable();
            // 2. Info Clients by Agency
            Table = Model.selectqClientByAgency(Agency);
            // 3. Make return
            return Table;
        }

        // 5. fnc.LoadCleints By Number
        public DataTable selectqClientByNumber(string Number)
        {
            // 1. Obj Data Table
            DataTable Table = new DataTable();
            // 2. Info clients by Number
            Table = Model.selectqClientByNumber(Number);
            // 3. return Table
            return Table;
        }
    }
}
