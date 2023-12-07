namespace BookShopWinForm.Features.Books
{
    partial class PageBook
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
            btnGetProduct = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnDetail = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGetProduct
            // 
            btnGetProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetProduct.Location = new Point(874, 14);
            btnGetProduct.Name = "btnGetProduct";
            btnGetProduct.Size = new Size(87, 32);
            btnGetProduct.TabIndex = 13;
            btnGetProduct.Text = "Get Product";
            btnGetProduct.Click += btnGetProduct_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(246, 19);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(132, 19);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(361, 19);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(75, 23);
            btnDetail.TabIndex = 17;
            btnDetail.Text = "Details";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(968, 446);
            dataGridView1.TabIndex = 19;
            // 
            // PageBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 657);
            Controls.Add(dataGridView1);
            Controls.Add(btnDetail);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnGetProduct);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PageBook";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PageBook";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGetProduct;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnDetail;
        private DataGridView dataGridView1;
    }
}