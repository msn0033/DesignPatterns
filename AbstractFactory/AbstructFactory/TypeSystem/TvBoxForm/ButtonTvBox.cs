using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryDesignPattern.AbstructFactory.AbstructTypeInput;

namespace AbstractFactoryDesignPattern.AbstructFactory.TypeSystem.TvBoxForm
{
    public class ButtonTvBox : AbstructButton
    {
        public override void Click()
        {
            System.Console.WriteLine("The button has been clicked\n");
        }

        public override void Render()
        {
           System.Console.WriteLine("TvBox Button");
        }
    }
}