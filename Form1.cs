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
            //LoadData();
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
            btnSave.Text = "New";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "New")
            {
                pInfo.Enabled = true;
                btnSave.Text = "Save";
            }
            else
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
                if (selectedProfileID == 0)
                {
                    MessageBox.Show("Please select a profile from the list first.");
                    return;
                }

                string query = "UPDATE Users SET LastName=@ln, FirstName=@fn, MiddleName=@mn, " +
                               "Contact=@con, Address=@addr WHERE ID=@id";

                MySqlParameter[] ps = {
                    new MySqlParameter("@ln", txtLname.Text),
                    new MySqlParameter("@fn", txtFname.Text),
                    new MySqlParameter("@mn", txtMname.Text),
                    new MySqlParameter("@con", txtContact.Text),
                    new MySqlParameter("@addr", rtbAddress.Text),
                    new MySqlParameter("@id", selectedProfileID)
                };

                new DatabaseHelper().ExecuteQuery(query, ps);
                MessageBox.Show("Profile Updated Successfully!");
                LoadData(); // Refresh the grid
                Reset();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProfileID == 0) return;

            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this profile?",
                "Delete Confirmation", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                string query = "DELETE FROM Users WHERE ID=@id";
                MySqlParameter[] ps = { new MySqlParameter("@id", selectedProfileID) };

                new DatabaseHelper().ExecuteQuery(query, ps);
                MessageBox.Show("Profile Deleted.");

                Reset(); // Helper to empty textboxes
                LoadData();    // Refresh the grid
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();

            // If the box is empty, load the full list
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                dgvData.DataSource = db.GetProfiles();
            }
            else
            {
                // Otherwise, call our new search method
                dgvData.DataSource = db.SearchByLastName(txtSearch.Text);
            }
        }
    }
    
}
