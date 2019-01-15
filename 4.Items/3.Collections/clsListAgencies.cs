using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Items
{
    /*
     * This project uses the following licenses:
     *  MIT License
     *  Copyright (c) 2018 Ricardo Mendoza
     *  Montréal Québec Canada
     */
    public class clsListAgencies
    {
        /// <summary>
        /// Propierties -> Collection : ListAgencies.
        /// </summary>
        private Dictionary<string, clsAgency> ListAgencies;
        /// <summary>
        /// Constructor
        /// </summary>
        public clsListAgencies()
        {
            ListAgencies = new Dictionary<string, clsAgency>();
        }
        /// <summary>
        /// Gets the number of the elements in the dictionary.
        /// </summary>
        public int Quantity
        {
            get { return ListAgencies.Values.Count; }
        }
        /// <summary>
        /// Gets the collection of elements in the dictionary
        /// </summary>
        public Dictionary<string, clsAgency>.ValueCollection Elements
        {
            get { return ListAgencies.Values; }
        }

        public clsAgency clsAgency
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
        /// <returns>ListAgencies.ContainsKey(number)</returns>
        public bool fncExist(string number)
        {
            try
            {
                return ListAgencies.ContainsKey(number);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in funcion Exist  : " + ex.Message);
                return false;
            }
        }
        //  2.Function : Find : TYPE clsAgency
        /// <summary>
        /// Function : fncFind(string number) -> returns an Agency by agenceNumber.
        /// </summary>
        /// <param name="agenceNumber">string number</param>
        /// <returns>ListAgencies[agenceNumber]</returns>
        public clsAgency fncFind(string number)
        {
            if (fncExist(number))
            {
                return ListAgencies[number];
            }
            else
            {
                return null;
            }
        }
        //  3.Function : Add : TYPE bool
        /// <summary>
        /// Function : fncAdd(clsAgency agency) -> adds an Agency in the Agency list.
        /// </summary>
        /// <param name="agency">clsAgency agency</param>
        /// <returns>ListAgencies.Add(agency.vAgencyNumber, agency) or false</returns>
        public bool fncAdd(clsAgency agency)
        {
            ListAgencies.Add(agency.vNumber, agency);
            return true;
        }

        public bool fncUpdate(clsAgency agency)
        {
            if (ListAgencies.ContainsKey(agency.vNumber))
            {
                ListAgencies.Remove(agency.vNumber);
            }
            ListAgencies.Add(agency.vNumber, agency);
            return true;
        }
        //  4.Function : Erase : TYPE bool
        /// <summary>
        /// Function : fncErase(string agenceNumber) -> erases an Agency from the list.
        /// </summary>
        /// <param name="agenceNumber">string number</param>
        /// <returns>ListAgencies.Remove(agenceNumber)</returns>
        public bool fncErase(string number)
        {
            return ListAgencies.Remove(number);
        }
        //  5.Function : Display : TYPE string
        /// <summary>
        /// Function : fncDisplay() -> display all agencies in ListAgencies.
        /// </summary>
        /// <returns>info</returns>
        public string fncDisplay()
        {
            string info = "";
            foreach (clsAgency agency in ListAgencies.Values)
            {
                info += agency.fncDisplayAgency();
            }
            return info;
        }
    }
}
