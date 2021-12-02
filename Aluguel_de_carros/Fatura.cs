using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aluguel_de_carros
{
    class Fatura
    {
        // Criando os costrutores
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public Fatura(double rental, double tax)
        {
            BasicPayment = rental;
            Tax = tax;
        }
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        //juntando todos os valores para retornar para o usuario posteriormente
        public override string ToString()
        {
            return "Basic payment: "
            + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTax: "
            + Tax.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTotal payment: "
            + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
