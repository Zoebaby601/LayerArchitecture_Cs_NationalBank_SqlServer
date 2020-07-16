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
        /// 2. Obj myBank -> interactions with the data base
        /// </summary>
        clsBank myBank = new clsBank();
        /// <summary>
        /// 3. Obj myAgency -> interactions with the data base
        /// </summary>
        clsAgency myAgency = new clsAgency();

        // DIRECTORS
        // 1. fnc.load directors list
        public clsListDirectors fncHandleListDirectors()
        {
            myBank.vListDirectors = Model.fncGetDirectors();
            return myBank.vListDirectors;
        }

        // ADMINS
        // 2. fnc. load admin list
        public clsListAdmins fncHandleListAdmins(string filter)
        {
            myBank.vListAdmins = Model.fncGetAdmins(filter);
            return myBank.vListAdmins;
        }

        // AGENCIES
        // 3. fnc.Load agency List
        public clsListAgencies fncHandleListAgencies()
        {
            myBank.vListAgencies = Model.fncGetAgencies();
            return myBank.vListAgencies;
        }

        // DIRECTORS AGENCY
        // 4. fnc. load directors agency list
        public clsListDirectorsAgency fncHandleListDirectorsAgency()
        {
            myAgency.vListDirectorsAgency = Model.fncGetDirectorsAgency();
            return myAgency.vListDirectorsAgency;
        }

        // EMPLOYEES
        // 5. fnc. load directors agency list
        public clsListEmployees fncHandleListEmployees()
        {
            myAgency.vListEmployees = Model.fncGetEmployees();
            return myAgency.vListEmployees;
        }
    }
}
