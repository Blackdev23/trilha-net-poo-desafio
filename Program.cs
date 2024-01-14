using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone NOKIA");
            Smartphone nokia = new Nokia("123456", "Modelo 1", "111111", 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("Whatsapp");

            Console.WriteLine("\nSmartphone IPHONE");
            Smartphone iphone = new Iphone("654321", "Modelo 2", "111111", 128);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");
        }
    }
}