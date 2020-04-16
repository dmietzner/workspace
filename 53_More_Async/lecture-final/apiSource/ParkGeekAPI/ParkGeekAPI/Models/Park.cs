using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkGeekAPI.Models
{
    public class Park
    {
        public string parkCode { get; set; }
        public string parkName { get; set; }
        public string state { get; set; }
        public int acreage { get; set; }
        public int elevationInFeet { get; set; }
        public double milesOfTrail { get; set; }
        public int numberOfCampsites { get; set; }
        public string climate { get; set; }
        public int yearFounded { get; set; }
        public int annualVisitorCount { get; set; }
        public string inspirationalQuote { get; set; }
        public string inspirationalQuoteSource { get; set; }
        [JsonProperty("description")]
        public string parkDescription { get; set; }
        public int entryFee { get; set; }
        public int numberOfAnimalSpecies { get; set; }
        public List<Weather> weather { get; set; }

        public static Dictionary<string, double[]> coordinates = new Dictionary<string, double[]>()
        {
            { "CVNP",new double[] {41.280880,-81.568668} },
            { "ENP",new double[] {25.308786,-80.924585} },
            { "GCNP",new double[] {36.082743,-112.2224191} },
            { "GNP",new double[] {48.753126,-113.751136} },
            { "GSMNP",new double[] {35.609131,-83.506203} },
            { "GTNP",new double[] {43.799082,-110.696796} },
            { "MRNP",new double[] {46.878179,-121.703833} },
            { "RMNP",new double[] {40.342764,-105.691623} },
            { "WNP",new double[] {48.459453,-120.137157} },
            { "YNP",new double[] {44.4277753,-110.589141} },
            { "YNP2",new double[] {37.866753,-119.555182} }
        };

    }
}
