using System;

namespace lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui paralelipiped dreptunghic, va afisa volumul lui
             */

            Console.WriteLine("introduceti lungimea");
            int lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti latimea");
            int latime = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti inaltimea");
            int inaltime = int.Parse(Console.ReadLine());



            int volume;
            volume = lungime * latime * inaltime;
            Console.WriteLine("volumul paralelipipedului avand lungime " + lungime + ", latime " + latime + ", inaltime " + inaltime + " este: " + volume);

        }
    }
}
