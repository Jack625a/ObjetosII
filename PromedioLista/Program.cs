//Crear un programa para calcular el promedio de los elementos de una lista
//Solicitar al usuario la cantidad de numeros en la lista
//Ingresar por teclado todos los numeros a la lista
//1. Crear la clase
//2. Definir los parametros o atributos
//3. Acciones
//4. Ojetos 
using System;
//1. Crear la clase
class Program
{
    static void Main()
    {
        //Parametros
        Console.WriteLine("Ingrese la cantidad de numeros de la lista: ");
        int cantidad=Convert.ToInt32(Console.ReadLine());
        //3. Acciones
        int[] numeros=new int[cantidad];
        for(int i=0;i<cantidad;i++)
        {
            Console.Write("Ingrese el numero a la lista: ");
            numeros[i]=Convert.ToInt32(Console.ReadLine());
        }
        //4.Objeto de la clase
        int producto=1;
        for(int i=0;i<cantidad;i++)
        {
            producto=producto*numeros[i];
            //producto*=numeros[i];
        }
        Console.WriteLine("El producto de los numeros es "+producto);
    }
}