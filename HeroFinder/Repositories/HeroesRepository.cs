using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroFinder.Models;

namespace HeroFinder.Repositories
{
    public static class HeroesRepository
    {
        public static List<Hero> GetAllHeroes()
        {
            return GetDcHeroes().Union(GetMarvelHeroes()).OrderBy(h => h.HeroName).ToList();
        }

        public static List<Hero> GetDcHeroes()
        {
            return new List<Hero>
            {
                CreateHero("Arthur", "Curry", "Aquaman", ComicUniverse.DC),
                CreateHero("Ray", "Palmer", "Atom", ComicUniverse.DC),
                CreateHero("Bruce", "Wayne", "Batman", ComicUniverse.DC),
                CreateHero("Oliver", "Queen", "Green Arrow", ComicUniverse.DC),
                CreateHero("Hal", "Jordan", "Green Lantern", ComicUniverse.DC),
                CreateHero("Carter", "Hall", "Hawkman", ComicUniverse.DC),
                CreateHero("Peter", "Parker", "Spiderman", ComicUniverse.DC),
                CreateHero("Kara", "Zor-El", "Supergirl", ComicUniverse.DC),
                CreateHero("Clark", "Kent", "Superman", ComicUniverse.DC),
                CreateHero("Barry", "Allen", "The Flash", ComicUniverse.DC),
                CreateHero("Diana", "Prince", "Wonder Woman", ComicUniverse.DC),
            };

        }

        public static List<Hero> GetMarvelHeroes()
        {
            return new List<Hero>
            {
                CreateHero("Scott", "Lang", "Ant-Man", ComicUniverse.Marvel),
                CreateHero("Natasha", "Romanova", "Black Widow", ComicUniverse.Marvel),
                CreateHero("Steve", "Rogers", "Captain America", ComicUniverse.Marvel),
                CreateHero("Scott", "Summers", "Cyclops", ComicUniverse.Marvel),
                CreateHero("Matt", "Murdock", "Daredevil", ComicUniverse.Marvel),
                CreateHero("Clint", "Barton", "Hawkeye", ComicUniverse.Marvel),
                CreateHero("Bruce", "Banner", "Hulk", ComicUniverse.Marvel),
                CreateHero("Johnny", "Storm", "Human Torch", ComicUniverse.Marvel),
                CreateHero("Tony", "Stark", "Ironman", ComicUniverse.Marvel),
                CreateHero("Ororo", "Munroe", "Storm", ComicUniverse.Marvel),
                CreateHero("James", "Howlett", "Wolverine", ComicUniverse.Marvel),
            };
        }

        private static Hero CreateHero(string firstName, string lastName, string heroName, ComicUniverse universe)
        {
            var fixedHeroName = heroName.Replace(' ', '_');
            var logoImageName = string.Format("../Resources/{0}_logo.png", fixedHeroName);
            var backgroundImage = string.Format("../Resources/{0}_Background.jpg", fixedHeroName);
            return new Hero
            {
                HeroName = heroName,
                FirstName = firstName,
                LastName = lastName,
                Universe = universe,
                LogoImage = logoImageName,
                BackgroundImage = backgroundImage
            };
        }
    }

}
