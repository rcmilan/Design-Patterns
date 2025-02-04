﻿using Factory.Creators;
using Domain.Models;
using System.Drawing;
using System;

namespace Factory.ConcreteCreators
{
    public class TunerFactory : ICarFactory
    {
        public Car Create(string model, Color color)
        {
            // ICar é um produto abstrato
            // ICar poderia ser abstract class ao invéz de interface
            // A fabrica retorna o produto concreto Car
            return new Car { Model = model, Color = color, Type = "Tuner" };
        }
    }
}
