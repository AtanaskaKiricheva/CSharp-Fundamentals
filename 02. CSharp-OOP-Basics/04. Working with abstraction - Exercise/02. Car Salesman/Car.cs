﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02_CarsSalesman
{
    public class Car
    {
        private const string offset = "  ";
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
            this.weight = -1;
            this.color = "n/a";
        }

        public Car(string model, Engine engine, int weight)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = "n/a";
        }

        public Car(string model, Engine engine, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = -1;
            this.color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}:\n", this.model);
            sb.Append(this.engine.ToString());
            sb.AppendFormat("{0}Weight: {1}\n", offset, this.weight == -1 ? "n/a" : this.weight.ToString());
            sb.AppendFormat("{0}Color: {1}", offset, this.color);

            return sb.ToString();
        }

        public static string Offset => offset;
        public string Model { get => model; set => model = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Color { get => color; set => color = value; }
        public Engine Engine { get => engine; set => engine = value; }
    }
}