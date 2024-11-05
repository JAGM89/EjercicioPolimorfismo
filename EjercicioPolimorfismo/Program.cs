

namespace EjercicioPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el tipo de animal (Animal, Perro, Gato): ");
            string tipoAnimal = Console.ReadLine();

            Animal animal;

            switch (tipoAnimal.ToLower())
            {
                case "perro":
                    animal = new Perro();
                    break;
                case "gato":
                    animal = new Gato();
                    break;
                case "animal":
                default:
                    animal = new Animal();
                    break;
            }

            animal.Hablar();

           
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}