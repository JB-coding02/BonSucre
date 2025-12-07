using System;
using System.Collections.Generic;
using System.Text;

namespace FinalBonSucreApp
{
    internal class Review
    {
        public int ReviewId { get; set; }

        public int CustomerId { get; set; }

        public int DessertId { get; set; }

        public int Score { get; set; }
    }
}
