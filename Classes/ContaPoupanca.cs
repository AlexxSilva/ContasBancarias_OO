using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasBancarias_OO.Classes
{
    public class ContaPoupanca : Conta
    {
        public override double Juros { get; protected set; } = 0.005;

        //metodo sacar da conta poupança, para sacar precisa ter saldo.
        public override decimal Sacar(decimal valor)
        {
            return base.Sacar(valor);
        }

        //depositar da classe base
    }
}
