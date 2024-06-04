namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            txtId = new TextBox();
            lblId = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox2 = new GroupBox();
            lblRua = new Label();
            lblEstado = new Label();
            lblNumero = new Label();
            lblBairro = new Label();
            lblCidade = new Label();
            txtRua = new TextBox();
            txtEstado = new TextBox();
            txtNumero = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            groupBox1 = new GroupBox();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            tabPage2 = new TabPage();
            label1 = new Label();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(67, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(54, 27);
            txtId.TabIndex = 0;
            txtId.Text = "0";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(41, 26);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 1;
            lblId.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 56);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 4;
            label2.Text = "Horário de Início:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 23);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 1;
            label3.Text = "Data da Festa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 85);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 6;
            label4.Text = "Horário de Término:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 66);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(534, 396);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(btnGravar);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(526, 368);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados da Festa";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(397, 319);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 31);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(321, 319);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 31);
            btnGravar.TabIndex = 11;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblRua);
            groupBox2.Controls.Add(lblEstado);
            groupBox2.Controls.Add(lblNumero);
            groupBox2.Controls.Add(lblBairro);
            groupBox2.Controls.Add(lblCidade);
            groupBox2.Controls.Add(txtRua);
            groupBox2.Controls.Add(txtEstado);
            groupBox2.Controls.Add(txtNumero);
            groupBox2.Controls.Add(txtBairro);
            groupBox2.Controls.Add(txtCidade);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(6, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(493, 149);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do Endereço";
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Location = new Point(18, 62);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(37, 20);
            lblRua.TabIndex = 11;
            lblRua.Text = "Rua:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(243, 25);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(243, 94);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(66, 20);
            lblNumero.TabIndex = 15;
            lblNumero.Text = "Número:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(3, 94);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(52, 20);
            lblBairro.TabIndex = 13;
            lblBairro.Text = "Bairro:";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(-3, 25);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(59, 20);
            lblCidade.TabIndex = 8;
            lblCidade.Text = "Cidade:";
            lblCidade.Click += lblCidade_Click;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(56, 55);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(431, 27);
            txtRua.TabIndex = 7;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(306, 22);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(181, 27);
            txtEstado.TabIndex = 6;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(315, 91);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(172, 27);
            txtNumero.TabIndex = 9;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(56, 91);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(181, 27);
            txtBairro.TabIndex = 8;
            txtBairro.TextChanged += txtBairro_TextChanged;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(56, 22);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(181, 27);
            txtCidade.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data e Hora:";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "HH:mm";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(157, 89);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.Size = new Size(83, 27);
            dateTimePicker3.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(157, 56);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(83, 27);
            dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(157, 23);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(114, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(526, 368);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dados do Alguel";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 54);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 0;
            label5.Text = "Cliente";
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 485);
            Controls.Add(tabControl1);
            Controls.Add(lblId);
            Controls.Add(txtId);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAluguelForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "O cadastro de Aluguéis";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private Label label2;
        private Label label3;
        private Label label4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblRua;
        private Label lblEstado;
        private Label lblNumero;
        private Label lblBairro;
        private Label lblCidade;
        private TextBox txtRua;
        private TextBox txtEstado;
        private TextBox txtNumero;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label1;
        private Label label5;
    }
}