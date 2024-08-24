using MaquinasPrj.Models;
using MaquinasPrj.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinasPrj
{
    public partial class FrmSetor : Form
    {
        DbConnection connection;
        SetorRepositorie setorRep;
        bool add = false;
        bool alterar = false;
        public FrmSetor()
        {
            InitializeComponent();
            connection = new DbConnection();
            setorRep = new SetorRepositorie(connection);
        }

        private void FrmSetor_Load(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNome.Enabled = false;
            btnSalvar.Enabled = false;
            CarregarDados();
        }

        private void HabilitaDel()
        {
            btnDeletar.Enabled = true;
            btnSalvar.Enabled = false;
            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = true;
            txtId.Enabled = true;
            txtNome.Enabled = false;
        }

        private void DesabilitaDel()
        {
            btnDeletar.Enabled = false;
            btnSalvar.Enabled = true;
            btnAdicionar.Enabled = false;
            btnAlterar.Enabled = false;
            txtId.Enabled = false;
            txtNome.Enabled = true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            add = true;
            DesabilitaDel();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterar = true;
            DesabilitaDel();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (add)
            {
                var setor = new Setor(0, txtNome.Text);
                setorRep.AddSetor(setor);
                add = false;
            }
            if (alterar)
            {
                var setor = new Setor(int.Parse(txtId.Text), txtNome.Text);
                setorRep.UpdateSetor(setor);
                alterar = false;
            }

            HabilitaDel();
            CarregarDados();
        }

        private void CarregarDados()
        {
            dgvSetor.DataSource = setorRep.BuscaSetores();
        }

        private void dgvSetor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSetor.Rows[e.RowIndex];
                txtId.Text = row.Cells["Setor Id"].Value.ToString();
                txtNome.Text = row.Cells["Nome"].Value.ToString();
            }

        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text)) { 
            Setor setor = setorRep.BuscaSetor(int.Parse(txtId.Text));
            txtId.Text = setor.SetorId.ToString();
            txtNome.Text = setor.Nome.ToString();
            }

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente excluir esse item?", 
                                                  "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                setorRep.DeleteSetor(int.Parse(txtId.Text));
                CarregarDados();
                HabilitaDel();
                
            }
            
        }
    }
}
