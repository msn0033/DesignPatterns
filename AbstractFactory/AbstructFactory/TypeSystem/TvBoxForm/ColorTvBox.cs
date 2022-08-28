using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryDesignPattern.AbstructFactory.AbstructTypeInput;

namespace AbstractFactoryDesignPattern.AbstructFactory.TypeSystem.TvBoxForm
{
    public class ColorTvBox : AbstructColor
    {
    
        public override void Color()
        {  
            System.Console.WriteLine(ColorValue);
        }
       

        public override void Render()
        {
                       System.Console.WriteLine("TvBox Color");

        }
    }
}