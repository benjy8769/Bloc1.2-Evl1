/*
Nom : CHEVALIER Benjamin
Auteur : CHEVALIER Benjamin
Titre : Meilleure et pire note
*/



using System;

namespace Exercice_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbr_note;
            float note, max = 0, min = 20;
            try
            {
                Console.WriteLine("Veulliez saisir le nombre de note à rentrer");
                nbr_note = int.Parse(Console.ReadLine());
            }
            catch
            {
                 Console.WriteLine("Veulliez saisir le nombre de note à rentrer");
                 nbr_note = int.Parse(Console.ReadLine());
            }
           

            for (int x = 0; x < nbr_note; x++)
            {
                try
                {
                    Console.WriteLine("Veuillez rentrer la note");
                    note = float.Parse(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("Veuillez rentrer la note");
                    note = float.Parse(Console.ReadLine());
                    x--;
                }

                if (note >= 0 && note <= 20)
                {
                    if (note > max)
                    {
                        max = note;
                    }

                    if (note < min)
                    {
                        min = note;
                    }
                }

                else
                {
                    Console.WriteLine("Erreur");
                }
            }
            Console.Clear();
            Console.WriteLine("Pire note : " + min);
            Console.WriteLine("Meilleure note : " + max);

            //Console.WriteLine("Meilleure note : " + max);
            //Console.WriteLine("Pire note : " + min);
        }
    }
}
