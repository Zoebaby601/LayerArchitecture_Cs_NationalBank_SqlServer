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
    public class clsAdmin : clsabstractHuman
    {
        /// <summary>
        /// Fields
        /// </summary>
        private string Password;

        /// <summary>
        /// Constructor
        /// </summary>
        public clsAdmin(int vId, string vNumber, string vName, string vLastName, string vEmail, string vImg, string vActive, string vSexe, string vPassword)
                         : base(vId, vNumber, vName, vLastName, vEmail, vImg, vActive, vSexe)
        {
            Password = vPassword;
        }
        /// <summary>
        /// Constructor empty
        /// </summary>
        public clsAdmin() : base()
        {
            Password = fncEmptyConstructor();
        }
        /// <summary>
        /// Properties
        /// </summary>
        public string vPassword
        {
            get { return Password; }
            set { Password = value; }
        }
        /// <summary>
        /// Methodes : override
        /// </summary>
        public override string fncDisplayHuman()
        {
            string info = "";
            info += base.fncDisplayHuman();
            info = info + "\nPassword" + Password;
            return info;
        }
        /// <summary>
        /// this function return do not exist to an empty propertie.
        /// </summary>
        //public string fncEmptyConstructor()
        //{
        //    return "Don not exist";
        //}
    }
}
