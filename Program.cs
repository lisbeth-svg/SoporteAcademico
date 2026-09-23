using System;

class Program
{
    static void Main()
    {
        MostrarMenu();

        string codigo;
        string nombre;
        string tipo;
        string descripcion;
        string prioridad;

        Console.WriteLine();
        Console.WriteLine("REGISTRO DE SOLICITUD");

        Console.Write("Ingrese código de estudiante: ");
        codigo = Console.ReadLine() ?? "";

        if (!ValidarCodigo(codigo))
        {
            Console.WriteLine("Código inválido.");
            return;
        }

        Console.Write("Ingrese nombre: ");
        nombre = Console.ReadLine() ?? "";

        if (!ValidarTexto(nombre))
        {
            Console.WriteLine("El nombre es obligatorio.");
            return;
        }

        Console.Write("Ingrese tipo de consulta: ");
        tipo = Console.ReadLine() ?? "";

        if (!ValidarTipo(tipo))
        {
            Console.WriteLine("Tipo de consulta inválido.");
            return;
        }

        Console.Write("Ingrese descripción: ");
        descripcion = Console.ReadLine() ?? "";

        if (!ValidarTexto(descripcion))
        {
            Console.WriteLine("La descripción es obligatoria.");
            return;
        }

        prioridad = AsignarPrioridad(tipo);

        MostrarResumen(
            codigo,
            nombre,
            tipo,
            descripcion,
            prioridad
        );
    }

    static void MostrarMenu()
    {
        Console.WriteLine("SISTEMA DE SOPORTE ACADÉMICO");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("1. Registrar solicitud");
        Console.WriteLine("2. Salir");
    }

    static bool ValidarCodigo(string codigo)
    {
        if (string.IsNullOrWhiteSpace(codigo))
        {
            return false;
        }

        if (codigo.Length < 5)
        {
            return false;
        }

        return true;
    }

    static bool ValidarTipo(string tipo)
    {
        if (tipo == "matricula" ||
            tipo == "pagos" ||
            tipo == "constancia" ||
            tipo == "plataforma" ||
            tipo == "otro")
        {
            return true;
        }

        return false;
    }

    static string AsignarPrioridad(string tipo)
    {
        string prioridad;

        if (tipo == "pagos" || tipo == "matricula")
        {
            prioridad = "Alta";
        }
        else if (tipo == "plataforma")
        {
            prioridad = "Media";
        }
        else
        {
            prioridad = "Baja";
        }

        return prioridad;
    }

    static bool ValidarTexto(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto))
        {
            return false;
        }

        return true;
    }

    static void MostrarResumen(
        string codigo,
        string nombre,
        string tipo,
        string descripcion,
        string prioridad)
    {
        Console.WriteLine();
        Console.WriteLine("----- RESUMEN DE SOLICITUD -----");
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Tipo de consulta: " + tipo);
        Console.WriteLine("Descripción: " + descripcion);
        Console.WriteLine("Prioridad: " + prioridad);
    }
}