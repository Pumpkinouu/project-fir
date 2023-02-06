namespace Sapin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool refaire = true;
            do
            {
                // Décaler les premières variables
                int position;
                int branche;
                int tronc;
                int positionfinal;

                // Demander les données pour remplir les variables
                Console.ForegroundColor = ConsoleColor.Gray;
                do
                {
                    Console.Write("Entrez la hauteur des branches (min 10) :");
                    branche = Convert.ToInt32(Console.ReadLine());

                } while (branche <= 9);
                do
                {
                    Console.Write("Entrez la largeur du tronc (chiffre impair, max 7) :");
                    tronc = Convert.ToInt32(Console.ReadLine());
                } while (tronc % 2 == 0 || tronc >= 8);

                Console.Write("Entrez la distance à gauche :");
                position = Convert.ToInt32(Console.ReadLine());

                // Créer les variables qu'on va utiliser dans le code
                int c = branche;
                int copie = c + 1;
                positionfinal = (position);
                Console.Clear();

                // Disposer le curseur là où le sapin va devoir commencer à se créer selon le calcul avec les 
                // données déja récoltées
                Console.SetCursorPosition(positionfinal, c);

                // Changer la couleur du text pour avoir des branches vertes
                Console.ForegroundColor = ConsoleColor.Green;

                // Créer une boucle pour chaque ligne
                for (int boucle = branche; boucle >= 0; boucle--)
                {
                    // Calculer le nombre "x" par ligne
                    int nbcroix = ((boucle * 2) - 1);

                    // Ecrire "x" le nombre de fois calculé au dessus
                    for (int nb = 1; nb <= nbcroix; nb++)
                    {
                        Console.Write("x");
                    }
                    if (boucle == 0)
                    {
                        Console.Write("x");
                    }
                    else if (branche - 0 != boucle)
                    {
                        Console.WriteLine("xx");
                    }

                    // Disposer le curseur sur la prochaine ligne pour répéter le processus
                    Console.SetCursorPosition(positionfinal++, c--);

                }

                // Calculer là où le tronc devra commencer à se créer pour être au milieu du sapin
                int posTronc = (position + branche) - ((tronc + 1) / 2);

                // Changer la couleur du text pour avoir le tronc rouge
                Console.ForegroundColor = ConsoleColor.Red;

                // Disposer le curseur là où on va créer le tronc
                Console.SetCursorPosition(posTronc, copie);

                // Créer une boucle pour écrire chaque ligne du tronc
                for (int p = 6; p >= 0; p--)
                {
                    // Ecrire le code ascii du rectangle rouge le nombre de fois demandé au début
                    for (int o = tronc; o >= 1; o--)
                    {
                        Console.Write("█");
                    }

                    // Passer à la prochaine ligne une fois la première terminer
                    Console.SetCursorPosition(posTronc, copie++);
                }

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("voulez vous refaire le programme ? (oui/non):");
                string oui = "oui";
                if (oui == Console.ReadLine())
                {
                    refaire = true;
                }
                else
                {
                    refaire = false;
                }
                Console.Clear();

            }while (refaire == true);
        }
    }
}