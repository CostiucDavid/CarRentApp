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
                //var user = dbContext.Users.firstOrDefault(x => x.id == id);
                var hashPassword = Utils.DefsultHashPassword();
                //User.password = hashPassword
                //dbContext.SaveChanges();
                MessageBox.Show("Pasword has been resert");
            }
            catch (Exception)
            {
                MessageBox.Show("Try again");
            }
        }
    }
}
