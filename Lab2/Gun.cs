namespace Lab2
{
    internal class Gun
    {
        private int _cartridges;

        public int Cartridges
        {
            get 
            { 
                return _cartridges; 
            }
            set 
            { 
                if (value > 0)
                {
                    _cartridges = value;
                }
                else
                {
                    _cartridges = 0;
                }
            }
        }

        public void Shoot()
        {
            if (_cartridges > 0)
            {
                Console.WriteLine("Бах!");
                _cartridges--;
            }
            else
            {
                Console.WriteLine("Клац!");
            }
        }

        public Gun()
        {
            _cartridges = 5;
        }

        public Gun (int cartridges)
        {
            _cartridges = cartridges;
        }
    }
}
