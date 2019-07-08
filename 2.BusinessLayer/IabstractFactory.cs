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
    public interface IabstractFactory
    {
        IgetCollections getCollections(string collection);
    }
}