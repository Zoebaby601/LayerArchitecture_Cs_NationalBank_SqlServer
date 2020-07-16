using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _4.Items;
// Handle Data
using _3.DataAccesLayer;

namespace _2.BusinessLayer
{
    /*
   * This project uses the following licenses:
   *  MIT License
   *  Copyright (c) 2017 Ricardo Mendoza 
   *  Montréal Québec Canada
   *  Institut Teccart
   *  www.teccart.qc.ca
   *  Août 2017
   */
    public class clsAdminService
    {
        // readonly la asignacion al campo solo ocurre en el constructor
        readonly IElementsRepository adminRepository;

        // Constructor
        public clsAdminService()
        {
            adminRepository = new clsElementsRepository();
        }

        public IEnumerable<clsAdmin> GetAdmins(string filter)
        {
            // aqui se esta usando la abstraccion del objeto
            return adminRepository.GetAdmins(filter);
        }
    }
}