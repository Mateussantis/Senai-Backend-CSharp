namespace testee.Model
{
    public class TesteModel
    {
        public string nome{get; set;}
        public string numero{get; set;}

        public TesteModel(string nome = "Padrão Nome", string numero = "Padrão Numero") {
            this.nome = nome;
            this.numero = numero;
        }
    }
}