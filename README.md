# desafio_HOTELARIANET
Complemento de código para desafio da DIO formação .NET MICROSOFT

DIO - Trilha .NET - Explorando a linguagem C#
www.dio.me

Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de explorando a linguagem C#, da trilha .NET da DIO.

Contexto
Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos.

O seu programa deverá cálcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

Regras e validações
Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.
Diagrama de classe estacionamento

Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

**********************************************************

PROPOSTAS DE COMPLEMENTOS 

***********************************************************

1 -  // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            
            bool validaCapacidade = Suite.Capacidade >= hospedes.Count;

2 - // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
               
                throw new System.InvalidOperationException("O número máximo de reservas já foi concluído!\n Atenção não existem mais vagas...");

3 -  // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)

            int quantidadeHospedes = this.Hospedes.Count;            
            return quantidadeHospedes;

4 -  // TODO: Retorna o valor da diária

            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = 0;            
            valor = DiasReservados * Suite.ValorDiaria;
5 - // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%

            bool validaDesconto = this.DiasReservados >= 10;
            if (validaDesconto)
            {
                valor = valor * (10 / 100);
            }

            return valor;

6 -   Usando a biblioteca System.Globalization; 
          
          CultureInfo culturaBrasileira = new CultureInfo("pt-BR");

7 - Usando recursos da classe String para formatar em moeda a saída do valor da reserva

             string valorReais = String.Format("{0:C2}", reserva.CalcularValorDiaria()); 
            Console.WriteLine($"Valor diária: {valorReais}");



           
