﻿namespace Exercise.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string gender) : base(name, age, gender)
        {
            Gender = "Female";
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
