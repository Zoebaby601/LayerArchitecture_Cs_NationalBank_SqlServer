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
    public class clsEmployee : clsabstractHuman
    {
        /// <summary>
        /// Fields
        /// </summary>
        private decimal Salary;
        private int Idagencies;
        //private clsDate HiringDate;
        private DateTime HiringDate;
        /// <summary>
        /// Constructor
        /// </summary>
        //public clsEmployee(int vId, string vNumber, string vName, string vLastName, string vEmail, string vImg, string vActive, string vSexe,
        //                 decimal vSalary, int vIdagencies, int vDay, int vMonth, int vYear) 
        //                 : base (vId, vNumber, vName, vLastName, vEmail, vImg, vActive, vSexe)
        //{
        //    Salary = vSalary;
        //    Idagencies = vIdagencies;
        //    HiringDate = new clsDate(vDay, vMonth, vYear);
        //}
        public clsEmployee(int vId, string vNumber, string vName, string vLastName, string vEmail, string vImg, string vActive, string vSexe,
                         decimal vSalary, int vIdagencies, DateTime vHiringDate)
                         : base(vId, vNumber, vName, vLastName, vEmail, vImg, vActive, vSexe)
        {
            Salary = vSalary;
            Idagencies = vIdagencies;
            HiringDate = vHiringDate;
        }
        /// <summary>
        /// Constructor empty.
        /// </summary>
        public clsEmployee() : base()
        {
            Salary = 0;
            Idagencies = 0;
            HiringDate = new DateTime();
        }
        /// <summary>
        /// Properties.
        /// </summary>
        public decimal vSalary
        {
            get { return Salary; }
            set { Salary = value; }
        }

        public int vIdagencies
        {
            get { return Idagencies; }
            set { Idagencies = value; }
        }

        //public clsDate vHiringDate
        //{
        //    get{return HiringDate;}    
        //    set{HiringDate = value; }
        //}

        public DateTime vHiringDate
        {
            get { return HiringDate; }
            set { HiringDate = value; }
        }

        public clsDate clsDate
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        /// Override Methods.
        /// fncDisplayHuman() -> info from a human.
        /// </summary>
        /// <returns>info</returns>
        public override string fncDisplayHuman()
        {
            //clsDate Info = new clsDate();
            string info = "";
            info += base.fncDisplayHuman();
            info = info + "\nSalary" + Salary;
            info = info + "\nIdagencies" + Idagencies;
            //info = info + "\nDate" + Info.fncPrintDate();
            info = info + "\nDate" + HiringDate;
            return info;
        }
    }
}
