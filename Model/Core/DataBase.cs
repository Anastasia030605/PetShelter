using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public class DataBase
    {
        public Shelter[] Shelters {  get; private set; }
        public Pet[] Homeless {  get; private set; }

        public DataBase(Shelter[] shelters, Pet[] homeless) 
        {
            Shelters = shelters;
            Homeless = homeless;
        }

        //future methods
    }
}
