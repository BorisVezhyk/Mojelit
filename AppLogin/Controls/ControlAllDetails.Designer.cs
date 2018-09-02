namespace AppLogin
{
    partial class ControlAllDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlAllDetails));
            this.DgvListAllDetails = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnToPrint = new System.Windows.Forms.Button();
            this.btnToExcel = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmSort = new System.Windows.Forms.ComboBox();
            this.cmType = new System.Windows.Forms.ComboBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.cmDep = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListAllDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListAllDetails
            // 
            this.DgvListAllDetails.AllowUserToAddRows = false;
            this.DgvListAllDetails.AllowUserToDeleteRows = false;
            this.DgvListAllDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListAllDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListAllDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvListAllDetails.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.DgvListAllDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListAllDetails.Location = new System.Drawing.Point(0, 64);
            this.DgvListAllDetails.Name = "DgvListAllDetails";
            this.DgvListAllDetails.ReadOnly = true;
            this.DgvListAllDetails.Size = new System.Drawing.Size(1048, 383);
            this.DgvListAllDetails.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnToPrint);
            this.panel1.Controls.Add(this.btnToExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 50);
            this.panel1.TabIndex = 3;
            // 
            // btnToPrint
            // 
            this.btnToPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnToPrint.FlatAppearance.BorderSize = 0;
            this.btnToPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToPrint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnToPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnToPrint.Image")));
            this.btnToPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToPrint.Location = new System.Drawing.Point(677, 3);
            this.btnToPrint.Name = "btnToPrint";
            this.btnToPrint.Size = new System.Drawing.Size(172, 44);
            this.btnToPrint.TabIndex = 8;
            this.btnToPrint.Text = "   Распечатать";
            this.btnToPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToPrint.UseVisualStyleBackColor = false;
            // 
            // btnToExcel
            // 
            this.btnToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToExcel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnToExcel.FlatAppearance.BorderSize = 0;
            this.btnToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToExcel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnToExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnToExcel.Image")));
            this.btnToExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToExcel.Location = new System.Drawing.Point(866, 3);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(179, 44);
            this.btnToExcel.TabIndex = 7;
            this.btnToExcel.Text = "Экспорт в Excel";
            this.btnToExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToExcel.UseVisualStyleBackColor = false;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtModel.Location = new System.Drawing.Point(721, 32);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(145, 26);
            this.txtModel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(264, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "по Виду";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(503, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "по Типу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(717, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "по Модели";
            // 
            // cmSort
            // 
            this.cmSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmSort.FormattingEnabled = true;
            this.cmSort.Location = new System.Drawing.Point(268, 30);
            this.cmSort.Name = "cmSort";
            this.cmSort.Size = new System.Drawing.Size(182, 28);
            this.cmSort.TabIndex = 10;
            // 
            // cmType
            // 
            this.cmType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmType.FormattingEnabled = true;
            this.cmType.Location = new System.Drawing.Point(507, 30);
            this.cmType.Name = "cmType";
            this.cmType.Size = new System.Drawing.Size(157, 28);
            this.cmType.TabIndex = 11;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetFilter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnResetFilter.FlatAppearance.BorderSize = 0;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResetFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnResetFilter.Image")));
            this.btnResetFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetFilter.Location = new System.Drawing.Point(873, 14);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(172, 44);
            this.btnResetFilter.TabIndex = 9;
            this.btnResetFilter.Text = " Сбросить поиск";
            this.btnResetFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetFilter.UseVisualStyleBackColor = false;
            // 
            // cmDep
            // 
            this.cmDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmDep.FormattingEnabled = true;
            this.cmDep.Location = new System.Drawing.Point(54, 30);
            this.cmDep.Name = "cmDep";
            this.cmDep.Size = new System.Drawing.Size(157, 28);
            this.cmDep.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Поиск по Участок";
            // 
            // ControlAllDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.cmDep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnResetFilter);
            this.Controls.Add(this.cmType);
            this.Controls.Add(this.cmSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvListAllDetails);
            this.Name = "ControlAllDetails";
            this.Size = new System.Drawing.Size(1048, 500);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListAllDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DgvListAllDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnToPrint;
        private System.Windows.Forms.Button btnToExcel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmSort;
        private System.Windows.Forms.ComboBox cmType;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.ComboBox cmDep;
        private System.Windows.Forms.Label label4;
    }
}
