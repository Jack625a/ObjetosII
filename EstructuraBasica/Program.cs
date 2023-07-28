//Programacion Orientada a Objetos
//1. Nombre de clase
//2. Atributos o Parametros de la clase
//3. Metodos o Acciones
//4. Objetos

//Ejercicio 1- Crear un programa que solicite el nombre y la edad para realizar la verificacion si es mayor de edad


using System;
class Program
{
    //Metodo principales, atributos o parametros que tendra la clase
    static void Main()
    {
        //Solicitar al usuario el ingreso de su nombre
        Console.Write("Ingrese su nombre completo");
        string nombre=Console.ReadLine();

        //Solicitar al usuario el ingreso de su edad
        Console.WriteLine("Ingrese su edad");
        int edad=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hola bienvenido "+nombre+ " la edad registrada es "+edad);
        //Verificar si es mayor de edad
        if (edad>=18){
            Console.Write(nombre+" es mayor de edad");
        }
        else
        {
            Console.Write(nombre+ " no es mayor de edad");
        }

        MostrarInformacion();
    }
    //Definir los metodos o acciones
    static void MostrarInformacion()
    {
        Console.WriteLine("Hola bienvenido ");
    }
}
