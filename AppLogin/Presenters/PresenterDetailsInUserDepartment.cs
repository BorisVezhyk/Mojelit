using System;
using System.Collections.Generic;
using System.Linq;
using Mojelit.BL;
using System.Windows.Forms;
using System.Data;

namespace AppLogin
{
    public class PresenterDetailsInUserDepartment
    {
        private readonly ICtrlDetailDepartament _ctrlDetail;
        public readonly IDbDetailsOnDep _dbDetails;
        private readonly IMessageService _messageService;
        private readonly int _userId;
        private readonly string _userDep;
        private DataTable _dt;

        public PresenterDetailsInUserDepartment(ICtrlDetailDepartament detailsInDep, IDbDetailsOnDep dbDetails, IMessageService messageService, int userId, string userDep)
        {
            _userId = userId;
            _userDep = userDep;
            _ctrlDetail = detailsInDep;
            _dbDetails = dbDetails;
            _messageService = messageService;
            _ctrlDetail.BtnTakeAwayDetails += CtrlDetail_BtnTakeAwayDetails;
            _ctrlDetail.BtnRowsClear += CtrlDetail_BtnRowsClear;
            Load_form();
            _ctrlDetail.BtnResetFilter += CtrlDetail_BtnResetFilter;
            _ctrlDetail.CmSortSelectedIndex += CtrlDetail_CmSortSelectedIndex;
            _ctrlDetail.CmTypeSelectedIndex += CtrlDetail_CmTypeSelectedIndex;
            _ctrlDetail.TxtModelChanged += CtrlDetail_TxtModelChanged;
            _ctrlDetail.CmSortTextChanged += _ctrlDetail_CmSortTextChanged;
            _ctrlDetail.CmTypeTextChanged += _ctrlDetail_CmTypeTextChanged;
            _ctrlDetail.BtnTransfer += _ctrlDetail_BtnTransfer;
        }

        //Button starts form Transfer
        private void _ctrlDetail_BtnTransfer(object sender, EventArgs e)
        {
            DataTable dataUsers = _dbDetails.GetData();
            
            FrmSelectTransfer frm = new FrmSelectTransfer(dataUsers,this, _ctrlDetail,_userId);
            if (CheckDataOnException(_ctrlDetail.GridSelected))
            {
                if (Application.OpenForms["FrmSelectTransfer"] == null)
                {
                    frm.Show();
                }
            }
            
          
            
        }

        #region Filter GridView
        private void _ctrlDetail_CmTypeTextChanged(object sender, EventArgs e)
        {
            FilterDgv();
        }

        private void _ctrlDetail_CmSortTextChanged(object sender, EventArgs e)
        {
            FilterDgv();
        }

        private void CtrlDetail_TxtModelChanged(object sender, EventArgs e)
        {
            FilterDgv();
        }

        private void CtrlDetail_CmTypeSelectedIndex(object sender, EventArgs e)
        {
            FilterDgv();
        }

        private void CtrlDetail_CmSortSelectedIndex(object sender, EventArgs e)
        {
            FilterDgv();
        }


        #endregion

        //Button Resets all filters
        private void CtrlDetail_BtnResetFilter(object sender, EventArgs e)
        {
            ClearFilterAndRefreshDgv();
        }

        //reset filter in datagridview
        public void ClearFilterAndRefreshDgv()
        {
            _ctrlDetail.Sort = "";
            _ctrlDetail.Type = "";
            _ctrlDetail.Model = "";
            FilterDgv();
            Load_form();
        }

        //Button clears all rows 
        private void CtrlDetail_BtnRowsClear(object sender, EventArgs e)
        {
            _ctrlDetail.ClearRowsGridSelected();
        }

        //Button takes away details in user department
        private void CtrlDetail_BtnTakeAwayDetails(object sender, EventArgs e)
        {
            if(CheckDataOnException(_ctrlDetail.GridSelected))
            {
                //Create new List addition details 
                try
                {
                    TakeAwayDetails();
                }
                catch(Exception except)
                {
                    _messageService.ShowError(except.ToString());

                }
            }
            //refresh all datagridview
            ClearFilterAndRefreshDgv();
        }

        public void TakeAwayDetails()
        {
            //create new takeAway list and get his number
            int idList = _dbDetails.CreateTakeAwayList(_userId);
            //fill "takeaway" list details 
            _dbDetails.FillTakeAwayList(idList, _ctrlDetail.GridSelected);
            _messageService.ShowInfo("Изменения успешно внесены в БД");
            //clear all rows in selected dgv
            _ctrlDetail.ClearRowsGridSelected();
        }

        /// <summary>
        /// The method checks Dgv on Exception. Return true if Dgv does not have exception. 
        /// </summary>
        /// <returns> </returns>
        public bool CheckDataOnException(DataGridView dgvListDepDetails)
        {
            if(dgvListDepDetails.Rows.Count==0)
            {
                _messageService.ShowInfo("Вы не выбрали ни одной детали");
                return false;
            }
            //if will exception this bool will been false
            bool checkExcept = true;
            for (int i = 0; i < dgvListDepDetails.Rows.Count; i++)
            {
                try
                {
                    uint takedet = Convert.ToUInt32(dgvListDepDetails.Rows[i].Cells[8].Value);
                    uint balance = Convert.ToUInt32(dgvListDepDetails.Rows[i].Cells[4].Value);
                        
                    if (balance < takedet)
                    {
                            string error = "Вы не можете взять больше деталей, чем их есть на балансе.";
                            string errArticle = $"Ошибка ввода. В строке №{i + 1} ";
                            _messageService.ShowError(error + "\n" + errArticle);
                            checkExcept = false;
                    }
                    
                }
                catch (Exception)
                {
                    _messageService.ShowExclamation("В колонке \"Взять кол-во деталей\" могут быть только положительные целочисленные значения");
                    checkExcept = false;
                }
            }

            return checkExcept;
        }

        //Load data for ComboBox
        private void Load_form()
        {
            _dt = _dbDetails.GetDataTableDetailsOnUserDep(_userDep);

            List<string> listSort = new List<string>();
            List<string> listType = new List<string>();

            //set first value in combobox
            listSort.Add("");
            listType.Add("");

            foreach (DataRow row in _dt.Rows)
            {
                //check data on repeat
                if (!listSort.Contains(row[1]))
                    listSort.Add(row[1].ToString());
                if (!listType.Contains(row[2]))
                    listType.Add(row[2].ToString());

            }    
            //fill comboboxes data
            _ctrlDetail.FillComboboxSort(listSort);
            _ctrlDetail.FillComboboxType(listType);
        }

        //Method searches detail in data
        private void FilterDgv()
        {
            //clear all rows
            _ctrlDetail.ClearRowsGridView();
            DataView dv = new DataView(_dbDetails.GetDataTableDetailsOnUserDep(_userDep))
            {
                //set filter
                RowFilter =
                    $"Вид Like '%{_ctrlDetail.Sort}%' and Тип like '%{_ctrlDetail.Type}%' and Модель like '%{_ctrlDetail.Model}%'"
            };

            _ctrlDetail.FillDataGrid(dv);

        }
    }
}
