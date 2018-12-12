using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            var vidzyDbFirstContext = new VidzyDbFirstContext();

            //vidzyDbFirstContext.AddVideo("Video 1", DateTime.Today.AddDays(-2), "Horror");
            //vidzyDbFirstContext.AddVideo("Video 2", DateTime.Today.AddDays(-3), "Action");
            //vidzyDbFirstContext.AddVideo("Video 3", DateTime.Today.AddDays(-4), "Comedy");
            //vidzyDbFirstContext.AddVideo("Video 4", DateTime.Today.AddDays(-4), "Comedy");
            vidzyDbFirstContext.AddVideo("Video 5", DateTime.Today.AddDays(-4), "Comedy", (byte)Classification.Platinum);
        }
    }
}
