
namespace MyObject
{
    public class Furniture
    {
        private float weight;
        private double price;
        private bool set;
        private string name, material, colour;

        public float Weight { get; set; }
        public double Price { get; set; }
        public bool Set { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Colour { get; set; }

        public Furniture() : this(0.0f, 0.0, false, "", "", "") { }

        public Furniture(string name, float weight) : this(weight, 0.0, false, name, "", "") { }

        public Furniture(string name, double price) : this(0.0f, price, false, name, "", "") { }

        public Furniture(string name, string material, string colour) : this(0.0f, 0.0, false, name, material, colour) { }

        public Furniture(float weight, double price, bool set, string name, string material, string colour)
        {
            Weight = weight;
            Price = price;
            Set = set;
            Name = name;
            Material = material;
            Colour = colour;
        }

        public virtual void GetInfo() {
            const string Furniture = "INFORMACIO DEL MOBLE:";
            const string MsgName = "Nom: ";
            const string MsgMaterial = "Material: ";
            const string MsgColour = "Color: ";

            Console.WriteLine(Furniture);
            Console.WriteLine(MsgName + Name);
            Console.WriteLine(MsgMaterial + Material);
            Console.WriteLine(MsgColour + Colour);
        }
    }
}
