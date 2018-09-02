using System;
using System.Collections.Generic;
using System.Linq;
using Mojelit.BL;
using System.Data;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;


namespace AppLogin
{
    class PresenterCtrlAllDetails
    {
        private readonly ICtrlAllDetails _ctrlAllDetails;
        private readonly IMessageService _messageService;
        private readonly IDbAllDetails _dbAllDetails;

        public PresenterCtrlAllDetails(ICtrlAllDetails ctrlAllDetails, IMessageService message, IDbAllDetails dbAllDetails)
        {
            _dbAllDetails = dbAllDetails;
            _ctrlAllDetails = ctrlAllDetails;
            _messageService = message;
            ctrlAllDetails.BtnImportToExcel += CtrlAllDetails_BtnImportToExcel;
            ctrlAllDetails.BtnResetFilter += CtrlAllDetails_BtnResetFilter;
            ctrlAllDetails.CmSortSelectedIndex += CtrlAllDetails_CmSelectedIndex;
            ctrlAllDetails.CmTypeSelectedIndex += CtrlAllDetails_CmTypeSelectedIndex;
            ctrlAllDetails.TxtModelChanged += CtrlAllDetails_TxtModelChanged;
            ctrlAllDetails.CmSortTextChanged += CtrlAllDetails_CmSortTextChanged;
            ctrlAllDetails.CmTypeTextChanged += CtrlAllDetails_CmTypeTextChanged;
            _ctrlAllDetails.CmDepSelectedIndex += _ctrlAllDetails_CmDepSelectedIndex;
            _ctrlAllDetails.CmDepTextChanged += _ctrlAllDetails_CmDepTextChanged;

            Load_form();
            }

        //Event Combobox textchanged
        private void _ctrlAllDetails_CmDepTextChanged(object sender, EventArgs e)
        {
            FilterDgv();
        }
        //Event Combobox textchanged
        private void _ctrlAllDetails_CmDepSelectedIndex(object sender, EventArgs e)
        {
            FilterDgv();
        }

        //Event Combobox textchanged
        private void CtrlAllDetails_CmTypeTextChanged(object sender, EventArgs e)
        {
            FilterDgv();
        }
        //Event Combobox textchanged
        private void CtrlAllDetails_CmSortTextChanged(object sender, EventArgs e)
        {
            FilterDgv();
        }

        //Event Txtbox change text
        private void CtrlAllDetails_TxtModelChanged(object sender, EventArgs e)
        {
            FilterDgv();
        }

        //Event Combobox selected Index Change
        private void CtrlAllDetails_CmTypeSelectedIndex(object sender, EventArgs e)
        {
            FilterDgv();
        }
        //Event Combobox selected Index Change
        private void CtrlAllDetails_CmSelectedIndex(object sender, EventArgs e)
        {
            FilterDgv();
        }

        //Button finds details
        private void CtrlAllDetails_BtnResetFilter(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            _ctrlAllDetails.Sort = "";
            _ctrlAllDetails.Type = "";
            _ctrlAllDetails.Model = "";
            _ctrlAllDetails.Departament = "";
            FilterDgv();
            Load_form();
        }

        //Method searches detail in data
        private void FilterDgv()
        {
            //get data all details
            DataView dv = new DataView(_dbAllDetails.GetAllDetails());
            //set filter
            dv.RowFilter =
                $"Вид Like '%{_ctrlAllDetails.Sort}%' and Тип like '%{_ctrlAllDetails.Type}%' and Модель like '%{_ctrlAllDetails.Model}%' and Участок like '%{_ctrlAllDetails.Departament}%'";
            //load data in datagridview
            _ctrlAllDetails.FillDataGridView(dv);

        }


        private void CtrlAllDetails_BtnImportToExcel(object sender, EventArgs e)
        {
            _ctrlAllDetails.CopyAlltoClipboard();
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

        }

        //Load data for ComboBox
        private void Load_form()
        {
            FilterDgv();
            DataTable dt = _dbAllDetails.GetAllDetails();

            List<string> listSort = new List<string>();
            List<string> listType = new List<string>();
            List<string> listDep = new List<string>();

            //Set first value for comboboxes
            listSort.Add("");
            listType.Add("");
            listDep.Add("");
            foreach (DataRow row in dt.Rows)
            {
                //check data on repeat
                if (!listSort.Contains(row[0]))
                    listSort.Add(row[0].ToString());
                if (!listType.Contains(row[1]))
                    listType.Add(row[1].ToString());
                if (!listDep.Contains(row[4]))
                {
                    listDep.Add(row[4].ToString());
                }
            }

            //Fill comboboxes
            _ctrlAllDetails.FillComboboxSort(listSort);
            _ctrlAllDetails.FillComboboxType(listType);
            _ctrlAllDetails.FillComboboxDep(listDep);
        }
    }
}
