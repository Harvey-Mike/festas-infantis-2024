using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        //TabelaClienteControl tabelaCliente;
        //RepositorioCliente repositorioCliente;

        //public ControladorCliente(RepositorioCliente repositorio)
        //{
        //    repositorioCliente = repositorio;
        //}
        public override string TipoCadastro { get { return "Tema"; } }

        public override string ToolTipAdicionar { get { return "Adicionar um Tema"; } }

        public override string ToolTipEditar { get { return "Editando um Tema"; } }

        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Adicionar()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
