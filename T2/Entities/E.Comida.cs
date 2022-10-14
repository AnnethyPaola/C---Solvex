using System;

namespace T2.Entity
{
    /*Clases*/
    public class EComida
    {
        //Tipos de datos: String | int
        public string Nombre { get; set; }
        public int cantidad { get; set; }
    }

    /*Clases con herencias*/
    //Accesibilidad
    public class EcomidaComplicada : EComida
    {
        //tipo de datos DateTimeOffset
        public DateTimeOffset FechaPreparacion { get; set; }
        public int NumeroPorciones { get; set; }
    }

    public class Sumar{

        public Sumar(int num1, int num2){
            num1 = num1 + num2;
            Console.WriteLine("La sum es " + num1 );
        }
    }

}