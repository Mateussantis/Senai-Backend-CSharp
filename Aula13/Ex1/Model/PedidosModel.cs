using System;
namespace Ex1.Model
{
    public class PedidosModel
    {
        public string data{get; set;}

        public string endereco{get; set;}

        public string previsao{get; set;}

       PizzasModel pizza = new PizzasModel();

       public PedidosModel (DateTime data = DateTime.Now, string endereco = "", DateTime previsao)  {
           this.data = data;
           this.endereco = endereco;
           this.previsao = previsao;
       }
    }
}