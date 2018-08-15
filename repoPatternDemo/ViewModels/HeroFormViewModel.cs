using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace repoPatternDemo.ViewModels
{
    public class HeroFormViewModel
    {
        public string HeroName { get; set; }
        public int HeroAge { get; set; }

        public int HeroFitness { get; set; }
        public int HeroMind { get; set; }
        public int HeroEmpathy { get; set; }

        public int HeroCity { get; set; }
    }
}