using System;

class Program
{
    static void Main()
    {
        MostrarMenu();

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine();
            Console.WriteLine("===== SOLICITUD " + i + " =====");

            RegistrarSolicitud();
        }

        Console.WriteLine();
        Console.WriteLine("Proceso terminado.");
    }

    // Req. 1 y Req. 4: muestra el menú del sistema
    static void MostrarMenu()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("   SISTEMA DE SOPORTE ACADÉMICO");
        Console.WriteLine("=================================");
        Console.WriteLine("1. Registrar solicitud");
        Console.WriteLine("2. Salir");
    }

    // Req. 1 y Req. 10: registra una solicitud
    static void RegistrarSolicitud()
    {
        string codigo;
        string nombre;
        string tipo;
        string descripcion;
        string prioridad;

        // Req. 1: registra los datos básicos
        Console.Write("Ingrese código de estudiante: ");
        codigo = Console.ReadLine() ?? "";

        // Req. 2: valida el código
        if (!ValidarCodigo(codigo))
        {
            Console.WriteLine("Código inválido.");
            return;
        }

        Console.Write("Ingrese nombre: ");
        nombre = Console.ReadLine() ?? "";

        // Req. 6: valida el nombre
        if (!ValidarTexto(nombre))
        {
            Console.WriteLine("El nombre es obligatorio.");
            return;
        }

        Console.Write("Ingrese tipo de consulta: ");
        tipo = Console.ReadLine() ?? "";

        // Req. 3: valida el tipo de consulta
        if (!ValidarTipo(tipo))
        {
            Console.WriteLine("Tipo de consulta inválido.");
            return;
        }

        Console.Write("Ingrese descripción: ");
        descripcion = Console.ReadLine() ?? "";

        // Req. 6: valida la descripción
        if (!ValidarTexto(descripcion))
        {
            Console.WriteLine("La descripción es obligatoria.");
            return;
        }

        // Req. 5: asigna la prioridad
        prioridad = AsignarPrioridad(tipo);

        // Req. 7: muestra el resumen
        MostrarResumen(
            codigo,
            nombre,
            tipo,
            descripcion,
            prioridad
        );
    }

    // Req. 2: valida que el código tenga mínimo 5 caracteres
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

    // Req. 3: valida los tipos de consulta
    static bool ValidarTipo(string tipo)
    {
        tipo = tipo.ToLower();

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

    // Req. 5 y Req. 9: asigna prioridad
    static string AsignarPrioridad(string tipo)
    {
        string prioridad;

        tipo = tipo.ToLower();

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

    // Req. 6: valida que los textos no estén vacíos
    static bool ValidarTexto(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto))
        {
            return false;
        }

        return true;
    }

    // Req. 7 y Req. 8: muestra el resumen y recibe parámetros
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