namespace DesafioPOO.Models{
    public abstract class Smartphone{
        
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria){
            
            // Propriedades públicas e privadas recebendo os parâmetros, para assim 
            // atribuir os dados durante a execução. Mas lembrando que Smartphone 
            // não será instanciado, e sim apenas Nokia e Iphone.           
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Exibir(){
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memória: {Memoria}\n");
        }

        public void Ligar(){
            Console.WriteLine("Ligando...");
            Thread.Sleep(2000);
        }

        public void ReceberLigacao(){
            Console.WriteLine("Recebendo ligação...");
            Thread.Sleep(2000);
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}