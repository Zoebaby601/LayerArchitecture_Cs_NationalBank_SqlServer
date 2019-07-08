using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Items
{
    public class clsListDirectorsAgency : IfncDictionary
    {
        /*
        * This project uses the following licenses:
        *  MIT License
        *  Copyright (c) 2018 Ricardo Mendoza
        *  Montréal Québec Canada
       */
        /// <summary>
        /// Propierties -> Collection : ListDirectorAgency.
        /// </summary>
        private Dictionary<string, clsDirectorAgency> ListDirectorAgency;
        /// <summary>
        /// Constructor
        /// </summary>
        public clsListDirectorsAgency()
        {
            ListDirectorAgency = new Dictionary<string, clsDirectorAgency>();
        }
        /// <summary>
        /// Gets the number of the elements in the dictionary.
        /// </summary>
        public int Quantity
        {
            get { return ListDirectorAgency.Values.Count; }
        }
        /// <summary>
        /// Gets the collection of elements in the dictionary
        /// </summary>
        public Dictionary<string, clsDirectorAgency>.ValueCollection Elements
        {
            get { return ListDirectorAgency.Values; }
        }

        public clsDirectorAgency clsDirectorAgency
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        //  Methodes
        //  1.Function : Exist : TYPE bool
        /// <summary>
        /// Function : fncExist(string number) -> bool true if the Agency exist.
        /// </summary>
        /// <param name="number">string number</param>
        /// <returns>ListAgencies.ContainsKey(number);</returns>
        public bool fncExist(string number)
        {
            return ListDirectorAgency.ContainsKey(number);
        }
        //  2.Function : Find : TYPE 
        /// <summary>
        /// Function : fncFind(string number) -> returns a Director Agency by Number.
        /// </summary>
        /// <param name="agenceNumber">number</param>
        /// <returns>ListAgencies[agenceNumber]</returns>
        public clsDirectorAgency fncFind(string number)
        {
            if (fncExist(number))
            {
                return ListDirectorAgency[number];
            }
            else
            {
                return null;
            }
        }
        //  3.Function : Add : TYPE bool
        /// <summary>
        /// Function : fncAdd(clsDirectorAgency director) -> adds a Director in the Director Agency list.
        /// </summary>
        /// <param name="agency">clsDirectorAgency director</param>
        /// <returns>ListDirectorAgency.Add(director.vNumber, director) or false</returns>
        public bool fncAdd(clsDirectorAgency director)
        {
            if (!fncExist(director.vNumber))
            {
                ListDirectorAgency.Add(director.vNumber, director);
                return true;
            }
            else
            {
                return false;
            }
        }
        //  4.Function : Update : TYPE bool
        /// <summary>
        /// Function : fncUpdate(clsDirectorAgency director) -> updates a Director in the Director Agency list.
        /// </summary>
        /// <param name="agency">clsDirectorAgency director</param>
        /// <returns>ListDirectorAgency.Add(director.vNumber, director) or false</returns>
        public bool fncUpdate(clsDirectorAgency director)
        {
            if (ListDirectorAgency.ContainsKey(director.vNumber))
            {
                ListDirectorAgency.Remove(director.vNumber);
            }
            ListDirectorAgency.Add(director.vNumber, director);
            return true;
        }
        //  5.Function : Erase TYPE bool
        /// <summary>
        /// Function : fncErase(string number) -> erases a Director in the Director Agency list.
        /// </summary>
        /// <param name="agenceNumber">string number</param>
        /// <returns>ListDirectorAgency.Remove(number)</returns>
        public bool fncErase(string number)
        {
            return ListDirectorAgency.Remove(number);
        }
        //  6.Function : Display
        /// <summary>
        /// Function : fncDisplay() -> display all Directors in the Directors list.
        /// </summary>
        /// <returns>info</returns>
        public string fncDisplay()
        {
            string info = "";
            foreach (clsDirectorAgency director in ListDirectorAgency.Values)
            {
                info += director.fncDisplayHuman();
            }
            return info;
        }

        public void fncClear()
        {
            throw new NotImplementedException();
        }
    }
}
