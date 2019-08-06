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
    public interface IClientRepository
    {
        // Comportamientos que va a tener
        // Define lo que va a hacer
        IEnumerable<clsClient> GetClients(string filter);
    }
}