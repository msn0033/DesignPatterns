using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryDesignPattern.AbstructFactory.Interface;

namespace AbstractFactoryDesignPattern.AbstructFactory.AbstructTypeInput
{
    public abstract class AbstructColor : IRenderable
    {
        protected string ColorValue { get; set; }="red";
        public abstract void Color();
        public abstract void Render();
    }
}