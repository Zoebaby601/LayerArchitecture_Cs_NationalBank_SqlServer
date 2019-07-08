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
    public static class clsComplements
    {
        public static string fncEmptyConstructor()
        {
            return "Do not exit";
        }
        /// <summary>
        /// Function fncTodayDate() -> Get the now date.
        /// </summary>
        /// <returns>todayDate</returns>
        public static DateTime fncTodayDate()
        {
            DateTime todayDate = DateTime.Now;
            return todayDate;
        }
    }
}