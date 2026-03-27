using System;

namespace Ejercicio-Diccionarios-mDorego
{

internal class Program
{

static void Main(string[] args)
{

Jugador jugador1 = new Jugador("jugador1")
bool salir = false;
    Console.WriteLine("Bienvenido a SuperSupervivencia version 1.0\n");
        while (salir == false)
        {
        Console.WriteLine("Que haras ahora?\n\n" +
                          "1 - Ver tu inventario \n" +
                          "2 - Recoger material \n"+
                          "3 - Usar material \n" +
                          "4 - Inspecionar material \n" +
                          "5 - Salir");
                          // opcion 4 deberia mostrar cuanto tenes de un material que le pidas. eso nadamas.

        string opcion = Console.ReadLine();




        }
}

}

}