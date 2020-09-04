using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using x3.Infrastructure;

namespace x3.GSpecific
{

    public class Cluster1_Core:ICluster1_Core
    {
        private readonly ICluster1_Border Border;

        public Cluster1_Core(ICluster1_Border border)
        {
            Border=border;
        }

        public SomeCore SomeCore => new SomeCore(Border.SomeBorder);
    }

    public interface ICluster1_Core
    {
        SomeCore SomeCore{ get;}
    }


    public interface ICluster1_Border
    {
        ISomeBorder SomeBorder { get; }
    }



}
