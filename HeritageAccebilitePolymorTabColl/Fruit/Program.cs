using System;
using System.Collections.Generic;
using metiers;

namespace FruitE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pomme p = new Pomme(100);
            //Orange orange = new Orange(90);

            //sous-casting
            //Fruit f;
            //f =  new Pomme(100);
            //((Pomme)f).AffichePoidPomme();

            //f = new Orange(20);
            //((Orange)f).AffichePoidOrange();
            //f.Affiche();

            //Array
            Fruit[] fruits = new Fruit[3];
            fruits[0] = new Pomme(90);
            fruits[1] = new Orange(10);
            fruits[2] = new Pomme(200);

            for (int i= 0;i<fruits.Length; i++)
            {
                //fruits[i].Affiche();
                fruits[i].affichePoids();
            }


            //collection (list ,arraylist , etc)

            List<Fruit> fruit = new List<Fruit>();

            fruit.Add(new Pomme(90));
            fruit.Add(new Orange(100));
            fruit.Add(new Pomme(9000));

            //for 

            for(int i=0; i<fruit.Count;i++ )
            {
                fruit[i].affichePoids();
            }

            //foreach
            foreach(Fruit f in fruits)
            {
                f.affichePoids();
            }



             Console.ReadLine();
        }
    }
}
