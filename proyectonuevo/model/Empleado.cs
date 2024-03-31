using System;

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
    }
}