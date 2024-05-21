namespace Gui
{
    partial class ConfirmacaoModal
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
            label1 = new Label();
            BtnSim = new Button();
            btnNao = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 34);
            label1.Name = "label1";
            label1.Size = new Size(396, 23);
            label1.TabIndex = 0;
            label1.Text = "Você gostaria de Adicionar Mais 1 Contato?";
            // 
            // BtnSim
            // 
            BtnSim.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSim.Location = new Point(53, 93);
            BtnSim.Name = "BtnSim";
            BtnSim.Size = new Size(117, 53);
            BtnSim.TabIndex = 1;
            BtnSim.Text = "Sim";
            BtnSim.UseVisualStyleBackColor = true;
            BtnSim.Click += BtnSim_click;
            // 
            // btnNao
            // 
            btnNao.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNao.Location = new Point(340, 92);
            btnNao.Name = "btnNao";
            btnNao.Size = new Size(109, 53);
            btnNao.TabIndex = 2;
            btnNao.Text = "Não";
            btnNao.UseVisualStyleBackColor = true;
            btnNao.Click += BtnNao_click;
            // 
            // ConfirmacaoModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 195);
            Controls.Add(btnNao);
            Controls.Add(BtnSim);
            Controls.Add(label1);
            Name = "ConfirmacaoModal";
            Text = "ConfirmacaoModal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnSim;
        private Button btnNao;
    }
}