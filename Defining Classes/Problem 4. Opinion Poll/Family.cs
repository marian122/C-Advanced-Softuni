using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people = new List<Person>();

        public void AddMember(Person member)
        {
            this.people.Add(member);

        }
        public Person GetOldestMember()
        {
            return this.people.OrderByDescending(x => x.Age).FirstOrDefault();
        }
        
        public List<Person> OverThirty()
        {
            return this.people.Where(x => x.Age > 30).ToList();
        }
    }
}