namespace DemoOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Observable observable = new Observable();
            observable.Notify += (o) => Console.WriteLine($"La valeur a changé : {o.X}");
  
            observable.X = 5;
            observable.X = 7;
            observable.X = 0;
        }        
    }

    class Observable
    {
        public event Action<Observable>? Notify;

        private int _x;

        public int X
        {
            get
            {
                return _x;
            }

            set
            {
                if(X != value)
                {
                    _x = value;
                    Notify?.Invoke(this);
                }
            }
        }
    }

    
}

