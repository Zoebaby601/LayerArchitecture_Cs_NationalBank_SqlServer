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
    public class clsAgency
    {
        /// <summary>
        /// Attributes
        /// </summary>
        private int Idagencies;
        private string Number;
        private string Name;
        private string Address;
        private int Idbank;
        private int IdtdirectorAgencie;
        private clsListDirectorsAgency ListDirectorsAgency = new clsListDirectorsAgency();
        private clsListEmployees ListEmployees = new clsListEmployees();
        private clsListCLients ListClients = new clsListCLients();
        /// <summary>
        /// Constructor that takes 6 arguments and 3 lists.
        /// </summary>
        public clsAgency(int vIdagencies, string vNumber, string vName, string vAddress, int vIdbank, int vIdtdirectorAgencie,
                         clsListDirectorsAgency vListDirectorsAgency, clsListEmployees vListEmployees, clsListCLients vListClients)
        {
            Idagencies = vIdagencies;
            Number = vNumber;
            Name = vName;
            Address = vAddress;
            Idbank = vIdbank;
            IdtdirectorAgencie = vIdtdirectorAgencie;
            ListDirectorsAgency = vListDirectorsAgency;
            ListEmployees = vListEmployees;
            ListClients = vListClients;
        }

        /// <summary>
        /// Constructor that takes 6 arguments and two lists.
        /// </summary>
        public clsAgency(int vIdagencies, string vNumber, string vName, string vAddress, int vIdbank, int vIdtdirectorAgencie)
        {
            Idagencies = vIdagencies;
            Number = vNumber;
            Name = vName;
            Address = vAddress;
            Idbank = vIdbank;
            IdtdirectorAgencie = vIdtdirectorAgencie;
        }

        /// <summary>
        /// Constructor that takes 6 arguments and two lists.
        /// </summary>
        public clsAgency(string vNumber, string vName, string vAddress)
        {
            Number = vNumber;
            Name = vName;
            Address = vAddress;
        }
        /// <summary>
        /// Constructor empty.
        /// </summary>
        public clsAgency()
        {
            Idagencies = 0;
            Number = fncEmptyConstructor();
            Name = fncEmptyConstructor();
            Address = fncEmptyConstructor();
            Idbank = 0;
            IdtdirectorAgencie = 0;
        }
        /// <summary>
        /// Properties.
        /// </summary>
        public int vIdagencies
        {
            get { return Idagencies; }
            set { Idagencies = value; }
        }

        public string vNumber
        {
            get { return Number; }
            set { Number = value; }
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

        public int vIdbank
        {
            get { return Idbank; }
            set { Idbank = value; }
        }

        public int vIdtdirectorAgencie
        {
            get { return IdtdirectorAgencie; }
            set { IdtdirectorAgencie = value; }
        }

        public clsListDirectorsAgency vListDirectorsAgency
        {
            get { return ListDirectorsAgency; }
            set { ListDirectorsAgency = value; }
        }

        public clsListEmployees vListEmployees
        {
            get { return ListEmployees; }
            set { ListEmployees = value; }
        }

        public clsListCLients vListClients
        {
            get { return ListClients; }
            set { ListClients = value; }
        }

        public clsListDirectorsAgency clsListDirectorsAgency
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public clsListCLients clsListCLients
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public clsListEmployees clsListEmployees
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        //  METHODES
        /// <summary>
        /// this function displays all info the agency.
        /// </summary>
        public string fncDisplayAgency()
        {
            string info = "";
            info += "id : " + Idagencies;
            info += "Number : " + Number;
            info += "Name : " + Name;
            info += "Address : " + Address;
            info += "idBank : " + Idbank;
            info += "iddirector : " + IdtdirectorAgencie;
            info += "Director : " + ListDirectorsAgency.fncDisplay();
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
