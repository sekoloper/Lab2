namespace Lab2
{
    internal class Time
    {
        private int _seconds;

        public int Seconds
        {
            get 
            { 
                return _seconds; 
            }
            set 
            { 
                _seconds = value;
            }
        }

        public void Add(int delta)
        {
            try
            {
                _seconds += delta;
            }
            catch
            {
                Console.WriteLine("Превышена верхняя граница количества секунд, операция отклонена");
            }
        }

        public void Remove(int delta)
        {
            try
            {
                _seconds -= delta;
            }
            catch
            {
                Console.WriteLine("Превышена нижняя граница количества секунд, операция отклонена");
            }
        }

        public Time()
        {
            Seconds = 0;
        }

        public Time (int seconds)
        {
            Seconds = seconds;
        }

        public Time (Time time)
        {
            Seconds = time.Seconds;
        }

        public override string ToString()
        {
            return $"{_seconds % 86400 / 3600}:{Math.Abs(_seconds) % 3600 / 60}:{Math.Abs(_seconds) % 60}";
        }
    }
}
