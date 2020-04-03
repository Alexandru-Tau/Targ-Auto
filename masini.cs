using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targ_Auto
{
    class masini
    {
        public enum culoare
        {
            rosu = 1,
            negru = 2,
            galben = 3,
            albastru = 4,
            alb = 5
        };


        [Flags]
        public enum optiuni
        {
            aer_conditionat = 1,
            navigatie = 2,
            cutie_automata = 4,
            pachet_sline = 8,
            nimic = 0
        };

        public const int LESS = -1;
        public const int MORE = 1;
        public const int EQUAL = 0;

        public string NumeVanzator { get; set; }
        public string NumeCumparator { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public int AnFabricatie { get; set; }
        public int Culoare { get; set; }
        public int Optiune { get; set; }
        public string DataTranzactiei { get; set; }
        public int Pret { get; set; }



        public masini()
        {
            NumeCumparator = null;
            Marca = null;
            Model = null;
            AnFabricatie = 0;
            Culoare = 5;
            Optiune = 0;
            DataTranzactiei = null;
            Pret = 0;
        }



        public masini(string Linie)
        {
            string[] separat = Linie.Split(',');
            NumeVanzator = separat[0];
            NumeCumparator = separat[1];
            Marca = separat[2];
            Model = separat[3];
            AnFabricatie = int.Parse(separat[4]);
            Culoare = int.Parse(separat[5]);
            Optiune = int.Parse(separat[6]);
            DataTranzactiei = separat[7];
            Pret = int.Parse(separat[8]);
        }

        public masini(string marca, string model, int anFabricatie, int culoare, int pret)
        {
            Marca = marca;
            Model = model;
            AnFabricatie = anFabricatie;
            Culoare = culoare;
            Pret = pret;
        }

        public static int Compara(masini m1, masini m2)
        {
            return string.Compare(m1.Marca, m2.Marca);
        }

        public string Conversie_la_sir()
        {
            string t = "Automobilul are: \n";
            t += "Vanzator: " + NumeVanzator + "\n";
            t += "Cumparator: " + NumeCumparator + "\n";
            t += "Data vanzare: " + DataTranzactiei + "\n";
            t += "Marca: " + Marca + "\n";
            t += "Modelul: " + Model + "\n";
            t += "Culoarea: " + (culoare)Culoare + "\n";
            t += "Pretul: " + Pret + "\n";
            t += "Anul de fabricatie: " + AnFabricatie + "\n";
            t += "Optiunile dumneavoastra sunt: \n";
            foreach (int nr in Enum.GetValues(typeof(optiuni)))
            {
                if ((Optiune & nr) == nr)
                    t += (optiuni)nr + "\n";
            }
            return t;
        }
    }
}
