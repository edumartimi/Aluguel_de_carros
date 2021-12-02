using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aluguel_de_carros
{
    class AluguelCarro
    {
        //criando um metodo contrutor para o aluguel do carro
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Veiculo Vehicle { get; private set; }
        public Fatura Invoice { get; set; }

        // criando um metodo para passar os valores posteriormente
        public AluguelCarro(DateTime start, DateTime finish, Veiculo vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
