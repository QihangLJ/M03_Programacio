using System;

namespace Program
{
    class Code
    {
        public static void Main()
        {
            const string MsgCanExtract = "Pots extreure";
            const string MsgCantExtract = "No pots extreure";
            const string MsgInteres = "El interes es: ";

            CompteCorrent compteCorrent = new CompteCorrent(1231213121231, "Pere", 1333.5f, 50.2f);
            CompteEstalvi compteEstalvi = new CompteEstalvi(1231213195343, "Pere", 1333.5f, 0.2f);
            CompteDiposit compteDiposit = new CompteDiposit(1231213124247, "Pere", 1333.5f, 3);

            compteCorrent.MostarDades();
            compteEstalvi.MostarDades();
            compteDiposit.MostarDades();

            Console.WriteLine(compteCorrent.Depositar(200));
            Console.WriteLine(compteEstalvi.Depositar(200));
            Console.WriteLine(compteDiposit.Depositar(200));

            Console.WriteLine(compteCorrent.Extreure(10.5f));
            Console.WriteLine(compteEstalvi.Extreure(20.5f));
            Console.WriteLine(compteDiposit.Extreure(60.5f));

            Console.WriteLine(compteCorrent.PucExtreure(100)? MsgCanExtract : MsgCantExtract);
            Console.WriteLine(MsgInteres + compteEstalvi.CalcularInteres(100));
            compteDiposit.MostrarRisc(100);
        
        }
    }
}
