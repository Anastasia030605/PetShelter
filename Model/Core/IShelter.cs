using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public interface ICountable
    {
        public int Count();
        public int Count(Type type);
        public int Percentage(Type type);
    }

    public interface IFilter
    {
        public Pet[] Filter(Type type);
        public Pet[] Filter(Type type, bool hasPhobia);
    }

    public interface IChangeable
    {
        public void Add(Pet pet);
        public void Remove(Pet pet);
    }
    
}
