using System;
using System.Collections.Generic;
using System.Text;
using DesafioProjetoHospedagem.Models;


namespace DESAFIO_HOTELARIANET_DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("######### CENÁRIO 1 TESTE ######################");

            // Cria os modelos de hóspedes e cadastra na lista de hóspedes
            List<Pessoa> hospedes = new List<Pessoa>();

            Pessoa p1 = new Pessoa(nome: "Hóspede 1");
            Pessoa p2 = new Pessoa(nome: "Hóspede 2");

            hospedes.Add(p1);
            hospedes.Add(p2);
            Pessoa p3 = new Pessoa(nome: "Hóspede 3");
            Pessoa p4 = new Pessoa(nome: "Hóspede 4");
            Pessoa p5 = new Pessoa(nome: "Hóspede 5");
            Pessoa p6 = new Pessoa(nome: "Hóspede 6");
            Pessoa p7 = new Pessoa(nome: "Hóspede 7");
            Pessoa p8 = new Pessoa(nome: "Hóspede 8");
            Pessoa p9 = new Pessoa(nome: "Hóspede 9");
            Pessoa p10 = new Pessoa(nome: "Hóspede 10");

            hospedes.Add(p3);
            hospedes.Add(p4);
            hospedes.Add(p5);
            hospedes.Add(p6);
          //  hospedes.Add(p7);
           // hospedes.Add(p8);

            // Cria a suíte
            Suite suite = new Suite(tipoSuite: "Premium", capacidade: 10, valorDiaria: 50);

            // Cria uma nova reserva, passando a suíte e os hóspedes
            Reserva reserva = new Reserva(diasReservados: 8);
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            // Exibe a quantidade de hóspedes e o valor da diária
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            string resultado = String.Format("{0:F2}", reserva.CalcularValorDiaria());
            Console.WriteLine($"Valor diária: {resultado}");
            Console.ReadKey();
           
            /*
                        Console.WriteLine("######### CENÁRIO 2 TESTE ######################");



                        Pessoa p3 = new Pessoa(nome: "Hóspede 3");
                        Pessoa p4 = new Pessoa(nome: "Hóspede 4");
                        Pessoa p5 = new Pessoa(nome: "Hóspede 5");
                        Pessoa p6 = new Pessoa(nome: "Hóspede 6");
                        Pessoa p7 = new Pessoa(nome: "Hóspede 7");
                        Pessoa p8 = new Pessoa(nome: "Hóspede 8");
                        Pessoa p9 = new Pessoa(nome: "Hóspede 9");
                        Pessoa p10 = new Pessoa(nome: "Hóspede 10");

                        hospedes.Add(p3);
                        hospedes.Add(p4);
                        hospedes.Add(p5);
                        hospedes.Add(p6);
                        hospedes.Add(p7);
                        hospedes.Add(p8);
                        // hospedes.Add(p9);
                        //  hospedes.Add(p10);


                        reserva.Suite = new Suite(tipoSuite: "Simples", capacidade: 20, valorDiaria: 10);
                        reserva.DiasReservados = 20;

                        reserva.CadastrarSuite(reserva.Suite);
                        reserva.CadastrarHospedes(hospedes);

                        // Exibe a quantidade de hóspedes e o valor da diária
                        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
                        Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
                        Console.ReadKey();
                        */
        }
    }
}
