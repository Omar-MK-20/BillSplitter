namespace BillSplitter
{
    partial class BillCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChListBoxNames = new CheckedListBox();
            TxtPrice = new TextBox();
            LblPrice = new Label();
            LblWhoShared = new Label();
            AddPrice = new Button();
            CalcTotals = new Button();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            ListNames = new ListBox();
            LblPaid = new Label();
            LblMoney = new Label();
            AddPayment = new Button();
            TxtMoney = new TextBox();
            dTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dTable).BeginInit();
            SuspendLayout();
            // 
            // ChListBoxNames
            // 
            ChListBoxNames.FormattingEnabled = true;
            ChListBoxNames.Location = new Point(39, 62);
            ChListBoxNames.Name = "ChListBoxNames";
            ChListBoxNames.Size = new Size(150, 224);
            ChListBoxNames.TabIndex = 0;
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(236, 62);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(125, 27);
            TxtPrice.TabIndex = 1;
            // 
            // LblPrice
            // 
            LblPrice.AutoSize = true;
            LblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblPrice.Location = new Point(236, 26);
            LblPrice.Name = "LblPrice";
            LblPrice.Size = new Size(47, 20);
            LblPrice.TabIndex = 2;
            LblPrice.Text = "Price:";
            // 
            // LblWhoShared
            // 
            LblWhoShared.AutoSize = true;
            LblWhoShared.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblWhoShared.Location = new Point(39, 26);
            LblWhoShared.Name = "LblWhoShared";
            LblWhoShared.Size = new Size(98, 20);
            LblWhoShared.TabIndex = 3;
            LblWhoShared.Text = "Who Shared:";
            // 
            // AddPrice
            // 
            AddPrice.Location = new Point(236, 120);
            AddPrice.Name = "AddPrice";
            AddPrice.Size = new Size(125, 29);
            AddPrice.TabIndex = 4;
            AddPrice.Text = "Add Bill";
            AddPrice.UseVisualStyleBackColor = true;
            AddPrice.Click += AddPrice_Click;
            // 
            // CalcTotals
            // 
            CalcTotals.Location = new Point(324, 274);
            CalcTotals.Name = "CalcTotals";
            CalcTotals.Size = new Size(270, 60);
            CalcTotals.TabIndex = 5;
            CalcTotals.Text = "Calculate Totals";
            CalcTotals.UseVisualStyleBackColor = true;
            CalcTotals.Click += CalcTotals_Click;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // ListNames
            // 
            ListNames.FormattingEnabled = true;
            ListNames.Location = new Point(505, 60);
            ListNames.Name = "ListNames";
            ListNames.Size = new Size(150, 184);
            ListNames.TabIndex = 6;
            // 
            // LblPaid
            // 
            LblPaid.AutoSize = true;
            LblPaid.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblPaid.Location = new Point(505, 26);
            LblPaid.Name = "LblPaid";
            LblPaid.Size = new Size(80, 20);
            LblPaid.TabIndex = 7;
            LblPaid.Text = "Who Paid:";
            // 
            // LblMoney
            // 
            LblMoney.AutoSize = true;
            LblMoney.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LblMoney.Location = new Point(707, 26);
            LblMoney.Name = "LblMoney";
            LblMoney.Size = new Size(61, 20);
            LblMoney.TabIndex = 8;
            LblMoney.Text = "Money:";
            // 
            // AddPayment
            // 
            AddPayment.Location = new Point(707, 120);
            AddPayment.Name = "AddPayment";
            AddPayment.Size = new Size(125, 29);
            AddPayment.TabIndex = 9;
            AddPayment.Text = "Add Payment";
            AddPayment.UseVisualStyleBackColor = true;
            AddPayment.Click += AddPayment_Click;
            // 
            // TxtMoney
            // 
            TxtMoney.Location = new Point(707, 62);
            TxtMoney.Name = "TxtMoney";
            TxtMoney.Size = new Size(125, 27);
            TxtMoney.TabIndex = 10;
            // 
            // dTable
            // 
            dTable.AllowUserToAddRows = false;
            dTable.AllowUserToDeleteRows = false;
            dTable.ColumnHeadersHeight = 29;
            dTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            dTable.Location = new Point(174, 348);
            dTable.Name = "dTable";
            dTable.ReadOnly = true;
            dTable.RowHeadersWidth = 51;
            dTable.Size = new Size(565, 258);
            dTable.TabIndex = 11;
            dTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BillCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 618);
            Controls.Add(dTable);
            Controls.Add(TxtMoney);
            Controls.Add(AddPayment);
            Controls.Add(LblMoney);
            Controls.Add(LblPaid);
            Controls.Add(ListNames);
            Controls.Add(CalcTotals);
            Controls.Add(AddPrice);
            Controls.Add(LblWhoShared);
            Controls.Add(LblPrice);
            Controls.Add(TxtPrice);
            Controls.Add(ChListBoxNames);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "BillCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill Calculator";
            ((System.ComponentModel.ISupportInitialize)dTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox ChListBoxNames;
        private TextBox TxtPrice;
        private Label LblPrice;
        private Label LblWhoShared;
        private Button AddPrice;
        private Button CalcTotals;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private ListBox ListNames;
        private Label LblPaid;
        private Label LblMoney;
        private Button AddPayment;
        private TextBox TxtMoney;
        private DataGridView dTable;
    }
}