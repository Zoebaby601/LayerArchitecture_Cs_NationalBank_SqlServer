using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Items
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
    public interface IElementsRepository
    {
        // Comportamientos que va a tener
        // Define lo que debe de hacer
        IEnumerable<clsAdmin> GetAdmins(string filter);
        IEnumerable<clsAgency> GetAgencies(string filter);
        IEnumerable<clsDirector> GetDirectors(string filter);
        IEnumerable<clsDirectorAgency> GetDirectorsAgency(string filter);
        IEnumerable<clsEmployee> GetEmployees(string filter);
    }
}