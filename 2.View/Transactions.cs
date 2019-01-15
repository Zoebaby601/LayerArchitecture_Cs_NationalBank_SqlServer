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
using _3.Controller;
// Handle Items
using _4.Items;


namespace _2.View
{
    public partial class Transactions : Form
    {
        public static clsBank myBank = new clsBank();
        public static clsAgency myAgency = new clsAgency();
        
        public Transactions()
        {
            InitializeComponent();
        }


        private void Transactions_Load(object sender, EventArgs e)
        {
            LoadtranCmbAgencies();
            DisplayAgencies();

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
            clsController Controller = new clsController();
            myBank.vListDirectors = Controller.fncHandleListDirectors();
        }
        /// <summary>
        /// Load list Admin
        /// </summary>
        public void fncLoadAdminsList()
        {
            clsController Controller = new clsController();
            myBank.vListAdmins = Controller.fncHandleListAdmins();
        }
        /// <summary>
        /// Load list Agency
        /// </summary>
        public void fncLoadAgenciesList()
        {
            clsController Controller = new clsController();
            myBank.vListAgencies = Controller.fncHandleListAgencies();
            gvAgencies.DataSource = myBank.vListAgencies;
        }
        /// <summary>
        /// Load list Directors
        /// </summary>
        public void fncLoadDirectorsAgencyList()
        {
            clsController Controller = new clsController();
            myAgency.vListDirectorsAgency = Controller.fncHandleListDirectorsAgency();
        }
        /// <summary>
        /// Load list Directors
        /// </summary>
        public void fncLoadEmployeesList()
        {
            clsController Controller = new clsController();
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







        private void LoadtranCmbAgencies()
        {
            clsController Controller = new clsController();
            cmbtranAgencies.DataSource = Controller.AgenciesList();
            cmbtranAgencies.DisplayMember = "Agency";
            cmbtranAgencies.ValueMember = "idagencies";

        }

        //public void getAgencies()
        //{
        //    clsController Controller = new clsController();
        //    Controller.gatAgencies();
        //}



        //private void DisplayClients()
        //{
        //    // new Controller cleans the object everytime it is called
        //    // new Controllercleans the view with every click
        //    clsInfo Controller = new clsInfo();
        //    gvClient.DataSource = Controller.LoadClients();
        //}

        private void cmbtranAgencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsController Controller = new clsController();
            string stringcmboxAgencies = cmbtranAgencies.Text.Trim();
            DataTable Table = new DataTable();
            string stringNumber = txtNumerodeClient.Text.Trim();
            Table = Controller.selectqClientByNumber(stringNumber);
        }

        private void btntranClientNumber_Click(object sender, EventArgs e)
        {

        }

        public void DisplayAgencies()
        {
            //  gvAgencies.DataSource = clsStaticDataSource.fncGetAgencies();
        }


    }
}
