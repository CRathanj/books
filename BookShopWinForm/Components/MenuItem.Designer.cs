namespace BookShopWinForm.Components
{
    partial class MenuItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ImgIcon = new PictureBox();
            btnText = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ImgIcon).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ImgIcon
            // 
            ImgIcon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ImgIcon.Location = new Point(15, 8);
            ImgIcon.Name = "ImgIcon";
            ImgIcon.Size = new Size(37, 31);
            ImgIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            ImgIcon.TabIndex = 0;
            ImgIcon.TabStop = false;
            // 
            // btnText
            // 
            btnText.FlatStyle = FlatStyle.Flat;
            btnText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnText.Location = new Point(-10, 0);
            btnText.Name = "btnText";
            btnText.Padding = new Padding(10, 0, 0, 0);
            btnText.Size = new Size(124, 47);
            btnText.TabIndex = 1;
            btnText.Text = "label1";
            btnText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnText);
            panel1.Location = new Point(74, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 47);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(ImgIcon);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(58, 47);
            panel2.TabIndex = 3;
            // 
            // MenuItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MenuItem";
            Size = new Size(188, 47);
            ((System.ComponentModel.ISupportInitialize)ImgIcon).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ImgIcon;
        private Label btnText;
        private Panel panel1;
        private Panel panel2;
    }
}
