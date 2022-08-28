using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryDesignPattern.AbstructFactory.AbstructTypeInput;

namespace AbstractFactoryDesignPattern.AbstructFactory.Interface
{
    public interface IAbstructFormFactory
    {
        public AbstructText CreateInputText();
        public AbstructButton CreateButton();
        public AbstructColor CreateColor();
        public AbstructLable CreateLable();
    }
}