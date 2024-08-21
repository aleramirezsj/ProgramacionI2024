using ClasesDeApoyo.Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        Ventilador ventilador = new Ventilador("Negro", "Liliana");
        Console.WriteLine(ventilador);
        ventilador.CambiarVelocidad(2);
        Console.WriteLine(ventilador);
    }
}