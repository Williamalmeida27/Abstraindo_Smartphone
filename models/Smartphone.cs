public abstract class Smartphone
{

    public string Numero { get; set; }
    private string Modelo { get; set; }
    private string Imei { get; set; }
    private int Memoria { get; set; }

    protected Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        Imei = imei;
        Memoria = memoria;
    }

    public void Ligar(string numero)
    {
        if (numero.Length > 9 && numero.Length < 11)
        {
            Console.WriteLine($"Ligando para: {numero}");
        }
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação");
    }

    public abstract void InstalarAplicativo(string nome);
}