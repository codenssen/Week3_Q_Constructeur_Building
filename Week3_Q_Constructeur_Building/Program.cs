namespace Week3_Q_Constructeur_Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int buildingFloor;
            double buildingSize;

            Console.WriteLine("(obligatoire) Quelle sera le nombre d'étage souhaité ?");
            buildingFloor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(optionnel) Quelle sera la hauteur en mètre du bâtiment à construire ? (Mettre 0 si pas de choix)");
            buildingSize = Convert.ToDouble(Console.ReadLine());
            if (buildingSize == 0)
            {
                Building batiment1 = new Building(buildingFloor);
                Console.WriteLine($"Taille des étages :{batiment1.GetFloorMaxSize()}");
                Console.WriteLine($"Nombre d'étage :{batiment1.GetFloorCount()}");
                Console.WriteLine($"Hauteur du bâtiment :{batiment1.GetSize()}");
            }
            else
            {
                Building batiment1 = new Building(buildingFloor, buildingSize);
                Console.WriteLine($"Taille des étages :{batiment1.GetFloorMaxSize()}");
                Console.WriteLine($"Nombre d'étage :{batiment1.GetFloorCount()}");
                Console.WriteLine($"Hauteur du bâtiment :{batiment1.GetSize()}");
            }
           

        }
    }
}
