using System;
using empleadocontroller;

class Program
{
    static void Main(string[] args)
    {
        int ident = 0;
        string nombre = "";
        DateTime horain, horasal;
        int opciones=0;
        Console.WriteLine("Por favor escriba el la opcion que desea: ");
        Console.WriteLine("1. Agregar Empleado 2. Listar Empleados");
        opciones=int.Parse(Console.ReadLine());

        switch(opciones){
            case 1:
            Console.WriteLine("Por favor escriba el # de identificación del empleado: ");
            ident = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor escriba un nombre y un apellido del empleado: ");
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

            break;
            case 2:
                Console.WriteLine("identificacion         nombre            hora entrada        hora salida");

                EmpleadoController empleControl = new EmpleadoController();
                empleControl.listarEmpleado();
            
            break;
        }
        

        
       

        

        
    }
}