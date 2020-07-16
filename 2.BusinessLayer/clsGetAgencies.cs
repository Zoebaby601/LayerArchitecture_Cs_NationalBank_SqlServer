using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _4.Items;
// Handle Data
using _3.DataAccesLayer;


namespace _2.BusinessLayer
{
    /*
    * This project uses the following licenses:
    *  MIT License
    *  Copyright (c) 2017 Ricardo Mendoza 
    *  Montréal Québec Canada
    *  Institut Teccart
    *  www.teccart.qc.ca
    *  Août 2017
    */
    public class clsGetAgencies : IgetCollections
    {
        /// <summary>
        /// 1. Obj Model -> object with the interactions with the data base
        /// </summary>
        private clsDataSource Model = new clsDataSource();
        /// <summary>
        /// 2. Obj myBank -> interactions with the data base
        /// </summary>
        clsBank myBank = new clsBank();


        // constructeur
        public clsGetAgencies() { }

        public clsListDirectors fncHandleListDirectors()
        {
            throw new NotImplementedException();
        }

        public clsListAdmins fncHandleListAdmins(string filter)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// AGENCIES -> 3. fnc.Load agency List
        /// </summary>
        /// <returns>myBank.vListAgencies;</returns>
        public clsListAgencies fncHandleListAgencies()
        {
            myBank.vListAgencies = Model.fncGetAgencies();
            return myBank.vListAgencies;
        }

        public clsListDirectorsAgency fncHandleListDirectorsAgency()
        {
            throw new NotImplementedException();
        }

        public clsListEmployees fncHandleListEmployees()
        {
            throw new NotImplementedException();
        }
    }
}