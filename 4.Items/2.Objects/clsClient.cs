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
    public class clsClient : clsabstractHuman
    {
        /// <summary>
        /// Fields
        /// </summary>
        private string Address;
        private string CardNumber;
        private string Nip;
        private int Idagencies;
        private int Idemployee;
        /// <summary>
        /// Constructor
        /// </summary>
        public clsClient(int vId, string vNumber, string vName, string vLastName, string vEmail, string vImg, string vActive, string vSexe,
                         string vAddress, string vCardNumber, string vNip, int vIdagencies, int vIdemployee)
                         : base(vId, vNumber, vName, vLastName, vEmail, vImg, vActive, vSexe)
        {
            Address = vAddress;
            CardNumber = vCardNumber;
            Nip = vNip;
            Idagencies = vIdagencies;
            Idemployee = vIdemployee;
        }
        /// <summary>
        /// Constructor empty.
        /// </summary>
        public clsClient() : base()
        {
            Address = fncEmptyConstructor();
            CardNumber = fncEmptyConstructor();
            Nip = fncEmptyConstructor();
            Idagencies = 0;
            Idemployee = 0;
        }
        /// <summary>
        /// Properties.
        /// </summary>
        public string vAddress
        {
            get { return Address; }
            set { Address = value; }
        }

        public string vCardNumber
        {
            get { return CardNumber; }
            set { CardNumber = value; }
        }

        public string vNip
        {
            get { return Nip; }
            set { Nip = value; }
        }

        public int vIdagencies
        {
            get { return Idagencies; }
            set { Idagencies = value; }
        }

        public int vIdemployee
        {
            get { return Idemployee; }
            set { Idemployee = value; }
        }

        /// Override Methods.
        /// fncDisplayHuman() -> info from a human.
        /// </summary>
        /// <returns>info</returns>
        public override string fncDisplayHuman()
        {
            string info = "";
            info += base.fncDisplayHuman();
            info = info + "\nAddress" + Address;
            info = info + "\nCardNumber" + CardNumber;
            info = info + "\nNip " + Nip;
            info = info + "\nIdagencies" + Idagencies;
            info = info + "\nIdemployee " + Idemployee;
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
