// Proiect_PAW/Desfaceri.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Desfaceri : ICloneable, IComparable, IDescriere
    {
        public string modalitate;
        public int incasariMin;
        public int incasariMax;
        public double tva;
        public string lucratorcomercial;

        public Desfaceri()
        {
            this.modalitate = "necunoscut";
            this.incasariMin = 0;
            this.incasariMax = 0;
            this.tva = 0;
            this.lucratorcomercial = "anonim";
        }

        public Desfaceri(string modalitate, int incasariMin, int incasariMax, double tva, string lucratorcomercial)
        {
            this.modalitate = modalitate;
            this.incasariMin = incasariMin;
            this.incasariMax = incasariMax;
            this.tva = tva;
            this.lucratorcomercial = lucratorcomercial;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Desfaceri otherDesfacere = obj as Desfaceri;
            if (otherDesfacere != null)
                return otherDesfacere.incasariMin.CompareTo(this.incasariMin);
            else
                throw new ArgumentException("Object is not a Desfaceri");
        }

        public static Desfaceri operator +(Desfaceri d1, Desfaceri d2)
        {
            if (d1 == null || d2 == null)
            {
                throw new ArgumentNullException("Operanzii nu pot fi null.");
            }
            Desfaceri rezultat = (Desfaceri)d1.Clone();
            rezultat.incasariMin += d2.incasariMin;
            rezultat.incasariMax += d2.incasariMax;
            rezultat.tva = (d1.tva + d2.tva) / 2;
            rezultat.lucratorcomercial += " & " + d2.lucratorcomercial;
            return rezultat;
        }

        public static bool operator >(Desfaceri d1, Desfaceri d2)
        {
            if (d1 == null || d2 == null) return false;
            return d1.CalculeazaIncasareMedie() > d2.CalculeazaIncasareMedie();
        }

        public static bool operator <(Desfaceri d1, Desfaceri d2)
        {
            if (d1 == null || d2 == null) return false;
            return d1.CalculeazaIncasareMedie() < d2.CalculeazaIncasareMedie();
        }

        public double CalculeazaIncasareMedie()
        {
            if (incasariMax >= incasariMin)
            {
                return (incasariMin + incasariMax) / 2.0;
            }
            return 0;
        }

        public bool EsteOnline()
        {
            return this.modalitate != null && this.modalitate.ToLower() == "online";
        }

        public string ObtineDescriere()
        {
            return string.Format("[DESFACERE] Modalitate={0}, Incasari={1}-{2}, TVA={3:P}, Lucrator={4}", modalitate, incasariMin, incasariMax, tva, lucratorcomercial);
        }

        public override string ToString()
        {
            return ObtineDescriere();
        }
    }
}