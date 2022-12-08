using System;


namespace metiers
{
     class Pomme:Fruit
    {
        public Pomme(int p)
        {
            this.poids = p;
        }

        public override void Affiche()
        {
            Console.WriteLine($"Création d'une Pomme de {poids} gramme");
        }

        public override void affichePoids()
        {
            Console.WriteLine($"Le poids de la pomme est la pomme est :{poids}");
        }
    }

}