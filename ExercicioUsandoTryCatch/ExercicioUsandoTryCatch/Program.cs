try
{
	int number1 = int.Parse(Console.ReadLine());
    int number2 = int.Parse(Console.ReadLine());

	int result = number1 / number2;
    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Não é permitido divição por zero");
}
catch(FormatException e)
{
    Console.WriteLine("Erro no formato" + e.Message);
}