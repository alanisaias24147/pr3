using System;
using System.Collections;

namespace PR3__TODO_list
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            while (opcion != "9")
            {
                opcion = "";
                Queue tarea = new Queue();
                tarea.Enqueue("lavar trastes");
                tarea.Enqueue("pasear al perro");
                tarea.Enqueue("sacar la basura");
                tarea.Enqueue("regar el jardin");
                tarea.Enqueue("comprar una pizza");


                while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5")
                {
                    Console.WriteLine("Elija una opcion");
                    Console.WriteLine("1)agrega tarea");
                    Console.WriteLine("2)checar tarea");
                    Console.WriteLine("3)quitar tarea");
                    Console.WriteLine("4)mostrar todas las tareas");
                    Console.WriteLine("5) salir");

                    opcion = Console.ReadLine();

                    if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion !="5")
                    {
                        Console.WriteLine("La opcion seleccionada no es correcta");
                    }
                }

                if (opcion == "1")
                {
                    Console.WriteLine("agregar tarea");
                    Console.WriteLine("escriba la tarea que desea agregar");
                    string tareaAgregada = Console.ReadLine();
                    tarea.Enqueue(tareaAgregada);
                    foreach (string mostrar in tarea)
                        Console.WriteLine("->{0}",mostrar);
                }
          
                else if (opcion == "2")
                {
                    Console.WriteLine("checar tarea");
                    tarea.Peek();
                    foreach (string mostrar in tarea)
                        Console.WriteLine("Peek->{0}",mostrar);
                }

                else if (opcion == "3")
                {
                    Console.WriteLine("quitar tarea");
                   tarea.Dequeue();
                    foreach (string mostrar in tarea)
                        Console.WriteLine("dequeue->{0}", mostrar);
                }

                else if (opcion == "4")
                {
                    Console.WriteLine("mostrar todas las tareas");
                    tarea.Peek();
                    foreach (string mostrar in tarea)
                        Console.WriteLine("Peek->{0}", mostrar);
                }

                else if (opcion == "5")
                {
                    Console.WriteLine("salir");

                }
            } 
        }
    }
}

            