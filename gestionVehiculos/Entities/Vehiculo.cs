abstract class Vehiculo
{
    private string marca;
    private string modelo;
    private float velocidadMaxima;

    public string Marca { get => marca; set => marca = value; }
    public string Modelo { get => modelo; set => modelo = value; }
    public float VelocidadMaxima { get => velocidadMaxima; set => velocidadMaxima = value; }

    public Vehiculo(string marca, string modelo, float velocidadMaxima)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.VelocidadMaxima = velocidadMaxima;
    }
}