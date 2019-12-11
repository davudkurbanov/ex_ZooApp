using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Lib
{
    public class PublicZoo
    {
        public decimal EntranceFee { get; set; } = 50.0M;
        public LionCage LionCage { get; set; }

        public PublicZoo(decimal entranceFee)
        {
            EntranceFee = entranceFee;
            LionCage = new LionCage();
        }

    }
}
