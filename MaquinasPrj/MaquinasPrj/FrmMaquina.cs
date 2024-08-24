using MaquinasPrj.Models;
using MaquinasPrj.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinasPrj
{
    public partial class FrmMaquina : Form
    {
        private DbConnection _connection;
        SetorRepositorie setorRep;
        MaquinaRepository maqRep;
        bool add = false;
        bool alterar = false;
        public FrmMaquina()
        {
            InitializeComponent();
            _connection = new DbConnection();
            setorRep = new SetorRepositorie(_connection);
            maqRep = new MaquinaRepository(_connection);
        }



        private void FrmMaquina_Load(object sender, EventArgs e)
        {
            HabilitaDel();
            CarregaDados();
        }

        private void HabilitaDel()
        {
            txtId.Enabled = true;
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            txtFabricante.Enabled = false;
            dtpDataAquisicao.Enabled = false;
            cmbSetor.Enabled = false;
            btnSalvar.Enabled = false;
            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = true;
            btnDeletar.Enabled = true;
        }

        private void DesabilitaDel()
        {
            txtId.Enabled = false;
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            txtFabricante.Enabled = true;
            dtpDataAquisicao.Enabled = true;
            cmbSetor.Enabled = true;
            btnSalvar.Enabled = true;
            btnAdicionar.Enabled = false;
            btnAlterar.Enabled = false;
            btnDeletar.Enabled = false;
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
                var maquina = new Maquina(0, txtNome.Text, txtDescricao.Text, txtFabricante.Text, dtpDataAquisicao.Text, int.Parse(cmbSetor.SelectedValue.ToString()), setorRep.BuscaSetor(int.Parse(cmbSetor.SelectedValue.ToString())));
                maqRep.AddMaquina(maquina);
                add = false;
            }
            if (alterar)
            {
                var maquina = new Maquina(int.Parse(txtId.Text), txtNome.Text, txtDescricao.Text, txtFabricante.Text, dtpDataAquisicao.Text, int.Parse(cmbSetor.SelectedValue.ToString()), setorRep.BuscaSetor(int.Parse(cmbSetor.SelectedValue.ToString())));
                maqRep.UpdateMaquina(maquina);
                alterar = false;
            }
            HabilitaDel();
            CarregaDados();
        }

        public void CarregaDados()
        {
            dgvMaquina.DataSource = maqRep.BuscaMaquinas();
            cmbSetor.DataSource = setorRep.BuscaSetores();
            cmbSetor.SelectedIndex = -1;
            cmbSetor.ValueMember = "SetorId";
            cmbSetor.DisplayMember = "Nome";
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult resut = MessageBox.Show("Deseja realmente excluir essa maquina?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resut == DialogResult.Yes)
            {
                maqRep.DeleteMaquina(int.Parse(txtId.Text));
                CarregaDados();
                HabilitaDel();
            }
        }

        private void dgvMaquina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMaquina.Rows[e.RowIndex];
                txtId.Text = row.Cells["Maquina Id"].Value.ToString();
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtDescricao.Text = row.Cells["Descricao"].Value.ToString();
                txtFabricante.Text = row.Cells["Fabricante"].Value.ToString();
                dtpDataAquisicao.Text = row.Cells["Data de aquisicao"].Value.ToString();
                cmbSetor.SelectedValue = row.Cells["Setor Id"].Value;
            }
        }
        private void txtId_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                Maquina maquina = maqRep.BuscaMaquina(int.Parse(txtId.Text));
                txtId.Text = maquina.MaquinaId.ToString();
                txtNome.Text = maquina.Nome.ToString();
                txtDescricao.Text = maquina.Descricao.ToString();
                txtFabricante.Text = maquina.Fabricante.ToString();
                dtpDataAquisicao.Text = maquina.ToString();
                cmbSetor.SelectedValue = maquina.SetorId;
            }
        }
    }
}
