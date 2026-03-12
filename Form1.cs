using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace SampleApp
{
    public partial class frmProfile : Form
    {
        int selectedProfileID;
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
            lblStatus.Text = string.Empty;
            btnEdit.Text = "Edit";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                // 1. Check if any row is selected
                if (dgvData.SelectedRows.Count > 0)
                {
                    // 2. Get the first selected row
                    DataGridViewRow row = dgvData.SelectedRows[0];

                    // 3. Store the ID globally so we know which record to update later
                    selectedProfileID = Convert.ToInt32(row.Cells["ID"].Value);

                    // 4. Fill the TextBoxes with the data from the grid
                    txtLname.Text = row.Cells["LastName"].Value?.ToString();
                    txtFname.Text = row.Cells["FirstName"].Value?.ToString();
                    txtMname.Text = row.Cells["MiddleName"].Value?.ToString();
                    txtContact.Text = row.Cells["Contact"].Value?.ToString();
                    rtbAddress.Text = row.Cells["Address"].Value?.ToString();

                    // 5. Visual cue: Let the user know they are in 'Edit Mode'
                    lblStatus.Text = "Editing Profile ID: " + selectedProfileID;
                    btnEdit.Text = "Update Changes"; // Change the Save button text
                }
                else
                {
                    // 6. Alert the user if they clicked Edit without selecting a row
                    MessageBox.Show("Please select a full row from the list to edit.",
                                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

            }
            
        }
    }
}
