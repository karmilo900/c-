using System;
using empleadocontroller;

class Program
{
    static void Main(string[] args)
    {
        int ident = 0;
        string nombre = "";
        DateTime horain, horasal;

        Console.WriteLine("Por favor escriba el # de identificación del empleado: ");
        ident = int.Parse(Console.ReadLine());

        Console.WriteLine("Por favor escriba el nombre del empleado: ");
        nombre = Console.ReadLine();

        Console.WriteLine("Por favor escriba la hora de ingreso del empleado (en formato HH:mm:ss): ");
        if (!DateTime.TryParseExact(Console.ReadLine(), "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out horain))
        {
            Console.WriteLine("Formato de hora incorrecto. Por favor, introduzca la hora en el formato correcto (HH:mm:ss).");
            return;
        }

        Console.WriteLine("Por favor escriba la hora de salida del empleado (en formato HH:mm:ss): ");
        if (!DateTime.TryParseExact(Console.ReadLine(), "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out horasal))
        {
            Console.WriteLine("Formato de hora incorrecto. Por favor, introduzca la hora en el formato correcto (HH:mm:ss).");
            return;
        }

        EmpleadoController empControl = new EmpleadoController();
        empControl.registrarEmpleado(ident, nombre, horain, horasal);
    }
}