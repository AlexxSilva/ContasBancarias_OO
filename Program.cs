using ContasBancarias_OO.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nConta Corrente: 1029 Titular: Alex Silva");

        Conta conta = new Conta(); // 
        conta.Titular = "Alex";
        conta.Saldo = 0;

        Console.WriteLine("Depositando R$ 1.000,00");
        conta.Depositar(1000);

        Console.WriteLine($"Saldo da conta após deposito: {conta.Saldo.ToString("c")}");

        Console.WriteLine("sacando R$ 100,00");
        conta.Sacar(100);

        Console.WriteLine($"Saldo da conta após saque: {conta.Saldo.ToString("c")}");



        Console.WriteLine("\nConta Poupança: 1022 Titular: Alex Silva");

        Conta contaPoupanca = new ContaPoupanca(); // 
        contaPoupanca.Titular = "Alex";
        contaPoupanca.Saldo = 0;

        Console.WriteLine("Depositando R$ 500,00");
        contaPoupanca.Depositar(500);

        Console.WriteLine($"Saldo da conta após deposito: {contaPoupanca.Saldo.ToString("c")}");

        Console.WriteLine("sacando R$ 20,00");
        contaPoupanca.Sacar(20);

        Console.WriteLine($"Saldo da conta após saque: {contaPoupanca.Saldo.ToString("c")}");


        Console.WriteLine("\nConta Investimento: 1024 Titular: Alex Silva");

        Conta contaInvestimento = new ContaInvestimento(); // 
        contaInvestimento.Titular = "Alex";
        contaInvestimento.Saldo = 0;

        Console.WriteLine("Depositando R$ 5.000,00");
        contaInvestimento.Depositar(5000);

        Console.WriteLine($"Saldo da conta após deposito: {contaInvestimento.Saldo.ToString("c")}");

        Console.WriteLine("sacando R$ 1.500,00");
        contaInvestimento.Sacar(1500);

        Console.WriteLine($"Saldo da conta após saque: {contaInvestimento.Saldo.ToString("c")}");



        Console.ReadKey();
    }
}