using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesesQueTenho
{
    class Meses
    {
        private DateTime data;
        public string recebe
        {
            set
            {
                data = Convert.ToDateTime(value);
            }
        }
        public string envia
        {
            get
            {
                DateTime hoje = DateTime.Now;
                int anos = hoje.Year - data.Year;
                int meses = hoje.Month - data.Month;
                int disas = hoje.Day - data.Day;
                string frase = "A sua idade é ";
                frase += anos.ToString() + " anos, ";
                frase += meses.ToString() + " mes e ";
                frase += meses.ToString() + " dia.";
                return frase;
            }
        }

    }
}
