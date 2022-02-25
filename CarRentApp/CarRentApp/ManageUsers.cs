using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentApp
{
    public partial class ManageUsers : Form
    {
        private CarRentDbContext _dbContext = new CarRentDbContext();
        private int Id;
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void btResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvUserList.SelectedRows[0].Cells["id"].Value;
                
                // query data base for record
                var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);
                var hashPassword = Utils.DefsultHashPassword();
                user.Password = hashPassword;
                //User.password = hashPassword
                _dbContext.SaveChanges();
                MessageBox.Show("Pasword has been resert");
            }
            catch (Exception)
            {
                MessageBox.Show("Try again");
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var users = _dbContext.Users.Select(x => new
            {
                x.Id,
                x.UserName,
                x.UserRoles.FirstOrDefault().Role.Name,
                //RoleName = x.UserRoles.FirstOrDefault().Role.Name,
                x.IsActive
            }).ToList();
            dgvUserList.DataSource = users;
            dgvUserList.Columns["Id"].Visible = false;
            dgvUserList.Columns["IsActive"].HeaderText = "Active";
            dgvUserList.Columns["Name"].HeaderText = "Role Name";
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void btActivateDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvUserList.SelectedRows[0].Cells["Id"].Value;
                var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);
                if(user != null)
                {
                    user.IsActive = !user.IsActive;
                    _dbContext.SaveChanges();
                    MessageBox.Show("User status has been updated!");
                    PopulateGrid();
                }
                else
                {
                    MessageBox.Show("User not found!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Cannot update user status");
            }
        }

        private void btAddNewUser_Click(object sender, EventArgs e)
        {
            var addNewUser = new AddNewUserForm(this);
            addNewUser.Show();

        }
    }
}
