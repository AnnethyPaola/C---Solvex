using System;

namespace Test{
    public class CaminarComportamiento{

        public string Caminar {get;}

        public Comportamiento(string caminar){
            console.WriteLine("Esta Persona Puede caminar");
        }
    
    }

    public class ComportamientoHumano: CaminarComportamiento{
        public string Correr{get;}

        public ComportamientoH(string caminar, string correr){
            console.WriteLine("Esta Persona puede correr");
        }
    }
}