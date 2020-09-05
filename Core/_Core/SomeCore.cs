using System;
using x3.Infrastructure;

namespace x3.GSpecific
{
    public class SomeCore:ISomeCore
    {
        private readonly ValueObject InfrastructureDependency;
        private readonly ISomeBorder SomeBorder;

        public SomeCore(Func<ISomeBorder> resolvesSomeBorder)
        {
            InfrastructureDependency= new ValueObject("x");
            SomeBorder=resolvesSomeBorder.Invoke();
        }

        public void Do()
        {
            SomeBorder.Do();
        }
    }


    public interface ISomeCore
    {
        void Do();
    }

}
