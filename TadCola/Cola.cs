using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Cola
{
    class Cola
    {
        public Queue miCola = new Queue();
        public void Acceso()
        {
            Console.WriteLine("INICIO COLA \n-----------");
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("a");
            numbers.Enqueue("b");
            numbers.Enqueue("c");
            numbers.Enqueue("d");
            numbers.Enqueue("e");
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nQuitar de la Cola '{0}'", numbers.Dequeue());
            Console.WriteLine("Siguiente elemento a quitar de la cola: {0}",
                numbers.Peek());
            Console.WriteLine("Quitar de la cola '{0}'", numbers.Dequeue());

            Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

            Console.WriteLine("\nContenido de la primera Cola:");
            foreach (string number in queueCopy)
            {
                Console.WriteLine(number);
            }

            string[] array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);

            Queue<string> queueCopy2 = new Queue<string>(array2);

            Console.WriteLine("\nContenido de la segunda cola copia, con duplicado y nulos:");
            foreach (string number in queueCopy2)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nCopia de cola contiene(\"d\") = {0}",
               queueCopy.Contains("d"));
        }
    }
}