using System;
using System.Windows.Forms;

namespace AppLogin
{
    public interface ICtrlDepartaments
    {
        DataGridView DataGrid { get; set; }
        event EventHandler BtnRefresh;
        event EventHandler BtnSave;
        string Abbrev { get; set; }
        string FullName { get; set; }
        string Phone { get; set; }
        event EventHandler BtnNewDep;

    }

    public partial class ControlAllDepartaments : UserControl,ICtrlDepartaments
    {
        public ControlAllDepartaments()
        {
            InitializeComponent();
            btnRefresh.Click += BtnRefresh_Click;
            btnSave.Click += BtnSave_Click;
            btnNewDep.Click += BtnNewDep_Click;
            txtAbbrev.TextChanged += TxtAbbrev_TextChanged;
            txtFullName.TextChanged += TxtFullName_TextChanged;
            txtPhone.TextChanged += TxtPhone_TextChanged;
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            int index = DataGrid.SelectedCells[0].RowIndex;
            DataGrid[3, index].Value = Phone;
        }

        private void TxtFullName_TextChanged(object sender, EventArgs e)
        {
            int index = DataGrid.SelectedCells[0].RowIndex;
            DataGrid[2, index].Value = FullName;
        }

        private void TxtAbbrev_TextChanged(object sender, EventArgs e)
        {
            int index = DataGrid.SelectedCells[0].RowIndex;
            DataGrid[1, index].Value = Abbrev;
        }

        private void BtnNewDep_Click(object sender, EventArgs e)
        {
            BtnNewDep?.Invoke(this, EventArgs.Empty);

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            BtnSave?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler BtnRefresh;
        public event EventHandler BtnSave;
        public event EventHandler BtnNewDep;

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            BtnRefresh?.Invoke(this, EventArgs.Empty);

        }

        public DataGridView DataGrid { get => gridView; set => gridView = value; }
        public string Abbrev { get => txtAbbrev.Text; set => txtAbbrev.Text=value; }
        public string FullName { get => txtFullName.Text; set => txtFullName.Text = value; }
        public string Phone { get => txtPhone.Text; set => txtPhone.Text=value; }
    }
}
