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
    public class clsGetAdmins : IgetCollections
    {
        /// <summary>
        /// 1. Obj Model -> object with the interactions with the data base
        /// </summary>
        // readonly la asignacion al campo solo ocurre en el constructor
        readonly clsDataSource Model;
        /// <summary>
        /// 2. Obj myBank -> interactions with the data base
        /// </summary>
        // readonly la asignacion al campo solo ocurre en el constructor
        readonly clsBank myBank;

        // Constructor
        public clsGetAdmins()
        {
            Model = new clsDataSource();
            myBank = new clsBank();
        }

        public clsListDirectors fncHandleListDirectors()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ADMINS -> 2. fnc. load admin list
        /// </summary>
        /// <returns>myBank.vListAdmins</returns>
        public clsListAdmins fncHandleListAdmins(string filter)
        {
            myBank.vListAdmins = Model.fncGetAdmins(filter);
            return myBank.vListAdmins;
        }

        public clsListAgencies fncHandleListAgencies()
        {
            throw new NotImplementedException();
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