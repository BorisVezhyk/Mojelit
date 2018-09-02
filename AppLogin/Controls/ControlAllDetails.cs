using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace AppLogin
{
    public interface ICtrlAllDetails
    {
        event EventHandler BtnImportToExcel;
        event EventHandler BtnResetFilter;
        event EventHandler CmSortSelectedIndex;
        event EventHandler CmTypeSelectedIndex;
        event EventHandler TxtModelChanged;
        event EventHandler CmSortTextChanged;
        event EventHandler CmTypeTextChanged;
        event EventHandler CmDepTextChanged;
        event EventHandler CmDepSelectedIndex;

        string Sort { get; set; }
        string Type { get; set; }
        string Model { get; set; }
        string Departament { get; set; }

        void CopyAlltoClipboard();
        void FillComboboxType(List<string> list);
        void FillComboboxSort(List<string> list);
        void FillComboboxDep(List<string> list);

        void FillDataGridView(DataView dv);

    }

    public partial class ControlAllDetails : UserControl,ICtrlAllDetails
    {
        public event EventHandler BtnImportToExcel;
        public event EventHandler BtnResetFilter;
        public event EventHandler CmSortSelectedIndex;
        public event EventHandler CmTypeSelectedIndex;
        public event EventHandler TxtModelChanged;
        public event EventHandler CmSortTextChanged;
        public event EventHandler CmTypeTextChanged;
        public event EventHandler CmDepTextChanged;
        public event EventHandler CmDepSelectedIndex;


        public string Sort { get => cmSort.Text;set=>cmSort.Text=value; }
        public string Type { get => cmType.Text; set => cmType.Text=value; }
        public string Model { get => txtModel.Text; set => txtModel.Text=value; }
        public string Departament
        {
            get => cmDep.Text;
            set => cmDep.Text = value;
        }
        
        public ControlAllDetails()
        {
            InitializeComponent();
            btnToExcel.Click += BtnToExcel_Click;
            btnToPrint.Click += BtnToPrint_Click;
            btnResetFilter.Click += BtnResetFilter_Click;
            cmSort.SelectedIndexChanged += CmSort_SelectedIndexChanged;
            cmType.SelectedIndexChanged += CmType_SelectedIndexChanged;
            txtModel.TextChanged += TxtModel_TextChanged;
            cmType.TextChanged += CmType_TextChanged;
            cmSort.TextChanged += CmSort_TextChanged;
            cmDep.TextChanged += CmDep_TextChanged;
            cmDep.SelectedIndexChanged += CmDep_SelectedIndexChanged;

        }



        //Select all cell for import to excel
        public void CopyAlltoClipboard()
        {
            DgvListAllDetails.SelectAll();
            DataObject dataObj = DgvListAllDetails.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        //method fills combobox Type
        public void FillComboboxType(List<string> list)
        {
            cmType.DataSource = list;
        }
        //method fills combobox Sort
        public void FillComboboxSort(List<string> list)
        {
            cmSort.DataSource = list;
        }
        //method fills datagridview
        public void FillDataGridView(DataView dv)
        {
            DgvListAllDetails.DataSource = dv;
        }
        //method fills combobox Departaments
        public void FillComboboxDep(List<string> list)
        {
            cmDep.DataSource = list;
        }
        //Print
        private void BtnToPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Список деталей";
            printer.SubTitle = "со всех участков";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = false;
            printer.PageSettings.Landscape = true;

            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Можелит";
            printer.FooterSpacing = 15;
            try
            {

                printer.PrintPreviewDataGridView(DgvListAllDetails);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
        #region Events
        private void TxtModel_TextChanged(object sender, EventArgs e)
        {
            TxtModelChanged?.Invoke(this, EventArgs.Empty);

        }
        private void CmType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmTypeSelectedIndex?.Invoke(this, EventArgs.Empty);

        }
        private void CmSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmSortSelectedIndex?.Invoke(this, EventArgs.Empty);

        }

        private void CmSort_TextChanged(object sender, EventArgs e)
        {
            CmSortTextChanged?.Invoke(this, EventArgs.Empty);
        }

        private void CmType_TextChanged(object sender, EventArgs e)
        {
            CmTypeTextChanged?.Invoke(this, EventArgs.Empty);
        }

        private void BtnResetFilter_Click(object sender, EventArgs e)
        {
            BtnResetFilter?.Invoke(this, EventArgs.Empty);
        }

        private void CmDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmDepSelectedIndex?.Invoke(this, EventArgs.Empty);
        }

        private void CmDep_TextChanged(object sender, EventArgs e)
        {
            CmDepTextChanged?.Invoke(this, EventArgs.Empty);
        }

        private void BtnToExcel_Click(object sender, EventArgs e)
        {
            BtnImportToExcel?.Invoke(this, EventArgs.Empty);

        }
#endregion       
    }
}
