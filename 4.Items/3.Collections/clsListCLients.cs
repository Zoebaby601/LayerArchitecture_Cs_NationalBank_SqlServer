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
    public class clsListCLients
    {
        /// <summary>
        /// Propierties -> Collection : ListClients.
        /// </summary>
        private Dictionary<string, clsClient> ListClients;
        /// <summary>
        /// Constructor
        /// </summary>
        public clsListCLients()
        {
            ListClients = new Dictionary<string, clsClient>();
        }

        //  TYPE int
        /// <summary>
        /// Gets the number of the elements in the dictionary.
        /// </summary>
        public int Quantity
        {
            get { return ListClients.Values.Count; }
        }

        //  TYPE Dictionary
        /// <summary>
        /// Gets the collection of elements in the dictionary
        /// </summary>
        public Dictionary<string, clsClient>.ValueCollection Elements
        {
            get { return ListClients.Values; }
        }

        public clsClient clsClient
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
        public bool fncExist(string number)
        {
            try
            {
                return ListClients.ContainsKey(number);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in funcion Exist  : " + ex.Message);
                return false;
            }
        }
        //  2.Function : Find : TYPE clsCLient
        /// <summary>
        /// Function : fncFind(string number) -> returns an Client by number.
        /// </summary>
        /// <param name="agenceNumber">string number</param>
        /// <returns>ListClients[number]</returns>
        public clsClient fncFind(string number)
        {
            if (fncExist(number))
            {
                return ListClients[number];
            }
            else
            {
                return null;
            }
        }
        //  3.Function : Add : TYPE bool
        /// <summary>
        /// Function : fncAdd(clsClient client) -> adds a Client in the Client list.
        /// </summary>
        /// <param name="agency">clsClient client</param>
        /// <returns>ListClients.Add(client.vNumber, client) or false</returns>
        public bool fncAdd(clsClient client)
        {
            ListClients.Add(client.vNumber, client);
            return true;
        }
        //  4.Function : Erase : TYPE bool
        /// <summary>
        /// Function : fncErase( string number) -> erases a CLient from the list.
        /// </summary>
        /// <param name="agenceNumber">string number</param>
        /// <returns>ListClients.Remove(number)</returns>
        public bool fncErase(string number)
        {
            return ListClients.Remove(number);
        }
        //  5.Function : Display : TYPE string
        /// <summary>
        /// Function : fncDisplay() -> display all clients in List Clients.
        /// </summary>
        /// <returns>info</returns>
        public string fncDisplay()
        {
            string info = "";
            foreach (clsClient client in ListClients.Values)
            {
                info += client.fncDisplayHuman();
            }
            return info;
        }
    }
}
