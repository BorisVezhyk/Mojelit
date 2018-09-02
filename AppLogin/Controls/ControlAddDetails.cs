using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppLogin
{
    public interface ICtrlAddDetails
    {
        string SortDet { get; set; }
        string TypeDet { get; set; }
        string ModelDet { get; set; }
        string Quatity { get; set; } 
        string Notice { get; set; }
        void FillDgvDataDetails(string clm0, string clm1, string clm2, string clm3, string clm4);

        DataGridView DataGrid { get; set; }

        event EventHandler BtnAddDetailOnDgv;
        event EventHandler BtnClearAllTxt;
        event EventHandler BtnClearAllRows;
        event EventHandler BtnSaveRowsInData;
        event EventHandler BtnDeleteSelectRow;

        void FillModelStringCollection(List<string> list);
        void FillTypeStringCollection(List<string> list);
        void FillViewStringCollection(List<string> list);
        void FillCmSort(List<string> list);
        void FillCmType(List<string> list);
    }

    public partial class ControlAddDetails : UserControl,ICtrlAddDetails
    {
        public ControlAddDetails()
        {
            InitializeComponent();
            btnAddDetOnDgv.Click += BtnAddDetOnDgv_Click;
            btnClearAllRows.Click += BtnClearAllRows_Click;
            btnClearTxt.Click += BtnClearTxt_Click;
            btnDeleteSelectRow.Click += BtnDeleteSelectRow_Click;
            btnSaveDetOnDB.Click += BtnSaveDetOnDB_Click;
        }

#region Events
        private void BtnSaveDetOnDB_Click(object sender, EventArgs e)
        {
            if (BtnSaveRowsInData != null)
                BtnSaveRowsInData(this, EventArgs.Empty);
        }

        private void BtnDeleteSelectRow_Click(object sender, EventArgs e)
        {
            if (BtnDeleteSelectRow != null)
                BtnDeleteSelectRow(this, EventArgs.Empty);
        }

        private void BtnClearTxt_Click(object sender, EventArgs e)
        {
            if (BtnClearAllTxt != null)
                BtnClearAllTxt(this, EventArgs.Empty);

        }

        private void BtnClearAllRows_Click(object sender, EventArgs e)
        {
            if (BtnClearAllRows != null)
                BtnClearAllRows(this, EventArgs.Empty);
        }

        private void BtnAddDetOnDgv_Click(object sender, EventArgs e)
        {
            if (BtnAddDetailOnDgv != null)
                BtnAddDetailOnDgv(this, EventArgs.Empty);
        }
#endregion
        public event EventHandler BtnAddDetailOnDgv;
        public event EventHandler BtnClearAllTxt;
        public event EventHandler BtnClearAllRows;
        public event EventHandler BtnSaveRowsInData;
        public event EventHandler BtnDeleteSelectRow;
        

        public string SortDet { get => cmbSort.Text; set=> cmbSort.Text = value; }
        public string TypeDet { get => cmbType.Text; set => cmbType.Text=value; }
        public string ModelDet { get => txtModel.Text; set => txtModel.Text=value; }
        public string Quatity { get => txtQuantity.Text; set => txtQuantity.Text=value; }
        public string Notice { get => txtNotice.Text; set => txtNotice.Text=value; }
        public DataGridView DataGrid { get=> dataGridAddDetails; set=> dataGridAddDetails = value; }

        public void FillDgvDataDetails(string clm0, string clm1, string clm2, string clm3, string clm4)
        {
            dataGridAddDetails?.Rows.Add(clm0, clm1, clm2, clm3, clm4);

            /*
            int i = dataGridAddDetails.Rows.Add();
            dataGridAddDetails[0, i].Value = clm0;
            dataGridAddDetails[1, i].Value = clm1;
            dataGridAddDetails[2, i].Value = clm2;
            dataGridAddDetails[3, i].Value = clm3;
            dataGridAddDetails[4, i].Value = clm4;
            */
        }

        private AutoCompleteStringCollection ModelStringCollection {
            set => txtModel.AutoCompleteCustomSource = value; }
        private AutoCompleteStringCollection TypeStringCollection {
            set => cmbType.AutoCompleteCustomSource = value; }
        private AutoCompleteStringCollection ViewStringCollection {
            set => cmbSort.AutoCompleteCustomSource = value; }
        
        //fill auto complete string
        public void FillModelStringCollection(List<string> list)
        {
            AutoCompleteStringCollection colModel = new AutoCompleteStringCollection();
            colModel.AddRange(list.ToArray());
            ModelStringCollection = colModel;
        }
        //fill auto complete string
        public void FillTypeStringCollection(List<string> list)
        {
            var colType = new AutoCompleteStringCollection();
            colType.AddRange(list.ToArray());
            TypeStringCollection = colType;
        }
        //fill auto complete string
        public void FillViewStringCollection(List<string> list)
        {
            var colView = new AutoCompleteStringCollection();
            colView.AddRange(list.ToArray());
            ViewStringCollection = colView;
        }
        //Fill combobox_Sort data
        public void FillCmSort(List<string> list)
        {
            cmbSort.DataSource = list;
        }
        //Fill combobox_Type data
        public  void FillCmType(List<string> list)
        {
            cmbType.DataSource = list;
        }

        //Placeholder 
        private void TxtQuantity_Enter(object sender, EventArgs e)
        {
            if (txtQuantity.Text ==@"x>0")
            {
                txtQuantity.Text = "";
                txtQuantity.ForeColor = Color.Black;
            }
        }
        private void TxtQuantity_Leave(object sender, EventArgs e)
        {
            if(txtQuantity.Text=="")
            {
                txtQuantity.Text = $@"x>0";
                txtQuantity.ForeColor = Color.Silver;
            }
        }

    }
}
