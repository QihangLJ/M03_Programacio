using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObject
{
    public class patient
    {
        private string? name;
        private string? breed;
        private int edat;
        private bool vaccinated;

        public patient(string? name, string? breed, int edat, bool vaccinated)
        {
            this.name = name;
            this.breed = breed;
            this.edat = edat;
            this.vaccinated = vaccinated;
        }

        public void SetName(string name) { this.name = name; }
        public void SetBreed(string breed) { this.breed = breed; }
        public void SetEdat(int edat) { this.edat = edat; }
        public void SetVaccinated(bool vaccinated) { this.vaccinated = vaccinated; }

        public string GetName() { return this.name ?? "NULL"; }
        public string GetBreed() { return this.breed ?? "NULL"; }
        public int GetEdat() { return this.edat; }
        public bool GetVaccinated() { return this.vaccinated; }


        public bool IsOlderThan(int years)
        {
            return this.edat > years;
        }
    }
}