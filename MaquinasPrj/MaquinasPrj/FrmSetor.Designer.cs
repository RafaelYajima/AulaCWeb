namespace MaquinasPrj
{
    partial class FrmSetor
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
            btnAdicionar = new Button();
            btnAlterar = new Button();
            btnDeletar = new Button();
            btnSalvar = new Button();
            dgvSetor = new DataGridView();
            setorBindingSource = new BindingSource(components);
            setorIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSetor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)setorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(41, 38);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(41, 56);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            txtId.Leave += txtId_Leave;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(41, 114);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(232, 23);
            txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(41, 96);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(12, 161);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(93, 161);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 5;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(174, 161);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 6;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(255, 161);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dgvSetor
            // 
            dgvSetor.AutoGenerateColumns = false;
            dgvSetor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSetor.Columns.AddRange(new DataGridViewColumn[] { setorIdDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn });
            dgvSetor.DataSource = setorBindingSource;
            dgvSetor.Location = new Point(12, 190);
            dgvSetor.Name = "dgvSetor";
            dgvSetor.RowTemplate.Height = 25;
            dgvSetor.Size = new Size(318, 150);
            dgvSetor.TabIndex = 8;
            dgvSetor.CellDoubleClick += dgvSetor_CellDoubleClick;
            // 
            // setorBindingSource
            // 
            setorBindingSource.DataSource = typeof(Models.Setor);
            // 
            // setorIdDataGridViewTextBoxColumn
            // 
            setorIdDataGridViewTextBoxColumn.DataPropertyName = "SetorId";
            setorIdDataGridViewTextBoxColumn.HeaderText = "Setor Id";
            setorIdDataGridViewTextBoxColumn.Name = "setorIdDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // FrmSetor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 347);
            Controls.Add(dgvSetor);
            Controls.Add(btnSalvar);
            Controls.Add(btnDeletar);
            Controls.Add(btnAlterar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "FrmSetor";
            Text = "Cadastro de setor::.";
            Load += FrmSetor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSetor).EndInit();
            ((System.ComponentModel.ISupportInitialize)setorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private TextBox txtNome;
        private Label lblNome;
        private Button btnAdicionar;
        private Button btnAlterar;
        private Button btnDeletar;
        private Button btnSalvar;
        private DataGridView dgvSetor;
        private DataGridViewTextBoxColumn setorIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private BindingSource setorBindingSource;
    }
}