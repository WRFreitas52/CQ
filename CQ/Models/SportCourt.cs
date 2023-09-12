using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQ.Models.Enums;

namespace CQ.Models
{
    public class SportCourt
    {
        //Quadra
        public Sport Sport { get; set; }

        public List<Match> Match { get; set; }

        public Scheduling Scheduling { get; set; }


    }
}
