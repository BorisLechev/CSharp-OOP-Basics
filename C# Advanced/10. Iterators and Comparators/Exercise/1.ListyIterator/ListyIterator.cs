﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1.ListyIterator
{
    public class ListyIterator<T>
    {
        private int index;

        private List<T> collection;

        public ListyIterator(List<T> elements)
        {
            this.index = 0;
            this.collection = new List<T>(elements);
        }

        public bool HasNext()
        {
            if (this.index + 1 < this.collection.Count)
            {
                return true;
            }

            return false;
        }

        public bool Move()
        {
            if (HasNext())
            {
                this.index++;
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.collection.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.collection[this.index]);
        }

        public void END()
        {
            return;
        }
    }
}
