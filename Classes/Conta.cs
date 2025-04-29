using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasBancarias_OO.Classes
{
    public class Conta
    {
        //encapsulamento dos atributos
        public int Numero { get; set; }
        public string? Titular { get; set; }
        public decimal Saldo { get; set; } = 0.00m;
        public virtual double Juros { get; protected set; } = 0.00;

        //classe privada
        private decimal CalculaRemuneracao(double juros)
        {
            return Saldo * (decimal)juros;
        }

        //método para sacar o dinheiro da conta
        public virtual decimal Sacar(decimal valor)
        {

            if (Saldo >= valor)
            {
                Saldo -= valor;
                return Saldo;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                return Saldo;
            }
        }

        //método para depositar o dinheiro da conta
        public decimal Depositar(decimal valor)
        {
            Saldo += valor;
            Saldo = Saldo + (CalculaRemuneracao(Juros));
            return Saldo;
        }
    }
}
