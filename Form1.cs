using MySql.Data.MySqlClient;

namespace SampleApp
{
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DatabaseHelper db = new DatabaseHelper();
            dgvData.DataSource = db.GetProfiles();
        }
        private void Reset()
        {
            txtLname.Text = string.Empty;
            txtFname.Text = string.Empty;
            txtMname.Text = string.Empty;
            txtContact.Text = string.Empty;
            rtbAddress.Text = string.Empty;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Users (LastName, FirstName, MiddleName, Contact, Address) " +
                   "VALUES (@ln, @fn, @mn, @con, @addr)";

            MySqlParameter[] ps = {
                new MySqlParameter("@ln", txtLname.Text),
                new MySqlParameter("@fn", txtFname.Text),
                new MySqlParameter("@mn", txtMname.Text),
                new MySqlParameter("@con", txtContact.Text),
                new MySqlParameter("@addr", rtbAddress.Text)
            };

            new DatabaseHelper().ExecuteQuery(query, ps);
            MessageBox.Show("Profile Saved!");
            LoadData();
            Reset();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
