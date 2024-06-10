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
            if (resultado == DialogResult.OK)
            {
                Cliente novoCliente = telaCliente.Cliente;
                repositorioCliente.Cadastrar(novoCliente);
                carregarClientes();
            }

        }

        private void carregarClientes()
        {
            List <Cliente> clientes = repositorioCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(clientes);
        }

        public override void Editar()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            int idSelecionado = tabelaCliente.ObterRegistroSelecionado();

            Cliente clienteSelecionado =
                repositorioCliente.SelecionarPorId(idSelecionado);

            if (clienteSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaCliente.Cliente = clienteSelecionado;

            DialogResult resultado = telaCliente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Cliente clienteEditado = telaCliente.Cliente;

            repositorioCliente.Editar(clienteSelecionado.Id, clienteEditado);

            CarregarClientes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{clienteEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaCliente.ObterRegistroSelecionado();

            Cliente clienteSelecionado =
                repositorioCliente.SelecionarPorId(idSelecionado);

            if (clienteSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{clienteSelecionado.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioCliente.Excluir(clienteSelecionado.Id);

            CarregarClientes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{clienteSelecionado.Nome}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if(tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();

            carregarClientes();

            return tabelaCliente;
        }

        private void CarregarClientes()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(clientes);
        }
    }
}
