namespace BookShopWinForm.Features.Epmloyee
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
            dateTimePicker1 = new DateTimePicker();
            tbPrice = new TextBox();
            tbCreateName = new TextBox();
            tbAuthor = new TextBox();
            tbISBN = new TextBox();
            cbGenres = new ComboBox();
            lbDescription = new Label();
            lbPrice = new Label();
            lbPublishDate = new Label();
            lbAuthor = new Label();
            lbGenres = new Label();
            lbName = new Label();
            lbISBN = new Label();
            btnCreate = new Button();
            btnClear = new Button();
            groupAdd.SuspendLayout();
            SuspendLayout();
            // 
            // groupAdd
            // 
            groupAdd.Controls.Add(tbDescription);
            groupAdd.Controls.Add(dateTimePicker1);
            groupAdd.Controls.Add(tbPrice);
            groupAdd.Controls.Add(tbCreateName);
            groupAdd.Controls.Add(tbAuthor);
            groupAdd.Controls.Add(tbISBN);
            groupAdd.Controls.Add(cbGenres);
            groupAdd.Controls.Add(lbDescription);
            groupAdd.Controls.Add(lbPrice);
            groupAdd.Controls.Add(lbPublishDate);
            groupAdd.Controls.Add(lbAuthor);
            groupAdd.Controls.Add(lbGenres);
            groupAdd.Controls.Add(lbName);
            groupAdd.Controls.Add(lbISBN);
            groupAdd.Location = new Point(35, 32);
            groupAdd.Name = "groupAdd";
            groupAdd.Size = new Size(665, 347);
            groupAdd.TabIndex = 1;
            groupAdd.TabStop = false;
            groupAdd.Text = "Create Employee";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(195, 260);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(404, 65);
            tbDescription.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(195, 224);
            dateTimePicker1.MaxDate = new DateTime(2023, 12, 6, 20, 56, 34, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(111, 23);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.Value = new DateTime(2023, 12, 6, 0, 0, 0, 0);
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(195, 187);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(404, 23);
            tbPrice.TabIndex = 11;
            // 
            // tbCreateName
            // 
            tbCreateName.Location = new Point(195, 61);
            tbCreateName.Name = "tbCreateName";
            tbCreateName.Size = new Size(404, 23);
            tbCreateName.TabIndex = 10;
            // 
            // tbAuthor
            // 
            tbAuthor.Location = new Point(195, 145);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(404, 23);
            tbAuthor.TabIndex = 9;
            // 
            // tbISBN
            // 
            tbISBN.Location = new Point(195, 25);
            tbISBN.Name = "tbISBN";
            tbISBN.Size = new Size(404, 23);
            tbISBN.TabIndex = 8;
            // 
            // cbGenres
            // 
            cbGenres.FormattingEnabled = true;
            cbGenres.Location = new Point(195, 105);
            cbGenres.Name = "cbGenres";
            cbGenres.Size = new Size(211, 23);
            cbGenres.TabIndex = 7;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(40, 260);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 6;
            lbDescription.Text = "Description";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(40, 190);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 5;
            lbPrice.Text = "Price";
            // 
            // lbPublishDate
            // 
            lbPublishDate.AutoSize = true;
            lbPublishDate.Location = new Point(40, 228);
            lbPublishDate.Name = "lbPublishDate";
            lbPublishDate.Size = new Size(70, 15);
            lbPublishDate.TabIndex = 4;
            lbPublishDate.Text = "PublishDate";
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.Location = new Point(40, 153);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(44, 15);
            lbAuthor.TabIndex = 3;
            lbAuthor.Text = "Author";
            // 
            // lbGenres
            // 
            lbGenres.AutoSize = true;
            lbGenres.Location = new Point(40, 113);
            lbGenres.Name = "lbGenres";
            lbGenres.Size = new Size(43, 15);
            lbGenres.TabIndex = 2;
            lbGenres.Text = "Genres";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(40, 69);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 1;
            lbName.Text = "Name";
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(40, 32);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(32, 15);
            lbISBN.TabIndex = 0;
            lbISBN.Text = "ISBN";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(499, 397);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(606, 397);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 450);
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
        private TextBox tbDescription;
        private DateTimePicker dateTimePicker1;
        private TextBox tbPrice;
        private TextBox tbCreateName;
        private TextBox tbAuthor;
        private TextBox tbISBN;
        private ComboBox cbGenres;
        private Label lbDescription;
        private Label lbPrice;
        private Label lbPublishDate;
        private Label lbAuthor;
        private Label lbGenres;
        private Label lbName;
        private Label lbISBN;
        private Button btnCreate;
        private Button btnClear;
    }
}