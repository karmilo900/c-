using System;
using empeadomodel;
using Org.BouncyCastle.Asn1.X509.SigI;


namespace empleadocontroller{

    class EmpleadoController{
        public void registrarEmpleado(int identificacion, string nombre){
            if(nombre != "" ){
                Empleado emp = new Empleado(identificacion, nombre);
                if(emp.registroEmpleado()){
                    Console.WriteLine("registro exitoso");
                }else{
                    Console.WriteLine("registro no exitoso");
                }


            }
        }
    }
}