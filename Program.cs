using System;

namespace Targ_Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            string model = "";
            string marca = "";
            int _an = 0, _pret = 0, _culoare, _optiuni = 0;
            const string nume_vanzator = "Alex";
            //masina1
            Console.WriteLine("Dati marca dorita: ");
            marca = Console.ReadLine();
            Console.WriteLine("Dati modelul dorit: ");
            model = Console.ReadLine();
            Console.WriteLine("Dati anul de fabricatie: ");
            _an = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dati pretul dorit: ");
            _pret = Int32.Parse(Console.ReadLine()); ;
            Console.WriteLine("Alegeti culoarea dorita: ");
            Console.WriteLine("rosu = 1\n negru = 2\n galben = 3\n albastru = 4\n alb  = 5");
            Int32.TryParse(Console.ReadLine(), out _culoare);

            masini auto = new masini(marca, model, _an, _culoare, _pret);
            Console.WriteLine("Alegeti optiuniile dorite: ");
            do
            {
                Console.WriteLine("aer_conditionat = 1\nnavigatie = 2\ncutie_automata = 4\npachet_sline = 8\nexit = -1");
                Int32.TryParse(Console.ReadLine(), out _optiuni);
                if (_optiuni == 1 || _optiuni == 2 || _optiuni == 0 || _optiuni == 4 || _optiuni == 8)
                    auto.Optiune |= _optiuni;
            } while (_optiuni != -1);

            Console.WriteLine("Introdu numele cumparatorului ");
            auto.NumeCumparator = Console.ReadLine();
            auto.NumeVanzator = nume_vanzator;
            auto.DataTranzactiei = DateTime.Now.ToString();
            Console.WriteLine(auto.Conversie_la_sir());
            Console.ReadLine();

            //masina2
            Console.WriteLine("Dati marca dorita: ");
            marca = Console.ReadLine();
            Console.WriteLine("Dati modelul dorit: ");
            model = Console.ReadLine();
            Console.WriteLine("Dati anul de fabricatie: ");
            _an = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dati pretul dorit: ");
            _pret = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Alegeti culoarea dorita: ");
            Console.WriteLine("rosu = 1\n negru = 2\n galben = 3\n albastru = 4\n alb  = 5");
            Int32.TryParse(Console.ReadLine(), out _culoare);
            Console.WriteLine("Alegeti optiuniile dorite: ");
            masini auto1 = new masini(marca, model, _an, _culoare, _pret);
            do
            {
                Console.WriteLine("aer_conditionat = 1\nnavigatie = 2\ncutie_automata = 4\npachet_sline = 8\nexit = -1");
                Int32.TryParse(Console.ReadLine(), out _optiuni);
                if (_optiuni == 1 || _optiuni == 2 || _optiuni == 0 || _optiuni == 4 || _optiuni == 8)
                    auto1.Optiune |= _optiuni;
            } while (_optiuni != -1);

            Console.WriteLine("Introdu numele cumparatorului ");
            auto1.NumeCumparator = Console.ReadLine();
            auto1.NumeVanzator = nume_vanzator;
            auto1.DataTranzactiei = DateTime.Now.ToString();
            Console.WriteLine(auto1.Conversie_la_sir());
            Console.ReadLine();


            switch (masini.Compara(auto, auto1))
            {
                case masini.LESS:
                    Console.WriteLine("Prima masina este mai mica decat a doua");
                    break;
                case masini.MORE:
                    Console.WriteLine("Prima masina este mai mare decat a doua");
                    break;
                case masini.EQUAL:
                    Console.WriteLine("Prima masina este egala cu a doua");
                    break;
            }
        }
    }
}
