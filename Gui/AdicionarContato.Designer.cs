namespace Gui
{
    partial class AdicionarContato
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
            label1 = new Label();
            lbNome = new Label();
            lbTelefone = new Label();
            lbCelular = new Label();
            lbTipo = new Label();
            lbEmail = new Label();
            txtNome = new TextBox();
            contatoBindingSource = new BindingSource(components);
            txtTelefone = new TextBox();
            txtCelular = new TextBox();
            txtEmail = new TextBox();
            cbTipo = new ComboBox();
            contatoBindingSource1 = new BindingSource(components);
            BtnAdicionar = new Button();
            BtnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)contatoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contatoBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(481, 28);
            label1.TabIndex = 0;
            label1.Text = "Digite as Informações para Adicionar um Contato";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Arial", 15F);
            lbNome.Location = new Point(21, 85);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(180, 23);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome (Obrigátorio)";
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTelefone.Location = new Point(21, 140);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(84, 23);
            lbTelefone.TabIndex = 2;
            lbTelefone.Text = "Telefone";
            // 
            // lbCelular
            // 
            lbCelular.AutoSize = true;
            lbCelular.Font = new Font("Arial", 15F);
            lbCelular.Location = new Point(21, 192);
            lbCelular.Name = "lbCelular";
            lbCelular.Size = new Size(71, 23);
            lbCelular.TabIndex = 3;
            lbCelular.Text = "Celular";
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTipo.Location = new Point(21, 293);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(166, 23);
            lbTipo.TabIndex = 4;
            lbTipo.Text = "Tipo (Obrigátorio)";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(21, 246);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(65, 23);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "E-mail";
            // 
            // txtNome
            // 
            txtNome.DataBindings.Add(new Binding("DataContext", contatoBindingSource, "Nome", true));
            txtNome.Location = new Point(207, 85);
            txtNome.MaxLength = 64;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(155, 23);
            txtNome.TabIndex = 6;
            // 
            // contatoBindingSource
            // 
            contatoBindingSource.DataSource = typeof(SistemaContatosBD.Dados.Contato);
            // 
            // txtTelefone
            // 
            txtTelefone.DataBindings.Add(new Binding("DataContext", contatoBindingSource, "Telefone", true));
            txtTelefone.Location = new Point(207, 140);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(155, 23);
            txtTelefone.TabIndex = 7;
            txtTelefone.KeyPress += txtNumero_KeyPress;
            // 
            // txtCelular
            // 
            txtCelular.DataBindings.Add(new Binding("DataContext", contatoBindingSource, "Celular", true));
            txtCelular.Location = new Point(207, 196);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(155, 23);
            txtCelular.TabIndex = 8;
            txtCelular.KeyPress += txtCelular_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.DataBindings.Add(new Binding("DataContext", contatoBindingSource, "Email", true));
            txtEmail.Location = new Point(207, 246);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(155, 23);
            txtEmail.TabIndex = 9;
            // 
            // cbTipo
            // 
            cbTipo.DataBindings.Add(new Binding("DataContext", contatoBindingSource, "Tipo", true));
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "", "Pessoal", "Profissonal", "Empressarial" });
            cbTipo.Location = new Point(207, 297);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(155, 23);
            cbTipo.TabIndex = 10;
            cbTipo.Tag = "";
            // 
            // contatoBindingSource1
            // 
            contatoBindingSource1.DataSource = typeof(SistemaContatosBD.Dados.Contato);
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.Location = new Point(21, 373);
            BtnAdicionar.Name = "BtnAdicionar";
            BtnAdicionar.Size = new Size(133, 38);
            BtnAdicionar.TabIndex = 11;
            BtnAdicionar.Text = "Adicionar";
            BtnAdicionar.UseVisualStyleBackColor = true;
            BtnAdicionar.Click += btnAdicionar_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(368, 373);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(134, 38);
            BtnVoltar.TabIndex = 12;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // AdicionarContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 450);
            Controls.Add(BtnVoltar);
            Controls.Add(BtnAdicionar);
            Controls.Add(cbTipo);
            Controls.Add(txtEmail);
            Controls.Add(txtCelular);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(lbEmail);
            Controls.Add(lbTipo);
            Controls.Add(lbCelular);
            Controls.Add(lbTelefone);
            Controls.Add(lbNome);
            Controls.Add(label1);
            Name = "AdicionarContato";
            Text = "AdicionarContato";
            ((System.ComponentModel.ISupportInitialize)contatoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)contatoBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbNome;
        private Label lbTelefone;
        private Label lbCelular;
        private Label lbTipo;
        private Label lbEmail;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtCelular;
        private TextBox txtEmail;
        private ComboBox cbTipo;
        private BindingSource contatoBindingSource;
        private BindingSource contatoBindingSource1;
        private Button BtnAdicionar;
        private Button BtnVoltar;
    }
}