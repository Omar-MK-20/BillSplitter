namespace BillSplitter
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UsersBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            BillBtnForm = new Button();
            SuspendLayout();
            // 
            // UsersBtn
            // 
            UsersBtn.Location = new Point(72, 269);
            UsersBtn.Margin = new Padding(3, 4, 3, 4);
            UsersBtn.Name = "UsersBtn";
            UsersBtn.Size = new Size(136, 31);
            UsersBtn.TabIndex = 0;
            UsersBtn.Text = "Lits of Users";
            UsersBtn.UseVisualStyleBackColor = true;
            UsersBtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 87);
            label1.Name = "label1";
            label1.Size = new Size(215, 54);
            label1.TabIndex = 1;
            label1.Text = "Bill Splitter";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 603);
            label2.Name = "label2";
            label2.Size = new Size(222, 20);
            label2.TabIndex = 2;
            label2.Text = "Copyright Resrved For Omar MK";
            // 
            // BillBtnForm
            // 
            BillBtnForm.Location = new Point(353, 271);
            BillBtnForm.Name = "BillBtnForm";
            BillBtnForm.Size = new Size(137, 29);
            BillBtnForm.TabIndex = 3;
            BillBtnForm.Text = "Bill Calculator";
            BillBtnForm.UseVisualStyleBackColor = true;
            BillBtnForm.Click += BillBtnForm_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 632);
            Controls.Add(BillBtnForm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UsersBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill Splitter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UsersBtn;
        private Label label1;
        private Label label2;
        private Button BillBtnForm;
    }
}
