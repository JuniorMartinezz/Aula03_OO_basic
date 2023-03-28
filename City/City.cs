using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_OO_basic
{
    public class City
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string State { get; set; }

        public City(string name, string state, int id){
            this.Name = name;
            this.State = state;
            this.Id = id;
        }
    }
}