using System;
using Mojelit.BL;
using System.Data;

namespace AppLogin
{
    public class PresenterCtrlDepartaments
    {
        private readonly IDbDepartament dbDepart;
        private readonly IMessageService message;
        private readonly ICtrlDepartaments ctrlDepart;

        public PresenterCtrlDepartaments(IDbDepartament db,IMessageService message,ICtrlDepartaments ctrl)
        {
            dbDepart = db;
            this.message = message;
            ctrlDepart = ctrl;
            Load_form();
            ctrlDepart.BtnRefresh += CtrlDepart_BtnRefresh;
            ctrlDepart.BtnSave += CtrlDepart_BtnSave;
            ctrlDepart.DataGrid.CellClick += DataGrid_CellClick;

            ctrlDepart.BtnNewDep += CtrlDepart_BtnNewDep;
        }

        private void CtrlDepart_BtnNewDep(object sender, EventArgs e)
        {
            int index = ctrlDepart.DataGrid.Rows.Add();
            int newId = dbDepart.GetNewIdDep();
            ctrlDepart.DataGrid[0, index].Value = newId;
            ctrlDepart.DataGrid[1, index].Value = "";
            ctrlDepart.DataGrid[2, index].Value = "";
            ctrlDepart.DataGrid[3, index].Value = "";
            ctrlDepart.DataGrid.Rows[index].Selected = true;
            ctrlDepart.Abbrev = "";
            ctrlDepart.FullName = "";
            ctrlDepart.Phone = "";

        }

        private void DataGrid_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            //If select head columns in datagridview return
            if (e.RowIndex < 0)
                return;
            //set values textboxes
            ctrlDepart.Abbrev = ctrlDepart.DataGrid[1, e.RowIndex].Value.ToString();
            ctrlDepart.FullName = ctrlDepart.DataGrid[2, e.RowIndex].Value.ToString();
            ctrlDepart.Phone = ctrlDepart.DataGrid[3, e.RowIndex].Value.ToString();
        }

        private void CtrlDepart_BtnSave(object sender, EventArgs e)
        {
            for (int i = 0; i < ctrlDepart.DataGrid.Rows.Count; i++)
            {
                if(ctrlDepart.DataGrid[1,i].Value.ToString()=="")
                {
                    message.ShowError("Отдел обязательно должен содержать аббревиатуру.");
                    return;
                }
            }
            
            dbDepart.SaveChange(ctrlDepart.DataGrid);
            message.ShowInfo("Изменения внесены");

        }

        private void CtrlDepart_BtnRefresh(object sender, EventArgs e)
        {
            Load_form();
        }

        private void Load_form()
        {
            ctrlDepart.DataGrid.Rows.Clear();
            DataTable dt = dbDepart.GetAllDepartaments();
            foreach (DataRow row in dt.Rows)
            {
                ctrlDepart.DataGrid.Rows.Add(row[0], row[1], row[2],row[3]);
            }
        }
    }
}
