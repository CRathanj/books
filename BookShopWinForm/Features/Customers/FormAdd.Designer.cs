namespace BookShopWinForm.Features.Customers
{
    partial class FormAdd
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
            groupAdd = new GroupBox();
            tbDescription = new TextBox();
            tbName = new TextBox();
            tbAuthor = new TextBox();
            tbAddress = new Label();
            tbContact = new Label();
            lbName = new Label();
            btnClear = new Button();
            btnCreate = new Button();
            groupAdd.SuspendLayout();
            SuspendLayout();
            // 
            // groupAdd
            // 
            groupAdd.Controls.Add(tbDescription);
            groupAdd.Controls.Add(tbName);
            groupAdd.Controls.Add(tbAuthor);
            groupAdd.Controls.Add(tbAddress);
            groupAdd.Controls.Add(tbContact);
            groupAdd.Controls.Add(lbName);
            groupAdd.Location = new Point(32, 33);
            groupAdd.Name = "groupAdd";
            groupAdd.Size = new Size(665, 212);
            groupAdd.TabIndex = 0;
            groupAdd.TabStop = false;
            groupAdd.Text = "Create Customer";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(195, 124);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(404, 65);
            tbDescription.TabIndex = 13;
            // 
            // tbName
            // 
            tbName.Location = new Point(195, 37);
            tbName.Name = "tbName";
            tbName.Size = new Size(404, 23);
            tbName.TabIndex = 10;
            // 
            // tbAuthor
            // 
            tbAuthor.Location = new Point(195, 77);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(404, 23);
            tbAuthor.TabIndex = 9;
            // 
            // tbAddress
            // 
            tbAddress.AutoSize = true;
            tbAddress.Location = new Point(40, 124);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(49, 15);
            tbAddress.TabIndex = 6;
            tbAddress.Text = "Address";
            // 
            // tbContact
            // 
            tbContact.AutoSize = true;
            tbContact.Location = new Point(40, 84);
            tbContact.Name = "tbContact";
            tbContact.Size = new Size(49, 15);
            tbContact.TabIndex = 3;
            tbContact.Text = "Contact";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(40, 43);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 1;
            lbName.Text = "Name";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(611, 270);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(501, 270);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 321);
            Controls.Add(btnCreate);
            Controls.Add(btnClear);
            Controls.Add(groupAdd);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdd";
            Text = "FormAdd";
            groupAdd.ResumeLayout(false);
            groupAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupAdd;
        private Button btnClear;
        private Button btnCreate;
        private Label tbAddress;
        private Label tbContact;
        private Label lbName;
        private TextBox tbName;
        private TextBox tbAuthor;
        private TextBox tbDescription;
    }
}