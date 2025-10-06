namespace Lab2
{
    internal class House
    {
        private int _floors;

        public int Floors
        {
            get 
            { 
                return _floors; 
            }
        }

        public House()
        {
            _floors = 1;
        }

        //House(); чтобы убрать стандартный конструктор, удалите его выше и уберите комментарий с этой строки

        public House(int floors)
        {
            if (floors > 1)
            {
                _floors = floors;
            }
            else
            {
                _floors = 1;
            }
        }

        public House(House house)
        {
            _floors = house.Floors;
        }

        public override string ToString()
        {
            if (_floors % 10 == 1 && _floors != 11)
            {
                return $"Дом с {_floors} этажом";
            }
            else
            {
                return $"Дом с {_floors} этажами";
            }
        }
    }
}