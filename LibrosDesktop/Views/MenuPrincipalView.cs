

using LibrosDesktop.Views;

namespace LibrosDesktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }



        private void librosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GestionLibrosView gestionLibrosView = new GestionLibrosView();
            gestionLibrosView.ShowDialog();
        }
    }
}
