using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_OO_basic
{
    public class Person
    {
        public int Id { get; private set; }
        public string Name { get; set; } = "";
        public Nullable<long> Phone { get; set; }

        public Person(string name, long phone, int id){
            this.Name = name;
            this.Phone = phone;
            this.Id = id;
        }
    }
}