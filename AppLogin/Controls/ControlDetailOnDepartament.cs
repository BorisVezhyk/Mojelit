using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AppLogin
{
    public interface ICtrlDetailDepartament
    {
        event EventHandler BtnTakeAwayDetails;
        event EventHandler BtnRowsClear;
        event EventHandler BtnResetFilter;
        event EventHandler CmSortSelectedIndex;
        event EventHandler CmTypeSelectedIndex;
        event EventHandler TxtModelChanged;
        event EventHandler CmSortTextChanged;
        event EventHandler CmTypeTextChanged;
        event EventHandler BtnTransfer;

        void FillComboboxSort(List<string> list);
        void FillComboboxType(List<string> list);
        void FillDataGrid(DataView dv);
        void ClearRowsGridView();
        void ClearRowsGridSelected();
        string Sort { get; set; }
        string Type { get; set; }
        string Model { get; set; }

        DataGridView GridView { get; }
        DataGridView GridSelected { get; }

    }

    public partial class ControlDetailOnDepartament : UserControl, ICtrlDetailDepartament
    {
        public event EventHandler BtnTakeAwayDetails;
        public event EventHandler BtnRowsClear;
        public event EventHandler BtnResetFilter;
        public event EventHandler CmSortSelectedIndex;
        public event EventHandler CmTypeSelectedIndex;
        public event EventHandler TxtModelChanged;
        public event EventHandler CmSortTextChanged;
        public event EventHandler CmTypeTextChanged;
        public event EventHandler BtnTransfer;

        public string Sort { get => cmSort.Text; set => cmSort.Text = value; }
        public string Type { get => cmType.Text; set => cmType.Text = value; }
        public string Model { get => txtModel.Text; set => txtModel.Text = value; }
        

        public DataGridView GridView { get => DgvListDepDetails;}
        public DataGridView GridSelected { get => DgvSelectedDetails;}

        public ControlDetailOnDepartament()
        {
            InitializeComponent();
            btnTakeDetails.Click += BtnTakeDetails_Click;
            btnRowsClear.Click += BtnRowsClear_Click;
            btnSelectRow.Click += BtnSelectDelRow_Click;
            cmSort.SelectedIndexChanged += CmSort_SelectedIndexChanged;
            cmType.SelectedIndexChanged += CmType_SelectedIndexChanged;
            txtModel.TextChanged += TxtModel_TextChanged;
            btnResetFilter.Click += BtnResetFilter_Click;
            DgvListDepDetails.CellClick += DgvListDepDetails_CellClick;
            cmSort.TextChanged += CmSort_TextChanged;
            cmType.TextChanged += CmType_TextChanged;
            btnTransfer.Click += BtnTransfer_Click;
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            BtnTransfer?.Invoke(this,EventArgs.Empty);
        }

        public void FillComboboxSort(List<string> list)
        {
            cmSort.DataSource = list;
        }

        public void FillComboboxType(List<string>list)
        {
            cmType.DataSource = list;
        }

        public void ClearRowsGridView()
        {
            GridView.Rows.Clear();
        }

        public  void ClearRowsGridSelected()
        {
            GridSelected.Rows.Clear();
        }

        //fill DataGrid
        public void FillDataGrid(DataView dv)
        {
            foreach (DataRowView row in dv)
            {
                int index = GridView.Rows.Add();
                for (int i = 0; i < row.Row.ItemArray.Length; i++)
                {
                    GridView.Rows[index].Cells[i].Value = row.Row.ItemArray[i].ToString();
                }
            }
        }

        //Button transfers selected row another DataGridView
        private void DgvListDepDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //check, where did user click column
            if(e.ColumnIndex==8)
            {
                int quantity = 1;
                
                //check row is empty
                if(DgvSelectedDetails.Rows.Count>0)
                {
                    //check rows on repeat in Datagridview_Selected
                    for (int i = 0; i < DgvSelectedDetails.Rows.Count; i++)
                    {
                        if (DgvListDepDetails.Rows[e.RowIndex].Cells[0].Value.ToString() == DgvSelectedDetails.Rows[i].Cells[0].Value.ToString())
                        {
                            //if there is row in Selected_datagridview then set quantity
                            quantity += Convert.ToInt32(DgvSelectedDetails.Rows[i].Cells[8].Value.ToString());
                            //set quantity details in last column
                            DgvSelectedDetails.Rows[i].Cells[8].Value = quantity.ToString();
                            return;
                        }
                    }
                }

                //set new row in datagridview Select
                int index = DgvSelectedDetails.Rows.Add();
                //copy data in new row 
                for (int i = 0; i < DgvListDepDetails.Rows[e.RowIndex].Cells.Count-1; i++)
                {
                    DgvSelectedDetails.Rows[index].Cells[i].Value = DgvListDepDetails.Rows[e.RowIndex].Cells[i].Value.ToString();
                }
                //set quantity details in last column
                DgvSelectedDetails.Rows[index].Cells[8].Value = quantity.ToString();
            }
                
        }

        //button remove at selected row in datagridview_Selected
        private void BtnSelectDelRow_Click(object sender, EventArgs e)
        {
            if (GridSelected.Rows.Count == 0)
                return;
            int index = GridSelected.SelectedCells[0].RowIndex;
            GridSelected.Rows.RemoveAt(index);
        }

        #region Event handlers
        //Button ResetFilter click
        private void BtnResetFilter_Click(object sender, EventArgs e)
        {
            BtnResetFilter?.Invoke(this, EventArgs.Empty);
        }
        //Event TextBoxModel TextChanged
        private void TxtModel_TextChanged(object sender, EventArgs e)
        {
            TxtModelChanged?.Invoke(this, EventArgs.Empty);
        }
        //Event ComboBoxType selectedIndexChanged
        private void CmType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmTypeSelectedIndex?.Invoke(this, EventArgs.Empty);
        }
        //Event ComboBoxSort selectedIndexChanged
        private void CmSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmSortSelectedIndex?.Invoke(this, EventArgs.Empty);
        }
        
        //button print_click
        private void BtnRowsClear_Click(object sender, EventArgs e)
        {
            BtnRowsClear?.Invoke(this, EventArgs.Empty);
        }
        //button takesdetails_click
        private void BtnTakeDetails_Click(object sender, EventArgs e)
        {
            BtnTakeAwayDetails?.Invoke(this, EventArgs.Empty);
        }
        //event cm Type Text Changed
        private void CmType_TextChanged(object sender, EventArgs e)
        {
            CmTypeTextChanged?.Invoke(this, EventArgs.Empty);
        }
        //event cm Sort TextChanged
        private void CmSort_TextChanged(object sender, EventArgs e)
        {
            CmSortTextChanged?.Invoke(this, EventArgs.Empty);
        }
        #endregion
    }
}
