using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aluguel_de_carros
{
    class Veiculo
    {
        //criando o metodo contrutor para o carro
        public string Model { get; set; }
        public Veiculo(string model)
        {
            Model = model;
        }
    }
}