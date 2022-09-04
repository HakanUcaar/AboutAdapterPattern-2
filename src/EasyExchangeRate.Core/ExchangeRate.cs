using EasyExchangeRate.Adapter;
using EasyExchangeRate.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Core
{
    public static class ExchangeRate
    {
        public static readonly TurkeyAdapter TurkeyAdapter;
        //public static readonly EuropeAdapter EuropeAdapter => new EuropeAdapter();
        //public static readonly DenmarkAdapter DenmarkAdapter => new DenmarkAdapter();        
        //public static readonly IsraelAdapter IsraelAdapter => new IsraelAdapter();

        static ExchangeRate()
        {
            TurkeyAdapter = new TurkeyAdapter();
        }
        

    }
}
