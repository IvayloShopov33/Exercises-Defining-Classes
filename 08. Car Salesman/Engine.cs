﻿namespace _08._Car_Salesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }

        public Engine(string model, int power, int displacement) : this(model, power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model, int power, int displacement, string efficiency) : this(model, power, displacement)
        {
            this.Efficiency = efficiency;
        }

        public string Model {  get; set; }

        public int Power {  get; set; }

        public int Displacement {  get; set; }

        public string Efficiency { get; set; }
    }
}
