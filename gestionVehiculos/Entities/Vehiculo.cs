public abstract class Vehiculo
{
    private string marca;
    private string modelo;
    private float velocidadMaxima;
    private float velocidadActual;

    public string Marca { get => marca; set => marca = value; }
    public string Modelo { get => modelo; set => modelo = value; }
    public float VelocidadMaxima { get => velocidadMaxima; set => velocidadMaxima = value; }
    public float VelocidadActual { get => velocidadActual; set => velocidadActual = value; }

    public Vehiculo(string marca, string modelo, float velocidadMaxima, float velocidadActual)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.VelocidadMaxima = velocidadMaxima;
        this.VelocidadActual = velocidadActual;
    }

    abstract public float Acelerar(float velocidadMaxima, float velocidadActual);
    abstract public float Frenar(float velocidadActual, float velocidadMaxima);
}