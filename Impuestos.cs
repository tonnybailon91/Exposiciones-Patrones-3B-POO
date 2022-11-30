using System;
class Impuestos
{
    //metodo para calcular
    public static double CalcularImpuestos(Empleado empleado1)
    {
        return empleado1.Sueldo * 0.35;
    }
    public static void pagarImpuesto(Empleado empleado1)
    {
        double imp = CalcularImpuestos(empleado1);
        Console.WriteLine("se pago {0} en impuesto por parte{1}", imp, empleado1.Nombre);
    }
}