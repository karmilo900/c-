using System;
using empleadocontroller;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        DateTime hora = new DateTime(1, 1, 1, 14, 30, 0);
        DateTime horasal = new DateTime(1, 1, 1, 22, 30, 0);
        EmpleadoController empControl = new EmpleadoController();
        empControl.registrarEmpleado(102323223,"carlos alberto",hora,horasal);
        
    }
}