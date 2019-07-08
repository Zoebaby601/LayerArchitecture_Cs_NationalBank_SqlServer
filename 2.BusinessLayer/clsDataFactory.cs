using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BusinessLayer
{
    public class clsDataFactory
    {
        public IabstractFactory IabstractFactory
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public static IabstractFactory factoryData(string dataOperation)
        {
            if (dataOperation.Equals("getData"))
            {
                return new clsGetCollectionsFactory();
            }
            else if (dataOperation.Equals("saveData"))
            {
               // return new clsSaveCollectionsFactory();
            }
            return null;
        }
    }
}