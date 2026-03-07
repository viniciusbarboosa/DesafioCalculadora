using CalculadoraDesafio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDesafio.Repositories
{
    public class Historico:IHistorico
    {
        private List<Operacao> operacoes = new List<Operacao>();

        public void Salvar(Operacao operacao)
        {
            operacoes.Add(operacao);
        }
        public List<Operacao> MostrarHistorico()
        {
            return operacoes;
        }
    }
}
