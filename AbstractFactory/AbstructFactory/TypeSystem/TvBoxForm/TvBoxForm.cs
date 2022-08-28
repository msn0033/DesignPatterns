using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryDesignPattern.AbstructFactory.AbstructTypeInput;
using AbstractFactoryDesignPattern.AbstructFactory.Interface;

namespace AbstractFactoryDesignPattern.AbstructFactory.TypeSystem.TvBoxForm
{
    public class TvBoxForm : IAbstructFormFactory
    {
        public AbstructButton CreateButton()=>new ButtonTvBox();
      
        public AbstructColor CreateColor()=>new ColorTvBox();
    

        public AbstructText CreateInputText()=>new TextTvBox();
       

        public AbstructLable CreateLable()=>new LableTvBox();
       
    }
}