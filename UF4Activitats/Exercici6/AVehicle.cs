namespace MyObject
{
    public abstract class AVehicle
    {
        protected string name;
        protected string color;
        protected bool wheeled;

        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public bool Wheeled { get => wheeled; set => wheeled = value; }

        public AVehicle(string name, string color, bool wheeled)
        {
            Name = name;
            Color = color;
            Wheeled = wheeled;
        }
    }
}