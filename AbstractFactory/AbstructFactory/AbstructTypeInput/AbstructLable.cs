using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryDesignPattern.AbstructFactory.Interface;

namespace AbstractFactoryDesignPattern.AbstructFactory.AbstructTypeInput
{
    public abstract class AbstructLable : IRenderable
    {
        public abstract void Render();
    }
}