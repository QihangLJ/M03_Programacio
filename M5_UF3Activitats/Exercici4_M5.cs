using System;

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
              Client client = new Client("Garcia","Juan",1234,1212, 1);    
              Proveedor proveidor = new Proveedor("Perez", "Luis", 7890, 8989, 4);
              Partner partner = new Partner("Lopez", "Maria", 5343, 3222, 9);
                
              Console.WriteLine(client.saludar(proveedor.Cognom, proveidor.Nom));
              Console.WriteLine(proveidor.saludar(client.Cognom, client.Nom));
              Console.WriteLine(partner.saludar(client.Cognom, client.Nom));
        
              double descompte = client.calcularDescompte(client.TipusClient);
              Console.WriteLine(descompte);
        
              Console.WriteLine(proveidor.retornarMarge(proveidor.TerminiPagament));
        
              Console.WriteLine(partner.mostrarRisc(partner.IndexReliability));
        }
    }
}
