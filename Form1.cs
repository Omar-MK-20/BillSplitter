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
    public partial class Main : Form
    {
        ApplicationDbContext context;
        public EmployeesService employeesService;

        public Main()
        {
            InitializeComponent();
            employeesService = new EmployeesService(context);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BillBtnForm_Click(object sender, EventArgs e)
        {
            BillCalculator billCalculator = new BillCalculator();
            billCalculator.Show();
        }
    }
}
