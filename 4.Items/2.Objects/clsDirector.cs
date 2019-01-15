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
    public class clsDirector : clsabstractHuman
    {
        private decimal Salary;
        private int Idbank;
        /// <summary>
        /// Constructor
        /// </summary>
        public clsDirector(int vId, string vNumber, string vName, string vLastName, string vEmail, string vImg, string vActive, string vSexe, decimal vSalary, int vIdbank)
                         : base(vId, vNumber, vName, vLastName, vEmail, vImg, vActive, vSexe)
        {
            Salary = vSalary;
            Idbank = vIdbank;
        }
        /// <summary>
        /// Constructor empty
        /// </summary>
        public clsDirector() : base()
        {
            Salary = 0;
            Idbank = 0;
        }
        /// <summary>
        /// Properties
        /// </summary>
        public decimal vSalary
        {
            get { return Salary; }
            set { Salary = value; }
        }

        public int vIdbank
        {
            get { return Idbank; }
            set { Idbank = value; }
        }
        /// <summary>
        /// Methodes : override
        /// </summary>
        public override string fncDisplayHuman()
        {
            string info = "";
            info += base.fncDisplayHuman();
            info = info + "\nSalary" + Salary;
            info = info + "\nIdbank" + Idbank;
            return info;
        }
    }
}
