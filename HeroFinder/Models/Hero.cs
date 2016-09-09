using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroFinder.Factories;

namespace HeroFinder.Models
{
    public class Hero
    {
        public string HeroName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LogoImage { get; set; }
        public string BackgroundImage { get; set; }
        public ComicUniverse Universe { get; set; }
        public string FullName => string.Format("{0} {1}", FirstName, LastName);

        public string BackStory => GenerateLoremIpsum();

        private string GenerateLoremIpsum()
        {
            return LoremIpsumFactory.GetRandomPassage(2);
        }
    }
}
