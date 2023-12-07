namespace BookShopWinForm.Features.Customers
{
    partial class FormUpdate
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
            btnUpdate = new Button();
            btnClear = new Button();
            groupUpdate = new GroupBox();
            textId = new TextBox();
            lbId = new Label();
            tbDescription = new TextBox();
            tbName = new TextBox();
            tbAuthor = new TextBox();
            lbDescription = new Label();
            lbAuthor = new Label();
            lbName = new Label();
            groupUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(506, 284);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(612, 284);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // groupUpdate
            // 
            groupUpdate.Controls.Add(textId);
            groupUpdate.Controls.Add(lbId);
            groupUpdate.Controls.Add(tbDescription);
            groupUpdate.Controls.Add(tbName);
            groupUpdate.Controls.Add(tbAuthor);
            groupUpdate.Controls.Add(lbDescription);
            groupUpdate.Controls.Add(lbAuthor);
            groupUpdate.Controls.Add(lbName);
            groupUpdate.Location = new Point(22, 29);
            groupUpdate.Name = "groupUpdate";
            groupUpdate.Size = new Size(665, 233);
            groupUpdate.TabIndex = 3;
            groupUpdate.TabStop = false;
            groupUpdate.Text = "Update Customer";
            // 
            // textId
            // 
            textId.Location = new Point(195, 22);
            textId.Name = "textId";
            textId.Size = new Size(404, 23);
            textId.TabIndex = 10;
            textId.TextChanged += textBox6_TextChanged;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(42, 29);
            lbId.Name = "lbId";
            lbId.Size = new Size(18, 15);
            lbId.TabIndex = 9;
            lbId.Text = "ID";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(195, 145);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(404, 65);
            tbDescription.TabIndex = 13;
            // 
            // tbName
            // 
            tbName.Location = new Point(195, 59);
            tbName.Name = "tbName";
            tbName.Size = new Size(404, 23);
            tbName.TabIndex = 10;
            // 
            // tbAuthor
            // 
            tbAuthor.Location = new Point(195, 101);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(404, 23);
            tbAuthor.TabIndex = 9;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(40, 145);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 6;
            lbDescription.Text = "Description";
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.Location = new Point(40, 109);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(44, 15);
            lbAuthor.TabIndex = 3;
            lbAuthor.Text = "Author";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(40, 67);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 1;
            lbName.Text = "Name";
            // 
            // FormUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 326);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(groupUpdate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUpdate";
            Text = "FormUpdate";
            groupUpdate.ResumeLayout(false);
            groupUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdate;
        private Button btnClear;
        private GroupBox groupUpdate;
        private TextBox tbDescription;
        private TextBox tbName;
        private TextBox tbAuthor;
        private Label lbDescription;
        private Label lbAuthor;
        private Label lbName;
        private TextBox textId;
        private Label lbId;
    }
}