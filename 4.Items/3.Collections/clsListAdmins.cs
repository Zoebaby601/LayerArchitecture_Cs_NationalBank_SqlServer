using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Items
{
    public class clsListAdmins
    {
        private Dictionary<string, clsAdmin> ListAdmins;

        public clsListAdmins()
        {
            ListAdmins = new Dictionary<string, clsAdmin>();
        }

        public int Quantity
        {
            get { return ListAdmins.Values.Count; }
        }

        public Dictionary<string, clsAdmin>.ValueCollection Elements
        {
            get { return ListAdmins.Values; }
        }

        public clsAdmin clsAdmin
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public bool fncExist(string number)
        {
            return ListAdmins.ContainsKey(number);
        }

        public clsAdmin fncFind(string number)
        {
            if (fncExist(number))
            {
                return ListAdmins[number];
            }
            else
            {
                return null;
            }
        }

        public bool fncAdd(clsAdmin admin)
        {
            if (!fncExist(admin.vNumber))
            {
                ListAdmins.Add(admin.vNumber, admin);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool fncUpdate(clsAdmin admin)
        {
            if (ListAdmins.ContainsKey(admin.vNumber))
            {
                ListAdmins.Remove(admin.vNumber);
            }
            ListAdmins.Add(admin.vNumber, admin);
            return true;
        }

        public bool fncErase(string number)
        {
            return ListAdmins.Remove(number);
        }

        public string fncDisplay()
        {
            string info = "";
            foreach (clsAdmin admin in ListAdmins.Values)
            {
                info = info + admin.fncDisplayHuman();
            }
            return info;
        }
    }
}
