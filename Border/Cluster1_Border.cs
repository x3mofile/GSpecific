using System;
using x3.IO;


namespace x3.GSpecific.Border
{
    public class Cluster1_Border:ICluster1_Border
    {
        private readonly ICluster1_Border_NextBorder NextBorder;

        public Cluster1_Border(ICluster1_Border_NextBorder nextBorder)
        {
            NextBorder= nextBorder;
        }
        public ISomeBorder SomeBorder => new Border_ForThisImplementation(NextBorder.Box());
    }


    public interface ICluster1_Border_NextBorder
    {
        IBox Box();
    }

}
