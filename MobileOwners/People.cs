using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestSemester2
{
    public class People
    {
        private List<Person> _people = new List<Person>();
        public int Count { get; }

        public void Add(Person person)
        {
            _people.Add(person);
        }

        public void Clear()
        {
            _people.Clear();
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return _people;
        }

        public IEnumerable<Person> GetAndroidPeople()
        {
            List<Person> androidPeople = new List<Person>();
            foreach (Person person in _people)
            {
                if (person.MobileType == MobileType.Android)
                {
                    androidPeople.Add(person);
                }        
            }
            return androidPeople;
        }

        public IEnumerable<Person> GetApplePeople()
        {
            List<Person> applePeople = new List<Person>();
            foreach (Person person in _people)
            {
                if (person.MobileType == MobileType.Apple)
                {
                    applePeople.Add(person);
                }
            }
            return applePeople;
        }
    }
}
