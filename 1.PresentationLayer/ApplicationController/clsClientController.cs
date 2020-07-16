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
    public class clsClientController
    {
        public IEnumerable<clsClient> GetClientsAll(string filter)
        {
            try
            {
                // variable de tipo implicita
                var ClientList = new clsClientService().GetClients(filter);
                // Instancia de Lista
                List<clsClient> viewModel = new List<clsClient>();
                // mapear datos
                foreach (clsClient item in ClientList)
                {
                    viewModel.Add(new clsClient
                    {
                        vId = item.vId,
                        vNumber = item.vNumber,
                        vName = item.vName,
                        vLastName = item.vLastName,
                        vEmail = item.vEmail,
                        vImg = item.vImg,
                        vActive = item.vActive,
                        vSexe = item.vSexe,
                        vAddress = item.vAddress,
                        vCardNumber = item.vCardNumber,
                        vNip = item.vNip,
                        vIdagencies = item.vIdagencies,
                        vIdemployee = item.vIdemployee
                    });
                }
                return viewModel;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
