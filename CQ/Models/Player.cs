using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQ.Models.Enums;

namespace CQ.Models
{
    public class Player
    {
        public string Name { get; set; }

        public int BirthDay { get; set; }
              
        public double Height { get; set; }

        public double Weight { get; set; }

        public int Goal { get; set; }

        public int VolleyballPoints { get; set; }

        public int BasketballPoints { get; set; }

        public int FootVolleyPoints { get; set; }

        public Player()
        {
        }

        public Player(string name, int birthDay, double height, double weight)
        {
            Name = name;
            BirthDay = birthDay;            
            Height = height;
            Weight = weight;
            Goal = 0;
            VolleyballPoints = 0;
            BasketballPoints = 0;
            FootVolleyPoints = 0;
        }

        public void Addpoint(Sport a, int x)
        {
            switch (x)
            {
                case 0:
                    Goal += x;
                    break;
                case 1:
                    VolleyballPoints += x;
                    break;
                case 2:
                    BasketballPoints += x;
                    break;
                case 3:
                    FootVolleyPoints += x;
                    break;
                default:
                    break;

            }
        }
    }
}

