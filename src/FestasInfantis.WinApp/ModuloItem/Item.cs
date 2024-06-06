using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class Item : EntidadeBase
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Tema { get; set; }

        public Item(string descricao, decimal valor, string tema)
        {
            Descricao = descricao;
            Valor = valor;
            Tema = tema;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Item itemAtualizado = (Item)novoRegistro;

            Descricao = itemAtualizado.Descricao;
            Valor = itemAtualizado.Valor;
            Tema = itemAtualizado.Tema;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Descricao.Trim()))
                erros.Add("O campo descrição não pode ser vazio");

            if (Valor <= 0)
                erros.Add("O valor do item deve ser maior que zero");

            if (Tema == null)
                erros.Add("O item deve estar associado a um tema");

            return erros;
        }
    }
}
