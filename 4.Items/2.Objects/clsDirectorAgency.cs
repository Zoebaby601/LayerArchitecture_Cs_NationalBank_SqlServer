using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Items
{
    /*
    * This project uses the following licenses:
    *  MIT License
    *  Copyright (c) 2018 Ricardo Mendoza
    *  Montréal Québec Canada
   */
    public class clsDirectorAgency : clsabstractHuman
    {
        /// <summary>
        /// Fields
        /// </summary>
        private decimal Salary;

        /// <summary>
        /// Constructor
        /// </summary>
        public clsDirectorAgency(int vId, string vNumber, string vName, string vLastName, string vEmail, string vImg, string vActive, string vSexe, decimal vSalary)
                         : base(vId, vNumber, vName, vLastName, vEmail, vImg, vActive, vSexe)
        {
            Salary = vSalary;
        }
        /// <summary>
        /// Constructor empty
        /// </summary>
        public clsDirectorAgency() : base()
        {
            Salary = 0;
        }
        /// <summary>
        /// Properties
        /// </summary>
        public decimal vSalary
        {
            get { return Salary; }
            set { Salary = value; }
        }
        /// <summary>
        /// Methodes : override
        /// </summary>
        public override string fncDisplayHuman()
        {
            string info = "";
            info += base.fncDisplayHuman();
            info = info + "\nSalary" + Salary;
            return info;
        }
    }
}
