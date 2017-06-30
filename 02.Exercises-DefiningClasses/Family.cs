using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Family
{
    public List<Person> people;

    public Family()
    {
        this.people = new List<Person>();
    }

    public void AddMember(Person person)
    {
        this.people.Add(person);
    }

    //public  Person GetOldestMember()
    //{
    //    var oldes = people.Max(x => x.age);

    //    return people.FirstOrDefault(x => x.age == oldes);
    //}



}

