internal class Program
{
    private static void Main(string[] args)
    {
        Empleado empleado1 = new Empleado("Veronica", "programador", 22, 3400);
        Console.WriteLine(empleado1);
        Console.WriteLine(Impuestos.CalcularImpuestos(empleado1));
        Impuestos.pagarImpuesto(empleado1);
    }
}