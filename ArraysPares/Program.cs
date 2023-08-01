//Crear un programa para contar la cantidad de numeros pares e impares dentro de una lista 
//1. Clase
//2. Atributos o parametros
//3. Metodos o Acciones
//4. Objetos

using System;
//1. clase
class Program
{
    //2. Atributos o Parametros
    static void Main()
    {
       Console.Write("Ingrese la cantidad numeros: ");
       int cantidad=Convert.ToInt32(Console.ReadLine());
       int[] numeros= new int[cantidad];

        //Bucle iterativo para ingresar los numeros a la lista
       for(int i=0; i<cantidad;i++)
       {
        Console.WriteLine("Ingrese un numero: ");
        numeros[i]=Convert.ToInt32(Console.ReadLine());
       }
       int cantidadPares=0;
       int cantidadImpares=0;
       //Iteracion para la cantidad de elementos de la lista
       //Comparativa para filtrar los numeros pares
       for(int i=0;i<cantidad;i++)
       {
        if(numeros[i]%2==0)
        {
            cantidadPares++;
        }
        else
        {
            cantidadImpares++;
        }
       }
    Console.WriteLine("La cantidad de numeros pares de la lista son: "+cantidadPares);
    Console.WriteLine("La cantidad de numeros impares de la lista son: "+cantidadImpares);

    }
}