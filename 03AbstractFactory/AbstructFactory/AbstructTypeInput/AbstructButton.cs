using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryDesignPattern.AbstructFactory.Interface;

namespace AbstractFactoryDesignPattern.AbstructFactory.AbstructTypeInput
{
    public abstract class AbstructButton : IRenderable
    {
        public string? value { set; get; }


        public abstract void Click();
        public abstract void Render();
    }
}