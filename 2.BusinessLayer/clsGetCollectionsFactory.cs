using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

    public class clsGetCollectionsFactory : IabstractFactory
    {
        public IgetCollections IgetCollections
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public IgetCollections getCollections(string collection)
        {
            if (collection.Equals("directors"))
            {
                return new clsGetDirectors();
            }
            else if (collection.Equals("admins"))
            {
                return new clsGetAdmins();
            }
            else if (collection.Equals("agencies"))
            {
                return new clsGetAgencies();
            }
            else if (collection.Equals("DirectorsAgency"))
            {
                return new clsGetDirectorsAgency();
            }
            else if (collection.Equals("employees"))
            {
                return new clGetEmployees();
            }
            else  
                return new clsGetNobody();
        }
    }
}