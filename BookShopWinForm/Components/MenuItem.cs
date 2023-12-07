namespace BookShopWinForm.Components
{
    public partial class MenuItem : UserControl
    {
        public EventHandler ClickItem { get; set; }
        public MenuItem()
        {
            InitializeComponent();
            ImgIcon.Click += MenuItem_Click;
            btnText.Click += MenuItem_Click;
            panel1.Click += MenuItem_Click;
            panel2.Click += MenuItem_Click;
        }

        public Image ImageResource { get => ImgIcon.Image; set => ImgIcon.Image = value; }
        public String TextTitle { get => btnText.Text; set => btnText.Text = value; }


        private void MenuItem_Click(object sender, EventArgs e)
        {
            ClickItem?.Invoke(this, EventArgs.Empty);
        }
    }
}
