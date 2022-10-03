namespace DesafioPOO.Models
{
    // DONE: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // DONE: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }
    }
}