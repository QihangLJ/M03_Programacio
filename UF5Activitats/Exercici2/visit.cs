using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObject
{
    public class visit
    {
        private owner? petOwner;
        private patient? pet;
        private DateTime date;
        private string? visitReason;

        public visit(owner petOwner, patient pet, DateTime date, string visitReason)
        {
            this.petOwner = petOwner;
            this.pet = pet;
            this.date = date;
            this.visitReason = visitReason;
        }

        public void SetPetOwner(owner petOwner) { this.petOwner = petOwner; }
        public void SetPet(patient pet) { this.pet = pet; }
        public void SetDate(DateTime date) { this.date = date; }
        public void SetVisitReason(string visitReason) { this.visitReason = visitReason; }

        public owner GetPetOwner() { return this.petOwner; }
        public patient GetPet() { return this.pet; }
        public DateTime GetDate() { return this.date; }
        public string GetVisitReason() { return this.visitReason ?? "NULL"; }


        public void GetVisitInfo()
        {
            Console.WriteLine($"Informacio del propietari --> Nom: {petOwner.GetName()} DNI: {petOwner.GetDni()} Telefon: {petOwner.GetPhone()} ");
            Console.WriteLine($"Informacio de la mascota --> Nom: {pet.GetName()} Edat: {pet.GetEdat()}");
            Console.WriteLine($"Data: {this.date.ToString("dd MMM yyyy")}");
            Console.WriteLine($"Motiu: {this.visitReason}");
        }
    }
}