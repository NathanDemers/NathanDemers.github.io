namespace Tour_de_zork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choixUti = 0;
            string nomPerso;
            int guerrier = 0;
            int magicien = 0;
            int voleur = 0;
            int rep = 0;
            bool jeu = true;
            int guerrier2 = 0;  
            int voleur2=0;
            int magicien2 = 0;
            int choixuti2 = 0;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Nouvelle Partie");
            Console.WriteLine("2. Quitter");
            int.TryParse(Console.ReadLine(), out choixUti);
            if (choixUti == 2)
            {
                Console.Clear();
                Console.WriteLine("Bonne Journée");
                jeu = false;

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Nom de votre personnage?");
                nomPerso = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Reponder au trois question pour savoir si vous aller etre un magicien ou un guerrier");

                Console.WriteLine("Tu fais face à un troll des cavernes! Tu...\r\n  1. prends ta hache et le décapite\r\n  2. jette un sort de flammes. Ça fera parfaitement l'affaire\r\n 3. TU lache prise et vole une grnad-mère");
                int.TryParse(Console.ReadLine(), out rep);

                if (rep == 1)
                {
                    guerrier++;
                }
                else if (rep == 2)
                {
                    magicien++;
                }
                else
                {
                    voleur++;
                }
                Console.Clear();
                Console.WriteLine("Une porte en bois massif bloque l'accès au prochain étage. Tu...\r\n  1. lui donne des couprs de pieds jusqu'à ce qu'elle défonce\r\n  2. reconnais le type de serrure et magnétise le loquet pour l'ouvrir\";\r\n3. Tu arrete et revole une grnad-mère");
                int.TryParse(Console.ReadLine(), out rep);

                if (rep == 1)
                {
                    guerrier++;
                }
                else if (rep == 2)
                {
                    magicien++;
                }
                else
                {
                    voleur++;
                }
                Console.Clear();

                Console.WriteLine("Le monstre que tu as capturé connais la réponse à une énigme critique. Tu...\r\n  1. lui tord tout ce que tu peux imaginer pour le faire parler\r\n  2. lui pose des questions sur l'énigme en lisant son esprit pour découvrir la réponse\r\n3. Tu vole tout sa famille et tout ce qu'il lui appartient pour le rendre triste");
                int.TryParse(Console.ReadLine(), out rep);

                if (rep == 1)
                {
                    guerrier++;
                }
                else if (rep == 2)
                {
                    magicien++;
                }
                else
                {
                    voleur++;
                }
                Console.Clear();

                

                if (guerrier >= 2)
                {
                    Console.WriteLine("guerrier\n");
                    Console.WriteLine("Une brute sanguinaire ou un noble chevalier, à toi de décider. Tu es endurant, rapide et un maître des arts martiaux. Pas le crayon le plus aiguisé de la boîte par contre...");
                    Console.WriteLine("Nom : " + nomPerso);
                    Console.WriteLine("Vie : 30");
                    Console.WriteLine("Armure : 15");
                    Console.WriteLine("Dommage : 10");
                }

                else if (magicien >= 2)
                {
                    Console.WriteLine("Magicien\n");
                    Console.WriteLine("Tu es un maître de l'arcane et des éléments. Mais les années d'étude et de recherche ne t'ont pas laissé l'occasion de développer ton physique.\";\r\n");
                    Console.WriteLine("Nom : " + nomPerso);
                    Console.WriteLine("Vie : 20");
                    Console.WriteLine("Armure : 25");
                    Console.WriteLine("Dommage : 8");
                }
                else if (voleur==2)
                {
                    Console.WriteLine("Voleur\n");
                    Console.WriteLine("Tu es une personne mal élever petit coquin\";\r\n");
                    Console.WriteLine("Nom : " + nomPerso);
                    Console.WriteLine("Vie : 15");
                    Console.WriteLine("Armure : 20");
                    Console.WriteLine("Dommage : 5");
                }
                else if(voleur==1 && guerrier==1 && magicien == 1)
                {
                    Console.WriteLine("WOW! Égalité entre les personnages! \r\n Lequelles désire tu?\r\n 1. Guerrier  2. Magicien  3. Voleur");
                    int.TryParse(Console.ReadLine(), out choixUti);
                    Console.Clear();

                    if (choixUti == 1)
                    {
                        Console.WriteLine("Guerrier \n");
                        Console.WriteLine("Une brute sanguinaire ou un noble chevalier, à toi de décider. Tu es endurant, rapide et un maître des arts martiaux. Pas le crayon le plus aiguisé de la boîte par contre...\n");
                        Console.WriteLine("Nom : " + nomPerso);
                        Console.WriteLine("Vie : 30");
                        Console.WriteLine("Armure : 15");
                        Console.WriteLine("Dommage : 10");
                    }

                    else if(choixUti == 2)
                    {
                        Console.WriteLine("Magicien\n");
                        Console.WriteLine("Tu es un maître de l'arcane et des éléments. Mais les années d'étude et de recherche ne t'ont pas laissé l'occasion de développer ton physique.\";\r\n");
                        Console.WriteLine("Nom : " + nomPerso);
                        Console.WriteLine("Vie : 20");
                        Console.WriteLine("Armure : 25");
                        Console.WriteLine("Dommage : 8");
                    }
                    else
                    {
                        Console.WriteLine("Voleur\n");
                        Console.WriteLine("Tu es une personne mal élever petit coquin\";\r\n");
                        Console.WriteLine("Nom : " + nomPerso);
                        Console.WriteLine("Vie : 15");
                        Console.WriteLine("Armure : 20");
                        Console.WriteLine("Dommage : 5");
                    }
                }
            }
           



        }
    }
}