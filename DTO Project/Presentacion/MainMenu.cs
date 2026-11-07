using DTO_Project.Presentacion;

namespace DTO_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomize_Click(object sender, EventArgs e)
        {
            CreateMenu createMenu = new CreateMenu();
            createMenu.Show();
            this.Hide();
        }
    }
}
