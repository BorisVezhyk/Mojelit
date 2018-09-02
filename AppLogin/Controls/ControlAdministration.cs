using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace AppLogin
{
    public interface IAdmin
    {
        string CmDepart { get; set; }
        string Lname { get; set; }
        string Fname { get; set; }
        string Mname { get; set; }
        string Phone { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        event EventHandler BtnDeactivation;
        DataGridView GridView { get; set; }
        event EventHandler BtnRefresh;
        event EventHandler BtnActivation;
        event EventHandler BtnSave;
        event EventHandler BtnNewUser;
        void FillComboboxDepart(List<string> list);
        void OffTxtLoginPass();
        void OnTxtLoginPass();
        void SetGrayColumnLogin(int index);
        void SetBlackColumnLogin(int index);

    }

    public partial class ControlAdministration : UserControl,IAdmin
    {
        public ControlAdministration()
        {
            InitializeComponent();
            DgvListUsers.CellClick += DgvListUsers_CellClick;
            btnDeactive.Click += BtnNoActive_Click;
            btnRefresh.Click += BtnRefresh_Click;
            btnNewUser.Click += BtnNewUser_Click;
            btnActivation.Click += BtnActivation_Click;
            btnSave.Click += BtnSave_Click;
            txtLName.TextChanged += TxtLName_TextChanged;
            txtFname.TextChanged += TxtFname_TextChanged;
            txtMname.TextChanged += TxtMname_TextChanged;
            cmDepart.SelectedIndexChanged += CmDepart_SelectedIndexChanged;
            txtPhone.TextChanged += TxtPhone_TextChanged;
            txtLogin.TextChanged += TxtLogin_TextChanged;
            txtPassword.TextChanged += TxtPassword_TextChanged;
        }

        
#region TextChanged in all textboxes
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            int index = GridView.SelectedCells[0].RowIndex;
            GridView.Rows[index].Cells[7].Value = txtPassword.Text;
        }

        private void TxtLogin_TextChanged(object sender, EventArgs e)
        {
            int index = GridView.SelectedCells[0].RowIndex;
            GridView.Rows[index].Cells[6].Value = txtLogin.Text;
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            int index = GridView.SelectedCells[0].RowIndex;
            GridView.Rows[index].Cells[5].Value = txtPhone.Text;
        }

        private void CmDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var index = GridView.SelectedCells[0].RowIndex;
                GridView.Rows[index].Cells[4].Value = cmDepart.Text;
            }
            catch (Exception exception)
            {
               // MessageBox.Show(exception.Message);
            }
            
        }

        private void TxtMname_TextChanged(object sender, EventArgs e)
        {
            int index = GridView.SelectedCells[0].RowIndex;
            GridView.Rows[index].Cells[3].Value = txtMname.Text;
        }

        private void TxtFname_TextChanged(object sender, EventArgs e)
        {
            int index = GridView.SelectedCells[0].RowIndex;
            GridView.Rows[index].Cells[2].Value = txtFname.Text;
        }

        private void TxtLName_TextChanged(object sender, EventArgs e)
        {
            int index = GridView.SelectedCells[0].RowIndex;
            GridView.Rows[index].Cells[1].Value = txtLName.Text;
        }
        #endregion

#region EventHandler

        private void BtnSave_Click(object sender, EventArgs e)
        {
            BtnSave?.Invoke(this, EventArgs.Empty);

        }

        private void BtnActivation_Click(object sender, EventArgs e)
        {
            BtnActivation?.Invoke(this, EventArgs.Empty);

        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            BtnNewUser?.Invoke(this, EventArgs.Empty);

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            BtnRefresh?.Invoke(this, EventArgs.Empty);

        }

        private void BtnNoActive_Click(object sender, EventArgs e)
        {
            BtnDeactivation?.Invoke(this, EventArgs.Empty);

        }
#endregion

        //select rows and fill text boxs
        private void DgvListUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //If select head columns in datagridview return
            if (e.RowIndex < 0)
                return;
            //set values textboxes from selected row
            Lname = DgvListUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            Fname= DgvListUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            Mname= DgvListUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
            CmDepart= DgvListUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
            Phone= DgvListUsers.Rows[e.RowIndex].Cells[5].Value.ToString();
            //Check actived user or not
            if (DgvListUsers.Rows[e.RowIndex].Cells[8].Value.ToString().ToLower() == "true")
            {
                //turn on textboxes Login and Password
                txtLogin.Enabled = true;
                txtPassword.Enabled = true;
                //set values textboxes login and Password from Datagridview
                Login = DgvListUsers.Rows[e.RowIndex].Cells[6].Value.ToString();
                Password = DgvListUsers.Rows[e.RowIndex].Cells[7].Value.ToString();

            }else
            {
                //set values textboxes Login and Password
                Login = DgvListUsers.Rows[e.RowIndex].Cells[6].Value.ToString();
                Password = DgvListUsers.Rows[e.RowIndex].Cells[7].Value.ToString();
                //turn off textboxes login and password
                txtLogin.Enabled = false;
                txtPassword.Enabled = false;

                //DgvListUsers[6, e.RowIndex].Style.ForeColor = SystemColors.GrayText;
                //DgvListUsers[6, e.RowIndex].Style.ForeColor = SystemColors.GrayText;

            }
        }

        public void FillComboboxDepart(List<string> list)
        {
            cmDepart.DataSource = list;
        }

        public void OffTxtLoginPass()
        {
            txtLogin.Enabled = false;
            txtPassword.Enabled = false;
        }

        public void OnTxtLoginPass()
        {
            txtLogin.Enabled = true;
            txtPassword.Enabled = true;
        }

        //set gray color in datagrid Column Login
        public void SetGrayColumnLogin(int index)
        {
            DgvListUsers[6, index].Style.ForeColor = SystemColors.GrayText;
        }

        //set black color in datagrid Column Login
        public void SetBlackColumnLogin(int index)
        {
            DgvListUsers[6, index].Style.ForeColor = SystemColors.WindowText;
        }

        public event EventHandler BtnDeactivation;
        public event EventHandler BtnRefresh;
        public event EventHandler BtnActivation;
        public event EventHandler BtnSave;
        public event EventHandler BtnNewUser;


        public string CmDepart { get => cmDepart.Text; set => cmDepart.Text = value; }
        public string Lname { get => txtLName.Text; set => txtLName.Text=value; }
        public string Fname { get => txtFname.Text; set => txtFname.Text=value; }
        public string Mname { get => txtMname.Text; set => txtMname.Text=value; }
        public string Phone { get => txtPhone.Text; set => txtPhone.Text=value; }
        public string Login { get => txtLogin.Text; set => txtLogin.Text=value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text=value; }
        public DataGridView GridView { get => DgvListUsers; set => DgvListUsers = value; }

    }
}
