namespace BookShopWinForm.Features.Epmloyee
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
            groupUpdate = new GroupBox();
            textId = new TextBox();
            lbId = new Label();
            tbDescription = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            tbPrice = new TextBox();
            tbName = new TextBox();
            tbAuthor = new TextBox();
            textISBN = new TextBox();
            cbGenres = new ComboBox();
            lbDescription = new Label();
            lbPrice = new Label();
            lbPublishDate = new Label();
            lbAuthor = new Label();
            lbGenres = new Label();
            lbName = new Label();
            lbISBN = new Label();
            btnUpdate = new Button();
            btnClear = new Button();
            groupUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // groupUpdate
            // 
            groupUpdate.Controls.Add(textId);
            groupUpdate.Controls.Add(lbId);
            groupUpdate.Controls.Add(tbDescription);
            groupUpdate.Controls.Add(dateTimePicker1);
            groupUpdate.Controls.Add(tbPrice);
            groupUpdate.Controls.Add(tbName);
            groupUpdate.Controls.Add(tbAuthor);
            groupUpdate.Controls.Add(textISBN);
            groupUpdate.Controls.Add(cbGenres);
            groupUpdate.Controls.Add(lbDescription);
            groupUpdate.Controls.Add(lbPrice);
            groupUpdate.Controls.Add(lbPublishDate);
            groupUpdate.Controls.Add(lbAuthor);
            groupUpdate.Controls.Add(lbGenres);
            groupUpdate.Controls.Add(lbName);
            groupUpdate.Controls.Add(lbISBN);
            groupUpdate.Location = new Point(30, 25);
            groupUpdate.Name = "groupUpdate";
            groupUpdate.Size = new Size(665, 371);
            groupUpdate.TabIndex = 4;
            groupUpdate.TabStop = false;
            groupUpdate.Text = "Update Books";
            // 
            // textId
            // 
            textId.Location = new Point(195, 22);
            textId.Name = "textId";
            textId.Size = new Size(404, 23);
            textId.TabIndex = 10;
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
            tbDescription.Location = new Point(195, 297);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(404, 65);
            tbDescription.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(195, 261);
            dateTimePicker1.MaxDate = new DateTime(2023, 12, 6, 20, 56, 34, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(111, 23);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.Value = new DateTime(2023, 12, 6, 0, 0, 0, 0);
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(195, 224);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(404, 23);
            tbPrice.TabIndex = 11;
            // 
            // tbName
            // 
            tbName.Location = new Point(195, 98);
            tbName.Name = "tbName";
            tbName.Size = new Size(404, 23);
            tbName.TabIndex = 10;
            // 
            // tbAuthor
            // 
            tbAuthor.Location = new Point(195, 182);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(404, 23);
            tbAuthor.TabIndex = 9;
            // 
            // textISBN
            // 
            textISBN.Location = new Point(195, 62);
            textISBN.Name = "textISBN";
            textISBN.Size = new Size(404, 23);
            textISBN.TabIndex = 8;
            // 
            // cbGenres
            // 
            cbGenres.FormattingEnabled = true;
            cbGenres.Location = new Point(195, 142);
            cbGenres.Name = "cbGenres";
            cbGenres.Size = new Size(211, 23);
            cbGenres.TabIndex = 7;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(40, 297);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 6;
            lbDescription.Text = "Description";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(40, 227);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 5;
            lbPrice.Text = "Price";
            // 
            // lbPublishDate
            // 
            lbPublishDate.AutoSize = true;
            lbPublishDate.Location = new Point(40, 265);
            lbPublishDate.Name = "lbPublishDate";
            lbPublishDate.Size = new Size(70, 15);
            lbPublishDate.TabIndex = 4;
            lbPublishDate.Text = "PublishDate";
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.Location = new Point(40, 190);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(44, 15);
            lbAuthor.TabIndex = 3;
            lbAuthor.Text = "Author";
            // 
            // lbGenres
            // 
            lbGenres.AutoSize = true;
            lbGenres.Location = new Point(40, 150);
            lbGenres.Name = "lbGenres";
            lbGenres.Size = new Size(43, 15);
            lbGenres.TabIndex = 2;
            lbGenres.Text = "Genres";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(40, 106);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 1;
            lbName.Text = "Name";
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(40, 69);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(32, 15);
            lbISBN.TabIndex = 0;
            lbISBN.Text = "ISBN";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(499, 402);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(603, 402);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // FormUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 443);
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

        private GroupBox groupUpdate;
        private TextBox textId;
        private Label lbId;
        private TextBox tbDescription;
        private DateTimePicker dateTimePicker1;
        private TextBox tbPrice;
        private TextBox tbName;
        private TextBox tbAuthor;
        private TextBox textISBN;
        private ComboBox cbGenres;
        private Label lbDescription;
        private Label lbPrice;
        private Label lbPublishDate;
        private Label lbAuthor;
        private Label lbGenres;
        private Label lbName;
        private Label lbISBN;
        private Button btnUpdate;
        private Button btnClear;
    }
}