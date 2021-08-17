using MVCPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPractice.ViewModels
{
    public class PotsViewModel
    {
        public List<Pot1> FirstPot { get; set; }
        public List<Pot2> SecondPot { get; set; }
        public List<Pot3> ThirdPot { get; set; }
        public List<Pot4> FourthPot { get; set; }
    }
}
