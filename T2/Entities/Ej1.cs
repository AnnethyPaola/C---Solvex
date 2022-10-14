using System;

namespace T2.Entity 
{
    //Clase de tipo dato generico
    public class Stack<T>
{
    Entry _Pila;
    //METODO
     public void Push(T data)
    {
        _Pila = new Entry(_Pila, data);
    }

    public T Pop()
    {
        if (_Pila == null)
        {
            throw new InvalidOperationException();
        }
        T result = _Pila._Data;
        _Pila = _Pila._Next;

        return result;
    }
    //Clase aninada
    //Clase aninada: es cuando se define una clase dentro de otra clase
    class Entry
    {
        public Entry _Next { get; set; }
        public T _Data { get; set; }

        public Entry(Entry next, T data)
        {
            _Next = next;
            _Data = data;
        }
    }
}


}