namespace BillSplitter
{
    partial class Users
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
            LblNames = new Label();
            TextName = new TextBox();
            AddNameBtn = new Button();
            listNames = new ListBox();
            UpdateUserBtn = new Button();
            DeleteUserBtn = new Button();
            SuspendLayout();
            // 
            // LblNames
            // 
            LblNames.AutoSize = true;
            LblNames.Location = new Point(79, 46);
            LblNames.Name = "LblNames";
            LblNames.Size = new Size(55, 20);
            LblNames.TabIndex = 0;
            LblNames.Text = "Names";
            // 
            // TextName
            // 
            TextName.Location = new Point(262, 82);
            TextName.Name = "TextName";
            TextName.Size = new Size(125, 27);
            TextName.TabIndex = 3;
            TextName.TextChanged += TextName_TextChanged;
            // 
            // AddNameBtn
            // 
            AddNameBtn.Location = new Point(262, 156);
            AddNameBtn.Name = "AddNameBtn";
            AddNameBtn.Size = new Size(125, 29);
            AddNameBtn.TabIndex = 4;
            AddNameBtn.Text = "Add User";
            AddNameBtn.UseVisualStyleBackColor = true;
            AddNameBtn.Click += AddName_Click;
            // 
            // listNames
            // 
            listNames.FormattingEnabled = true;
            listNames.HorizontalScrollbar = true;
            listNames.Location = new Point(79, 82);
            listNames.Name = "listNames";
            listNames.Size = new Size(150, 284);
            listNames.TabIndex = 5;
            // 
            // UpdateUserBtn
            // 
            UpdateUserBtn.Location = new Point(262, 221);
            UpdateUserBtn.Name = "UpdateUserBtn";
            UpdateUserBtn.Size = new Size(125, 29);
            UpdateUserBtn.TabIndex = 6;
            UpdateUserBtn.Text = "Update User";
            UpdateUserBtn.UseVisualStyleBackColor = true;
            UpdateUserBtn.Click += UpdateUserBtn_Click;
            // 
            // DeleteUserBtn
            // 
            DeleteUserBtn.Location = new Point(262, 283);
            DeleteUserBtn.Name = "DeleteUserBtn";
            DeleteUserBtn.Size = new Size(125, 29);
            DeleteUserBtn.TabIndex = 7;
            DeleteUserBtn.Text = "Delete User";
            DeleteUserBtn.UseVisualStyleBackColor = true;
            DeleteUserBtn.Click += DeleteUserBtn_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 433);
            Controls.Add(DeleteUserBtn);
            Controls.Add(UpdateUserBtn);
            Controls.Add(listNames);
            Controls.Add(AddNameBtn);
            Controls.Add(TextName);
            Controls.Add(LblNames);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNames;
        private TextBox TextName;
        private Button AddNameBtn;
        private ListBox listNames;
        private Button UpdateUserBtn;
        private Button DeleteUserBtn;
    }
}