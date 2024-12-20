using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillSplitter
{
    public partial class Users : Form
    {
        ApplicationDbContext context;
        public EmployeesService employeesService;
        public Label LblResult = new Label();

        public Users()
        {
            InitializeComponent();
            LoadData();
            EditComponent();
            context = new ApplicationDbContext();
            employeesService = new EmployeesService(context);
        }

        private void AddName_Click(object sender, EventArgs e)
        {
            var newName = TextName.Text;
            if (context.Employees.SingleOrDefault(e => e.Name == newName) is not null || string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Enter a valid Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                employeesService.Add(newName);
                string result = "Add Successful";
                LblResult.Text = result;
                LoadData();
            }
        }

        public void LoadData()
        {
            context = new ApplicationDbContext();
            employeesService = new EmployeesService(context);
            var employees = employeesService.GetAll();
            string[] empNames = new string[employees.Count];
            for (int i = 0; i < employees.Count; i++)
            {
                empNames[i] += employees[i].Name;
            }
            listNames.DataSource = empNames;
        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateUserBtn_Click(object sender, EventArgs e)
        {
            var oldName = listNames.SelectedItem as string;
            var newName = TextName.Text;

            if (oldName is null || string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Enter a User first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (context.Employees.SingleOrDefault(e => e.Name == newName) is not null)
            {
                MessageBox.Show("User already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = employeesService.Update(oldName, newName);
                LblResult.Text = result;
                LoadData();

            }
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            var oldName = listNames.SelectedItem as string;
            if (oldName is null)
            {
                MessageBox.Show("Select a User first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string result =  employeesService.Delete(oldName);
                LblResult.Text = result;
                LoadData();
            }
            
        }

        public void EditComponent()
        {
            LblResult.Size = new Size(200, 20);
            LblResult.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            LblResult.Visible = true;
            this.Controls.Add(LblResult);
        }
    }
}
