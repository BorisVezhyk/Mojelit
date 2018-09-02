using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace AppLogin
{
    public interface ICtrlCreaterReport
    {
        event EventHandler BtnCreateReport;
        event EventHandler BtnImportToExcel;
        
        void CopyAlltoClipboard();
        void FillComboboxFio(List<string> list);
        void FillComboboxDep(List<string> list);

        DataGridView DataGrid { get; set; }
        DateTimePicker FromDate { get; set; }
        DateTimePicker ToDate { get; set; }
        DateTimePicker DtDateRemainder { get; }
        string Action { get; set; }
        string NameFio { get; set; }
        string Departament { get; set; }
        CheckBox AllTime { get; set; }
        bool ChRemainder { get; }
        bool ChMainReport { get; }
        bool ChActivity { get; }


    }

    public partial class ControlCreaterReport : UserControl,ICtrlCreaterReport
    {
        public ControlCreaterReport()
        {
            InitializeComponent();
            btnCreateRep.Click += BtnCreateRep_Click;
            btnToExcel.Click += BtnToExcel_Click;
            btnToPrint.Click += BtnToPrint_Click;
            chAllTime.CheckedChanged += ChAllTime_CheckedChanged;
            chbRemainder.CheckedChanged += ChbRemainder_CheckedChanged;
            chActivity.CheckedChanged += ChActivity_CheckedChanged;
            chMainReport.CheckedChanged += ChMainReport_CheckedChanged;
            chMainReport.Checked = true;
        }

        //Event CheckedChanged set enable (true/false) Comboboxes and DatetimePikers
        private void ChMainReport_CheckedChanged(object sender, EventArgs e)
        {
            if (chMainReport.Checked)
            {
                chbRemainder.Checked = false;
                chActivity.Checked = false;
                cmName.Enabled = false;
                cmAction.Enabled = false;
            }

        }
        //Event CheckedChanged set enable (true/false) Comboboxes and DatetimePikers
        private void ChActivity_CheckedChanged(object sender, EventArgs e)
        {
            if (chActivity.Checked)
            {
                chbRemainder.Checked = false;
                chMainReport.Checked = false;
                cmName.Enabled = true;
                cmAction.Enabled = true;
            }
        }

        //Event CheckedChanged set enable (true/false) Comboboxes and DatetimePikers
        private void ChbRemainder_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRemainder.Checked)
            {
                dtDateRemainder.Enabled = true;
                chAllTime.Checked = false;
                chActivity.Checked = false;
                chMainReport.Checked = false;
                dtFromDate.Enabled = false;
                dtToDate.Enabled = false;
                cmAction.Enabled = false;
                cmName.Enabled = false;

            }
            else
            {
                dtDateRemainder.Enabled = false;
                cmName.Enabled = true;
                cmAction.Enabled = true;
                dtToDate.Enabled = true;
                dtFromDate.Enabled = true;
            }
            
        }

        //Event CheckedChanged set enable(true/false) DateTimePickers
        private void ChAllTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chAllTime.Checked)
            {
                chbRemainder.Checked = false;
                dtFromDate.Enabled = false;
                dtToDate.Enabled = false;

            }
            else
            {
                dtFromDate.Enabled = true;
                dtToDate.Enabled = true;
            }
            
        }

        private void BtnToPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            
            if (ChRemainder || DataGrid.ColumnCount==5)
            {
                printer.Title = "Отчет по остаткам";
                printer.SubTitle = $"На дату {dtDateRemainder.Value.ToString("d")}";

            }
            else
            {
                if (chAllTime.Checked)
                {
                    printer.Title = "Отчет о движении деталей";
                    printer.SubTitle = $"За все время";
                }
                else
                {
                    printer.Title = "Отчет о движении деталей";
                    printer.SubTitle = $"За период с {dtFromDate.Value.ToString("d")} до {dtToDate.Value.ToString("d")} ";
                }
            }
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = false;
            printer.PageSettings.Landscape = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            try
            {

                printer.PrintPreviewDataGridView(DgvReport);
            }
            catch (Exception)
            {
                
            }
        }

        private void BtnToExcel_Click(object sender, EventArgs e)
        {
            BtnImportToExcel?.Invoke(this, EventArgs.Empty);
        }

        private void BtnCreateRep_Click(object sender, EventArgs e)
        {
            BtnCreateReport?.Invoke(this, EventArgs.Empty);
        }

        //Select all cell for import to excel
        public void CopyAlltoClipboard()
        {
            DgvReport.SelectAll();
            DataObject dataObj = DgvReport.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        //Method fill Combobox Fio
        public void FillComboboxFio(List<string> list)
        {
            cmName.DataSource = list;
        }
        //Method fill Combobox Departament
        public void FillComboboxDep(List<string> list)
        {
            cmDepartament.DataSource = list;
        }

        public DataGridView DataGrid { get => DgvReport; set => DgvReport=value; }
        public DateTimePicker FromDate { get => dtFromDate; set => dtFromDate=value; }
        public DateTimePicker ToDate { get => dtToDate; set => dtToDate=value; }
        

        public DateTimePicker DtDateRemainder => dtDateRemainder;
        public string Action { get => cmAction.Text; set => cmAction.Text = value; }
        public string NameFio { get => cmName.Text; set => cmName.Text = value; }
        public string Departament { get => cmDepartament.Text; set => cmDepartament.Text = value; }
        public CheckBox AllTime { get => chAllTime; set => chAllTime = value; }
        public bool ChRemainder => chbRemainder.Checked;
        public event EventHandler BtnImportToExcel;
        public event EventHandler BtnCreateReport;
        public bool ChMainReport => chMainReport.Checked;
        public bool ChActivity => chActivity.Checked;

      
    }
}
