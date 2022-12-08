using System;
using System.Windows.Forms;
using transport;
using CargaisonForm;
namespace GestionCargaison
{
    class Program
    {
        static void Main()
        {
            Application.Run(new distance());


            /* CargaisonRoutiere cr = new CargaisonRoutiere(40);
             cr.AddMarchandise(new Marchandise(110, 500, 89));
             cr.AddMarchandise(new Marchandise(111, 400, 89));
             cr.AddMarchandise(new Marchandise(112, 900, 89));

             cr.DisplayMarchandise();
             Console.WriteLine(cr.ToString() +" Le coût est :" +cr.cout());
             try
             {
                 Console.WriteLine(cr.ConsulterMarchandise(130));
             }catch (Exception e) { Console.WriteLine(e.Message); }

 */
            Console.ReadLine();
        }
    }
}
