using System.Windows.Forms;
using System.Drawing;

namespace AppLogin
{
    public partial class ControlDetailOnDepartament
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlDetailOnDepartament));
            this.DgvListDepDetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTakeDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnTakeDetails = new System.Windows.Forms.Button();
            this.btnRowsClear = new System.Windows.Forms.Button();
            this.btnSelectRow = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.cmType = new System.Windows.Forms.ComboBox();
            this.cmSort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DgvSelectedDetails = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListDepDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSelectedDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListDepDetails
            // 
            this.DgvListDepDetails.AllowUserToAddRows = false;
            this.DgvListDepDetails.AllowUserToDeleteRows = false;
            this.DgvListDepDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListDepDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListDepDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvListDepDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvListDepDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListDepDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.btnTakeDetail});
            this.DgvListDepDetails.Location = new System.Drawing.Point(0, 53);
            this.DgvListDepDetails.Name = "DgvListDepDetails";
            this.DgvListDepDetails.ReadOnly = true;
            this.DgvListDepDetails.Size = new System.Drawing.Size(1048, 163);
            this.DgvListDepDetails.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Код детали";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 58;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 105.8371F;
            this.Column2.HeaderText = "Вид";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 105.8371F;
            this.Column3.HeaderText = "Тип";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 105.8371F;
            this.Column4.HeaderText = "Модель";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 105.8371F;
            this.Column5.HeaderText = "Количество";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.FillWeight = 105.8371F;
            this.Column6.HeaderText = "Участок";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.FillWeight = 105.8371F;
            this.Column7.HeaderText = "Последнее изменение";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.FillWeight = 105.8371F;
            this.Column8.HeaderText = "Примечание";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnTakeDetail
            // 
            this.btnTakeDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTakeDetail.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnTakeDetail.FillWeight = 70F;
            this.btnTakeDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeDetail.HeaderText = "Отобрать деталь";
            this.btnTakeDetail.Name = "btnTakeDetail";
            this.btnTakeDetail.ReadOnly = true;
            this.btnTakeDetail.Text = "Добавить";
            this.btnTakeDetail.UseColumnTextForButtonValue = true;
            this.btnTakeDetail.Width = 82;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTransfer);
            this.panel1.Controls.Add(this.btnTakeDetails);
            this.panel1.Controls.Add(this.btnRowsClear);
            this.panel1.Controls.Add(this.btnSelectRow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 50);
            this.panel1.TabIndex = 2;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransfer.BackColor = System.Drawing.Color.SandyBrown;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(79, 3);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(172, 44);
            this.btnTransfer.TabIndex = 10;
            this.btnTransfer.Text = "Передать в другой отдел";
            this.btnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransfer.UseVisualStyleBackColor = false;
            // 
            // btnTakeDetails
            // 
            this.btnTakeDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTakeDetails.BackColor = System.Drawing.Color.SandyBrown;
            this.btnTakeDetails.FlatAppearance.BorderSize = 0;
            this.btnTakeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTakeDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnTakeDetails.Image")));
            this.btnTakeDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakeDetails.Location = new System.Drawing.Point(873, 3);
            this.btnTakeDetails.Name = "btnTakeDetails";
            this.btnTakeDetails.Size = new System.Drawing.Size(172, 44);
            this.btnTakeDetails.TabIndex = 9;
            this.btnTakeDetails.Text = "Взять детали из фонда";
            this.btnTakeDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTakeDetails.UseVisualStyleBackColor = false;
            // 
            // btnRowsClear
            // 
            this.btnRowsClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRowsClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRowsClear.FlatAppearance.BorderSize = 0;
            this.btnRowsClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRowsClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRowsClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRowsClear.Image = ((System.Drawing.Image)(resources.GetObject("btnRowsClear.Image")));
            this.btnRowsClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRowsClear.Location = new System.Drawing.Point(365, 3);
            this.btnRowsClear.Name = "btnRowsClear";
            this.btnRowsClear.Size = new System.Drawing.Size(190, 44);
            this.btnRowsClear.TabIndex = 8;
            this.btnRowsClear.Text = "    Очистить все строки";
            this.btnRowsClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRowsClear.UseVisualStyleBackColor = false;
            // 
            // btnSelectRow
            // 
            this.btnSelectRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectRow.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectRow.FlatAppearance.BorderSize = 0;
            this.btnSelectRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectRow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectRow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectRow.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectRow.Image")));
            this.btnSelectRow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectRow.Location = new System.Drawing.Point(561, 3);
            this.btnSelectRow.Name = "btnSelectRow";
            this.btnSelectRow.Size = new System.Drawing.Size(190, 44);
            this.btnSelectRow.TabIndex = 7;
            this.btnSelectRow.Text = "Удалить выбранную строку";
            this.btnSelectRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectRow.UseVisualStyleBackColor = false;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnResetFilter.FlatAppearance.BorderSize = 0;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResetFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnResetFilter.Image")));
            this.btnResetFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetFilter.Location = new System.Drawing.Point(873, 3);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(172, 44);
            this.btnResetFilter.TabIndex = 15;
            this.btnResetFilter.Text = " Сбросить поиск";
            this.btnResetFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetFilter.UseVisualStyleBackColor = false;
            // 
            // cmType
            // 
            this.cmType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmType.FormattingEnabled = true;
            this.cmType.Location = new System.Drawing.Point(465, 19);
            this.cmType.Name = "cmType";
            this.cmType.Size = new System.Drawing.Size(157, 28);
            this.cmType.TabIndex = 18;
            // 
            // cmSort
            // 
            this.cmSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmSort.FormattingEnabled = true;
            this.cmSort.Location = new System.Drawing.Point(210, 19);
            this.cmSort.Name = "cmSort";
            this.cmSort.Size = new System.Drawing.Size(182, 28);
            this.cmSort.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(626, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "по Модели";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(396, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "по Типу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Поиск:   по Виду";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtModel.Location = new System.Drawing.Point(722, 20);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(127, 26);
            this.txtModel.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnResetFilter);
            this.panel3.Controls.Add(this.txtModel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cmType);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmSort);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1048, 51);
            this.panel3.TabIndex = 22;
            // 
            // DgvSelectedDetails
            // 
            this.DgvSelectedDetails.AllowUserToAddRows = false;
            this.DgvSelectedDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSelectedDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSelectedDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvSelectedDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvSelectedDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSelectedDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Column9});
            this.DgvSelectedDetails.Location = new System.Drawing.Point(0, 25);
            this.DgvSelectedDetails.MultiSelect = false;
            this.DgvSelectedDetails.Name = "DgvSelectedDetails";
            this.DgvSelectedDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSelectedDetails.Size = new System.Drawing.Size(1044, 201);
            this.DgvSelectedDetails.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Код детали";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 105.5838F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Вид";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 105.5838F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 105.5838F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Модель";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 105.5838F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 105.5838F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Участок";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 105.5838F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Последнее изменение";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 105.5838F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Примечание";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column9.FillWeight = 70F;
            this.Column9.HeaderText = "Задать кол-во";
            this.Column9.Name = "Column9";
            this.Column9.Width = 82;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Отобранные детали:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.DgvSelectedDetails);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1045, 236);
            this.panel2.TabIndex = 23;
            // 
            // ControlDetailOnDepartament
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DgvListDepDetails);
            this.Controls.Add(this.panel1);
            this.Name = "ControlDetailOnDepartament";
            this.Size = new System.Drawing.Size(1048, 500);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListDepDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSelectedDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        public System.Windows.Forms.DataGridView DgvListDepDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTakeDetails;
        private System.Windows.Forms.Button btnRowsClear;
        private System.Windows.Forms.Button btnSelectRow;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.ComboBox cmType;
        private System.Windows.Forms.ComboBox cmSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView DgvSelectedDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewButtonColumn btnTakeDetail;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn Column9;
        private Button btnTransfer;
    }
}
