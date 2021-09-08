using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    //Vi kan ikke nedarve fra en 'Sealed' klasse!
    sealed class DogClass : ParentClass
    {
        public int NumberOfTimesBarkedAtThePostman { get; set; }
        public int AmountOfSticksFetched {  get; set; }
    }
}
