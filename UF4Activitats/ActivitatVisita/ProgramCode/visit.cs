using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObject
{
    public class visit
    {
        private owner petOwner;
        private patient pet;
        private string date;
        private string visitReason;

        public void SetPetOwner(owner petOwner) { this.petOwner = petOwner; }
        public void SetPet(patient pet) { this.pet = pet; }
        public void SetDate(string date) { this.date = date; }
        public void SetVisitReason(string visitReason) { this.visitReason = visitReason; }

        public owner GetPetOwner() { return this.petOwner; }
        public patient GetPet() { return this.pet; }
        public string GetDate() { return this.date; }
        public string GetVisitReason() { return this.visitReason; }


        public void GetVisitInfo()
        {
            Console.WriteLine($"Informacio del propietari --> Nom: {petOwner.GetName()} DNI: {petOwner.GetDni()} Telefon: {petOwner.GetPhone()} ");
            Console.WriteLine($"Informacio de la mascota --> Nom: {pet.GetName()} Edat: {pet.GetEdat()}");
            Console.WriteLine($"Data: {this.date}");
            Console.WriteLine($"Motiu: {this.visitReason}");
        }
    }
}
