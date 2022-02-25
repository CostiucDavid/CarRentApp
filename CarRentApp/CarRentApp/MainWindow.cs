using CarRentApp.Entities;
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
    public partial class MainWindow : Form
    {
       
        private LoginForm _login;
        public string roleName;
        public User user;
        private CarRentDbContext _dbContext = new CarRentDbContext();
        public MainWindow()
        {
            InitializeComponent();
        } 
        public MainWindow(LoginForm loginForm,  User userModel)
        {
            InitializeComponent();
           _login = loginForm;
            user = userModel;
            roleName = "Admin"; // Get role from user
            //MessageBox.Show(this.user + "" + roleName);
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!Utils.FormIsOpen("ManageUsers"))
            {
                var manageUsers = new ManageUsers();
                //manageUsers.MdiParent = this;
                manageUsers.Show();
            }
        }

        
        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddEditRentalForm"))
            {
                var addRentalForm = new AddEditRentalForm();
                //manageUsers.MdiParent = this;
                addRentalForm.Show();
            }
        }

        private void editRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = (int)dgvRentalRecord.SelectedRows[0].Cells["Id"].Value;
            if (index < 0)
            {
                MessageBox.Show("Please select an item from the Grid");
            }
            else
            {
                var carRentalRecord = _dbContext.CarRentalRecords.FirstOrDefault(x => x.Id == index);
                if (carRentalRecord != null)
                {
                    if (!Utils.FormIsOpen("AddEditRentalForm"))
                    {
                        var addRentalForm = new AddEditRentalForm(carRentalRecord);
                        //manageUsers.MdiParent = this;
                        addRentalForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Record is missing");
                }
            }
            if (!Utils.FormIsOpen("AddEditRentalForm"))
            {
                CarRentalRecord carRentalRecord = new CarRentalRecord();
                var addRentalForm = new AddEditRentalForm(carRentalRecord);
                //manageUsers.MdiParent = this;
                addRentalForm.Show();
                
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Load CarRecordsGrid
            var carRecords = _dbContext.CarRentalRecords
                .Select(x => new
                {
                    x.CustomerName,
                    x.Cost,
                    x.DateRented,
                    x.DateReturned,
                    x.Id,
                    Car = x.TypesOfCar.Make + " " + x.TypesOfCar.Model,
                    x.TypesOfCarId
                }).ToList();
            
            dgvRentalRecord.DataSource = carRecords;
            dgvRentalRecord.Columns["Id"].Visible = false; // скрываем колонку
            dgvRentalRecord.Columns["TypesOfCarId"].Visible = false;
        }

        private void viewArhiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("SearchArchiveForm"))
            {
                var searchArchivedForm = new SearchArchiveForm();
                searchArchivedForm.Show();
            }
        }
    }
}
