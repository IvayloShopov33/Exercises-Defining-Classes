﻿namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) : this()
        {
            this.Age = age;
        }

        public Person(string name, int age) : this(age)
        {
            this.Name = name;
        }

        public string Name { get { return name; } set { name = value; } }

        public int Age { get { return age; } set { age = value; } }

        public bool IsAgeValid()
        {
            return this.Age >= 0 && this.Age <= 130;
        }
    }
}