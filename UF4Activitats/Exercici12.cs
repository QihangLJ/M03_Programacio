/* Qihang Li Jiang
 * M03_UF4 Programacio
 * 17/02/2024
 * Exercici 12.Implementa l’encadenament de constructors de la classe següent:
    public class Furniture {
    private float weight;
    private double price;
    private boolean set;
    private String name, material, colour;
    }
 */


namespace MyObject
{
    public class Furniture
    {
        private float weight;
        private double price;
        private bool set;
        private string name, material, colour;

        public Furniture() : this(0.0f, 0.0, false, "", "", "") { }

        public Furniture(string name, float weight) : this(weight, 0.0, false, name, "", "") { }

        public Furniture(string name, double price) : this(0.0f, price, false, name, "", "") { }

        public Furniture(string name, string material, string colour) : this(0.0f, 0.0, false, name, material, colour) { }

        public Furniture(float weight, double price, bool set, string name, string material, string colour)
        {
            this.weight = weight;
            this.price = price;
            this.set = set;
            this.name = name;
            this.material = material;
            this.colour = colour;
        }
    }
}
