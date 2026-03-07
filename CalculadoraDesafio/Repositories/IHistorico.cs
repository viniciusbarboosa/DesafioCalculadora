using CalculadoraDesafio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDesafio.Repositories
{
    public interface IHistorico
    {
        public void Salvar(Operacao operacao);
        public List<Operacao> MostrarHistorico();
    }
}
