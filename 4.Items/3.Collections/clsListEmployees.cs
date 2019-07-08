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
    public class clsListEmployees : IfncDictionary
    {
        /// <summary>
        /// Propierties -> Collection : ListEmployees.
        /// </summary>
        private Dictionary<string, clsEmployee> ListEmployees;
        /// <summary>
        /// Constructor
        /// </summary>
        public clsListEmployees()
        {
            ListEmployees = new Dictionary<string, clsEmployee>();
        }
        /// <summary>
        /// Gets the number of the elements in the dictionary.
        /// </summary>
        public int Quantity
        {
            get { return ListEmployees.Values.Count; }
        }
        /// <summary>
        /// Gets the collection of elements in the dictionary
        /// </summary>
        public Dictionary<string, clsEmployee>.ValueCollection Elements
        {
            get { return ListEmployees.Values; }
        }

        public clsEmployee clsEmployee
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
        //  1.Function : Exist
        /// <summary>
        /// Function : fncExist(string number) -> bool true if the Employee exist.
        /// </summary>
        /// <param name="number">string number</param>
        /// <returns>ListEmployees.ContainsKey(number)</returns>
        public bool fncExist(string number)
        {
            try
            {
                return ListEmployees.ContainsKey(number);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in funcion Exist  : " + ex.Message);
                return false;
            }
        }
        //  2.Function : Find
        /// <summary>
        /// Function : fncFind(string number) -> returns an Employee by number.
        /// </summary>
        /// <param name="agenceNumber">string number</param>
        /// <returns>ListAgencies[agenceNumber]</returns>
        public clsEmployee fncFind(string number)
        {
            if (fncExist(number))
            {
                return ListEmployees[number];
            }
            else
            {
                return null;
            }
        }
        //  3.Function : Add
        /// <summary>
        /// Function : fncAdd(clsEmployee employee) -> adds an Employee in the Employee list.
        /// </summary>
        /// <param name="agency">clsEmployee employee</param>
        /// <returns>ListEmployees.Add(employee.vNumber, employee) or false</returns>
        public bool fncAdd(clsEmployee employee)
        {
            ListEmployees.Add(employee.vNumber, employee);
            return true;
        }
        //  4.Function : Erase
        /// <summary>
        /// Function : fncErase(number) -> erases an Employee from the list.
        /// </summary>
        /// <param name="agenceNumber">string number</param>
        /// <returns>ListAgencies.Remove(agenceNumber)</returns>
        public bool fncErase(string number)
        {
            return ListEmployees.Remove(number);
        }
        //  5.Function : Display
        /// <summary>
        /// Function : fncDisplay() -> display all Employees in ListEmployees.
        /// </summary>
        /// <returns>info</returns>
        public string fncDisplay()
        {
            string info = "";
            foreach (clsEmployee employee in ListEmployees.Values)
            {
                info += employee.fncDisplayHuman();
            }
            return info;
        }

        public void fncClear()
        {
            throw new NotImplementedException();
        }
    }
}
