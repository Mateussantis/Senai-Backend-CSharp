namespace Ex1.Model
{
    public class PizzasModel
    {
        public string tipo{get; set;}

        public string nome{get; set;}

        public double preco{get; set;}

        public string tamanho{get; set;}

        public PizzasModel (string tipo = "Salgada", string nome = "Pizza Da Casa", double preco = 30.00, string tamanho = "Normal") {
            this.tipo = tipo;
            this.nome = nome;
            this.preco = preco;
            this.tamanho = tamanho;
        }
    }
}