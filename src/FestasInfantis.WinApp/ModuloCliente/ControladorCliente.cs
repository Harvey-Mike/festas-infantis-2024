using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        TabelaClienteControl tabelaCliente;
        RepositorioCliente repositorioCliente;

        public ControladorCliente(RepositorioCliente repositorio)
        {
            repositorioCliente = repositorio;
        }
        public override string TipoCadastro { get { return "Cliente"; } }

        public override string ToolTipAdicionar { get { return "Adicionar um Cliente"; } }

        public override string ToolTipEditar { get { return "Editar um Cliente"; } }

        public override string ToolTipExcluir { get { return "Excluir um Cliente existente"; } }

        public override void Adicionar()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();
            DialogResult resultado = telaCliente.ShowDialog();
            if (resultado == DialogResult.OK) return;

            Cliente novoCliente = telaCliente.Cliente;
            repositorioCliente.Cadastrar(novoCliente);
            carregarClientes();
        }

        private void carregarClientes()
        {
            List <Cliente> clientes = repositorioCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(clientes);
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            if(tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();

            carregarClientes();

            return tabelaCliente;
        }
    }
}
