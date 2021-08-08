using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticsClub
{
    class Club
    {
        public string club_id { get; set; }
        public string club_name { get; set; }

        Club(string _id, string _name)
        {
            this.club_id = _id;
            this.club_name = _name;
        }
    }
}
