Console.WriteLine("Primer Codigo");
//Tipos de Datos 
//1. Tipos de datos Numericos
int numero=12; //Enteros
double numero2=3.14161922; // Decimales de mayor alcance
float numero3=4.5F; //Decimales de menor alcane
//2. Tipos de Datos Cadenas de Caracteres
string materia="Objetos II"; //Cadena de caracter
char letra='A';
//3. Tipos de datos Logicos - Booleanos
bool encender=true;
//Tipos de datos Compuestos
//1. Fecha y Hora
DateTime fechaactual=DateTime.Now;
//2. Tipos Array []
int[] edades={24,12,25,36,45,75,15};

//Imprension en Pantalla
Console.WriteLine(numero);
Console.WriteLine(fechaactual);
Console.WriteLine(numero2);
Console.WriteLine(numero3);
Console.WriteLine(materia);
Console.WriteLine(encender);

//Operadores en C#
//Operadores Aritmeticos
//Suma, Resta, Multiplicacion, Division, Modulo
int num1=45;
int num2=60;
int suma=num1+num2;
int resta=num1-num2;
int multiplicacion=num1*num2;
int division=num1/num2;
Console.WriteLine("SUMA");
Console.WriteLine(suma);
Console.WriteLine("RESTA");
Console.WriteLine(resta);
Console.WriteLine("MULTIPLICACION");
Console.WriteLine(multiplicacion);
Console.WriteLine("DIVISION");
Console.WriteLine(division);
Console.WriteLine("MODULO");
Console.WriteLine(num1%2);
//Operadores de cadenas de caracteres
//Concatenar
//Operadores Logicos
//Mayor que, Menor que, Igual que, Distinto que, y, o
Console.WriteLine(num1>=num2); //True
Console.WriteLine(num1<=num2); //False
Console.WriteLine(num1==num2); //False
Console.WriteLine(num1!=num2); //True

//Condicionales en c#
//If: Estructura de control si se cumple una condicion y es verdadero, mostrar una linea de codigo
//else: Caso contrario mostrar otra linea de codigo
//Ejercicio 1 - Condicionales Simples
if (num1>=num2){
    Console.WriteLine("La variable 1 es el mayor");
}
else{
    Console.WriteLine("La variable 2 es el mayor");
}
//Ejercicio 2 - Condicionales Compuestas
//if -- 
int opcion=1;
if (opcion==1){
    Console.WriteLine("Selecion Opcion 1");
}
else if (opcion==2){
    Console.WriteLine("Selecion Opcion 2");
}
else if(opcion==3){
    Console.WriteLine("Seleccion Opcion 3");
}
else if(opcion==4){
    Console.WriteLine("Seleccion Opcion 4");
}
else {
    Console.WriteLine("Error");
}

//Entradas de Datos
//Console.ReadLine();
//Ejercicio 3. Solicitar ingresar nombre completo
//Console.ReadLine("Ingrese su Nombre Completo");
//Console.ReadLine("Ingrese su edad");

//int num5=45;
//string num6="12";
//Console.WriteLine(num5*num6);
Console.WriteLine("Ingrese su edad:");
//Convertir la cadena de caracter en tipo de datos numerico
int edadd=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese su Nombre:");
string nombree=Console.ReadLine();

Console.WriteLine("Bienvenido "+nombree);

//Ejercicio de Clase 1.
//Realizar una calculadora simple con un menu de opciones
int opcionElegir=Convert.ToInt32(Console.ReadLine());

int operador1=Convert.ToInt32(Console.ReadLine());
int operador2=Convert.ToInt32(Console.ReadLine());