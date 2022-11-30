using System;

class Empleado
{
    public string Nombre{get; set;}
    public string Puesto { get; set;}
    public int Edad {get;set;}
    public double Sueldo{get;set;}

    public Empleado( string Nombre, string Puesto, int Edad, double Sueldo)
    {
        this.Nombre = Nombre;
        this.Puesto = Puesto;
        this.Edad = Edad;
        this.Sueldo = Sueldo;
    }
    //para mostar
    public override string ToString()
    {
        return string.Format ("{0}, {1}, {2}, {3}", Nombre, Puesto, Edad, Sueldo);
    }

}