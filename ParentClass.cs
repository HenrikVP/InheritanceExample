using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    //Abstracte klasser kan IKKE instantieres!
    abstract class ParentClass : GrandparentBaseClass
    {
        public int Id { get; set; }
        public string Name {  get; set; }
        public AnimalColor Color { get; set; }
    }
}
