/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 08/11/2023
* Exercici 1 (repte): En el videojoc League of Legends una de les parts més importants per al jungla (un dels rols), per exemple un Rammus, és matar al primer gran monstre (conegut popularment com a “blau” o “vermell”). Per fer això necessites ajuda del teu equip, com per exemple un Twitch. No obstant, alguns del teu equip poden tenir habilitats de verí…).
* 
*/

using System;
class JunglaLOL
{
    static void Main()
    {
        const string intro_test_number = "Introdueix el nombre de proves que vol realitzar:";
        const string intro_monster_health = "Introdueix la quantitat de vida que té el monstre de la jungla:";
        const string intro_rammus_dmg = "Introdueix el dany de Rammus:";
        const string intro_twitch_dmg = "Introdueix el dany del veri de Twitch:";
        int test_num, max_health, rammus_dmg, twitch_dmg, rounds;
        bool victory_rammus;

        Console.WriteLine(intro_test_number);
        test_num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < test_num; i++)
        {
            Console.WriteLine(intro_monster_health);
            max_health = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intro_rammus_dmg);
            rammus_dmg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intro_twitch_dmg);
            twitch_dmg = Convert.ToInt32(Console.ReadLine());

            rounds = 0;
            victory_rammus = false;

            while (max_health > 0)
            {
                max_health = max_health - rammus_dmg;
                if (max_health <= 0)
                {
                    victory_rammus = true;
                }
                max_health = max_health - twitch_dmg;
                rounds++;
            }

            if (victory_rammus)
            {
                Console.WriteLine("RAMMUS " + rounds);
            }
            else
            {
                Console.WriteLine("TWITCH " + rounds);
            }

        }
    }
}