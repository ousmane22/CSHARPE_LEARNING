using System;

namespace metiers
{
     abstract class Fruit
    {
        protected int poids { get; set; }

        public Fruit()
        {
            Console.WriteLine("Création d'un fruit");
        }

        public virtual void Affiche()
        {
            Console.WriteLine("c'est un fruit");
        }

        public abstract void affichePoids();
    }

}
