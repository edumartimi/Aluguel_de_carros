using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel_de_carros 
{
    //criando uma herança
    interface ITaxaServico
    {
        double Tax(double amount);
    }
    //fazendo a herança
    class TaxaServicoBR : ITaxaServico
    {
        //fazendo os calculos e depois retornando o resultado
        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
