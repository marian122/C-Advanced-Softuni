using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Repository
    {
        private Dictionary<int, Person> data;

        public Repository()
        {
            this.data = new Dictionary<int, Person>();
        }

        public int Count { get; set; } = 0;

        public int Id { get; set; } = -1;

        public void Add(Person person)
        {
            data[++this.Id] = person;
            this.Count++;
            
        }

        public Person Get(int id)
        {
            Person person = this.data[id];
            return person;
        }

        public bool Update(int id, Person newPerson)
        {
            if (this.data.ContainsKey(id))
            {
                this.data[id] = newPerson;
                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            if (this.data.ContainsKey(id))
            {
                this.data.Remove(id);
                this.Count--;
                return true;
            }

            return false;
        }
    }
}
