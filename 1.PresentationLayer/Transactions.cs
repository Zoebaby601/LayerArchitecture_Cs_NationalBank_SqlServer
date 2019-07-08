using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Handle decisions
using _2.BusinessLayer;
// Handle Items
using _4.Items;


namespace _1.PresentationLayer
{
    /*
    * This project uses the following licenses:
    *  MIT License
    *  Copyright (c) 2019 Ricardo Mendoza 
    *  Montréal Québec Canada
    *  Institut Teccart
    *  www.teccart.qc.ca
    *  Hiver 2019
    */

    public partial class Transactions : Form
    {
        static clsBank myBank = new clsBank();
        static clsAgency myAgency = new clsAgency();

        // CONTROLLER
        static IabstractFactory factoryGetData = clsDataFactory.factoryData("getData");
       
        public Transactions()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Transactions_Load(object sender, EventArgs e)
        {
            // DIRECTORS
            fncLoadDirectorsList();
            // ADMINS
            fncLoadAdminsList();
            // AGENCIES
            fncLoadAgenciesList();
            // DIRECTORS AGENCY
            fncLoadDirectorsAgencyList();
            // EMPLOYEES LIST
            fncLoadEmployeesList();

            fncLoadComboListDirectors();
            fncLoadComboListAdmin();
            fncLoadComboListAgency();
            fncLoadComboListDirectorsAgency();
            fncLoadComboListEmployees();
        }

        //  ANALISYS
        /// <summary>
        /// Load list Directors
        /// </summary>
        public void fncLoadDirectorsList()
        {
            IgetCollections Controller = factoryGetData.getCollections("directors");
            myBank.vListDirectors = Controller.fncHandleListDirectors();
        }
        /// <summary>
        /// Load list Admin
        /// </summary>
        public void fncLoadAdminsList()
        {
            // clsBusiness Controller = new clsBusiness();
            IgetCollections Controller = factoryGetData.getCollections("admins");
            myBank.vListAdmins = Controller.fncHandleListAdmins();
        }
        /// <summary>
        /// Load list Agency
        /// </summary>
        public void fncLoadAgenciesList()
        {
            // clsBusiness Controller = new clsBusiness();
            IgetCollections Controller = factoryGetData.getCollections("agencies");
            myBank.vListAgencies = Controller.fncHandleListAgencies();
            gvAgencies.DataSource = myBank.vListAgencies;
        }
        /// <summary>
        /// Load list Directors
        /// </summary>
        public void fncLoadDirectorsAgencyList()
        {
            // clsBusiness Controller = new clsBusiness();
            IgetCollections Controller = factoryGetData.getCollections("DirectorsAgency");
            myAgency.vListDirectorsAgency = Controller.fncHandleListDirectorsAgency();
        }
        /// <summary>
        /// Load list Directors
        /// </summary>
        public void fncLoadEmployeesList()
        {
            // clsBusiness Controller = new clsBusiness();
            IgetCollections Controller = factoryGetData.getCollections("employees");
            myAgency.vListEmployees = Controller.fncHandleListEmployees();
        }
        /// <summary>
        /// Load combo directors
        /// </summary>
        public void fncLoadComboListDirectors()
        {
            try
            {
                foreach (clsDirector director in myBank.vListDirectors.Elements)
                {

                    cmbListDirectors.Items.Add(director.vName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Load combo admin
        /// </summary>
        public void fncLoadComboListAdmin()
        {
            try
            {
                foreach (clsAdmin admin in myBank.vListAdmins.Elements)
                {

                    cmbListAdmins.Items.Add(admin.vName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Load combo agency
        /// </summary>
        public void fncLoadComboListAgency()
        {
            try
            {
                foreach (clsAgency tmp in myBank.vListAgencies.Elements)
                {
                    cmbListAgencies.Items.Add(tmp.vAddress);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Load combo directors agency
        /// </summary>
        public void fncLoadComboListDirectorsAgency()
        {
            try
            {
                foreach (clsDirectorAgency director in myAgency.vListDirectorsAgency.Elements)
                {
                    cmbListDirectorsAgency.Items.Add(director.vEmail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Load combo employees
        /// </summary>
        public void fncLoadComboListEmployees()
        {
            try
            {
                foreach (clsEmployee employee in myAgency.vListEmployees.Elements)
                {
                    cmbListEmployee.Items.Add(employee.vHiringDate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btntranClientNumber_Click(object sender, EventArgs e)
        {

        }

       

        
    }
}

