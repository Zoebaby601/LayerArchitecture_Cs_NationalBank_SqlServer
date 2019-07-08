using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Items
{
    public class clsListDirectors : IfncDictionary
    {
        /*
       * This project uses the following licenses:
       *  MIT License
       *  Copyright (c) 2018 Ricardo Mendoza
       *  Montréal Québec Canada
      */
        /// <summary>
        /// Propierties -> Collection : ListDirectors.
        /// </summary>
        private Dictionary<string, clsDirector> ListDirectors;
        /// <summary>
        /// Constructor
        /// </summary>
        public clsListDirectors()
        {
            ListDirectors = new Dictionary<string, clsDirector>();
        }
        /// <summary>
        /// Gets the number of the elements in the dictionary.
        /// </summary>
        public int Quaantity
        {
            get { return ListDirectors.Values.Count; }
        }
        /// <summary>
        /// Gets the collection of elements in the dictionary
        /// </summary>
        public Dictionary<string, clsDirector>.ValueCollection Elements
        {
            get { return ListDirectors.Values; }
        }

        public clsDirector clsDirector
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
        /// Function : fncExist(string number) -> bool true if the Director exist.
        /// </summary>
        /// <param name="number">string number</param>
        /// <returns>ListDirectors.ContainsKey(number)</returns>
        public bool fncExist(string number)
        {
            return ListDirectors.ContainsKey(number);
        }
        //  2.Function : Find : TYPE 
        /// <summary>
        /// Function : fncFind(string number) -> returns a Director by Number.
        /// </summary>
        /// <param name="agenceNumber">number</param>
        /// <returns>ListAgencies[agenceNumber]</returns>
        public clsDirector fncFind(string number)
        {
            if (fncExist(number))
            {
                return ListDirectors[number];
            }
            else
            {
                return null;
            }
        }
        //  3.Function : Add : TYPE bool
        /// <summary>
        /// Function : fncAdd(clsDirector director) -> adds a Director in the Director list.
        /// </summary>
        /// <param name="agency">clsDirector director</param>
        /// <returns>ListDirectors.Add(director.vNumber, director) or false</returns>
        public bool fncAdd(clsDirector director)
        {
            if (!fncExist(director.vNumber))
            {
                ListDirectors.Add(director.vNumber, director);
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
        public bool fncUpdate(clsDirector director)
        {
            if (ListDirectors.ContainsKey(director.vNumber))
            {
                ListDirectors.Remove(director.vNumber);
            }
            ListDirectors.Add(director.vNumber, director);
            return true;
        }
        //  5.Function : Erase
        /// <summary>
        /// Function : fncErase(string number) -> erases a Director in the Director list.
        /// </summary>
        /// <param name="agenceNumber">string number</param>
        /// <returns>ListDirectors.Remove(number)</returns>
        public bool fncErase(string number)
        {
            return ListDirectors.Remove(number);
        }
        //  6.Function : Display
        /// <summary>
        /// Function : fncDisplay() -> display all Directors in the Directors list.
        /// </summary>
        /// <returns>info</returns>
        public string fncDisplay()
        {
            string info = "";
            foreach (clsDirector director in ListDirectors.Values)
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
