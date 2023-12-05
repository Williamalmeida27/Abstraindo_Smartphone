namespace celular.models
{
    class Nokia : Smartphone
    {
        public Nokia(
        string numero, 
        string modelo, 
        string imei, 
        int memoria) : base(numero, modelo, imei, memoria)
        { }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine("Instalando no seu Nokia o app {nome}");
        }
    }
}