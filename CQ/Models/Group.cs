using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQ.Models
{
    public class Group
    {
        //# propriedades
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Player> Players { get; set; }

        //# Costructors  
        public Group()
        {
        }

        public Group(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //#Methods

        public void AddPlayer(Player x)
        {
            Players.Add(x);
        }

        public void RemovePlayer(Player x)
        {
            Players.Remove(x);
        }

    }


}
