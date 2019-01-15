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
    public abstract class clsabstractHuman
    {
        /// <summary>
        /// Fields
        /// </summary>
        private int Id;
        private string Number;
        private string Name;
        private string LastName;
        private string Email;
        private string Img;
        private string Active;
        private string Sexe;

        /// <summary>
        /// Constructor that takes 8 arguments : Photo constructor.
        /// </summary>
        public clsabstractHuman(int vId, string vNumber, string vName, string vLastName, string vEmail, string vImg, string vActive, string vSexe)
        {
            Id = 0;
            Number = vNumber;
            Name = vName;
            LastName = vLastName;
            Email = vEmail;
            Img = vImg;
            Active = vActive;
            Sexe = vSexe;
        }

        /// <summary>
        /// Constructor empty
        /// </summary>
        public clsabstractHuman()
        {
            Id = 0;
            Number = fncEmptyConstructor();
            Name = fncEmptyConstructor();
            LastName = fncEmptyConstructor();
            Email = fncEmptyConstructor();
            Img = fncEmptyConstructor();
            Active = fncEmptyConstructor();
            Sexe = fncEmptyConstructor();
        }

        /// <summary>
        /// Properties
        /// </summary>
        public int vId
        {
            get { return Id; }
            set { Id = value; }
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

        public string vLastName
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public string vEmail
        {
            get { return Email; }
            set { Email = value; }
        }

        public string vImg
        {
            get { return Img; }
            set { Img = value; }
        }

        public string vActive
        {
            get { return Active; }
            set { Active = value; }
        }

        public string vSexe
        {
            get { return Sexe; }
            set { Sexe = value; }
        }

        /// <summary>
        /// Methodes : virtual
        /// </summary>
        public virtual string fncDisplayHuman()
        {
            string info = "";
            info += "\nId : " + Id;
            info = info + "\nNumber" + Number;
            info = info + "\nName" + Name;
            info = info + "\nLastName" + LastName;
            info = info + "\nLastName" + Email;
            info = info + "\nActive" + Img;
            info = info + "\nActive" + Active;
            info = info + "\nSexe" + Sexe;
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
