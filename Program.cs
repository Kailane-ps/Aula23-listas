using System;
using System.Collections.Generic;

namespace _555
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando Lista
            List<Produto> produtos = new List<Produto>();
        
            Produto Produto1 = new Produto();
            Produto1.Codigo  = 1;
            Produto1.Nome    = "Samsung SmartTV";
            Produto1.Preco   = 400.99f;

           produtos.Add(Produto1);

           produtos.Add( new Produto(2,"Frigobar Brastemp",156.99f));
           produtos.Add( new Produto(3,"Refrigerador Panasonic",419.99f));
           produtos.Add( new Produto(4,"Fogão de piso Atlas",508.99f));
           produtos.Add( new Produto(5,"Forno Micro-ondas LG",449.99f));
           produtos.Add( new Produto(7,"Maquina de lava",999.99f));
           produtos.Add( new Produto(6,"Ferro a Vapor",200.99f));
           
           foreach (Produto item in produtos)
           {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"R$ {item.Preco} \t {item.Nome}");
            Console.ResetColor();
           }
            //Removendo itens
            produtos.Remove(Produto1);
            produtos.RemoveAt(2);
            produtos.RemoveAll(y=>y.Nome == "Refrigerador Panasonic");

            //Para ler os itens Removidos
            foreach(Produto item in produtos)
            {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"R$ {item.Preco} \t {item.Nome}");
            Console.ResetColor();
            }
            //Para Encontrar um Produto
            Produto ml = produtos.Find(sla => sla.Codigo == 7);
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"O Produto que você procura é:\nMaquina de lavar R$ {ml.Preco}");
            Console.ResetColor();

            //Complemento

            //Criando Lista de cartões
            List<Cartao> cartoes = new List<Cartao>();

            Cartao C = new Cartao();

            C.Titular    ="Maria Silva";
            C.Numero     = 1111222233334440m;
            C.CVV        = 123f;
            C.Vencimento = 1220f;  
            C.Bandeira   = "Master Card";

            //Cartões instanciados
            cartoes.Add( new Cartao( "João Antonio",5555666677778888m, 111f, 1324f, "Visa"));
            cartoes.Add( new Cartao( "Ana Paula",9999111122224444m, 222f, 1421f, "Elo"));
            cartoes.Add( new Cartao( "Juliana Helena",6666777788883333m, 333f, 1825f, "Aelo"));
            cartoes.Add( new Cartao( "Pedro Santos",2222777799991111m, 444f, 1727f, "Hiber Card"));  

            //Mostrar os Cartões instanciados
            foreach(Cartao item in cartoes){
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.WriteLine( $"\nTitular:\t{item.Titular}\nNumero:\t\t{item.Numero}\nCVV:\t\t{item.CVV}\nVencimento:\t{item.Vencimento}\nBandeira:\t{item.Bandeira}");
            Console.ResetColor();}
        }
     }   
}
