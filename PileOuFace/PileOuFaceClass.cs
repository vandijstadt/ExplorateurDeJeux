using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorateurDeJeux
{
    class PileOuFaceClass
    {
        public void game(int[,] mise, int random)
        {
            int nombreDePointEnJeux=0, nomnbreDeGagnant=0;

            for (int i = 0; i < Program.j.Count; i++)
            {
                nombreDePointEnJeux+=mise[i, 1];
                if(mise[i, 2] == random)
                {
                    nomnbreDeGagnant++;
                }
            }
            for (int i = 0; i < Program.j.Count; i++)
            {
                if (mise[i, 2] == random)
                {
                    Program.j[i].AddPoint(nombreDePointEnJeux / nomnbreDeGagnant);
                }
                else if(mise[i, 2] != 0){ 
                    Program.j[i].RemovePoint(mise[i,1]); 
                }
            }
            debugComande(random);
        }
        public void debugComande(int valeur)
        {
            solution(valeur);
            pointJoueur();
        }

        private void pointJoueur()
        {
            for (int i = 0; i < Program.j.Count; i++)
            {
                Debug.WriteLine(Program.j[i].nomJoueur + " : " + Program.j[i].GetPoint());
            }
        }

        private void solution(int valeur)
        {
            if (valeur == 1)
            {
                Debug.WriteLine("Face ! ");
            }
            else if (valeur == 2)
            {
                Debug.WriteLine("Pile ! ");
            }
            else if (valeur == 3)
            {
                Debug.WriteLine("Tranche ! ");
            }
        }
        public static int random()
        {
            Random r = new Random();
            int valeur = r.Next(1000);

            if (valeur <= 100) { valeur = 1; }
            else if (valeur <= 550) { valeur = 2; }
            else if (valeur <= 1000) { valeur = 3; }
            return valeur;
        }
    }
}
