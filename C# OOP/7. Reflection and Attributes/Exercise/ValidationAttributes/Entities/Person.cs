﻿using System;
using System.Collections.Generic;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Entities
{
    public class Person
    {
        private const int MIN_AGE = 12;

        private const int MAX_AGE = 90;

        public Person(string fullname, int age)
        {
            this.FullName = fullname;
            this.Age = age;
        }

        [MyRequired]
        public string FullName { get; private set; }

        [MyRange(MIN_AGE, MAX_AGE)]
        public int Age { get; private set; }
    }
}
