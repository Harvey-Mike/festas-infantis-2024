namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TelaClienteForm
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
            txtId = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtCPF = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtTelefone = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 48);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(110, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(42, 23);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(110, 69);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(411, 23);
            txtNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 77);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            label2.Click += this.label2_Click;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(110, 101);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(157, 23);
            txtCPF.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 109);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 141);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefone:";
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(374, 182);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 51);
            btnGravar.TabIndex = 5;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(469, 182);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 51);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(110, 133);
            txtTelefone.Mask = "(99) 0 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(157, 23);
            txtTelefone.TabIndex = 4;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 245);
            Controls.Add(txtTelefone);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label4);
            Controls.Add(txtCPF);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaClienteForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtCPF;
        private Label label3;
        private Label label4;
        private Button btnGravar;
        private Button btnCancelar;
        private MaskedTextBox txtTelefone;
    }
}