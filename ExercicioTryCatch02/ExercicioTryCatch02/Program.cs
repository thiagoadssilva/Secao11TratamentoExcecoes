using ExercicioTryCatch02.Entities;
using ExercicioTryCatch02.Entities.Exceptions;

try
{

    Console.Write("Número do quarto: ");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine("data de entrada (dd/MM/yyyy)");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("data de saída (dd/MM/yyyy)");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());

    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine(reservation);
    Console.WriteLine();

    Console.WriteLine("Coloque data para atualizar sua reserva");
    Console.WriteLine("data de entrada (dd/MM/yyyy)");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("data de saída (dd/MM/yyyy)");
    checkOut = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(checkIn, checkOut);
    Console.WriteLine(reservation);
}
catch (DomainExeception e)
{
    Console.WriteLine("Erro: " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Erro: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Qualquer erro: " + e.Message);
}
