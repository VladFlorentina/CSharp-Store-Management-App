// Proiect_PAW/Magazine.cs
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    public class Magazine : ICloneable, IComparable, IDescriere, IEnumerable<string>
    {
        public int idMagazin;
        public string denumire;
        public string locatie;
        public string program;
        public int nrAngajati;
        public string parcare;

        private string[] programZilnic;

        public Magazine()
        {
            this.idMagazin = 0;
            this.denumire = "anonim";
            this.locatie = "necunoscut";
            this.program = "nespecificat";
            this.nrAngajati = 0;
            this.parcare = "necunoscut";
            this.programZilnic = new string[7] { "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A" };
        }

        public Magazine(int idMagazin, string denumire, string locatie, string program, int nrAngajati, string parcare)
        {
            this.idMagazin = idMagazin;
            this.denumire = denumire;
            this.locatie = locatie;
            this.program = program;
            this.nrAngajati = nrAngajati;
            this.parcare = parcare;
            this.programZilnic = new string[7];
            for (int i = 0; i < 7; i++)
            {
                this.programZilnic[i] = program;
            }
        }

        public string[] ProgramZilnic
        {
            get { return programZilnic; }
            set { programZilnic = value; }
        }

        public object Clone()
        {
            Magazine clona = (Magazine)this.MemberwiseClone();

            string[] programZilnicClona = new string[this.programZilnic.Length];
            for (int i = 0; i < this.programZilnic.Length; i++)
            {
                programZilnicClona[i] = this.programZilnic[i];
            }
            clona.programZilnic = programZilnicClona;

            return clona;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Magazine otherMagazine = obj as Magazine;
            if (otherMagazine != null)
                return this.idMagazin.CompareTo(otherMagazine.idMagazin);
            else
                throw new ArgumentException("Object is not a Magazine");
        }

        public static Magazine operator +(Magazine m, int nrAngajatiAdaugati)
        {
            Magazine rezultat = (Magazine)m.Clone();
            rezultat.nrAngajati += nrAngajatiAdaugati;
            return rezultat;
        }

        public static Magazine operator -(Magazine m, int nrAngajatiRedusi)
        {
            Magazine rezultat = (Magazine)m.Clone();
            if (rezultat.nrAngajati >= nrAngajatiRedusi)
            {
                rezultat.nrAngajati -= nrAngajatiRedusi;
            }
            else
            {
                rezultat.nrAngajati = 0;
            }
            return rezultat;
        }

        public string this[int indexZi]
        {
            get
            {
                if (indexZi >= 0 && indexZi < programZilnic.Length)
                {
                    return programZilnic[indexZi];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index zi invalid!");
                }
            }
            set
            {
                if (indexZi >= 0 && indexZi < programZilnic.Length)
                {
                    programZilnic[indexZi] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index zi invalid!");
                }
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (string prog in programZilnic)
            {
                yield return prog;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool EsteDeschisNonStop()
        {
            return this.program != null && this.program.ToLower().Contains("nonstop");
        }

        public string ObtineInformatiiSumare()
        {
            return string.Format("Magazinul '{0}' (ID: {1}) situat în {2}. Angajați: {3}.", this.denumire, this.idMagazin, this.locatie, this.nrAngajati);
        }

        public string ObtineDescriere()
        {
            return string.Format("[MAGAZIN] ID={0}, Nume={1}, Locatie={2}, Program={3}, Angajati={4}, Parcare={5}", idMagazin, denumire, locatie, program, nrAngajati, parcare);
        }

        public override string ToString()
        {
            return ObtineInformatiiSumare();
        }
    }
}