namespace MaquinasPrj
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void setorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var setor = new FrmSetor();
            setor.MdiParent = this;
            setor.Show();
        }

        private void maquinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var maquina = new FrmMaquina();
            maquina.MdiParent = this;
            maquina.Show();
        }
    }
}
