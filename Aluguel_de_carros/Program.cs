using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace Aluguel_de_carros
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedindo para o usuario entrar com os valores e atribuindo esses valores a variaveis
            Console.WriteLine("Entre com os dados da locação:");
            Console.Write("modelo: ");
            string model = Console.ReadLine();
            Console.Write("entrada (dd / MM / yyyy HH: mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("saida (dd / MM / yyyy HH: mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Entre com o preço por hora: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com preço por dia: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //instanciando um alguem de carro e passando os valores
            AluguelCarro carRental = new AluguelCarro(start, finish, new Veiculo(model));

            //instanciando um servico de locacao e passando os valores
            ServicoLocacao rentalService = new ServicoLocacao(hour, day, new TaxaServicoBR());

            //chamando o precesso da fatura para depois passar para o usuario
            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("FATURA: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
