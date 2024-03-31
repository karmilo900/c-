using System;
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
        Conexion con = new Conexion();

        public bool registroEmpleado(){
            string sql = "INSERT INTO empleado (identificacion, nombre) VALUES ('" + this.Identificacion + "','" + this.Nombre + "'); ";
                    sql += "INSERT INTO ingresos (identifi, hora_in, hora_sal) VALUES ('" + this.Identificacion + "','" + this.Ingreso.ToString("yyyy-MM-dd HH:mm:ss") + "','" + this.HoraSalida.ToString("yyyy-MM-dd HH:mm:ss") + "');";
            if(con.guardarSQL(sql)){
                return true;
            }else{
                return false;
            }
        }

    }
}