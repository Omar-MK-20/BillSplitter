using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BillSplitter
{
    public partial class BillCalculator : Form
    {
        ApplicationDbContext context;
        public EmployeesService employeesService;
        Dictionary<string, List<float>> UserDic = new Dictionary<string, List<float>>();

        public BillCalculator()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            employeesService = new EmployeesService(context);
            LoadData();
        }

        public void LoadData()
        {
            context = new ApplicationDbContext();
            employeesService = new EmployeesService(context);
            var employees = employeesService.GetAll();
            for (int i = 0; i < employees.Count; i++)
            {
                ListNames.Items.Add(employees[i].Name);
                ChListBoxNames.Items.Add(employees[i].Name);
                UserDic.Add(employees[i].Name, new List<float> { 0, 0, 0 });
                //Console.WriteLine(UserDic[employees[i].Name]);
            }
        }

        private void AddPrice_Click(object sender, EventArgs e)
        {
            try
            {
                float price = float.Parse(TxtPrice.Text);
                var numOfUsers = ChListBoxNames.CheckedItems.Count;
                var devPrice = price / numOfUsers;

                foreach (string user in ChListBoxNames.CheckedItems)
                {
                    UserDic[user][0] += devPrice;
                }
                TxtPrice.Text = string.Empty;
                CalculateBill();
                DisplayDic(UserDic);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddPayment_Click(object sender, EventArgs e)
        {
            try
            {
                float money = float.Parse(TxtMoney.Text);
                var user = ListNames.SelectedItem as string;
                if (user is null)
                {
                    MessageBox.Show("Select a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UserDic[user][1] = money;
                    Console.WriteLine(UserDic[user]);
                }
                TxtMoney.Text = string.Empty;
                CalculateBill();
                DisplayDic(UserDic);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void CalculateBill()
        {
            foreach (string user in UserDic.Keys)
            {
                UserDic[user][2] = UserDic[user][1] - UserDic[user][0];
            }
        }

        public void DisplayDic(Dictionary<string, List<float>> data)
        {
            // Create a DataTable
            var table = new DataTable();

            // Add columns
            table.Columns.Add("Name", typeof(string)); // Key column
            int maxValues = data.Values.Any() ? data.Values.Max(list => list.Count) : 0;
            List<string> titles = new List<string> { "Required", "Paid", "Remaining"};
            for (int i = 0; i < maxValues; i++)
            {
                table.Columns.Add($"{titles[i]}", typeof(float));
            }

            // Populate rows
            foreach (var kvp in data)
            {
                if (kvp.Value[0] == 0 && kvp.Value[1] == 0 && kvp.Value[2] == 0)
                {
                    continue;
                }
                var row = table.NewRow();
                row["Name"] = kvp.Key;

                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    row[$"{titles[i]}"] = kvp.Value[i];
                }

                table.Rows.Add(row);
            }

            // Bind to DataGridView
            dTable.DataSource = table;
        }

        private void CalcTotals_Click(object sender, EventArgs e)
        {
            CalculateBill();
            DisplayDic(UserDic);
        }
    }
}
