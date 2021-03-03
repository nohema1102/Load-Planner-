using System;

namespace Objetos
{
    class Objetos
    {
        public float peso; 
        public string nombreObjeto;
        public string iniciales;
        

        public Objetos(float peso, string nombreObjeto, string iniciales)
        {
            this.nombreObjeto = nombreObjeto;
            this.iniciales = iniciales;
            this.peso = peso;
        }
         private string InicialesAMostrar()

        {
            string nombreAMostrar;
            if (this.iniciales != null)
            {
                
                nombreAMostrar = this.iniciales;
            }
            else
            {
                nombreAMostrar = " ";
            }
            return nombreAMostrar;
        }
    }
}
