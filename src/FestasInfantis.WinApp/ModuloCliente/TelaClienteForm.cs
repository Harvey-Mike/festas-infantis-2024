﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {

        private Cliente cliente;

        public Cliente Cliente
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                txtTelefone.Text = value.Telefone;
                txtCPF.Text = value.Cpf;
            }
            get { return cliente; }
        }
        public TelaClienteForm()
        {
            InitializeComponent();
        }

        private TelaClienteForm(object sender,EventArgs e)
        {
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string cpf = txtCPF.Text;

            cliente = new Cliente(nome, telefone, cpf);
        }
    }
}
