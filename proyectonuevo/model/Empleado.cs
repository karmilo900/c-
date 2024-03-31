using System;
using MySqlCon;

namespace empeadomodel{

    class Empleado{
        private int identificacion;
        private string nombre;

        public int Identificacion {get => identificacion; set => identificacion = value; }
        public string Nombre {get => nombre; set => nombre = value; }

        public Empleado(int identificacion, string nombre){
            this.Identificacion= identificacion;
            this.Nombre=nombre;
        }
        Conexion con = new Conexion();

        public bool registroEmpleado(){
            string sql="INSERT INTO empleado (identificacion, nombre) VALUES ('"+this.Identificacion+"','"+this.Nombre+"')" ;
            if(con.guardarSQL(sql)){
                return true;
            }else{
                return false;
            }
        }
    }
}