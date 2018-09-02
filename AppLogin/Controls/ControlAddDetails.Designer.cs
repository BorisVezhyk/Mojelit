using System.Windows.Forms;
using System.Drawing;

namespace AppLogin
{
    public partial class ControlAddDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlAddDetails));
            this.btnClearAllRows = new System.Windows.Forms.Button();
            this.btnSaveDetOnDB = new System.Windows.Forms.Button();
            this.btnDeleteSelectRow = new System.Windows.Forms.Button();
            this.btnAddDetOnDgv = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnClearTxt = new System.Windows.Forms.Button();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.dataGridAddDetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearAllRows
            // 
            this.btnClearAllRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAllRows.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClearAllRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAllRows.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllRows.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearAllRows.Image = ((System.Drawing.Image)(resources.GetObject("btnClearAllRows.Image")));
            this.btnClearAllRows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearAllRows.Location = new System.Drawing.Point(227, 462);
            this.btnClearAllRows.Name = "btnClearAllRows";
            this.btnClearAllRows.Size = new System.Drawing.Size(256, 44);
            this.btnClearAllRows.TabIndex = 34;
            this.btnClearAllRows.Text = "  Стереть все записи";
            this.btnClearAllRows.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearAllRows.UseVisualStyleBackColor = false;
            // 
            // btnSaveDetOnDB
            // 
            this.btnSaveDetOnDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDetOnDB.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSaveDetOnDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDetOnDB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDetOnDB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveDetOnDB.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveDetOnDB.Image")));
            this.btnSaveDetOnDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveDetOnDB.Location = new System.Drawing.Point(794, 462);
            this.btnSaveDetOnDB.Name = "btnSaveDetOnDB";
            this.btnSaveDetOnDB.Size = new System.Drawing.Size(256, 44);
            this.btnSaveDetOnDB.TabIndex = 33;
            this.btnSaveDetOnDB.Text = "Сохранить все детали в БД";
            this.btnSaveDetOnDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveDetOnDB.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSelectRow
            // 
            this.btnDeleteSelectRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSelectRow.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteSelectRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectRow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectRow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteSelectRow.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSelectRow.Image")));
            this.btnDeleteSelectRow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteSelectRow.Location = new System.Drawing.Point(489, 462);
            this.btnDeleteSelectRow.Name = "btnDeleteSelectRow";
            this.btnDeleteSelectRow.Size = new System.Drawing.Size(256, 44);
            this.btnDeleteSelectRow.TabIndex = 7;
            this.btnDeleteSelectRow.Text = "Удалить выбранную строку";
            this.btnDeleteSelectRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteSelectRow.UseVisualStyleBackColor = false;
            // 
            // btnAddDetOnDgv
            // 
            this.btnAddDetOnDgv.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddDetOnDgv.FlatAppearance.BorderSize = 3;
            this.btnAddDetOnDgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDetOnDgv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDetOnDgv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDetOnDgv.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDetOnDgv.Image")));
            this.btnAddDetOnDgv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDetOnDgv.Location = new System.Drawing.Point(875, 110);
            this.btnAddDetOnDgv.Name = "btnAddDetOnDgv";
            this.btnAddDetOnDgv.Size = new System.Drawing.Size(164, 44);
            this.btnAddDetOnDgv.TabIndex = 31;
            this.btnAddDetOnDgv.Text = "   Добавить";
            this.btnAddDetOnDgv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddDetOnDgv.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Добавить новые детали";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Примечание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Количество*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Модель*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Тип*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Вид*";
            // 
            // txtNotice
            // 
            this.txtNotice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNotice.Location = new System.Drawing.Point(575, 78);
            this.txtNotice.MaxLength = 50;
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.Size = new System.Drawing.Size(294, 26);
            this.txtNotice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtQuantity.Location = new System.Drawing.Point(575, 41);
            this.txtQuantity.MaxLength = 20;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(294, 26);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.Text = "x>0";
            this.txtQuantity.Enter += new System.EventHandler(this.TxtQuantity_Enter);
            this.txtQuantity.Leave += new System.EventHandler(this.TxtQuantity_Leave);
            // 
            // btnClearTxt
            // 
            this.btnClearTxt.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClearTxt.FlatAppearance.BorderSize = 3;
            this.btnClearTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearTxt.Image = ((System.Drawing.Image)(resources.GetObject("btnClearTxt.Image")));
            this.btnClearTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearTxt.Location = new System.Drawing.Point(704, 110);
            this.btnClearTxt.Name = "btnClearTxt";
            this.btnClearTxt.Size = new System.Drawing.Size(164, 44);
            this.btnClearTxt.TabIndex = 35;
            this.btnClearTxt.Text = "Очистить поля";
            this.btnClearTxt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearTxt.UseVisualStyleBackColor = true;
            // 
            // cmbSort
            // 
            this.cmbSort.AutoCompleteCustomSource.AddRange(new string[] {
            "123"});
            this.cmbSort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbSort.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Подшипник",
            "Электродвигатель"});
            this.cmbSort.Location = new System.Drawing.Point(137, 41);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(222, 28);
            this.cmbSort.TabIndex = 1;
            // 
            // cmbType
            // 
            this.cmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Роликовый радиальный",
            "Шариковый радиальный",
            "Электродвигатель"});
            this.cmbType.Location = new System.Drawing.Point(137, 75);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(222, 28);
            this.cmbType.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtModel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtModel.Location = new System.Drawing.Point(137, 109);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(222, 26);
            this.txtModel.TabIndex = 3;
            // 
            // dataGridAddDetails
            // 
            this.dataGridAddDetails.AllowUserToAddRows = false;
            this.dataGridAddDetails.AllowUserToDeleteRows = false;
            this.dataGridAddDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAddDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridAddDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAddDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridAddDetails.Location = new System.Drawing.Point(0, 160);
            this.dataGridAddDetails.Name = "dataGridAddDetails";
            this.dataGridAddDetails.ReadOnly = true;
            this.dataGridAddDetails.Size = new System.Drawing.Size(1057, 296);
            this.dataGridAddDetails.TabIndex = 36;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Вид";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Тип";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Модель";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Количество";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Примечание";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // ControlAddDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridAddDetails);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.btnClearTxt);
            this.Controls.Add(this.btnClearAllRows);
            this.Controls.Add(this.btnSaveDetOnDB);
            this.Controls.Add(this.btnDeleteSelectRow);
            this.Controls.Add(this.btnAddDetOnDgv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNotice);
            this.Controls.Add(this.txtQuantity);
            this.Name = "ControlAddDetails";
            this.Size = new System.Drawing.Size(1057, 509);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearAllRows;
        private System.Windows.Forms.Button btnSaveDetOnDB;
        private System.Windows.Forms.Button btnDeleteSelectRow;
        private System.Windows.Forms.Button btnAddDetOnDgv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnClearTxt;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.ComboBox cmbType;
        public System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.DataGridView dataGridAddDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
