using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        private List<Hero> data;

        public int Count { get { return this.data.Count; } }
        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            foreach (var hero in data)
            {
                if (hero.Name == name)
                {
                    data.Remove(hero);
                    break;
                }
            }
        }

        public Hero GetHeroWithHighestStrength()
        {
            int strength = 0;

            foreach (var hero in this.data)
            {
                if (hero.Item.Strength > strength)
                {
                    strength = hero.Item.Strength;
                }
            }

            return data.FirstOrDefault(x => x.Item.Strength == strength);
        }

        public Hero GetHeroWithHighestAbility()
        {
            int ability = 0;

            foreach (var hero in this.data)
            {
                if (hero.Item.Ability > ability)
                {
                    ability = hero.Item.Ability;
                }
            }

            return data.FirstOrDefault(x => x.Item.Ability == ability);
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            int intelligence = 0;

            foreach (var hero in this.data)
            {
                if (hero.Item.Intelligence > intelligence)
                {
                    intelligence = hero.Item.Strength;
                }
            }

            return data.FirstOrDefault(x => x.Item.Intelligence == intelligence);
        }

        public override string ToString()
        {

            return $"{string.Join(Environment.NewLine, data)}";
        }
    }
}
