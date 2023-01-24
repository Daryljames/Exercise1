namespace Exercise1.Models
{
    public class App
    {
        public string name { get; private set; }
        public float size { get; set; }

        public App(string name, float size)
        {
            this.name = name;
            this.size = size;
        }
    }
}