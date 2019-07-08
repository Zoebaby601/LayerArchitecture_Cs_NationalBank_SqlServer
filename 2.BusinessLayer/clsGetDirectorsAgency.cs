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
    public class clsGetDirectorsAgency : IgetCollections
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

        // constructeur
        public clsGetDirectorsAgency() { }

        public clsListDirectors fncHandleListDirectors()
        {
            throw new NotImplementedException();
        }

        public clsListAdmins fncHandleListAdmins()
        {
            throw new NotImplementedException();
        }

        public clsListAgencies fncHandleListAgencies()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// DIRECTORS AGENCY -> 4. fnc. load directors agency list
        /// </summary>
        /// <returns>myAgency.vListDirectorsAgency;</returns>
        public clsListDirectorsAgency fncHandleListDirectorsAgency()
        {
            myAgency.vListDirectorsAgency = Model.fncGetDirectorsAgency();
            return myAgency.vListDirectorsAgency;
        }

        public clsListEmployees fncHandleListEmployees()
        {
            throw new NotImplementedException();
        }
    }
}