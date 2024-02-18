
namespace MyObject
{
    public class Table : Furniture
    {
        public Table(float weight, double price, bool set, string name, string material, string colour) : base (weight, price, set, name, material, colour) { }

        public override void GetInfo()
        {
            const string Table = "ESPECIFICACIONS TAULA:";
            const string MsgName = "Nom: ";
            const string MsgPrice = "Preu: ";
            const string MsgMaterial = "Material: ";
            const string MsgColour = "Color: ";
            const string MsgWeight = "Pes: ";

            Console.WriteLine(Table);
            Console.WriteLine(MsgName + Name);
            Console.WriteLine(MsgPrice + Price);
            Console.WriteLine(MsgMaterial + Material);
            Console.WriteLine(MsgColour + Colour);
            Console.WriteLine(MsgWeight + Weight);
        }
    }
}