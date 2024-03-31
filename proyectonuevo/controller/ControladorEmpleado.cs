using System;
using empeadomodel;
using Org.BouncyCastle.Asn1.X509.SigI;


namespace empleadocontroller{

    class EmpleadoController{
        public void registrarEmpleado(int identificacion, string nombre, DateTime ingreso, DateTime horaSalida){
            if(nombre != "" ){
                Empleado emp = new Empleado(identificacion, nombre, ingreso, horaSalida);
                if(emp.registroEmpleadoin()){
                    Console.WriteLine("registro exitoso");
                }else{
                    Console.WriteLine("registro no exitoso");
                }


            }
        }
    }
}