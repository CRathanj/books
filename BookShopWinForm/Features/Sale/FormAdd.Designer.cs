namespace BookShopWinForm.Features.Sale
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
            btnAddItem = new Button();
            tbQuantity = new TextBox();
            label1 = new Label();
            tbPrice = new TextBox();
            tbName = new TextBox();
            tbISBN = new TextBox();
            lbPrice = new Label();
            lbId = new Label();
            lbISBN = new Label();
            btnClear = new Button();
            btnCreate = new Button();
            dgvSale = new DataGridView();
            lbName = new Label();
            lbTotal = new Label();
            groupAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSale).BeginInit();
            SuspendLayout();
            // 
            // groupAdd
            // 
            groupAdd.Controls.Add(btnAddItem);
            groupAdd.Controls.Add(tbQuantity);
            groupAdd.Controls.Add(label1);
            groupAdd.Controls.Add(tbPrice);
            groupAdd.Controls.Add(tbName);
            groupAdd.Controls.Add(tbISBN);
            groupAdd.Controls.Add(lbPrice);
            groupAdd.Controls.Add(lbId);
            groupAdd.Controls.Add(lbISBN);
            groupAdd.Location = new Point(32, 21);
            groupAdd.Name = "groupAdd";
            groupAdd.Size = new Size(665, 183);
            groupAdd.TabIndex = 0;
            groupAdd.TabStop = false;
            groupAdd.Text = "Create Sales";
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(554, 31);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 3;
            btnAddItem.Text = "Add";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(158, 104);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(359, 23);
            tbQuantity.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 112);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 12;
            label1.Text = "Quantity";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(158, 151);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(359, 23);
            tbPrice.TabIndex = 11;
            // 
            // tbName
            // 
            tbName.Location = new Point(158, 61);
            tbName.Name = "tbName";
            tbName.Size = new Size(359, 23);
            tbName.TabIndex = 10;
            // 
            // tbISBN
            // 
            tbISBN.Location = new Point(158, 25);
            tbISBN.Name = "tbISBN";
            tbISBN.Size = new Size(359, 23);
            tbISBN.TabIndex = 8;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(40, 154);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 5;
            lbPrice.Text = "Price";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(40, 33);
            lbId.Name = "lbId";
            lbId.Size = new Size(17, 15);
            lbId.TabIndex = 1;
            lbId.Text = "Id";
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Location = new Point(41, 69);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(32, 15);
            lbISBN.TabIndex = 0;
            lbISBN.Text = "ISBN";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(616, 398);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(509, 398);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvSale
            // 
            dgvSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSale.Location = new Point(32, 222);
            dgvSale.Name = "dgvSale";
            dgvSale.Size = new Size(665, 161);
            dgvSale.TabIndex = 14;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.Location = new Point(51, 398);
            lbName.Name = "lbName";
            lbName.Size = new Size(45, 21);
            lbName.TabIndex = 15;
            lbName.Text = "Total:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotal.Location = new Point(107, 399);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(49, 21);
            lbTotal.TabIndex = 16;
            lbTotal.Text = "0.00$";
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 443);
            Controls.Add(lbTotal);
            Controls.Add(lbName);
            Controls.Add(dgvSale);
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
            ((System.ComponentModel.ISupportInitialize)dgvSale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupAdd;
        private Button btnClear;
        private Button btnCreate;
        private Label lbPrice;
        private Label lbId;
        private Label lbISBN;
        private TextBox tbName;
        private TextBox tbISBN;
        private TextBox tbPrice;
        private TextBox tbQuantity;
        private Label label1;
        private Button btnAddItem;
        private DataGridView dgvSale;
        private Label lbName;
        private Label lbTotal;
    }
}