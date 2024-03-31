using System;
using System.Data;
using MySqlCon;

namespace empeadomodel{

    class Empleado{
        private int identificacion;
        private string nombre;

        private DateTime ingreso;
        private DateTime horaSalida;


        public int Identificacion {get => identificacion; set => identificacion = value; }
        public string Nombre {get => nombre; set => nombre = value; }
        public DateTime Ingreso {get => ingreso; set => ingreso = value; }
        public DateTime HoraSalida {get => horaSalida; set => horaSalida = value; }

        public Empleado(int identificacion, string nombre, DateTime ingreso, DateTime horaSalida){
            this.Identificacion= identificacion;
            this.Nombre=nombre;
            this.Ingreso=ingreso;
            this.HoraSalida=horaSalida;
                                }

        public Empleado(string nombreTabla){
            this.Nombre =nombreTabla;
        }
        Conexion con = new Conexion();

        public bool registroEmpleadoin(){
            string sql = $"INSERT INTO empleadoin (identificacion, nombre, hora_in) VALUES ('{this.Identificacion}', '{this.Nombre}', '{this.Ingreso.ToString("yyyy-MM-dd HH:mm:ss")}') ; INSERT INTO empleadosal (identificacion, nombre, hora_sal) VALUES ('{this.Identificacion}', '{this.Nombre}', '{this.HoraSalida.ToString("yyyy-MM-dd HH:mm:ss")}') ;";
            if(con.guardarSQL(sql)){
                return true;
            }else{
                return false;
            }
        }

        public void listasempleados(){
            foreach (DataRow dato in con.listaempleados(this.Nombre).Rows){

                Console.WriteLine(dato["identificación: "].ToString()+"-"+dato["Nombre: "].ToString()+"-"+dato["hora ingreso"]);
            }
        }


    }
}