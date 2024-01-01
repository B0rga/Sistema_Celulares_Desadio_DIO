namespace DesafioPOO.Models{

    public class Nokia : Smartphone{

        // passando todos os parâmetros da classe abstrata para o Nokia
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");
            Thread.Sleep(2000);
        }
    }
}