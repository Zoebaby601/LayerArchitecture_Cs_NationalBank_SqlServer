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
    public class clsBank
    {
        /// <summary>
        /// Fields
        /// </summary>
        private int IdBank;
        private string Name;
        private string Address;
        private float Capital;
        private clsListDirectors ListDirectors = new clsListDirectors();
        private clsListAdmins ListAdmins = new clsListAdmins();
        private clsListAgencies ListAgencies = new clsListAgencies();
        /// <summary>
        /// Constructor that takes four arguments and the director list, agencies list and the admin list.
        /// </summary>
        public clsBank(int vIdBank, string vName, string vAddress, float vCapital,
                       clsListDirectors vListDirectors, clsListAdmins vListAdmins, clsListAgencies vListAgencies)
        {
            IdBank = vIdBank;
            Name = vName;
            Address = vAddress;
            Capital = vCapital;
            ListDirectors = vListDirectors;
            ListAdmins = vListAdmins;
            ListAgencies = vListAgencies;
        }
        /// <summary>
        /// Constructor empty
        /// </summary>
        public clsBank()
        {
            IdBank = 0;
            Name = fncEmptyConstructor();
            Address = fncEmptyConstructor();
            Capital = 0;
            ListAgencies = null;
        }
        /// <summary>
        /// Properties
        /// </summary>
        public int vIdBank
        {
            get { return IdBank; }
            set { IdBank = value; }
        }

        public string vName
        {
            get { return Name; }
            set { Name = value; }
        }

        public string vAddress
        {
            get { return Address; }
            set { Address = value; }
        }

        public float vCapital
        {
            get { return Capital; }
            set { Capital = value; }
        }

        public clsListDirectors vListDirectors
        {
            get { return ListDirectors; }
            set { ListDirectors = value; }
        }

        public clsListAdmins vListAdmins
        {
            get { return ListAdmins; }
            set { ListAdmins = value; }
        }

        public clsListAgencies vListAgencies
        {
            get { return ListAgencies; }
            set { ListAgencies = value; }
        }

        public clsListAdmins clsListAdmins
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public clsListDirectors clsListDirectors
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public clsListAgencies clsListAgencies
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        /// <summary>
        /// Methodes
        /// </summary>
        public string fncDisplay()
        {
            string info = "";
            info += "\nIdBank" + IdBank;

            info += "\nName" + Name;
            info += "\nAddress" + Address;
            info += "\nCapital" + Capital;
            info += "\nDirectors" + ListDirectors.fncDisplay();
            info += "\nAdmins" + ListAdmins.fncDisplay();
            info += "\nAgencies" + ListAgencies.fncDisplay();
            return info;
        }
        /// <summary>
        /// this function return do not exist to an empty propertie.
        /// </summary>
        public string fncEmptyConstructor()
        {
            return "Don not exist";
        }
    }
}
