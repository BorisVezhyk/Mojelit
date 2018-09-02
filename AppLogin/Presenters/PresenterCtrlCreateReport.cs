using System;
using System.Collections.Generic;
using Mojelit.BL;
using System.Data;
using System.Globalization;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

namespace AppLogin
{
    public class PresenterCtrlCreateReport
    {
        private readonly ICtrlCreaterReport _ctrlCreaterReport;
        private readonly IMessageService _message;
        private readonly IDbReport _bdReport;
        private readonly int userId;
        private readonly string userDep;

        public PresenterCtrlCreateReport(ICtrlCreaterReport createrReport, IMessageService mesSer, IDbReport bdrep, int id, string dep )
        {
            _ctrlCreaterReport = createrReport;
            _message = mesSer;
            _bdReport = bdrep;
            userDep = dep;
            userId = id;
            _ctrlCreaterReport.BtnCreateReport += CtrlCreaterReport_BtnCreateReport;
            _ctrlCreaterReport.BtnImportToExcel += CtrlCreaterReport_BtnImportToExcel;
            Load_Form();
        }

        //Button import to Excel
        private void CtrlCreaterReport_BtnImportToExcel(object sender, EventArgs e)
        {
            if (_ctrlCreaterReport.DataGrid.Rows.Count > 1)
            {
                _ctrlCreaterReport.CopyAlltoClipboard();
                Application xlexcel;
                Workbook xlWorkBook;
                Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Range cr = (Range)xlWorkSheet.Cells[1, 1];
                cr.Select();
                xlWorkSheet.PasteSpecial(cr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                //Delete blank column A(it's always empty)
                Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.Range["A1"].AutoFormat(XlRangeAutoFormat.xlRangeAutoFormatClassic2);

                xlWorkSheet.get_Range("A1").Select();
                //ImportExcel.ImportDgvToExcel();
            }
            else _message.ShowExclamation("У вас пустой отчет");

        }
        //Button Create Report
        private void CtrlCreaterReport_BtnCreateReport(object sender, EventArgs e)
        {
            DataTable dt;
            string fromDate;
            string toDate;
            if (!_ctrlCreaterReport.ChRemainder)
            {
                if (!_ctrlCreaterReport.AllTime.Checked)
                {
                    fromDate = _ctrlCreaterReport.FromDate.Value.ToString(CultureInfo.CurrentUICulture);
                    toDate = _ctrlCreaterReport.ToDate.Value.ToString(CultureInfo.CurrentUICulture);
                }
                else
                {
                    fromDate = "01-01-2018";
                    toDate = "01-12-2100";
                }

                //set string parameters for search
                string action = _ctrlCreaterReport.Action == "Все" ? "" : _ctrlCreaterReport.Action;
                string fio = _ctrlCreaterReport.NameFio == "Все" ? "" : _ctrlCreaterReport.NameFio;
                string departament = _ctrlCreaterReport.Departament == "Все" ? "" : _ctrlCreaterReport.Departament;

                if (_ctrlCreaterReport.ChMainReport)
                {
                    dt = _bdReport.LoadReportQuery(fromDate, toDate);

                    DataView dv = dt.DefaultView;

                    dv.RowFilter = $"Участок like '%{departament}%'";

                    _ctrlCreaterReport.DataGrid.DataSource = dv;
                    _ctrlCreaterReport.DataGrid.Columns["Остаток"].DisplayIndex = 8;
                }
                else
                {
                    dt = _bdReport.GetDataActivity(fromDate, toDate);

                    DataView dv = dt.DefaultView;

                    dv.RowFilter =
                        $"Фио like '%{fio}%' and Отдел like '%{departament}%' and Действие like '%{action}%'";

                    _ctrlCreaterReport.DataGrid.DataSource = dv;
                    _ctrlCreaterReport.DataGrid.Columns["Остаток"].DisplayIndex = 8;

                }

            }
            else
            {
                string dateFromPicker = _ctrlCreaterReport.DtDateRemainder.Value.ToString(CultureInfo.CurrentUICulture);
               

                dt = _bdReport.GetRemainder(dateFromPicker);
                DataView dv2 = dt.DefaultView;
                string departament = _ctrlCreaterReport.Departament == "Все" ? "" : _ctrlCreaterReport.Departament;

                dv2.RowFilter = $"Отдел like '%{departament}%'";
                
                _ctrlCreaterReport.DataGrid.DataSource = dv2;
            }

            

        }

        //Initialization comboBoxs
        public void Load_Form()
        {
            DataTable dtName = _bdReport.GetDataUser();
            DataTable dtDep = _bdReport.GetDataDepartament();

            List<string> listName = new List<string>();
            List<string> listDepartaments = new List<string>();
            //set first value
            listName.Add("Все");
            listDepartaments.Add("Все");

            //fill listName 
            foreach (DataRow row in dtName.Rows)
            {
                    listName.Add(row[0].ToString());
            }
            _ctrlCreaterReport.FillComboboxFio(listName);

            foreach (DataRow row in dtDep.Rows)
            {
                listDepartaments.Add(row[0].ToString());
            }
            _ctrlCreaterReport.FillComboboxDep(listDepartaments);

        }
    }
}
