// See https://aka.ms/new-console-template for more information
using System;

public class Empleado
{
    private string Nombre, Apellido;
    private DateTime Fnacimiento, FIngreso;
    private char Ecivil, Genero;
    private Cargos Cargo;

    private double Sbasico;



    public string Nombre1 { get => Nombre; set => Nombre = value; }
    public string Apellido1 { get => Apellido; set => Apellido = value; }
    public DateTime Fnacimiento1 { get => Fnacimiento; set => Fnacimiento = value; }
    public DateTime FIngreso1 { get => FIngreso; set => FIngreso = value; }
    public char Ecivil1 { get => Ecivil; set => Ecivil = value; }
    public char Genero1 { get => Genero; set => Genero = value; }
    internal Cargos Cargo1 { get => Cargo; set => Cargo = value; }
    public double Sbasico1 { get => Sbasico; set => Sbasico = value; }

    private TimeSpan RestaFechas(DateTime fechaInicio, DateTime fechaFinal)
    {
        TimeSpan Dif_fecha = fechaFinal.Subtract(fechaInicio);
        return Dif_fecha;
    }

    public TimeSpan Antiguedad()
    {
        var Antiguedad = RestaFechas(FIngreso, DateTime.Now);
        return Antiguedad;
    }

    public TimeSpan Edad()
    {
        var edad = RestaFechas(Fnacimiento, DateTime.Now);
        return edad;
    }

    public double Salario()
    {
        double adicional = 0;
        var aux = Antiguedad();
        int antiguedad = aux.Days / 365;
        if (antiguedad < 20)
        {
            adicional = Sbasico * 0.01 * antiguedad;
        }
        else
        {
            adicional = Sbasico * 0.25;
        }
        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
        {
            adicional = adicional * 0.50 + adicional;
        }

        if (Ecivil == 'c')
        {
            adicional = adicional + 15000;
        }
        return Sbasico + adicional;
    }

    public Empleado(string nombre, string apellido, DateTime fnacimiento, DateTime fIngreso, char ecivil, char genero, Cargos cargo, double sbasico)
    {
        Nombre = nombre;
        Apellido = apellido;
        Fnacimiento = fnacimiento;
        FIngreso = fIngreso;
        Ecivil = ecivil;
        Genero = genero;
        Cargo = cargo;
        Sbasico = sbasico;
    }
}