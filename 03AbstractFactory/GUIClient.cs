using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryDesignPattern.AbstructFactory.Interface;

namespace AbstractFactoryDesignPattern
{
    public class GUIClient
    {
        public IAbstructFormFactory _Factory { get; }
        public GUIClient(IAbstructFormFactory factory)
        {
            this._Factory = factory;
            CreateForm();
            
        }
        public void  CreateForm(){
            var x=_Factory.CreateButton();
            var color=_Factory.CreateColor();
            x.Click();
            x.Render();
           color.Color();
           color.Render();

            
        }
    }
}