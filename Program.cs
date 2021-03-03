using System;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Objetos objetos1 = new Objetos(70f,"Barril","B");
            Objetos objetos2 = new Objetos(20f,"Bolsa de chatarra","BC");
            Objetos objetos3 = new Objetos(3f,"Bolsa con plantas","BP");
            Objetos objetos4 = new Objetos(5f,"Caja ligera","C1");
            Objetos objetos5 = new Objetos(15f,"Caja pesada","C2");
            Objetos objetos6 = new Objetos(0.2f,"Caja vacía","C3");
            Objetos objetos7 = new Objetos(4f,"Silla","S");
            Objetos objetos8 = new Objetos(0f," ",null);
          
          Objetos [,] orden = new Objetos [3,4] {{objetos8,objetos4,objetos7,objetos8},
                                                {objetos6,objetos1,objetos7,objetos3},
                                                {objetos2,objetos1,objetos5,objetos3}};

          for(int i = 0;i < 3;i++){
            for(int j = 0;j < 4;j++){
              Console.Write(orden[i,j].iniciales + " ");
            }
            Console.WriteLine();
          
          }
          if (orden[1,0].peso > orden[2,0].peso)
          {
            Console.WriteLine("Se está aplastando " + orden[2,0].nombreObjeto);
          }
          else if (orden[0,1].peso > orden[1,1].peso)
          {
            Console.WriteLine("Se está aplastando " + orden[1,1].nombreObjeto);
          }
          else if (orden[1,1].peso > orden[2,1].peso)
          {
            Console.WriteLine("Se está aplastando " + orden[2,1].nombreObjeto);
          }
          else if (orden[0,2].peso > orden[1,2].peso )
          {
            Console.WriteLine("Se está aplastando " + orden[2,2].nombreObjeto);
          }
          else if (orden[1,2].peso > orden[2,2].peso)
          {
            Console.WriteLine("Se está aplastando " + orden[2,2].nombreObjeto);
          }
          else if (orden[1,3].peso > orden[2,3].peso)
          {
            Console.WriteLine("Se está aplastando" + orden[2,3].nombreObjeto);
          }
          else 
          {
            Console.WriteLine("Nada se está aplastando");
          }
             
        
        }
        
    }        
}
