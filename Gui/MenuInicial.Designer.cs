namespace Gui
{
    partial class MenuInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnCadastrar = new Button();
            BtnVerContatosSalvos = new Button();
            SuspendLayout();
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.BackColor = Color.White;
            BtnCadastrar.Location = new Point(56, 106);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(208, 53);
            BtnCadastrar.TabIndex = 0;
            BtnCadastrar.Text = "Cadastrar Contato";
            BtnCadastrar.UseVisualStyleBackColor = false;
            BtnCadastrar.Click += BtnAdicionarContato_Click;
            // 
            // BtnVerContatosSalvos
            // 
            BtnVerContatosSalvos.BackColor = Color.White;
            BtnVerContatosSalvos.Location = new Point(56, 256);
            BtnVerContatosSalvos.Name = "BtnVerContatosSalvos";
            BtnVerContatosSalvos.Size = new Size(208, 53);
            BtnVerContatosSalvos.TabIndex = 1;
            BtnVerContatosSalvos.Text = "Ver Contatos Salvos";
            BtnVerContatosSalvos.UseVisualStyleBackColor = false;
            BtnVerContatosSalvos.Click += BtnVerContato_Click;
            // 
            // MenuInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 412);
            Controls.Add(BtnVerContatosSalvos);
            Controls.Add(BtnCadastrar);
            Name = "MenuInicial";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCadastrar;
        private Button BtnVerContatosSalvos;
    }
}
