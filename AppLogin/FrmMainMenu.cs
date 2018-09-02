using System;
using System.Windows.Forms;


namespace AppLogin
{
    public interface IMainMenu
    {

        ControlDetailOnDepartament CtrlDetailOnDepartment { get; set; }
        ControlAllDetails CtrlAllDetails { get; set; }
        ControlAdministration CtrlAdministrator { get; set; }
        ControlCreaterReport CtrlReport { get; set; }
        ControlAllDepartaments CtrlDepartaments { get; set; }
        ControlAddDet CtrAddDet { get; set; }

        event EventHandler BtnRefreshTable;
        event EventHandler BtnDetInDep;
        event EventHandler BtnAllDetails;
        event EventHandler BtnAdmin;
        event EventHandler BtnAddDetails;
    }

    public partial class FrmMainMenu : Form,IMainMenu
    {
        public event EventHandler BtnRefreshTable;
        public event EventHandler BtnDetInDep;
        public event EventHandler BtnAllDetails;
        public event EventHandler BtnAdmin;
        public event EventHandler BtnAddDetails;

        public ControlAddDet CtrAddDet
        {
            get { return controlAddDet1; }
            set { controlAddDet1 = value; }
        }

        public ControlAllDetails CtrlAllDetails
        {
            get { return controlAllDetails; }
            set { controlAllDetails = value; }
        }

        public ControlDetailOnDepartament CtrlDetailOnDepartment
        {
            get { return controlDetailOnDepartament; }
            set { controlDetailOnDepartament = value; }
        }

        public ControlAdministration CtrlAdministrator
        {
            get { return controlAdministration; }
            set { controlAdministration = value; }
        }

        public ControlCreaterReport CtrlReport
        {
            get { return controlCreaterReport; }
            set { controlCreaterReport = value; }
        }


        public ControlAllDepartaments CtrlDepartaments { get => controlAllDepartaments1; set => controlAllDepartaments1 = value; }

        //Аргумент в конструкторе statusAdmin, false устанавливает ограничения в программе, true полный доступ
        public FrmMainMenu(bool statusAdmin)
        {
            InitializeComponent();
            
            //ограничение
            btnAdmin.Enabled = statusAdmin;
            btnDepartaments.Enabled = statusAdmin;
            //для админа блокирока т.к. кнопка бесполезная
            btnDetInDep.Enabled = statusAdmin ? false : true;
            btnAddDet.Enabled = statusAdmin ? false : true;

            btnRefresh.Click += BtnRefresh_Click;
            btnDetInDep.Click += BtnDetInDep_Click;
            btnAllDet.Click += BtnAllDet_Click;
            btnAdmin.Click += BtnAdmin_Click;
            btnAddDet.Click += BtnAddDet_Click;
            btnDepartaments.Click += BtnDepartaments_Click;
        }

        private void BtnDepartaments_Click(object sender, EventArgs e)
        {
            MarkerPanel.Height = btnDepartaments.Height;
            MarkerPanel.Top = btnDepartaments.Top;
            controlAllDepartaments1.BringToFront();
        }

        //Button shows FrmMenuListAdd
        private void BtnAddDet_Click(object sender, EventArgs e)
        {
            MarkerPanel.Height = btnAddDet.Height;
            MarkerPanel.Top = btnAddDet.Top;
            controlAddDet1.BringToFront();
            BtnAddDetails?.Invoke(this, EventArgs.Empty);
        }

        //Button show all users
        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            MarkerPanel.Height = btnAdmin.Height;
            MarkerPanel.Top = btnAdmin.Top;
            controlAdministration.BringToFront();
            BtnAdmin?.Invoke(this, EventArgs.Empty);
        }

        //Button shows all details in all departaments
        private void BtnAllDet_Click(object sender, EventArgs e)
        {
            MarkerPanel.Height = btnAllDet.Height;
            MarkerPanel.Top = btnAllDet.Top;
            controlAllDetails.BringToFront();

            BtnAllDetails?.Invoke(this, EventArgs.Empty);
        }

        //Button shows detail in User's Departament 
        private void BtnDetInDep_Click(object sender, EventArgs e)
        {
            MarkerPanel.Height = btnDetInDep.Height;
            MarkerPanel.Top = btnDetInDep.Top;
            controlDetailOnDepartament.BringToFront();
            BtnDetInDep?.Invoke(this, EventArgs.Empty);
        }

        //Button refreshes all table
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            BtnRefreshTable?.Invoke(this, EventArgs.Empty);
        }

        //Button is exit
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        //Button shows FrmReport
        private void BtnShowFrmReport(object sender, EventArgs e)
        {
            MarkerPanel.Height = btnShowReport.Height;
            MarkerPanel.Top = btnShowReport.Top;
            controlCreaterReport.BringToFront();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {

        }
        
    }
}
