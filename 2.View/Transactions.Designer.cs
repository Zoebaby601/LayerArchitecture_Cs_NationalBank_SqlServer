namespace _1.PresentationLayer
{
    partial class Transactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbtranAgencies = new System.Windows.Forms.ComboBox();
            this.txtNumerodeClient = new System.Windows.Forms.TextBox();
            this.btntranClientNumber = new System.Windows.Forms.Button();
            this.gvAgencies = new System.Windows.Forms.DataGridView();
            this.cmbListAgencies = new System.Windows.Forms.ComboBox();
            this.cmbListAdmins = new System.Windows.Forms.ComboBox();
            this.cmbListDirectors = new System.Windows.Forms.ComboBox();
            this.cmbListDirectorsAgency = new System.Windows.Forms.ComboBox();
            this.cmbListEmployee = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvAgencies)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbtranAgencies
            // 
            this.cmbtranAgencies.FormattingEnabled = true;
            this.cmbtranAgencies.Location = new System.Drawing.Point(616, 132);
            this.cmbtranAgencies.Name = "cmbtranAgencies";
            this.cmbtranAgencies.Size = new System.Drawing.Size(121, 21);
            this.cmbtranAgencies.TabIndex = 0;
            this.cmbtranAgencies.SelectedIndexChanged += new System.EventHandler(this.cmbtranAgencies_SelectedIndexChanged);
            // 
            // txtNumerodeClient
            // 
            this.txtNumerodeClient.Location = new System.Drawing.Point(616, 178);
            this.txtNumerodeClient.Name = "txtNumerodeClient";
            this.txtNumerodeClient.Size = new System.Drawing.Size(121, 20);
            this.txtNumerodeClient.TabIndex = 1;
            // 
            // btntranClientNumber
            // 
            this.btntranClientNumber.Location = new System.Drawing.Point(616, 250);
            this.btntranClientNumber.Name = "btntranClientNumber";
            this.btntranClientNumber.Size = new System.Drawing.Size(121, 23);
            this.btntranClientNumber.TabIndex = 2;
            this.btntranClientNumber.Text = "Next >>>";
            this.btntranClientNumber.UseVisualStyleBackColor = true;
            this.btntranClientNumber.Click += new System.EventHandler(this.btntranClientNumber_Click);
            // 
            // gvAgencies
            // 
            this.gvAgencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAgencies.Location = new System.Drawing.Point(30, 12);
            this.gvAgencies.Name = "gvAgencies";
            this.gvAgencies.Size = new System.Drawing.Size(564, 150);
            this.gvAgencies.TabIndex = 3;
            // 
            // cmbListAgencies
            // 
            this.cmbListAgencies.FormattingEnabled = true;
            this.cmbListAgencies.Location = new System.Drawing.Point(387, 289);
            this.cmbListAgencies.Name = "cmbListAgencies";
            this.cmbListAgencies.Size = new System.Drawing.Size(121, 21);
            this.cmbListAgencies.TabIndex = 4;
            // 
            // cmbListAdmins
            // 
            this.cmbListAdmins.FormattingEnabled = true;
            this.cmbListAdmins.Location = new System.Drawing.Point(387, 250);
            this.cmbListAdmins.Name = "cmbListAdmins";
            this.cmbListAdmins.Size = new System.Drawing.Size(121, 21);
            this.cmbListAdmins.TabIndex = 5;
            // 
            // cmbListDirectors
            // 
            this.cmbListDirectors.FormattingEnabled = true;
            this.cmbListDirectors.Location = new System.Drawing.Point(387, 204);
            this.cmbListDirectors.Name = "cmbListDirectors";
            this.cmbListDirectors.Size = new System.Drawing.Size(121, 21);
            this.cmbListDirectors.TabIndex = 6;
            // 
            // cmbListDirectorsAgency
            // 
            this.cmbListDirectorsAgency.FormattingEnabled = true;
            this.cmbListDirectorsAgency.Location = new System.Drawing.Point(137, 204);
            this.cmbListDirectorsAgency.Name = "cmbListDirectorsAgency";
            this.cmbListDirectorsAgency.Size = new System.Drawing.Size(121, 21);
            this.cmbListDirectorsAgency.TabIndex = 7;
            // 
            // cmbListEmployee
            // 
            this.cmbListEmployee.FormattingEnabled = true;
            this.cmbListEmployee.Location = new System.Drawing.Point(137, 252);
            this.cmbListEmployee.Name = "cmbListEmployee";
            this.cmbListEmployee.Size = new System.Drawing.Size(121, 21);
            this.cmbListEmployee.TabIndex = 8;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 335);
            this.Controls.Add(this.cmbListEmployee);
            this.Controls.Add(this.cmbListDirectorsAgency);
            this.Controls.Add(this.cmbListDirectors);
            this.Controls.Add(this.cmbListAdmins);
            this.Controls.Add(this.cmbListAgencies);
            this.Controls.Add(this.gvAgencies);
            this.Controls.Add(this.btntranClientNumber);
            this.Controls.Add(this.txtNumerodeClient);
            this.Controls.Add(this.cmbtranAgencies);
            this.Name = "Transactions";
            this.Text = "MVC_NationalBanc C# .NET";
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAgencies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbtranAgencies;
        private System.Windows.Forms.TextBox txtNumerodeClient;
        private System.Windows.Forms.Button btntranClientNumber;
        private System.Windows.Forms.DataGridView gvAgencies;
        private System.Windows.Forms.ComboBox cmbListAgencies;
        private System.Windows.Forms.ComboBox cmbListAdmins;
        private System.Windows.Forms.ComboBox cmbListDirectors;
        private System.Windows.Forms.ComboBox cmbListDirectorsAgency;
        private System.Windows.Forms.ComboBox cmbListEmployee;
    }
}

