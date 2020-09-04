using x3.Infrastructure;

namespace x3.GSpecific
{
    public class SomeCore:ISomeCore
    {
        private readonly ValueObject InfrastructureDependency;
        private readonly ISomeBorder SomeBorder;

        public SomeCore(ISomeBorder someBorder)
        {
            InfrastructureDependency= new ValueObject("x");
            SomeBorder=someBorder;
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
