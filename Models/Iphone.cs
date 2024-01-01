namespace DesafioPOO.Models{
    
    public class Iphone : Smartphone{
        
        // passando todos os parâmetros da classe abstrata para o Nokia
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando {nomeApp} no Iphone...");
            Thread.Sleep(2000);
        }
    }
}