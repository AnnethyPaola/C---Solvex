using System;
using T2.Entity;
using T2.Services;



internal class Program
{
    private static void Main(string[] args)
    {
        // Objectos 
        var comida = new EComida();
        Console.WriteLine("Instanciar objetos");
        comida.Nombre = "Pasta";
        comida.cantidad = 34;

        Console.WriteLine(comida.Nombre);
        Console.WriteLine(comida.cantidad);

        // Objectos de clases que tienen herencias
        Console.WriteLine("Instanciar objetos de clase con herencia");

        var comidaCompleta = new EcomidaComplicada();

        comidaCompleta.Nombre = "Pasta ";
        comidaCompleta.cantidad = 50;
        comidaCompleta.FechaPreparacion = DateTime.Now;
        comidaCompleta.NumeroPorciones = 40;

        Console.WriteLine($"{comidaCompleta.Nombre} | {comidaCompleta.cantidad} | {comidaCompleta.FechaPreparacion} | {comidaCompleta.NumeroPorciones}");

        var Pila = new T2.Entity.Stack<int>();
        Pila.Push(1);
        Pila.Push(10);
        Pila.Push(30);
        Pila.Push(19);
        Console.WriteLine(Pila.Pop());
        Console.WriteLine(Pila.Pop());
        Console.WriteLine(Pila.Pop());
        Console.WriteLine(Pila.Pop());

        Console.WriteLine("Enums");
        var materia1 = Materias.biologia;
        var materia2 = Materias.matematica;

        Console.WriteLine(materia1 + " y " + materia2);

        //Null types
        string? Text = default;
        Text = "FUNDAMENTOS DE PROGRAMACION.";

        //Frases Sumar1 = new Frases();
        //Sumar1.Frase();

        Frases[] arregloFrases = new Frases[3]{
            new Frases("Monica ", "Diaz"),
            new Frases("Laura ", "Perez"),
            new Frases("Angelica ", "Diaz"),
        };

        Console.WriteLine("Arreglo de frases");
        foreach (Frases frase in arregloFrases){
            Console.WriteLine("Nombre : " + frase.PrimerNombre, frase.SegundoNombre);
        }

        Frases arregloFrases1 = new Frases(" Pamela ", " Diaz ");
        arregloFrases1.caminar();
        arregloFrases1.correr();

        Console.WriteLine("Suma");
        Sumar Suma1 = new Sumar(30, 2);
        Console.WriteLine("Suma " + Suma1);
    }
}