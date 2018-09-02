using System;
using System.Collections.Generic;
using Mojelit.BL;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace AppLogin
{
    public class PresenterLoginPass
    {
        private readonly IMessageService _messageService;
        private readonly IDbManager _bdManager;
        private readonly ILoginPass _loginPass;
        private string _passwordAdmin = "";


        public PresenterLoginPass(IMessageService messageService,IDbManager iBdManager, ILoginPass loginPass)
        {
            _messageService = messageService;
            _loginPass = loginPass;
            _bdManager = iBdManager;
            _loginPass.BtnEnterClick += _loginPass_BtnEnterClick;
            Load_Form();
            try
            {
                _passwordAdmin = ConfigurationManager.AppSettings.Get("password");
            }
            catch (Exception)
            {
                
            }
            
        }

        //button Check password and login
        private void _loginPass_BtnEnterClick(object sender, EventArgs e)
        {
            bool isAdmin = false;
            string userLogin = _loginPass.Login;
            string _password = "";

            //First check on empty field
            if (_loginPass.Login==""|| _loginPass.Password=="" || _loginPass.Login == "-Выберите пользователя-" || _loginPass.Password == "Password")
            {
                _messageService.ShowExclamation("Имя пользователя или пароль не могут быть пустыми!");
                return;
            }
            //check user admin
            if (_loginPass.Login=="Администратор" && _loginPass.Password== _passwordAdmin)
            {
                isAdmin = true;
                StartMainMenu(isAdmin);
                
                return;
            }
            else
            {
                if (userLogin.Contains(" "))
                    userLogin = _loginPass.Login.Remove(_loginPass.Login.IndexOf(" "));
                _password = _bdManager.GetPassword(userLogin);
            }
            //Сравнение логина с паролем хранящийся в бд
            if (_loginPass.Password== _password)
            {
                //если юзер прошел проверку для дальнейшей работы необходимо знать какой юзер в данный момент работает с программой.И его участок.
                string userDep = _bdManager.GetUserDepartament(_password);
                int userId = _bdManager.GetUserId(_password);
                StartMainMenu(isAdmin,userId,userDep);

            }
            else
            {
                _messageService.ShowInfo("Неверный пароль");

                _loginPass.Password = "";
            }
        }


        //Запускает главное меню
        private void StartMainMenu(bool admin,int id, string dep)
        {
            _loginPass.HideForm();
            FrmMainMenu frmMainMenu = new FrmMainMenu(admin);
            frmMainMenu.Show();
            
            PresenterMainMenu menuPresenter = new PresenterMainMenu(frmMainMenu, _messageService, _bdManager,id,dep);
        }
        //Запускает главное меню для админа
        private void StartMainMenu(bool admin)
        {
            StartMainMenu(admin, 0, "");
        }

        //Заполнение комбобокса
        private void Load_Form()
        {
            DataTable dt = _bdManager.GetAllUser();

            List<string> list = new List<string>();
            list.Add("-Выберите пользователя-");

            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            
            list.Add("Администратор");

            _loginPass.FillCmLogin(list);
        }

    }
}
