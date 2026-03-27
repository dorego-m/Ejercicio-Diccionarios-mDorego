using System;

namespace Ejercicio-Diccionarios-mDorego
{

class Jugador
{

private string nombre;
private Dictionary<string, int> inventario; //string es el NOMBRE DEL MATERIAL, es la KEY. -- int es la CANTIDAD del material, es el VALOR.

public Jugador(string nombre)
{
    this.nombre = nombre;
    this.inventario = new Dictionary <string, int>();
}

}

}