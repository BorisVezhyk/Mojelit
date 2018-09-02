using System;
using System.Collections.Generic;
using Mojelit.BL;
using System.Data;


namespace AppLogin
{
    class PresenterCtrlAdministration
    {
        private readonly IAdmin _ctrlAdmin;
        private readonly IMessageService _message;
        private readonly IDbAdmin _bdAdmin;

        public PresenterCtrlAdministration(IAdmin admin,IMessageService message,IDbAdmin bdAdmin)
        {
            _ctrlAdmin = admin;
            _message = message;
            _bdAdmin = bdAdmin;

            Load_Form();
            //events
            _ctrlAdmin.BtnDeactivation += CtrlAdmin_BtnDeactivation;
            _ctrlAdmin.BtnRefresh += CtrlAdmin_BtnRefresh;
            _ctrlAdmin.BtnActivation += CtrlAdmin_BtnActivation;
            _ctrlAdmin.BtnSave += CtrlAdmin_BtnSave;
            _ctrlAdmin.BtnNewUser += CtrlAdmin_BtnNewUser;
            
        }

        //Button add new User in datagridview
        private void CtrlAdmin_BtnNewUser(object sender, EventArgs e)
        {
            //clear all selection
            _ctrlAdmin.GridView.ClearSelection();
            //add new row and select it
            int index = _ctrlAdmin.GridView.Rows.Add();
            _ctrlAdmin.GridView.Rows[index].Selected = true;
            //fill textbox
            _ctrlAdmin.Lname = "";
            _ctrlAdmin.Fname = "";
            _ctrlAdmin.Mname = "";
            _ctrlAdmin.Phone = "";
            _ctrlAdmin.CmDepart = "";
            _ctrlAdmin.Login= "";
            _ctrlAdmin.Password = "";
            //set checkbox column on false
            _ctrlAdmin.GridView.Rows[index].Cells[8].Value = false;
            //set value columns login and password
            _ctrlAdmin.GridView[6, index].Value = "";
            _ctrlAdmin.GridView[7, index].Value = "";
            //turn off textboxes Login and Password
            _ctrlAdmin.OffTxtLoginPass();

            //set value new id user 
            int newIdUser = _bdAdmin.GetNewIdUser();
            _ctrlAdmin.GridView[0, index].Value = newIdUser;

        }

        //button save all change
        private void CtrlAdmin_BtnSave(object sender, EventArgs e)
        {
            //Check gridview on exception
            for (int i = 0; i < _ctrlAdmin.GridView.Rows.Count; i++)
            {
                //Check Login and Password Actived Users
                if (_ctrlAdmin.GridView[8,i].Value.ToString().ToLower()=="true")
                {
                    if (_ctrlAdmin.GridView[6,i].Value.ToString()==""||
                        _ctrlAdmin.GridView[7,i].Value.ToString()=="")
                    {
                        _message.ShowExclamation("У активных пользователей обязательно должны быть логин и пароль");
                        return;
                    }
                }
                //Check Lname and Abbrevation on all users
                if (_ctrlAdmin.GridView[1, i].Value.ToString() == "" ||
                    _ctrlAdmin.GridView[4, i].Value.ToString() == "")
                {
                    int idUser = Convert.ToInt32(_ctrlAdmin.GridView[0, i].Value.ToString());
                    _message.ShowExclamation("У пользователя с id№"+idUser+" ошибка. Все поля , отмеченные *, должны быть заполнены");
                    return;
                }
            }

            try
            {
                _bdAdmin.SaveChangedUser(_ctrlAdmin.GridView);
            }
            catch (Exception exc)
            {
                _message.ShowError("Ошибка");
                _message.ShowError(exc.Message);
            }
            
        }


        //button activates user in selected row
        private void CtrlAdmin_BtnActivation(object sender, EventArgs e)
        {
            int index = _ctrlAdmin.GridView.SelectedCells[0].RowIndex;
            //set ColumnCheck true
            _ctrlAdmin.GridView[8, index].Value = true;
            //turn on textboxes Login and Password
            _ctrlAdmin.OnTxtLoginPass();
            _ctrlAdmin.SetBlackColumnLogin(index);

        }

        //button refresh table of users
        private void CtrlAdmin_BtnRefresh(object sender, EventArgs e)
        {
            Load_Form();
        }

        //button deactive user
        private void CtrlAdmin_BtnDeactivation(object sender, EventArgs e)
        {
            int index = _ctrlAdmin.GridView.SelectedCells[0].RowIndex;
            _ctrlAdmin.GridView.Rows[index].Cells[8].Value = false;
            _ctrlAdmin.GridView.Rows[index].Cells[7].Value = "";

            _ctrlAdmin.Password = "";
            _ctrlAdmin.OffTxtLoginPass();
            _ctrlAdmin.SetGrayColumnLogin(index);

        }

        //initialization Combobox
        private void InitComboboxDep()
        {
            DataTable dt = _bdAdmin.GetDataDepartament();

            List<string> listDep = new List<string>();
            //set first value empty
            listDep.Add("");

            foreach (DataRow row in dt.Rows)
            {
                listDep.Add(row[0].ToString());
            }
            //load data abbrevation in combobox
            _ctrlAdmin.FillComboboxDepart(listDep);
        }

        private void Load_Form()
        {
            //Refresh Combobox
            InitComboboxDep();
            //Clear all Rows in datagridview
            _ctrlAdmin.GridView.Rows.Clear();
            //get new data all users
            DataTable dt = _bdAdmin.GetDataTableAllUsers();
            foreach (DataRow row in dt.Rows)
            {
                //load data all users in datagridview
                int index = _ctrlAdmin.GridView.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
                //check login column activated user or not
                if (_ctrlAdmin.GridView[7, index].Value.ToString() == "")
                    //if no. Set checkbox column False
                {
                    _ctrlAdmin.GridView.Rows[index].Cells[8].Value = false;
                    _ctrlAdmin.SetGrayColumnLogin(index);
                    _ctrlAdmin.OffTxtLoginPass();
                }
                else
                    //if yes. Set checkbox column true
                    _ctrlAdmin.GridView.Rows[index].Cells[8].Value = true;
            }
        }
    }
}
