namespace Exemplo1.Model
{
    public class ProdutosModel
    {
        public int numero {get; set;}
        public string nome {get; set;}

        public string descricao{get; set;}

        public double numero2 {get; set;}

        public ProdutosModel (int numero = 0,string nome = "Padrão", string descricao = "Padrão", double numero2 = 0.0) {
            System.Console.WriteLine();
            this.numero = numero;
            this.nome = nome;
            this.descricao = descricao;
            this.numero2 = numero2;
        }
    }
}