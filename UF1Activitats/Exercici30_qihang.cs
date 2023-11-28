/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 07/11/2023
* Exercici 30: ABBA va ser un grup suec de música pop que es va crear a Estocolm l'any 1972, però la fama li va arribar l'any 1974 en guanyar el Festival de la Cançó d'Eurovisió d'aquell any amb la seva cançó Waterloo. Van aprofitar aquell moment per encadenar un èxit darrere un altre fins a convertir-se en la banda amb més vendes de la dècada dels setanta.
* 
* El grup va destacar també pel seu atrevit vestuari, extravagant i molt colorit. El nom del grup tampoc deixava indiferent, ja que estava compost per les inicials dels quatre membres del grup: Agneta, Björn, Benny i Anni-Frid.
* 
* Entrada
* Cada cas conté la llista de membres d'un grup musical. Un grup musical té un mínim de dos membres i un màxim de quinze (si fossin més no tocarien a res a l'hora de repartir-se els guanys...) La llista es compon pel nom de cadascú dels membres separats per comes a excepció de l'últim membre, que en comptes d'una coma té la conjunció "i".
* 
* Sortida
* Per a cada cas cal indicar la primera lletra del nom de cadascun dels membres en majúscules, sense accents.
* 
*/

using System;

namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string msgEnterList = "Introdueïx els membres del grup:";
            const int maxMembers = 15;

            string memberList;
            char[] groupAcronym = new char[maxMembers];
            int j = 0;

            Console.WriteLine(msgEnterList);
            memberList = Console.ReadLine();
            char[] arrayList = memberList.ToCharArray();

            for (int i = 0; i < arrayList.Length - 1; i++)
            {
                if (i == 0)
                {
                    groupAcronym[j] = arrayList[i];
                    j++;
                }
                else if (arrayList[i] == ',' || (arrayList[i] == 'i' && arrayList[i - 1] == ' '))
                {
                    if ((arrayList[i + 2] == 'Á')||(arrayList[i + 2] == 'À'))
                    {
                        groupAcronym[j] = 'A';
                        j++;
                    }
                    else if ((arrayList[i + 2] == 'É') || (arrayList[i + 2] == 'È'))
                    {
                        groupAcronym[j] = 'E';
                        j++;
                    }
                    else if ((arrayList[i + 2] == 'Í') || (arrayList[i + 2] == 'Ì'))
                    {
                        groupAcronym[j] = 'I';
                        j++;
                    }
                    else if ((arrayList[i + 2] == 'Ó') || (arrayList[i + 2] == 'Ò'))
                    {
                        groupAcronym[j] = 'O';
                        j++;
                    }
                    else if ((arrayList[i + 2] == 'Ú') || (arrayList[i + 2] == 'Ù'))
                    {
                        groupAcronym[j] = 'U';
                        j++;
                    }
                    else
                    {
                        groupAcronym[j] = arrayList[i + 2];
                        j++;
                    }
                }
            }
            foreach (char c in groupAcronym)
            {
                Console.Write(c);
            }
        }
    }
}
