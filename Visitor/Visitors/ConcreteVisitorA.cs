﻿using Visitor.Components;

namespace Visitor.Visitors
{
    public class ConcreteVisitorA : IVisitor
    {
        public int VisitConcreteComponent1(ConcreteComponent1 concreteComponent1)
        {
            return concreteComponent1.SpecialMethodOfConcreteComponent1();
        }

        public string VisitConcreteComponentA(ConcreteComponentA concreteComponentA)
        {
            return concreteComponentA.ExclusiveMethodOfConcreteComponentA();
        }
    }
}