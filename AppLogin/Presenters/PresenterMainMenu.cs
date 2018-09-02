using System;
using Mojelit.BL;
using System.Data;
using System.Configuration;
using DataTable = System.Data.DataTable;

namespace AppLogin
{
    public class PresenterMainMenu
    {
        private readonly IMainMenu _mainMenu;
        private readonly IDbManager _bdManager;
        private readonly IMessageService _messageService;
        private readonly int _userId;
        private readonly string _userDep;
        private DataTable _dtAllDetail;
        private PresenterCtrlAllDetails _presenterCtrlAllDetails;
        private PresenterCrtlAddDetails _presenterCrtlAddDetails;
        private PresenterDetailsInUserDepartment _presenterDetailsInUserDepartment;
        private PresenterCtrlCreateReport _presenterCtrlCreateReport;

        public PresenterMainMenu(IMainMenu mainMenu, IMessageService messageService, IDbManager bdManager, int userid, string userdep)
        {
            _userId = userid;
            _userDep = userdep;
            _mainMenu = mainMenu;
            _bdManager = bdManager;
            _messageService = messageService;
            InitailizetAllPresentersCtrls();
            _mainMenu.BtnRefreshTable += _mainMenu_BtnRefreshTable;
            _mainMenu.BtnDetInDep += _mainMenu_BtnDetInDep;
            _mainMenu.BtnAllDetails += _mainMenu_BtnAllDetails;
            _mainMenu.BtnAdmin += _mainMenu_BtnAdmin;
            _mainMenu.BtnAddDetails += _mainMenu_BtnAddDetails;
        }


        //Button get details on all Details
        private void _mainMenu_BtnAllDetails(object sender, EventArgs e)
        {
        }

        //Button get Details on user department
        private void _mainMenu_BtnDetInDep(object sender, EventArgs e)
        {
            GetAndFillTableUserDep();
        }

        //Button refreshs All Tables
        private void _mainMenu_BtnRefreshTable(object sender, EventArgs e)
        {
            //RefreshTable();
            _presenterCtrlAllDetails.RefreshData();
            _presenterCrtlAddDetails.Load_form();
            _presenterDetailsInUserDepartment.ClearFilterAndRefreshDgv();
            _presenterCtrlCreateReport.Load_Form();
        }

        //Button load in Dgv all users
        private void _mainMenu_BtnAdmin(object sender, EventArgs e)
        {
        }

        #region RefreshOld
        //Method fills table "All Details"
        private void GetAndFillTableAllDetails()
        {
            _dtAllDetail = _bdManager.GetDataTableAllDetails();
            _mainMenu.CtrlAllDetails.DgvListAllDetails.DataSource = _dtAllDetail;
        }

        //Method fills table "Details in user department"
        private void GetAndFillTableUserDep()
        {
            _mainMenu.CtrlDetailOnDepartment.GridView.Rows.Clear();
            DataTable dt = _bdManager.GetDataTableDetailsOnUserDep(_userDep) ?? throw new ArgumentNullException(string.Format("_bdManager.GetDataTableDetailsOn{0}UserDep(_userDep)", "ARG0"));

            foreach (DataRow row in dt.Rows)
            {
                _mainMenu.CtrlDetailOnDepartment.DgvListDepDetails.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
            }
        }

        //Method refresh all data at the tables
        private void RefreshTable()
        {
            _mainMenu.CtrlDetailOnDepartment.DgvListDepDetails.Rows.Clear();
            FillAllTables();
        }

        //Method fill all tables
        private void FillAllTables()
        {
            GetAndFillTableUserDep();
            GetAndFillTableAllDetails();

        }

        #endregion

        //Button Add Details
        private void _mainMenu_BtnAddDetails(object sender, EventArgs e)
        {
            
        }


        //Initiazet all presenters contorol
        private void InitailizetAllPresentersCtrls()
        {
            //set string connection from config
            var con = ConfigurationManager.ConnectionStrings["SqlProvider"].ConnectionString;

            //start controlAddDetails presenter
            DbAddDetails dbAdd=new DbAddDetails();
            dbAdd.OpenConnection(con);
            _presenterCrtlAddDetails = new PresenterCrtlAddDetails(_mainMenu.CtrAddDet, dbAdd, _messageService,_userId,_userDep);

            //start controlDetailsOnDepartament presenter
            DbDetailstOnDep dBDetailstOnDep = new DbDetailstOnDep();
            dBDetailstOnDep.OpenConnection(con);
            _presenterDetailsInUserDepartment= new PresenterDetailsInUserDepartment(_mainMenu.CtrlDetailOnDepartment, dBDetailstOnDep, _messageService, _userId, _userDep);
            
            //Start controlAllDetails
            DBAllDetails dBAllDetails = new DBAllDetails();
            dBAllDetails.OpenConnection(con);
            _presenterCtrlAllDetails= new PresenterCtrlAllDetails(_mainMenu.CtrlAllDetails,_messageService, dBAllDetails);

            //Start controlCreateReport Presenter
            var bDReport = new DBReport();
            bDReport.OpenConnection(con);
            _presenterCtrlCreateReport= new PresenterCtrlCreateReport(_mainMenu.CtrlReport, _messageService, bDReport, _userId, _userDep);
            
            //Start controlAdmin presenter
            DbAdmin bDAdmin = new DbAdmin();
            bDAdmin.OpenConnection(con);
            new PresenterCtrlAdministration(_mainMenu.CtrlAdministrator, _messageService, bDAdmin);
            
            //Start controlAllDepartaments presenter
            DBdepartament dBdepartament = new DBdepartament();
            dBdepartament.OpenConnection(con);
            new PresenterCtrlDepartaments(dBdepartament,_messageService,_mainMenu.CtrlDepartaments);


        }
    }
}
