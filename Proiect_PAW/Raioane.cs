// Proiect_PAW/Raioane.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Raioane : IDescriere
    {
        public int codRaion;
        public string denumire;
        public string sefRaion;

        public Raioane()
        {
            this.codRaion = 0;
            this.denumire = "necunoscut";
            this.sefRaion = "anonim";
        }

        public Raioane(int codRaion, string denumire, string sefRaion)
        {
            this.codRaion = codRaion;
            this.denumire = denumire;
            this.sefRaion = sefRaion;
        }

        public static Raioane operator ++(Raioane r)
        {
            if (r != null)
            {
                r.sefRaion += " (promovat)";
            }
            return r;
        }

        public static explicit operator string(Raioane r)
        {
            return (r != null && r.denumire != null) ? r.denumire : "N/A";
        }

        public char ObtineInitialaSef()
        {
            if (!string.IsNullOrEmpty(this.sefRaion))
            {
                return this.sefRaion[0];
            }
            return '?';
        }

        public bool EsteRaionAlimentar()
        {
            string denLowerCase = (this.denumire != null) ? this.denumire.ToLower() : "";
            return denLowerCase.Contains("lactate") ||
                   denLowerCase.Contains("fructe") ||
                   denLowerCase.Contains("legume") ||
                   denLowerCase.Contains("carne") ||
                   denLowerCase.Contains("congelate");
        }

        public string ObtineDescriere()
        {
            return string.Format("[RAION] Cod={0}, Denumire={1}, Sef={2}", codRaion, denumire, sefRaion);
        }

        public override string ToString()
        {
            return ObtineDescriere();
        }
    }
}