public void btnClose_click(object sender, EventArgs e)
{
    collapseMenu();
}


private void CollapseMenu()
{
    if (this.panelMenu.Width > 200)
    {
        panelMenu.Width = 100;
        pictureBox1.Visible = false;
        btnMenu.Dock = DockStyle.Top;
        foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
        {
            menuButton.Text = "";
            menuButton.Image Align = ContentAlignment.MiddleCenter;
            menuButton.Padding = new Padding(0);
        }
    }

    else
    {
        panelMenu.Width = 230;
        pictureBox1.Visible = true;
        btnMenu.Dock = DockStyle.None;
        foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
        {
            menuButton.Text = "    " + btnMenu.Tag.ToString();
            menuButton.Image Align = ContentAlignment.Middleft;
            menuButton.Padding = new Padding(10, 0, 0, 0);
        }
    }
}