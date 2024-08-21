using CiclismoDesktopPorCodigo.Views;
using CiclismoDesktopPorCodigo.Views.Linq;

namespace CiclismoDesktopPorCodigo
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesView clientesView = new ClientesView();
            clientesView.ShowDialog();
        }

        private void gestionarClientesStoredProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesStoredProceduresView clientesStoreProceduresView = new ClientesStoredProceduresView();
            clientesStoreProceduresView.ShowDialog();
        }

        private void gestionarClientesORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesORMView clientesORMView = new ClientesORMView();
            clientesORMView.ShowDialog();
        }

        private void pruebasConLinqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruebasLinqView pruebasLinqView = new PruebasLinqView();
            pruebasLinqView.ShowDialog();
        }
    }
}
