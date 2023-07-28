//Ejercicio 1. Encontrar el numero mayor de un array
using System;
class Program //Paso 1 Definir la clase
{
    //Paso dos definir los atributos o parametros
    static void Main()
    {   
        //Paso 2
        Console.WriteLine("Ingrese la cantidad de numeros: ");
        int cantidad=Convert.ToInt32(Console.ReadLine());

        int[] numeros=new int[cantidad];
        for (int i=0;i<cantidad;i++)
        {
            Console.WriteLine("Ingrese el numero :");
            numeros[i]=Convert.ToInt32(Console.ReadLine());
        }
        //Paso 3
        int mayor=numeros[0];
        for (int i=1;i<cantidad;i++)
        {
            if(numeros[i]>mayor)
            {
                mayor=numeros[i];
            }
        }
    Console.WriteLine("El numero mayor es: "+mayor);
    }
}
