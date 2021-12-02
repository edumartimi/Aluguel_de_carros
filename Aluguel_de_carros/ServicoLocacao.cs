using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel_de_carros
{
    class ServicoLocacao
    {
        //criando o metodo construtor do servico de locacão
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxaServico _taxService;

        //criando um metodo para repassar os dados do servico posteriormente
        public ServicoLocacao(double pricePerHour, double pricePerDay, ITaxaServico taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        //criando um metodo para calcular os dados e posteriormente passalos
        public void ProcessInvoice(AluguelCarro carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _taxService.Tax(basicPayment);
            carRental.Invoice = new Fatura(basicPayment, tax);
        }
    }
}
