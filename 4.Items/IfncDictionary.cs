using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Items
{
    public interface IfncDictionary
    {
        bool fncExist(string id);
        bool fncErase(string number);
        void fncClear();
        string fncDisplay();
    }
}