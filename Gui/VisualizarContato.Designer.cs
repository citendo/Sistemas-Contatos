namespace Gui
{
    partial class VisualizarContato
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
            DtContato = new DataGridView();
            contatoBindingSource = new BindingSource(components);
            label1 = new Label();
            BtnVoltar = new Button();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            celularDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DtContato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contatoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DtContato
            // 
            DtContato.AllowUserToAddRows = false;
            DtContato.AllowUserToDeleteRows = false;
            DtContato.AllowUserToResizeRows = false;
            DtContato.AutoGenerateColumns = false;
            DtContato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtContato.Columns.AddRange(new DataGridViewColumn[] { nomeDataGridViewTextBoxColumn, telefoneDataGridViewTextBoxColumn, celularDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn });
            DtContato.DataSource = contatoBindingSource;
            DtContato.Location = new Point(34, 70);
            DtContato.Name = "DtContato";
            DtContato.ReadOnly = true;
            DtContato.Size = new Size(678, 313);
            DtContato.TabIndex = 0;
            // 
            // contatoBindingSource
            // 
            contatoBindingSource.DataSource = typeof(SistemaContatosBD.Dados.Contato);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(221, 24);
            label1.TabIndex = 1;
            label1.Text = "Contatos Cadastrados";
            // 
            // BtnVoltar
            // 
            BtnVoltar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVoltar.Location = new Point(34, 410);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(133, 29);
            BtnVoltar.TabIndex = 2;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            celularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.FillWeight = 150F;
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VisualizarContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 476);
            Controls.Add(BtnVoltar);
            Controls.Add(label1);
            Controls.Add(DtContato);
            Name = "VisualizarContato";
            Text = "VisualizarContato";
            ((System.ComponentModel.ISupportInitialize)DtContato).EndInit();
            ((System.ComponentModel.ISupportInitialize)contatoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DtContato;
        private BindingSource contatoBindingSource;
        private Label label1;
        private Button BtnVoltar;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
    }
}