using eAgenda.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        public Cliente(string nome, string cpf, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Cliente clienteAtualizado = (Cliente)novoRegistro;

            Nome = clienteAtualizado.Nome;
            Cpf = clienteAtualizado.Cpf;
            Telefone = clienteAtualizado.Telefone;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo nome não pode ser vazio");

            if (string.IsNullOrEmpty(Cpf.Trim()))
                erros.Add("O campo cpf não pode ser vazio");

            if (string.IsNullOrEmpty(Telefone.Trim()))
                erros.Add("O campo telefone não pode ser vazio");

            return erros;
        }
    }
}



