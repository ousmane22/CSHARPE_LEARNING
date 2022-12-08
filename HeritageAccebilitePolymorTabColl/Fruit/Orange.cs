using System;


namespace metiers
{
     class Orange:Fruit
    {
        public Orange(int p)
        {
            this.poids = p;
        }

        public override void  Affiche()
        {
            Console.WriteLine($"Création d'une Orange de {poids}");
        }

        public override void affichePoids()
        {
            Console.WriteLine($"Le poids de l'orange est :{poids}");
        }
    }

}