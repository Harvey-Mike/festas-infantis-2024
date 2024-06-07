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
            groupData = new GroupBox();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            tabPage2 = new TabPage();
            button1 = new Button();
            button2 = new Button();
            groupPagamento = new GroupBox();
            lblValorPendente = new Label();
            lblValorDesconto = new Label();
            lblvalorSinal = new Label();
            lblValorTema = new Label();
            lblDesconto = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            cmbSinal = new ComboBox();
            cmbTema = new ComboBox();
            cmbCliente = new ComboBox();
            lblSinal = new Label();
            lblTema = new Label();
            lblCliente = new Label();
            button3 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupData.SuspendLayout();
            tabPage2.SuspendLayout();
            groupPagamento.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(38, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(65, 27);
            txtId.TabIndex = 0;
            txtId.Text = "0";
            txtId.TextChanged += txtId_TextChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(12, 21);
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
            tabControl1.Location = new Point(12, 62);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(542, 375);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(btnGravar);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupData);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(534, 347);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados da Festa";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(427, 310);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 31);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(346, 310);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 31);
            btnGravar.TabIndex = 9;
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
            groupBox2.Location = new Point(3, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 149);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do Endereço";
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Location = new Point(25, 62);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(37, 20);
            lblRua.TabIndex = 11;
            lblRua.Text = "Rua:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(252, 23);
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
            lblBairro.Location = new Point(10, 94);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(52, 20);
            lblBairro.TabIndex = 13;
            lblBairro.Text = "Bairro:";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(3, 25);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(59, 20);
            lblCidade.TabIndex = 8;
            lblCidade.Text = "Cidade:";
            lblCidade.Click += lblCidade_Click;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(62, 55);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(425, 27);
            txtRua.TabIndex = 5;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(315, 22);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(172, 27);
            txtEstado.TabIndex = 4;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(315, 91);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(172, 27);
            txtNumero.TabIndex = 7;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(62, 91);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(175, 27);
            txtBairro.TabIndex = 6;
            txtBairro.TextChanged += txtBairro_TextChanged;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(62, 22);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(175, 27);
            txtCidade.TabIndex = 3;
            // 
            // groupData
            // 
            groupData.Controls.Add(dateTimePicker3);
            groupData.Controls.Add(dateTimePicker2);
            groupData.Controls.Add(dateTimePicker1);
            groupData.Controls.Add(label3);
            groupData.Controls.Add(label4);
            groupData.Controls.Add(label2);
            groupData.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupData.Location = new Point(0, 6);
            groupData.Name = "groupData";
            groupData.Size = new Size(499, 139);
            groupData.TabIndex = 0;
            groupData.TabStop = false;
            groupData.Text = "Data e Hora:";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "HH:mm";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(157, 89);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.Size = new Size(68, 27);
            dateTimePicker3.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(157, 56);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(68, 27);
            dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(157, 23);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(114, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(groupPagamento);
            tabPage2.Controls.Add(cmbSinal);
            tabPage2.Controls.Add(cmbTema);
            tabPage2.Controls.Add(cmbCliente);
            tabPage2.Controls.Add(lblSinal);
            tabPage2.Controls.Add(lblTema);
            tabPage2.Controls.Add(lblCliente);
            tabPage2.Font = new Font("Segoe UI", 11.25F);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(534, 347);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dados do Alguel";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.DialogResult = DialogResult.Cancel;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(444, 302);
            button1.Name = "button1";
            button1.Size = new Size(76, 31);
            button1.TabIndex = 8;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(365, 302);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 9;
            button2.Text = "Gravar";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupPagamento
            // 
            groupPagamento.Controls.Add(button3);
            groupPagamento.Controls.Add(lblValorPendente);
            groupPagamento.Controls.Add(lblValorDesconto);
            groupPagamento.Controls.Add(lblvalorSinal);
            groupPagamento.Controls.Add(lblValorTema);
            groupPagamento.Controls.Add(lblDesconto);
            groupPagamento.Controls.Add(textBox5);
            groupPagamento.Controls.Add(textBox4);
            groupPagamento.Controls.Add(textBox3);
            groupPagamento.Controls.Add(textBox2);
            groupPagamento.Controls.Add(textBox1);
            groupPagamento.Location = new Point(22, 110);
            groupPagamento.Name = "groupPagamento";
            groupPagamento.Size = new Size(498, 186);
            groupPagamento.TabIndex = 100;
            groupPagamento.TabStop = false;
            groupPagamento.Text = "Dados de Pagamento:";
            groupPagamento.Enter += groupPagamento_Enter;
            // 
            // lblValorPendente
            // 
            lblValorPendente.AutoSize = true;
            lblValorPendente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorPendente.Location = new Point(242, 134);
            lblValorPendente.Name = "lblValorPendente";
            lblValorPendente.Size = new Size(99, 17);
            lblValorPendente.TabIndex = 10;
            lblValorPendente.Text = "Valor Pendente:";
            // 
            // lblValorDesconto
            // 
            lblValorDesconto.AutoSize = true;
            lblValorDesconto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorDesconto.Location = new Point(243, 29);
            lblValorDesconto.Name = "lblValorDesconto";
            lblValorDesconto.Size = new Size(98, 85);
            lblValorDesconto.TabIndex = 10;
            lblValorDesconto.Text = "\r\n\r\n\r\nValor do Tema\r\n com desconto:\r\n";
            // 
            // lblvalorSinal
            // 
            lblvalorSinal.AutoSize = true;
            lblvalorSinal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblvalorSinal.Location = new Point(14, 134);
            lblvalorSinal.Name = "lblvalorSinal";
            lblvalorSinal.Size = new Size(92, 17);
            lblvalorSinal.TabIndex = 10;
            lblvalorSinal.Text = "Valor do Sinal:";
            // 
            // lblValorTema
            // 
            lblValorTema.AutoSize = true;
            lblValorTema.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorTema.Location = new Point(14, 91);
            lblValorTema.Name = "lblValorTema";
            lblValorTema.Size = new Size(96, 17);
            lblValorTema.TabIndex = 10;
            lblValorTema.Text = "Valor do Tema:";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesconto.Location = new Point(6, 59);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(100, 17);
            lblDesconto.TabIndex = 10;
            lblDesconto.Text = "% de Desconto:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(347, 129);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(93, 27);
            textBox5.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(347, 86);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(93, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(104, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(104, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(45, 27);
            textBox1.TabIndex = 3;
            // 
            // cmbSinal
            // 
            cmbSinal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSinal.FormattingEnabled = true;
            cmbSinal.Location = new Point(86, 66);
            cmbSinal.Name = "cmbSinal";
            cmbSinal.Size = new Size(187, 28);
            cmbSinal.TabIndex = 2;
            // 
            // cmbTema
            // 
            cmbTema.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTema.FormattingEnabled = true;
            cmbTema.Location = new Point(345, 31);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(175, 28);
            cmbTema.TabIndex = 1;
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Items.AddRange(new object[] { "israel ", "kauã" });
            cmbCliente.Location = new Point(86, 31);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(187, 28);
            cmbCliente.TabIndex = 0;
            // 
            // lblSinal
            // 
            lblSinal.AutoSize = true;
            lblSinal.Font = new Font("Segoe UI", 11.25F);
            lblSinal.Location = new Point(36, 66);
            lblSinal.Name = "lblSinal";
            lblSinal.Size = new Size(44, 20);
            lblSinal.TabIndex = 0;
            lblSinal.Text = "Sinal:";
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Font = new Font("Segoe UI", 11.25F);
            lblTema.Location = new Point(291, 34);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(48, 20);
            lblTema.TabIndex = 0;
            lblTema.Text = "Tema:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 11.25F);
            lblCliente.Location = new Point(22, 34);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // button3
            // 
            button3.Location = new Point(219, 21);
            button3.Name = "button3";
            button3.Size = new Size(75, 32);
            button3.TabIndex = 11;
            button3.Text = "Calcular";
            button3.UseVisualStyleBackColor = true;
           
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 448);
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
            groupData.ResumeLayout(false);
            groupData.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupPagamento.ResumeLayout(false);
            groupPagamento.PerformLayout();
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
        private GroupBox groupData;
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
        private Label lblCliente;
        private Label lblSinal;
        private Label lblTema;
        private ComboBox cmbSinal;
        private ComboBox cmbTema;
        private ComboBox cmbCliente;
        private GroupBox groupPagamento;
        private Label lblValorPendente;
        private Label lblValorDesconto;
        private Label lblvalorSinal;
        private Label lblValorTema;
        private Label lblDesconto;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}