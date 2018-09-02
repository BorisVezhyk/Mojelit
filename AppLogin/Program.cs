using System;
using System.Windows.Forms;
using System.Configuration;
using Mojelit.BL;

namespace AppLogin
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLoginPass frmLoginPass = new FrmLoginPass();
            MessageService messageService = new MessageService();
            //set string connection from config

            string con = ConfigurationManager.ConnectionStrings["SqlProvider"].ConnectionString;
            try
            {
                DbManager bDManager = new DbManager();
                bDManager.OpenConnection(con);
                PresenterLoginPass presenterLoginPass = new PresenterLoginPass(messageService, bDManager, frmLoginPass);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД \n"+ex.Message );
            }
           

            Application.Run(frmLoginPass);
        }
    }
}
