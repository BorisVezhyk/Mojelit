using System;
using System.Collections.Generic;
using System.Linq;
using Mojelit.BL;
using System.Data;


namespace AppLogin
{

    public class PresenterCrtlAddDetails
    {
        private readonly ICtrlAddDet _ctrlAddDetails;
        private readonly IDbAddDetails _dbAddDetails;
        private readonly IMessageService _messageService;
        private readonly int _userId;
        private readonly string _userDep;
        

        public PresenterCrtlAddDetails(ICtrlAddDet addDetails, IDbAddDetails dbAddDetails, IMessageService messageService, int userId,string userDep )
        {
            _userId = userId;
            _userDep = userDep;
            _dbAddDetails = dbAddDetails;
            _ctrlAddDetails = addDetails;
            _messageService = messageService;
            _ctrlAddDetails.BtnAddDetailOnDgv += _ctrlAddDetails_BtnAddDetailOnDgv;
            _ctrlAddDetails.BtnClearAllTxt += _ctrlAddDetails_BtnClearAllTxt;
            _ctrlAddDetails.BtnClearAllRows += _ctrlAddDetails_BtnClearAllRows;
            _ctrlAddDetails.BtnDeleteSelectRow += _ctrlAddDetails_BtnDeleteSelectRow;
            _ctrlAddDetails.BtnSaveRowsInData += _ctrlAddDetails_BtnSaveRowsInData;
            Load_form();
        }

        //Button saves details in DB
        private void _ctrlAddDetails_BtnSaveRowsInData(object sender, EventArgs e)
        {
            //If gridView is not empty
            if (_ctrlAddDetails.DataGrid.Rows.Count > 0)
            {
                //Create new List Adding Details
                int idList;
                idList = _dbAddDetails.CreateListAdd(_userId);
                //Fill in the list with details
                _dbAddDetails.SaveListDetails(idList, _userDep, _ctrlAddDetails.DataGrid);
                _messageService.ShowInfo("Детали успешно внесены в базу данных");
                //Clear drigView
                _ctrlAddDetails.DataGrid.Rows.Clear();
            }
            else _messageService.ShowInfo("Пустой список нельзя сохранить");

        }

        //Button remove select row
        private void _ctrlAddDetails_BtnDeleteSelectRow(object sender, EventArgs e)
        {
            int index = _ctrlAddDetails.DataGrid.SelectedCells[0].RowIndex;
            _ctrlAddDetails.DataGrid.Rows.RemoveAt(index);
        }

        //Button clears Dgv
        private void _ctrlAddDetails_BtnClearAllRows(object sender, EventArgs e)
        {
            _ctrlAddDetails.DataGrid.Rows.Clear();
        }

        //Button clears all txt
        private void _ctrlAddDetails_BtnClearAllTxt(object sender, EventArgs e)
        {
            ClearTxt();
        }

        //The method clears txt of the field
        private void ClearTxt()
        {
            _ctrlAddDetails.SortDet = "";
            _ctrlAddDetails.ModelDet = "";
            _ctrlAddDetails.TypeDet = "";
            _ctrlAddDetails.Quatity = "";
            _ctrlAddDetails.Notice = "";
        }

        //Button adds Details on Dgv
        private void _ctrlAddDetails_BtnAddDetailOnDgv(object sender, EventArgs e)
        {
            if (_ctrlAddDetails.SortDet == "" || _ctrlAddDetails.TypeDet == "" || _ctrlAddDetails.ModelDet == "" || _ctrlAddDetails.Quatity == "")
                _messageService.ShowInfo("Заполните все данные помеченные *");
            else
            {
                try
                {
                    
                    uint tempUint = Convert.ToUInt32(_ctrlAddDetails.Quatity);

                    if (CheckDgvOnRepeat(tempUint)) return;


                    _ctrlAddDetails.FillDgvDataDetails(_ctrlAddDetails.SortDet, _ctrlAddDetails.TypeDet,
                        _ctrlAddDetails.ModelDet, _ctrlAddDetails.Quatity, _ctrlAddDetails.Notice);
                }
                catch (Exception ex)
                {
                    _messageService.ShowError(ex.Message);
                    _messageService.ShowError("В поле количество может быть только положительные целочисленные значения");
                    _ctrlAddDetails.Quatity = "";
                }
            }
        }
        //Check DataGrid on repeat
        private bool CheckDgvOnRepeat(uint tempUint)
        {
//check DataGridView on repeat
            if (_ctrlAddDetails.DataGrid.Rows.Count > 0)
            {
                for (int i = 0; i < _ctrlAddDetails.DataGrid.Rows.Count; i++)
                {
                    if (_ctrlAddDetails.DataGrid[0, i].Value.ToString() == _ctrlAddDetails.SortDet &&
                        _ctrlAddDetails.DataGrid[1, i].Value.ToString() == _ctrlAddDetails.TypeDet &&
                        _ctrlAddDetails.DataGrid[2, i].Value.ToString() == _ctrlAddDetails.ModelDet)
                    {
                        _ctrlAddDetails.DataGrid[3, i].Value =
                            Convert.ToUInt32(_ctrlAddDetails.DataGrid[3, i].Value.ToString()) + tempUint;
                        _ctrlAddDetails.DataGrid[4, i].Value = _ctrlAddDetails.Notice;
                        return true;
                    }
                }
            }

            return false;
        }

        public void Load_form()
        {
            InitialAutoCompleteCustomSource();
            InitialCmboxCollection();
            _ctrlAddDetails.ModelDet = "";

        }

        /// <summary>
        /// Method initialize Comboboxs collection
        /// </summary>
        private void InitialCmboxCollection()
        {
            DataTable dt = _dbAddDetails.GetDataTableAllDetails();

            List<string> listSort = new List<string>();
            List<string> listType = new List<string>();

            listSort.Add("");
            listType.Add("");

            foreach (DataRow row in dt.Rows)
            {
                if (!listSort.Contains(row[1]))
                    listSort.Add(row[1].ToString());
                if (!listType.Contains(row[2]))
                    listType.Add(row[2].ToString());

            }
            _ctrlAddDetails.FillCmSort(listSort);
            _ctrlAddDetails.FillCmType(listType);

        }

        /// <summary>
        /// Method initializes AutoCompleteCustomSource with DB
        /// </summary>
        private void InitialAutoCompleteCustomSource()
        {
            DataTable dt = _dbAddDetails.GetDataForCompleteString();
            var listModel = new List<string>();
            var listType = new List<string>();
            var listView = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                listView.Add(row[0].ToString());
                listType.Add(row[1].ToString());
                listModel.Add(row[2].ToString());
            }

            _ctrlAddDetails.FillModelStringCollection(listModel);
            _ctrlAddDetails.FillTypeStringCollection(listType);
            _ctrlAddDetails.FillViewStringCollection(listView);
        }
    }
}
