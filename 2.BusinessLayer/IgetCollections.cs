using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Handle Items
using _4.Items;

namespace _2.BusinessLayer
{
    /*
    * This project uses the following licenses:
    *  MIT License
    *  Copyright (c) 2019 Ricardo Mendoza 
    *  Montréal Québec Canada
    *  Institut Teccart
    *  www.teccart.qc.ca
    *  Hiver 2019
    */
    public interface IgetCollections
    {
        // DIRECTORS
        //1. fnc.load directors
        clsListDirectors fncHandleListDirectors();
        // ADMINS
        // 2. fnc. load admin list
        clsListAdmins fncHandleListAdmins(string filter);
        // AGENCIES
        // 3. fnc.Load agency List
        clsListAgencies fncHandleListAgencies();
        // DIRECTORS AGENCY
        // 4. fnc. load directors agency list
        clsListDirectorsAgency fncHandleListDirectorsAgency();
        // EMPLOYEES
        // 5. fnc. load directors agency list
        clsListEmployees fncHandleListEmployees();
    }
}