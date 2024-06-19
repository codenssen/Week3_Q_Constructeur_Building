namespace Week3_Q_Constructeur_Building
{
    internal class Building
    {
        // Propriété 
        int _floor;
        double _size;


        //Constructeur
        public Building(int floor, double size)
        {
            _floor = floor;
            _size = size;
        }
        public Building(int floor)
        {
            _floor = floor;
            _size = 3 * floor;
        }
        public double GetFloorMaxSize() { return (_size / _floor); }
        public int GetFloorCount() { return _floor; }
        public double GetSize() { return _size; }


    }
}
