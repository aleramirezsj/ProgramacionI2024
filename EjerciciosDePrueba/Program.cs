﻿


using EjerciciosDePrueba.Clases;
using EjerciciosDePrueba.Enums;

public class ProgramEjercicios
{
    private static void Main(string[] args)
    {
        //PedirNombreYSaludar();
        //CalcularDiasDeVida();
        //ImprimirMinimoDe4();
        //CalcularValorPago();
        //PruebaDeObjetoSplit();
        //PruebaDeObjetoPersona();
        //PruebaPavaElectrica();
        //PruebaDeClasesAbstractasYHerencia();
        //PruebaCalculadoraPasajePorReferencia();
        //fechasValidasInvalidas();
        //Console.WriteLine(ControlFechasValida(31, 4, 2023));
        //Console.WriteLine(CalcularDiasDeVida(10, 10, 1));
        PruebaDeClasesGenéricas();
    }

    private static void PruebaDeClasesGenéricas()
    {
        Empresa<Empleado> empresa = new Empresa<Empleado>("Neumáticos Debona");
        Gerente empleado1 = new Gerente("Juan", "Perez");
        Gerente empleado2 = new Gerente("Pedro", "Gomez");
        empresa.agregarEmpleado(empleado1);
        empresa.agregarEmpleado(empleado2);
        Console.WriteLine(empresa.listarPersonas());
        empresa.quitarEmpleado(empleado2);
        Console.WriteLine(empresa.listarPersonas());


    }

    private static void PruebaCalculadoraPasajePorReferencia()
    {
        int a = 123;
        int b = 10;
        int total = 0;
        Calculadora calculadora = new Calculadora();
        calculadora.Sumar(a, b, ref total);
        Console.WriteLine("La suma total es:" + total);
    }

    private static void PruebaDeClasesAbstractasYHerencia()
    {
        Gerente juan = new Gerente("Juan Javier", "Fernandez");
        Console.WriteLine(juan.ImprimirDatos());
    }

    private static void PruebaPavaElectrica()
    {
        PavaElectrica miPava = new PavaElectrica("Liliana", "Plateado", "Acero inoxidable");
        miPava.PresionarBotonEncendido();
        miPava.CambiarModo(ModoEnum.Maximo);
        miPava.CalentarAgua();
        Console.WriteLine($"La pava está en modo {miPava.Modo}");
        Thread.Sleep(2000);
        miPava.PresionarBotonEncendido();
        miPava.CambiarModo(ModoEnum.Minimo);
        miPava.CalentarAgua();
        Console.WriteLine($"La pava está en modo {miPava.Modo}");



    }

    private static void PruebaDeObjetoPersona()
    {
        Persona albert = new Persona("Albert Einstein", "9 de Julio 1111", 1879);
        Persona robert = new Persona("Robert Oppenheider", "Manhattan 2222", 1904);
        robert.Decir("Albert, sabés como se despiden los químicos?");
        albert.Decir("No, ni idea");
        albert.Apellido = "Pianetti";
        albert.Dni = 1111111;
        robert.Decir("Acido un placer");
    }

    private static void PruebaDeObjetoSplit()
    {
        //instanciamos el objeto split
        Split miSplit = new Split("Blanco", 3000, "Marshall");
        miSplit.SubirTemperatura();
        miSplit.SubirTemperatura();
        miSplit.PresionarBotonEncendido();
        miSplit.CambiarModo("Deshumidificación");
        miSplit.SubirTemperatura();
        Console.WriteLine("El modo definido del split es:" + miSplit.modo);
    }

    private static void CalcularValorPago()
    {
        //declaramos las variables
        double valorCuota;
        int nroDia;

        //Leemos las variable
        Console.Write("Ingrese valor de la cuota:");
        valorCuota = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el número del día de pago:");
        nroDia = int.Parse(Console.ReadLine());

        switch (nroDia)
        {
            case < 3:
                valorCuota = valorCuota - (valorCuota * 0.03);
                break;
            case >= 6 and <= 10:
                valorCuota = valorCuota + (valorCuota * 0.1);
                break;
            case >= 11 and <= 20:
                valorCuota = valorCuota + (valorCuota * 0.12);
                break;
            case >= 21 and <= 31:
                valorCuota += (valorCuota * 0.15);
                break;
        }
        Console.WriteLine($"El valor de la cuota para el día de pago es:{valorCuota}");
    }

    /// <summary>
    /// algoritmo que imprime el mínimo entre cuatro valores que se piden al usuario.
    /// </summary>
    private static void ImprimirMinimoDe4()
    {
        //declaramos las variables
        int num1, num2, num3, num4;

        //pedimos el ingreso de los 4 números
        Console.Write("Ingrese el primer número:");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número:");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer número:");
        num3 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el cuarto número:");
        num4 = int.Parse(Console.ReadLine());

        //comparamos los números
        if (num1 < num2 && num1 < num3 && num1 < num4)
            Console.WriteLine("El número menor es primero: " + num1);
        if (num2 < num1 && num2 < num3 && num2 < num4)
            Console.WriteLine("El número menor es el segundo: " + num2);
        if (num3 < num1 && num3 < num2 && num3 < num4)
            Console.WriteLine("El número menor es el tercero: " + num3);
        if (num4 < num1 && num4 < num3 && num4 < num2)
            Console.WriteLine("El número menor es el cuerto: " + num4);
    }

    //Creamos un método que pida el nombre y apellido del usuario
    //y posteriormente lo salude con "Bienvenido [Apellido], [Nombre]
    private static void PedirNombreYSaludar()
    {
        //Declaramos las variables
        string nombre, apellido;

        Console.Write("Ingrese su nombre:");
        nombre = Console.ReadLine();

        Console.Write("Ingrese su apellido:");
        apellido = Console.ReadLine();

        //Console.WriteLine("Bienvenido "+apellido+", "+nombre);
        Console.WriteLine($"Bienvenido {apellido}, {nombre}");
    }

    /*Creamos un método que nos pida los años, meses y días de vida
    y muestre al final la cantidad total de días de vida
     */
    private static void CalcularDiasDeVida()
    {
        //declaramos las variables
        int años, meses, dias, diasDeVida;

        Console.Write("Ingrese sus años de vida:");
        años = int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus meses de vida:");
        meses = int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus días de vida:");
        dias = int.Parse(Console.ReadLine());

        diasDeVida = (años * 365) + (meses * 30) + dias;

        Console.WriteLine($"Los días de vida totales son:{diasDeVida}");
    }
    public static int CalcularDiasDeVida(int años, int meses, int dias)
    {
        //declaramos las variables
        int diasDeVida;

        diasDeVida = (años * 365) + (meses * 30) + dias;

        return diasDeVida;
    }
    private static void fechasValidasInvalidas()

    {
        //definir variables  
        int dia, mes, año;

        // Pedir Informacion al usuario
        Console.WriteLine("Ingrese el día");
        dia = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el mes");
        mes = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el año");
        año = int.Parse(Console.ReadLine());


        if ((dia >= 1 && dia <= 31) && (mes == 1 || mes == 3 ||
                mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12))
            Console.WriteLine("Fecha Valida");

        else if ((dia >= 1 && dia <= 30) && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
            Console.WriteLine("Fecha Valida ");

        else if ((dia == 29) && (mes == 2) && (año % 4 == 0) || (dia >= 1 && dia <= 28) && (mes == 2))

            Console.WriteLine("Fecha Valida ");

        else
            Console.WriteLine("Fecha Invalida");

    }
    public static bool ControlFechasValida(int dia, int mes, int año)

    {
        if ((dia >= 1 && dia <= 31) && (mes == 1 || mes == 3 ||
                mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12))
            return true;

        else if ((dia >= 1 && dia <= 30) && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
            return true;

        else if ((dia == 29) && (mes == 2) && (año % 4 == 0) || (dia >= 1 && dia <= 28) && (mes == 2))

            return true;

        else
            return false;

    }

    private static void Triangulos()
    {
        // Declaramos las variables 
        int lado1, lado2, lado3;

        Console.Write("Ingrese el 1er Lado del triángulo: ");
        lado1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el 2do Lado del triángulo: ");
        lado2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el 3er Lado del triángulo: ");
        lado3 = int.Parse(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("El triángulo es equilátero.");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("El triángulo es isósceles.");
        }
        else
        {
            Console.WriteLine("El triángulo es escaleno.");
        }
    }
    public static string Triangulos(int lado1, int lado2, int lado3)
    {
        if (lado1 == lado2 && lado2 == lado3)
        {
            return "equilatero";
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            return "isoceles";
        }
        else
        {
            return "escaleno";
        }

    }

}

