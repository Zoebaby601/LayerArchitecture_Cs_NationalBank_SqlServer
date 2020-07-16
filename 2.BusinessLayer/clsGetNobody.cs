using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; // MsgBox
using _4.Items;

namespace _2.BusinessLayer
{
    public class clsGetNobody : IgetCollections
    {
        public clsListDirectors fncHandleListDirectors()
        {
            MessageBox.Show("\nTHERE IS NO COLLECTION");
            return null;
        }

        public clsListAdmins fncHandleListAdmins(string filter)
        {
            throw new NotImplementedException();
        }

        public clsListAgencies fncHandleListAgencies()
        {
            throw new NotImplementedException();
        }

        public clsListDirectorsAgency fncHandleListDirectorsAgency()
        {
            throw new NotImplementedException();
        }

        public clsListEmployees fncHandleListEmployees()
        {
            throw new NotImplementedException();
        }
    }
}