using System;
using empleadocontroller;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        EmpleadoController empControl = new EmpleadoController();
        empControl.registrarEmpleado(1000349332,"carlos alberto");
        
    }
}