/*
 * Nom: Qihang Li Jiang
 * Módul: M03: UF1 Programació estructurada
 * Data: 09/10/2003
 * Exercici 1: Implementa un programa que demani tres nombres enters:
 *      - min i max: valors mínim i màxim
 *      - num
 * El programa haurà de validar si està dins del rang (entre min i max) i en cas contrari, informar a l’usuari, donant per finalitzat el programa.
 * 
 */

using System;
class ExercisesAC2
{
    static void Main()
    {
        const string value_min = "Introdueix un minim: ";
        const string value_max = "Introdueix un maxim: ";
        const string value_num = "Introdueix un nombre enter: ";

        int num_min, num_max, num;

        Console.Write(value_min);
        num_min = Convert.ToInt32(Console.ReadLine());
        Console.Write(value_max);
        num_max= Convert.ToInt32(Console.ReadLine());
        Console.Write(value_num);
        num = Convert.ToInt32(Console.ReadLine());

        string inside = ((num_min < num) && (num < num_max)) ? "El valor num està dintre del rang" : "El valor num NO està dintre del rang";

        Console.Write(inside);
    }
}
