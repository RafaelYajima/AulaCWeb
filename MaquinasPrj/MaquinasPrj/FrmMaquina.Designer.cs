namespace MaquinasPrj
{
    partial class FrmMaquina
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblId = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            lblNome = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            txtFabricante = new TextBox();
            lblFabricante = new Label();
            lblData = new Label();
            lblSetor = new Label();
            cmbSetor = new ComboBox();
            btnAdicionar = new Button();
            btnAlterar = new Button();
            btnDeletar = new Button();
            btnSalvar = new Button();
            dgvMaquina = new DataGridView();
            maquinaBindingSource1 = new BindingSource(components);
            dtpDataAquisicao = new DateTimePicker();
            maquinaBindingSource = new BindingSource(components);
            maquinaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fabricanteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataAquisicaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            setorIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Setor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMaquina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maquinaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maquinaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(42, 33);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(42, 51);
            txtId.Name = "txtId";
            txtId.Size = new Size(60, 23);
            txtId.TabIndex = 1;
            txtId.Leave += txtId_Leave;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(125, 51);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(219, 23);
            txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(125, 33);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(42, 104);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(367, 23);
            txtDescricao.TabIndex = 5;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(42, 86);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição";
            // 
            // txtFabricante
            // 
            txtFabricante.Location = new Point(42, 159);
            txtFabricante.Name = "txtFabricante";
            txtFabricante.Size = new Size(181, 23);
            txtFabricante.TabIndex = 7;
            // 
            // lblFabricante
            // 
            lblFabricante.AutoSize = true;
            lblFabricante.Location = new Point(42, 141);
            lblFabricante.Name = "lblFabricante";
            lblFabricante.Size = new Size(62, 15);
            lblFabricante.TabIndex = 6;
            lblFabricante.Text = "Fabricante";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(42, 196);
            lblData.Name = "lblData";
            lblData.Size = new Size(84, 15);
            lblData.TabIndex = 8;
            lblData.Text = "Data aquisição";
            // 
            // lblSetor
            // 
            lblSetor.AutoSize = true;
            lblSetor.Location = new Point(171, 197);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(34, 15);
            lblSetor.TabIndex = 10;
            lblSetor.Text = "Setor";
            // 
            // cmbSetor
            // 
            cmbSetor.FormattingEnabled = true;
            cmbSetor.Location = new Point(171, 215);
            cmbSetor.Name = "cmbSetor";
            cmbSetor.Size = new Size(189, 23);
            cmbSetor.TabIndex = 11;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(25, 268);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 12;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(129, 268);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 13;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(238, 268);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 14;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(334, 268);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dgvMaquina
            // 
            dgvMaquina.AutoGenerateColumns = false;
            dgvMaquina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaquina.Columns.AddRange(new DataGridViewColumn[] { maquinaIdDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn, fabricanteDataGridViewTextBoxColumn, dataAquisicaoDataGridViewTextBoxColumn, setorIdDataGridViewTextBoxColumn, Setor });
            dgvMaquina.DataSource = maquinaBindingSource1;
            dgvMaquina.EnableHeadersVisualStyles = false;
            dgvMaquina.Location = new Point(12, 324);
            dgvMaquina.Name = "dgvMaquina";
            dgvMaquina.RowTemplate.Height = 25;
            dgvMaquina.Size = new Size(429, 150);
            dgvMaquina.TabIndex = 16;
            dgvMaquina.CellDoubleClick += dgvMaquina_CellDoubleClick;
            // 
            // maquinaBindingSource1
            // 
            maquinaBindingSource1.DataSource = typeof(Models.Maquina);
            // 
            // dtpDataAquisicao
            // 
            dtpDataAquisicao.Format = DateTimePickerFormat.Short;
            dtpDataAquisicao.Location = new Point(42, 215);
            dtpDataAquisicao.Name = "dtpDataAquisicao";
            dtpDataAquisicao.Size = new Size(122, 23);
            dtpDataAquisicao.TabIndex = 17;
            dtpDataAquisicao.Value = new DateTime(2024, 8, 17, 0, 0, 0, 0);
            // 
            // maquinaBindingSource
            // 
            maquinaBindingSource.DataSource = typeof(Models.Maquina);
            // 
            // maquinaIdDataGridViewTextBoxColumn
            // 
            maquinaIdDataGridViewTextBoxColumn.DataPropertyName = "MaquinaId";
            maquinaIdDataGridViewTextBoxColumn.HeaderText = "Maquina Id";
            maquinaIdDataGridViewTextBoxColumn.Name = "maquinaIdDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // fabricanteDataGridViewTextBoxColumn
            // 
            fabricanteDataGridViewTextBoxColumn.DataPropertyName = "Fabricante";
            fabricanteDataGridViewTextBoxColumn.HeaderText = "Fabricante";
            fabricanteDataGridViewTextBoxColumn.Name = "fabricanteDataGridViewTextBoxColumn";
            // 
            // dataAquisicaoDataGridViewTextBoxColumn
            // 
            dataAquisicaoDataGridViewTextBoxColumn.DataPropertyName = "DataAquisicao";
            dataAquisicaoDataGridViewTextBoxColumn.HeaderText = "Data de aquisicao";
            dataAquisicaoDataGridViewTextBoxColumn.Name = "dataAquisicaoDataGridViewTextBoxColumn";
            // 
            // setorIdDataGridViewTextBoxColumn
            // 
            setorIdDataGridViewTextBoxColumn.DataPropertyName = "SetorId";
            setorIdDataGridViewTextBoxColumn.HeaderText = "Setor Id";
            setorIdDataGridViewTextBoxColumn.Name = "setorIdDataGridViewTextBoxColumn";
            // 
            // Setor
            // 
            Setor.DataPropertyName = "Setor.Nome";
            Setor.HeaderText = "Setor.Nome";
            Setor.Name = "Setor";
            // 
            // FrmMaquina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 486);
            Controls.Add(dtpDataAquisicao);
            Controls.Add(dgvMaquina);
            Controls.Add(btnSalvar);
            Controls.Add(btnDeletar);
            Controls.Add(btnAlterar);
            Controls.Add(btnAdicionar);
            Controls.Add(cmbSetor);
            Controls.Add(lblSetor);
            Controls.Add(lblData);
            Controls.Add(txtFabricante);
            Controls.Add(lblFabricante);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "FrmMaquina";
            Text = "Cadastro de maquina::.";
            Load += FrmMaquina_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaquina).EndInit();
            ((System.ComponentModel.ISupportInitialize)maquinaBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)maquinaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private TextBox txtFabricante;
        private Label lblFabricante;
        private Label lblData;
        private Label lblSetor;
        private ComboBox cmbSetor;
        private Button btnAdicionar;
        private Button btnAlterar;
        private Button btnDeletar;
        private Button btnSalvar;
        private DataGridView dgvMaquina;
        private DateTimePicker dtpDataAquisicao;
        private BindingSource maquinaBindingSource;
        private BindingSource maquinaBindingSource1;
        private DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maquinaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fabricanteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataAquisicaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn setorIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Setor;
    }
}