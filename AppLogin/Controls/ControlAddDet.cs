using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppLogin
{
    public interface ICtrlAddDet
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




    public partial class ControlAddDet : UserControl,ICtrlAddDet
    {
        public ControlAddDet()
        {
            InitializeComponent();
            btnAddDetOnDgv.Click += BtnAddDetOnDgv_Click;
            btnClearAllRows.Click += BtnClearAllRows_Click;
            btnClearTxt.Click += BtnClearTxt_Click;
            btnDeleteSelectRow.Click += BtnDeleteSelectRow_Click;
            btnSaveDetOnDB.Click += BtnSaveDetOnDB_Click;
            txtQuantity.Enter += TxtQuantity_Enter1;
            txtQuantity.Leave += TxtQuantity_Leave1;
        }


        //Placeholder
        private void TxtQuantity_Leave1(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                txtQuantity.Text = @"x>0";
                txtQuantity.ForeColor = Color.Silver;
            }
        }


        private void TxtQuantity_Enter1(object sender, EventArgs e)
        {
            if (txtQuantity.Text == @"x>0")
            {
                txtQuantity.Text = "";
                txtQuantity.ForeColor = Color.Black;
            }
        }

        #region Events
        private void BtnSaveDetOnDB_Click(object sender, EventArgs e)
        {
            BtnSaveRowsInData?.Invoke(this, EventArgs.Empty);
        }

        private void BtnDeleteSelectRow_Click(object sender, EventArgs e)
        {
            BtnDeleteSelectRow?.Invoke(this, EventArgs.Empty);
        }

        private void BtnClearTxt_Click(object sender, EventArgs e)
        {
            BtnClearAllTxt?.Invoke(this, EventArgs.Empty);

        }

        private void BtnClearAllRows_Click(object sender, EventArgs e)
        {
            BtnClearAllRows?.Invoke(this, EventArgs.Empty);
        }

        private void BtnAddDetOnDgv_Click(object sender, EventArgs e)
        {
            BtnAddDetailOnDgv?.Invoke(this, EventArgs.Empty);
        }
        #endregion
        public event EventHandler BtnAddDetailOnDgv;
        public event EventHandler BtnClearAllTxt;
        public event EventHandler BtnClearAllRows;
        public event EventHandler BtnSaveRowsInData;
        public event EventHandler BtnDeleteSelectRow;


        public string SortDet { get => cmbSort.Text; set => cmbSort.Text = value; }
        public string TypeDet { get => cmbType.Text; set => cmbType.Text = value; }
        public string ModelDet { get => txtModel.Text; set => txtModel.Text = value; }
        public string Quatity { get => txtQuantity.Text; set => txtQuantity.Text = value; }
        public string Notice { get => txtNotice.Text; set => txtNotice.Text = value; }
        public DataGridView DataGrid { get => gridViewAddDet; set => gridViewAddDet = value; }

        public void FillDgvDataDetails(string clm0, string clm1, string clm2, string clm3, string clm4)
        {
            gridViewAddDet.Rows.Add(clm0, clm1, clm2, clm3, clm4);
        }

        private AutoCompleteStringCollection ModelStringCollection
        {
            set => txtModel.AutoCompleteCustomSource = value;
        }
        private AutoCompleteStringCollection TypeStringCollection
        {
            set => cmbType.AutoCompleteCustomSource = value;
        }
        private AutoCompleteStringCollection ViewStringCollection
        {
            set => cmbSort.AutoCompleteCustomSource = value;
        }

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
        public void FillCmType(List<string> list)
        {
            cmbType.DataSource = list;
        }

    }
}
