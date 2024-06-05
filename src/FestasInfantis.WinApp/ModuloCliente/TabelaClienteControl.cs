using eAgenda.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TabelaClienteControl : UserControl
    {
        public TabelaClienteControl()
        {
            InitializeComponent();

            dataGrid.Columns.AddRange(CriarColunas());
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            dataGrid.Rows.Clear();

            foreach (Cliente c in clientes)
            {
                dataGrid.Rows.Add(c.Id, c.Nome, c.Telefone, c.Cpf);
            }
        }
        public int ObterRegistroSelecionado()
        {
            return dataGrid.SelecionarId();
        }

        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]
                {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Cpf", HeaderText = "Cpf"}
                };
        }
    }
}




