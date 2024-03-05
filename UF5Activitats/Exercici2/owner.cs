using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObject
{
    public class owner
    {
        private int dni;
        private string? name;
        private string? surname;
        private int phone;

        public owner(int dni, string name, string surname, int phone)
        {
            this.dni = dni;
            this.name = name;
            this.surname = surname;
            this.phone = phone;
        }

        public void SetDni(int dni) { this.dni = dni; }
        public void SetName(string name) { this.name = name; }
        public void SetSurname(string surname) { this.surname = surname; }
        public void SetPhone(int phone) { this.phone = phone; }

        public int GetDni() { return this.dni; }
        public string GetName() { return this.name ?? "NULL"; }
        public string GetSurname() { return this.surname ?? "NULL"; }
        public int GetPhone() { return this.phone; }

        public bool IsDNIaNIE()
        {
            string dniString = this.dni.ToString();
            return dniString.Length != 8;
        }

    }
}