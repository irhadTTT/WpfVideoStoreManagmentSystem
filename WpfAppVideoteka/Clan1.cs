using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppVideoteka
{
    public partial class Clan
    {
        public string PunoIme {
        get {
                return this.Ime + " " + this.Prezime;
            }
        }
    }
}
