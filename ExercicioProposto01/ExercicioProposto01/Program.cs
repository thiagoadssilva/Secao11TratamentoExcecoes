using ExercicioProposto01.Entities;
using System.Globalization;

try
{

    Console.Write("Entre com os dados da conta");
    Console.WriteLine();

    Console.Write("Número da conta: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Entre com usuario da conta: ");
    string holder = Console.ReadLine();
    Console.Write("Entre com o saldo inicial da conta: ");
    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Entre com o limite de saque: ");
    double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine();

    Console.Write("Entre com o valor do saque: ");
    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account account = new Account(number, holder, balance, withdrawLimit);
    account.Withdraw(amount);
    Console.WriteLine(account);
}
catch (ApplicationException e)
{
    Console.WriteLine("Erro: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}