using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasBancarias_OO.Classes
{
    public class ContaInvestimento : Conta
    {
        public override double Juros { get; protected set; } = 0.005;
        public double Imposto { get; set; } = 0.001;

       
        // metodo de saque da consta de investimento (saldo - valor - imposto)
        // para sacar precisa ter saldo
        public override decimal Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo = Saldo - valor - (CalculaImposto(Imposto));
                return Saldo;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                return Saldo;
            }
        }

        //método privado da classe para calcular imposto (encapsulamento)
        private decimal CalculaImposto(double imposto)
        {
            return Saldo * (decimal)Imposto;
        }
    }
}
