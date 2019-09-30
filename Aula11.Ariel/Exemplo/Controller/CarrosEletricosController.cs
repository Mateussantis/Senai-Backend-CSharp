using Aula11.Ariel.Exemplo.Controller;
using Aula11.Ariel.Exemplo.Model;

namespace Aula11.Ariel.Exemplo.Model
{
    public class CarrosEletricosController  : CarrosController
    {
        
        CarroEletricoModel carroEletrico = new CarroEletricoModel();

        MotorModel motor = new MotorModel();

        public void CarregarBateria(float carga) {
            if (carroEletrico.Bateria < 100) {
                carroEletrico.Bateria += carga;
            }
            else {
                System.Console.WriteLine("A bateria ja esta completa!");
            }
        }

        public double StatusBateria() {
            System.Console.WriteLine(carroEletrico.Bateria);
            return carroEletrico.Bateria;
        }

    }
}