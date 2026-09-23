using System;

class Program
{
    static void Main()
    {
        string codigo;
        string nombre;
        string tipo;
        string descripcion;

        Console.WriteLine("SISTEMA DE SOPORTE ACADÉMICO");
        Console.WriteLine("-----------------------------");

        Console.Write("Ingrese código de estudiante: ");
        codigo = Console.ReadLine();

        Console.Write("Ingrese nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese tipo de consulta: ");
        tipo = Console.ReadLine();

        Console.Write("Ingrese descripción: ");
        descripcion = Console.ReadLine();
    }
}