namespace AppLogin
{
    partial class ControlCreaterReport
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlCreaterReport));
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvReport = new System.Windows.Forms.DataGridView();
            this.labFrom = new System.Windows.Forms.Label();
            this.labTo = new System.Windows.Forms.Label();
            this.cmAction = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmDepartament = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmName = new System.Windows.Forms.ComboBox();
            this.chAllTime = new System.Windows.Forms.CheckBox();
            this.chbRemainder = new System.Windows.Forms.CheckBox();
            this.dtDateRemainder = new System.Windows.Forms.DateTimePicker();
            this.chActivity = new System.Windows.Forms.CheckBox();
            this.chMainReport = new System.Windows.Forms.CheckBox();
            this.btnCreateRep = new System.Windows.Forms.Button();
            this.btnToPrint = new System.Windows.Forms.Button();
            this.btnToExcel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFromDate
            // 
            resources.ApplyResources(this.dtFromDate, "dtFromDate");
            this.dtFromDate.Name = "dtFromDate";
            // 
            // dtToDate
            // 
            resources.ApplyResources(this.dtToDate, "dtToDate");
            this.dtToDate.Name = "dtToDate";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnToPrint);
            this.panel1.Controls.Add(this.btnToExcel);
            this.panel1.Name = "panel1";
            // 
            // DgvReport
            // 
            resources.ApplyResources(this.DgvReport, "DgvReport");
            this.DgvReport.AllowUserToAddRows = false;
            this.DgvReport.AllowUserToDeleteRows = false;
            this.DgvReport.AllowUserToOrderColumns = true;
            this.DgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReport.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvReport.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.DgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReport.Name = "DgvReport";
            this.DgvReport.ReadOnly = true;
            // 
            // labFrom
            // 
            resources.ApplyResources(this.labFrom, "labFrom");
            this.labFrom.Name = "labFrom";
            // 
            // labTo
            // 
            resources.ApplyResources(this.labTo, "labTo");
            this.labTo.Name = "labTo";
            // 
            // cmAction
            // 
            resources.ApplyResources(this.cmAction, "cmAction");
            this.cmAction.FormattingEnabled = true;
            this.cmAction.Items.AddRange(new object[] {
            resources.GetString("cmAction.Items"),
            resources.GetString("cmAction.Items1"),
            resources.GetString("cmAction.Items2")});
            this.cmAction.Name = "cmAction";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // cmDepartament
            // 
            resources.ApplyResources(this.cmDepartament, "cmDepartament");
            this.cmDepartament.FormattingEnabled = true;
            this.cmDepartament.Name = "cmDepartament";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // cmName
            // 
            resources.ApplyResources(this.cmName, "cmName");
            this.cmName.FormattingEnabled = true;
            this.cmName.Name = "cmName";
            // 
            // chAllTime
            // 
            resources.ApplyResources(this.chAllTime, "chAllTime");
            this.chAllTime.Name = "chAllTime";
            this.chAllTime.UseVisualStyleBackColor = true;
            // 
            // chbRemainder
            // 
            resources.ApplyResources(this.chbRemainder, "chbRemainder");
            this.chbRemainder.Name = "chbRemainder";
            this.chbRemainder.UseVisualStyleBackColor = true;
            // 
            // dtDateRemainder
            // 
            resources.ApplyResources(this.dtDateRemainder, "dtDateRemainder");
            this.dtDateRemainder.Name = "dtDateRemainder";
            // 
            // chActivity
            // 
            resources.ApplyResources(this.chActivity, "chActivity");
            this.chActivity.Name = "chActivity";
            this.chActivity.UseVisualStyleBackColor = true;
            // 
            // chMainReport
            // 
            resources.ApplyResources(this.chMainReport, "chMainReport");
            this.chMainReport.Name = "chMainReport";
            this.chMainReport.UseVisualStyleBackColor = true;
            // 
            // btnCreateRep
            // 
            resources.ApplyResources(this.btnCreateRep, "btnCreateRep");
            this.btnCreateRep.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCreateRep.FlatAppearance.BorderSize = 0;
            this.btnCreateRep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateRep.Name = "btnCreateRep";
            this.btnCreateRep.UseVisualStyleBackColor = false;
            // 
            // btnToPrint
            // 
            resources.ApplyResources(this.btnToPrint, "btnToPrint");
            this.btnToPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnToPrint.FlatAppearance.BorderSize = 0;
            this.btnToPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnToPrint.Name = "btnToPrint";
            this.btnToPrint.UseVisualStyleBackColor = false;
            // 
            // btnToExcel
            // 
            resources.ApplyResources(this.btnToExcel, "btnToExcel");
            this.btnToExcel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnToExcel.FlatAppearance.BorderSize = 0;
            this.btnToExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.UseVisualStyleBackColor = false;
            // 
            // ControlCreaterReport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.chMainReport);
            this.Controls.Add(this.chActivity);
            this.Controls.Add(this.btnCreateRep);
            this.Controls.Add(this.dtDateRemainder);
            this.Controls.Add(this.chbRemainder);
            this.Controls.Add(this.chAllTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmDepartament);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmAction);
            this.Controls.Add(this.labTo);
            this.Controls.Add(this.labFrom);
            this.Controls.Add(this.DgvReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.dtFromDate);
            this.Name = "ControlCreaterReport";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnToPrint;
        private System.Windows.Forms.Button btnToExcel;
        private System.Windows.Forms.DataGridView DgvReport;
        private System.Windows.Forms.Button btnCreateRep;
        private System.Windows.Forms.Label labFrom;
        private System.Windows.Forms.Label labTo;
        private System.Windows.Forms.ComboBox cmAction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmDepartament;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmName;
        private System.Windows.Forms.CheckBox chAllTime;
        private System.Windows.Forms.CheckBox chbRemainder;
        private System.Windows.Forms.DateTimePicker dtDateRemainder;
        private System.Windows.Forms.CheckBox chActivity;
        private System.Windows.Forms.CheckBox chMainReport;
    }
}
