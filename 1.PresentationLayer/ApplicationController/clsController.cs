using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4.Items;
using _2.BusinessLayer;
using System.Windows.Forms;

namespace _1.PresentationLayer
{
    /*
  * This project uses the following licenses:
  *  MIT License
  *  Copyright (c) 2018 Ricardo Mendoza 
  *  Montréal Québec Canada
  */
    public class clsController
    {
        public IEnumerable<clsAdmin> GetAdminsAll(string filter)
        {
            try
            {
                // variable de tipo implicitA
                var AdminList = new clsAdminService().GetAdmins(filter);
                // Instancia de Lista
                List<clsAdmin> viewModel = new List<clsAdmin>();
                // mapear datos
                foreach (clsAdmin item in AdminList)
                {
                    viewModel.Add(new clsAdmin
                    {
                        vId=item.vId,
                        vNumber = item.vNumber,
                        vName = item.vName,
                        vLastName=item.vLastName,
                        vEmail=item.vEmail,
                        vImg=item.vImg,
                        vActive=item.vActive,
                        vSexe=item.vSexe,
                        vPassword=item.vPassword
                    });
                }
                return viewModel;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

    }
}
