using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnityEditor.Progress;

namespace Assets.Scripts.UtilityScripts
{
    public class FixedInsertList<T> 
    {
        private readonly List<T> values;
        private readonly int dimension;


        public FixedInsertList(int dimension)
        {
            this.dimension = dimension;
            this.values = new List<T>(dimension);
        }

        public void Insert(T item)
        {
            this.values.Insert(0, item);

            if (this.values.Count > dimension)
            {
                this.values.RemoveAt(this.values.Count - 1);
            }
        }

        public T? FirstOrDefault(Predicate<T> match)
        {
            return this.values.Find(match);
        }

        public T this[int index] => this.values[index];
        public IReadOnlyList<T> Values => this.values;
    }
}
