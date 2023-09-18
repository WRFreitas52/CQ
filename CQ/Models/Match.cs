using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQ.Models
{
    public class Match
    {
        //Partida

        public Group Players { get; set; }

        public List<Player> TeamOne { get; set; }

        public List<Player> TeamTwo { get; set; }

        public Player GoalKeeperOne { get; set; }

        public Player GoalKeeperTwo { get; set; }


        //#Constructs
        public Match()
        {
        }

        public Match(Group players, Player goalKeeperOne, Player goalKeeperTwo)
        {
            Players = players;
            GoalKeeperOne = goalKeeperOne;
            GoalKeeperTwo = goalKeeperTwo;
        }

        public void Draw()
        {


        }

    }
}
