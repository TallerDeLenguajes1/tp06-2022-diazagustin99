// See https://aka.ms/new-console-template for more information
public class Calculadora{
    private double resultado;

    public double Resultado { get => resultado; set => resultado = value; }

    public Calculadora(double valor)
    {
        resultado = valor;
    }

    public void suma(double asumar){
        resultado= resultado + asumar;
    }


    public void Resta(double arestar){
        resultado= resultado - arestar;
    }


    public void Multiplicar(double amultiplicar){
        resultado= resultado * amultiplicar;
    }


    public bool Dividir(double adividir){
        if (adividir!=0)
        {
            resultado= resultado/adividir;
            return true;
        }else
        {
            return false;

        }
    }

    public void Limpiar(){
        resultado=0;
    }
}