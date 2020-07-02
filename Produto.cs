namespace _555
{
    public class Produto
    {
        public int Codigo {get; set;}
        public string Nome{get;set;}
        public float Preco{get;set;}
       

        public Produto(int _codigo, string _nome, float _proco)
        {
            this.Codigo = _codigo;
            this.Nome   = _nome;
            this.Preco  = _proco;
        }
        public Produto()
        {
        }
    }   

    public class Cartao
    {
        public string Titular {get;set;}
        public decimal Numero {get;set;}
         public float CVV {get;set;}
        public float Vencimento {get;set;}
        public string Bandeira {get;set;}

        public Cartao(string _titular, decimal _numero, float _cvv, float _vencimento,string _bandeira){
            this.Titular    = _titular;
            this.Numero     = _numero;
            this.CVV        = _cvv;
            this.Vencimento = _vencimento;
            this.Bandeira   = _bandeira;
        }
        public Cartao()
        {}
    }
}