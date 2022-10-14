using System;
using T2.Entity;

namespace T2.Services
{
    //Modificadores de acceso
   public interface IFrase {
    string PrimerNombre {set; get;}
    string SegundoNombre {set; get;}

    void caminar();

    void correr();
     
   }

   public class Frases : IFrase {
    public string PrimerNombre {set; get;}
    public string SegundoNombre {set; get;}

    public Frases(string PrimerNombre, string SegundoNombre){
      this.PrimerNombre = PrimerNombre;
      this.SegundoNombre = SegundoNombre;
    }

    public void caminar(){
      Console.WriteLine(" La persona llamada " + PrimerNombre + SegundoNombre + " puede caminar ");
    }

    public void correr(){
      Console.WriteLine(" La persona llamada " + PrimerNombre + SegundoNombre + " puede correr ");
    }

   }
} 
   
