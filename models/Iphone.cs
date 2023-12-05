namespace celular.models
{
    class Iphone : Smartphone
    {
        public Iphone(
            string Numero, 
            string Modelo, 
            string Imei, 
            int Memoria): base(Numero, Modelo, Imei, Memoria)
        {}

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando app {nome} no Iphone");
        }
    }
}