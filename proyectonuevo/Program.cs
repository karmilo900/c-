using System;
using empleadocontroller;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        DateTime hora = new DateTime(1, 1, 1, 18, 30, 0);
        DateTime horasal = new DateTime(1, 1, 1, 23, 30, 0);
        EmpleadoController empControl = new EmpleadoController();
        empControl.registrarEmpleado(103423223,"juan alberto",hora,horasal);
        
    }
}