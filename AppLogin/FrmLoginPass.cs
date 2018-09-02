using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppLogin
{
    public interface ILoginPass
    {
        string Login { get;}
        string Password { get; set; }
        void HideForm();
        event EventHandler BtnEnterClick;
        void FillCmLogin(List<string> list);
    }

   
    public partial class FrmLoginPass : Form, ILoginPass
    {
        public string Login
        {
            get { return cmbLogin.Text; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public event EventHandler BtnEnterClick;

        public void FillCmLogin(List<string> list)
        {
            cmbLogin.DataSource = list;
        }

        public FrmLoginPass()
        {
            InitializeComponent();
            btnEnter.Click += BtnEnter_Click;
            

        }

   

        public void HideForm()
        {
            Hide();
        }
        

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (BtnEnterClick != null)
                BtnEnterClick(this, EventArgs.Empty);
        }

        #region PlaceHolder

        private void Password_Enter(object sender, EventArgs e)
        {

            if (txtPassword.Text == @"Password")
            {

                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = @"Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        #endregion
    }

}
