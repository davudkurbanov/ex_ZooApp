using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Lib
{
    public class LionCage
    {
        public List<Lion> Lions { get; set; }

        public LionCage()
        {

            Lion lion = new Lion("Simba", Sex.M);
            Lion lion2 = new Lion("Harambe", Sex.M);
            Lion lion3 = new Lion("Sandra", Sex.F);
            Lions = new List<Lion>();
            Lions.Add(lion);
            Lions.Add(lion2);
            Lions.Add(lion3);
        }


    }
}