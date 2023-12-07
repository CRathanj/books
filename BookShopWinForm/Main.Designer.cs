namespace BookShopWinForm;

partial class Main
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
        flowLayoutPanel1 = new FlowLayoutPanel();
        logo = new Panel();
        picLogo = new PictureBox();
        menuItemSale = new Components.MenuItem();
        menuItemBook = new Components.MenuItem();
        menuItemCustomer = new Components.MenuItem();
        menuItemEmployee = new Components.MenuItem();
        panel1 = new Panel();
        lblTitle = new Label();
        panelMainPage = new Panel();
        menuItemReport = new Components.MenuItem();
        flowLayoutPanel1.SuspendLayout();
        logo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.BackColor = Color.Silver;
        flowLayoutPanel1.Controls.Add(logo);
        flowLayoutPanel1.Controls.Add(menuItemSale);
        flowLayoutPanel1.Controls.Add(menuItemBook);
        flowLayoutPanel1.Controls.Add(menuItemCustomer);
        flowLayoutPanel1.Controls.Add(menuItemEmployee);
        flowLayoutPanel1.Controls.Add(menuItemReport);
        flowLayoutPanel1.Dock = DockStyle.Left;
        flowLayoutPanel1.Location = new Point(0, 0);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(173, 676);
        flowLayoutPanel1.TabIndex = 1;
        // 
        // logo
        // 
        logo.Controls.Add(picLogo);
        logo.Dock = DockStyle.Top;
        logo.Location = new Point(3, 3);
        logo.Name = "logo";
        logo.Size = new Size(167, 100);
        logo.TabIndex = 0;
        // 
        // picLogo
        // 
        picLogo.BackColor = Color.Transparent;
        picLogo.Dock = DockStyle.Fill;
        picLogo.Image = Properties.Resources.logo_removebg_preview;
        picLogo.InitialImage = null;
        picLogo.Location = new Point(0, 0);
        picLogo.Name = "picLogo";
        picLogo.Size = new Size(167, 100);
        picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        picLogo.TabIndex = 0;
        picLogo.TabStop = false;
        // 
        // menuItemSale
        // 
        menuItemSale.BackColor = Color.WhiteSmoke;
        menuItemSale.ClickItem = null;
        menuItemSale.ForeColor = SystemColors.ActiveCaptionText;
        menuItemSale.ImageResource = Properties.Resources.sale;
        menuItemSale.Location = new Point(3, 109);
        menuItemSale.Name = "menuItemSale";
        menuItemSale.Size = new Size(167, 48);
        menuItemSale.TabIndex = 11;
        menuItemSale.TextTitle = "Sale";
        // 
        // menuItemBook
        // 
        menuItemBook.BackColor = Color.WhiteSmoke;
        menuItemBook.ClickItem = null;
        menuItemBook.ForeColor = SystemColors.ActiveCaptionText;
        menuItemBook.ImageResource = Properties.Resources.book;
        menuItemBook.Location = new Point(3, 163);
        menuItemBook.Name = "menuItemBook";
        menuItemBook.Size = new Size(167, 48);
        menuItemBook.TabIndex = 12;
        menuItemBook.TextTitle = "Books";
        // 
        // menuItemCustomer
        // 
        menuItemCustomer.BackColor = Color.WhiteSmoke;
        menuItemCustomer.ClickItem = null;
        menuItemCustomer.ForeColor = SystemColors.ActiveCaptionText;
        menuItemCustomer.ImageResource = Properties.Resources.customer;
        menuItemCustomer.Location = new Point(3, 217);
        menuItemCustomer.Name = "menuItemCustomer";
        menuItemCustomer.Size = new Size(167, 48);
        menuItemCustomer.TabIndex = 13;
        menuItemCustomer.TextTitle = "Customers";
        // 
        // menuItemEmployee
        // 
        menuItemEmployee.BackColor = Color.WhiteSmoke;
        menuItemEmployee.ClickItem = null;
        menuItemEmployee.ForeColor = SystemColors.ActiveCaptionText;
        menuItemEmployee.ImageResource = Properties.Resources.member;
        menuItemEmployee.Location = new Point(3, 271);
        menuItemEmployee.Name = "menuItemEmployee";
        menuItemEmployee.Size = new Size(167, 48);
        menuItemEmployee.TabIndex = 17;
        menuItemEmployee.TextTitle = "Employee";
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(224, 224, 224);
        panel1.Controls.Add(lblTitle);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(173, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(705, 55);
        panel1.TabIndex = 11;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblTitle.Location = new Point(17, 24);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(0, 20);
        lblTitle.TabIndex = 0;
        // 
        // panelMainPage
        // 
        panelMainPage.Dock = DockStyle.Fill;
        panelMainPage.Location = new Point(173, 55);
        panelMainPage.Name = "panelMainPage";
        panelMainPage.Size = new Size(705, 621);
        panelMainPage.TabIndex = 12;
        // 
        // menuItemReport
        // 
        menuItemReport.BackColor = Color.WhiteSmoke;
        menuItemReport.ClickItem = null;
        menuItemReport.ForeColor = SystemColors.ActiveCaptionText;
        menuItemReport.ImageResource = Properties.Resources.report;
        menuItemReport.Location = new Point(3, 325);
        menuItemReport.Name = "menuItemReport";
        menuItemReport.Size = new Size(167, 48);
        menuItemReport.TabIndex = 18;
        menuItemReport.TextTitle = "Reports";
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(878, 676);
        Controls.Add(panelMainPage);
        Controls.Add(panel1);
        Controls.Add(flowLayoutPanel1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MinimumSize = new Size(700, 500);
        Name = "Main";
        Text = "Main";
        WindowState = FormWindowState.Maximized;
        flowLayoutPanel1.ResumeLayout(false);
        logo.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private FlowLayoutPanel flowLayoutPanel1;
    private Panel logo;
    private Button button1;
    private Button button2;
    private Button button3;
    private Components.MenuItem menuItemSale;
    private Components.MenuItem menuItemBook;
    private Components.MenuItem menuItemCustomer;
    private Components.MenuItem menuItemEmployee;
    private PictureBox picLogo;
    private Panel panel1;
    private Label lblTitle;
    private Panel panelMainPage;
    private Components.MenuItem menuItemReport;
}
