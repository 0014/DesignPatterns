namespace SingletonPattern
{
    public sealed class Singleton
    {
        public string Property { get; set; }

        public static readonly Lazy<Singleton> _lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance 
        { 
            get
            {
                Console.WriteLine("Instance called.");
                return _lazy.Value;
            }
        }

        private Singleton()
        {
            // private constructur allows the class not to be instantiated from outside
            Console.WriteLine("Constuctor invoked.");
        }
    }
}
