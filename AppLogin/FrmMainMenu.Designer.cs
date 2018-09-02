namespace AppLogin
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.btnAddDet = new System.Windows.Forms.Button();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDepartaments = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.MarkerPanel = new System.Windows.Forms.Panel();
            this.btnAllDet = new System.Windows.Forms.Button();
            this.btnDetInDep = new System.Windows.Forms.Button();
            this.controlAllDetails = new AppLogin.ControlAllDetails();
            this.controlDetailOnDepartament = new AppLogin.ControlDetailOnDepartament();
            this.controlCreaterReport = new AppLogin.ControlCreaterReport();
            this.controlAddDet1 = new AppLogin.ControlAddDet();
            this.controlAdministration = new AppLogin.ControlAdministration();
            this.controlAllDepartaments1 = new AppLogin.ControlAllDepartaments();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddDet
            // 
            this.btnAddDet.FlatAppearance.BorderSize = 0;
            this.btnAddDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDet.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDet.Image")));
            this.btnAddDet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDet.Location = new System.Drawing.Point(12, 172);
            this.btnAddDet.Name = "btnAddDet";
            this.btnAddDet.Size = new System.Drawing.Size(204, 80);
            this.btnAddDet.TabIndex = 2;
            this.btnAddDet.Text = "    Внести в базу новые детали";
            this.btnAddDet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddDet.UseVisualStyleBackColor = true;
            // 
            // btnShowReport
            // 
            this.btnShowReport.FlatAppearance.BorderSize = 0;
            this.btnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowReport.Image = ((System.Drawing.Image)(resources.GetObject("btnShowReport.Image")));
            this.btnShowReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowReport.Location = new System.Drawing.Point(12, 258);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(204, 80);
            this.btnShowReport.TabIndex = 3;
            this.btnShowReport.Text = "  Вывести отчет";
            this.btnShowReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.BtnShowFrmReport);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(12, 516);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(204, 80);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "    Обновить данные";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDepartaments);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.MarkerPanel);
            this.panel1.Controls.Add(this.btnAllDet);
            this.panel1.Controls.Add(this.btnAddDet);
            this.panel1.Controls.Add(this.btnDetInDep);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnShowReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 667);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 51);
            this.label1.TabIndex = 13;
            this.label1.Text = "Copyright © 2018,  Vezhyk BV\r\ntel:  +375336907007\r\nmail to: randomar9@gmail.com";
            // 
            // btnDepartaments
            // 
            this.btnDepartaments.FlatAppearance.BorderSize = 0;
            this.btnDepartaments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartaments.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartaments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDepartaments.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartaments.Image")));
            this.btnDepartaments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartaments.Location = new System.Drawing.Point(12, 430);
            this.btnDepartaments.Name = "btnDepartaments";
            this.btnDepartaments.Size = new System.Drawing.Size(204, 80);
            this.btnDepartaments.TabIndex = 12;
            this.btnDepartaments.Text = "    Отделы";
            this.btnDepartaments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepartaments.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(12, 344);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(204, 80);
            this.btnAdmin.TabIndex = 9;
            this.btnAdmin.Text = " Администратор";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // MarkerPanel
            // 
            this.MarkerPanel.BackColor = System.Drawing.Color.SandyBrown;
            this.MarkerPanel.Location = new System.Drawing.Point(0, 0);
            this.MarkerPanel.Name = "MarkerPanel";
            this.MarkerPanel.Size = new System.Drawing.Size(10, 80);
            this.MarkerPanel.TabIndex = 8;
            // 
            // btnAllDet
            // 
            this.btnAllDet.FlatAppearance.BorderSize = 0;
            this.btnAllDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllDet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllDet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAllDet.Image = ((System.Drawing.Image)(resources.GetObject("btnAllDet.Image")));
            this.btnAllDet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllDet.Location = new System.Drawing.Point(12, 0);
            this.btnAllDet.Name = "btnAllDet";
            this.btnAllDet.Size = new System.Drawing.Size(204, 80);
            this.btnAllDet.TabIndex = 7;
            this.btnAllDet.Text = "  Детали на   всех участках";
            this.btnAllDet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllDet.UseVisualStyleBackColor = true;
            // 
            // btnDetInDep
            // 
            this.btnDetInDep.FlatAppearance.BorderSize = 0;
            this.btnDetInDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetInDep.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetInDep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDetInDep.Image = ((System.Drawing.Image)(resources.GetObject("btnDetInDep.Image")));
            this.btnDetInDep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetInDep.Location = new System.Drawing.Point(12, 86);
            this.btnDetInDep.Name = "btnDetInDep";
            this.btnDetInDep.Size = new System.Drawing.Size(204, 80);
            this.btnDetInDep.TabIndex = 6;
            this.btnDetInDep.Text = "    Детали на участке";
            this.btnDetInDep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetInDep.UseVisualStyleBackColor = true;
            // 
            // controlAllDetails
            // 
            this.controlAllDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlAllDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.controlAllDetails.Departament = "";
            this.controlAllDetails.Location = new System.Drawing.Point(218, 0);
            this.controlAllDetails.Model = "";
            this.controlAllDetails.Name = "controlAllDetails";
            this.controlAllDetails.Size = new System.Drawing.Size(1077, 666);
            this.controlAllDetails.Sort = "";
            this.controlAllDetails.TabIndex = 9;
            this.controlAllDetails.Type = "";
            // 
            // controlDetailOnDepartament
            // 
            this.controlDetailOnDepartament.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlDetailOnDepartament.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.controlDetailOnDepartament.Location = new System.Drawing.Point(218, 0);
            this.controlDetailOnDepartament.Model = "";
            this.controlDetailOnDepartament.Name = "controlDetailOnDepartament";
            this.controlDetailOnDepartament.Size = new System.Drawing.Size(1077, 666);
            this.controlDetailOnDepartament.Sort = "";
            this.controlDetailOnDepartament.TabIndex = 8;
            this.controlDetailOnDepartament.Type = "";
            // 
            // controlCreaterReport
            // 
            this.controlCreaterReport.Action = "Все";
            this.controlCreaterReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlCreaterReport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.controlCreaterReport.Departament = "";
            this.controlCreaterReport.Location = new System.Drawing.Point(218, 0);
            this.controlCreaterReport.Name = "controlCreaterReport";
            this.controlCreaterReport.NameFio = "";
            this.controlCreaterReport.Size = new System.Drawing.Size(1077, 666);
            this.controlCreaterReport.TabIndex = 11;
            // 
            // controlAddDet1
            // 
            this.controlAddDet1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlAddDet1.Location = new System.Drawing.Point(218, 0);
            this.controlAddDet1.ModelDet = "";
            this.controlAddDet1.Name = "controlAddDet1";
            this.controlAddDet1.Notice = "";
            this.controlAddDet1.Quatity = "x>0";
            this.controlAddDet1.Size = new System.Drawing.Size(1077, 666);
            this.controlAddDet1.SortDet = "";
            this.controlAddDet1.TabIndex = 14;
            this.controlAddDet1.TypeDet = "";
            // 
            // controlAdministration
            // 
            this.controlAdministration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlAdministration.CmDepart = "";
            this.controlAdministration.Fname = "";
            this.controlAdministration.Lname = "";
            this.controlAdministration.Location = new System.Drawing.Point(218, 0);
            this.controlAdministration.Login = "";
            this.controlAdministration.Mname = "";
            this.controlAdministration.Name = "controlAdministration";
            this.controlAdministration.Password = "";
            this.controlAdministration.Phone = "";
            this.controlAdministration.Size = new System.Drawing.Size(1077, 666);
            this.controlAdministration.TabIndex = 12;
            // 
            // controlAllDepartaments1
            // 
            this.controlAllDepartaments1.Abbrev = "";
            this.controlAllDepartaments1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlAllDepartaments1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlAllDepartaments1.FullName = "";
            this.controlAllDepartaments1.Location = new System.Drawing.Point(218, 0);
            this.controlAllDepartaments1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.controlAllDepartaments1.Name = "controlAllDepartaments1";
            this.controlAllDepartaments1.Phone = "";
            this.controlAllDepartaments1.Size = new System.Drawing.Size(1077, 666);
            this.controlAllDepartaments1.TabIndex = 13;
            // 
            // FrmMainMenu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1295, 667);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlAllDetails);
            this.Controls.Add(this.controlDetailOnDepartament);
            this.Controls.Add(this.controlCreaterReport);
            this.Controls.Add(this.controlAddDet1);
            this.Controls.Add(this.controlAdministration);
            this.Controls.Add(this.controlAllDepartaments1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ОАО \"МОЖЕЛИТ\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddDet;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAllDet;
        private System.Windows.Forms.Button btnDetInDep;
        private System.Windows.Forms.Panel MarkerPanel;
        public ControlDetailOnDepartament controlDetailOnDepartament;
        //private AllDetails allDetails1;
        private ControlAllDetails controlAllDetails;
        private ControlCreaterReport controlCreaterReport;
        private System.Windows.Forms.Button btnAdmin;
        private ControlAdministration controlAdministration;
        private System.Windows.Forms.Button btnDepartaments;
        private ControlAllDepartaments controlAllDepartaments1;
        private ControlAddDet controlAddDet1;
        private System.Windows.Forms.Label label1;
    }
}