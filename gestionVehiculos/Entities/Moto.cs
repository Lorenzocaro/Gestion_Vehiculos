public class Moto : Vehiculo
{
    public Moto(string marca, string modelo, float velocidadMaxima, float velocidadActual) : base(marca, modelo, velocidadMaxima, velocidadActual)
    {
    }

    public override float Acelerar(float velocidadMaxima, float velocidadActual)
    {
        float aceleracion = velocidadMaxima / 2;
        velocidadActual += aceleracion;
        Console.WriteLine("");
        return velocidadActual;
    }

    public override float Frenar(float velocidadActual, float velocidadMaxima)
    {
        float frenar = velocidadActual / 2;
        velocidadActual -= frenar;
        Console.WriteLine("");
        return velocidadActual;
    }

}