using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Mojelit.BL;

namespace AppLogin
{
    public partial class FrmSelectTransfer : Form
    {
        private readonly DataTable _dataUsers;
        private readonly PresenterDetailsInUserDepartment _tempPresent;
        private readonly ICtrlDetailDepartament _ctrlDetail;
        private readonly int _userId;
        //private readonly IDbAddDetails _dbAddDetails;
        private int _newUser;
        private string _newDep;


        public FrmSelectTransfer(DataTable dataTable, PresenterDetailsInUserDepartment tempPresent, ICtrlDetailDepartament ctrlDetail, int userId)
        {
            _userId = userId;
            InitializeComponent();
            _dataUsers = dataTable;
            LoadCMBdata();
            _tempPresent = tempPresent;
            _ctrlDetail = ctrlDetail;
          //  _dbAddDetails = new DbAddDetails();
            cmListDep.SelectedIndexChanged += CmListDep_SelectedIndexChanged;
        }

        //Set newUser ID and newDep. It's nessacery for transfer
        private void CmListDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] list= cmListDep.Text.Split(' ');
            _newUser = Convert.ToInt32(list[0]);
            _newDep = list[1];
           // MessageBox.Show("_newUser ID="+_newUser+" _newDep="+_newDep);
        }



        //Button closes the form
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Load data for a combobox
        private void LoadCMBdata()
        {
            

            List<string> list = new List<string>();
            list.Add("Выберите, кому вы хотите передать отобранные детали");

            foreach (DataRow rows in _dataUsers.Rows)
            {
                if (_userId!=Convert.ToInt32(rows[0].ToString()))
                {

                    string forcm = rows[0].ToString() + " " + rows[1].ToString() + " " + rows[2].ToString();
                    list.Add(forcm);
                }
                
            }

            cmListDep.DataSource = list;
        }


        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (cmListDep.Text != "Выберите, кому вы хотите передать отобранные детали")
            {
                if (_tempPresent.CheckDataOnException(_ctrlDetail.GridSelected))
                {
                    try
                    {
                        int idList = _tempPresent._dbDetails.CreateListAdd(_newUser);
                        _tempPresent._dbDetails.SaveListDetailsTransfer(idList,_newDep,_ctrlDetail.GridSelected);

                        _tempPresent.TakeAwayDetails();

                        _tempPresent.ClearFilterAndRefreshDgv();
                        Close();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }

                }
            }
            else
            {
                MessageBox.Show("Вы ничего не выбрали");
            }
        }
    }
}
