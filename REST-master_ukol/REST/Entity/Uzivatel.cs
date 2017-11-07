using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST.Entity
{
    public class Uzivatel
    {
        public int id { get; set; }
        public string jmeno { get; set; }
        public string prijmeni { get; set; }
        public int rod_cislo { get; set; }
        public string dat_nar { get; set; }
        public string pohlavi { get; set; }

        public override string ToString()
        {
            return $"id: {id},jmeno: {jmeno}, prijmeni: {prijmeni}, rod_cislo: {rod_cislo}, dat_nar: {dat_nar}, pohlavi: {pohlavi}";
        }
    }
}
