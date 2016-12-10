using DungeonRaider.StatGenerator.Types;
using DungeonRaider.StatGenerator.Utils;
using DungeonRaider.Utils.Math;
using System;

namespace DungeonRaider.StatGenerator
{
    public class StatGenerator
    {
        public StatFunction LowStatFunction { get; private set; }
        public StatFunction HighStatFunction { get; private set; }

        public RangeStat GenerateRangeStat(int itemDegree)
        {
            double lowValue = LowStatFunction.f(itemDegree);
            double highValue = HighStatFunction.f(itemDegree);
            double difference = Math.Round(highValue - lowValue, 1); 
            double finalLowValue = RandomDoubleStepper.NextDoubleBeetween(lowValue, highValue , 1);
            double finalHighvalue = finalLowValue + difference;
            double gain = Math.Round(finalLowValue - lowValue, 1);
            int percentage = (int)Math.Round((gain / difference) * 100);
            return new RangeStat(finalLowValue, finalHighvalue, percentage);
        }

        public SingleStat GenerateSingleStat(int itemDegree)
        {
            double lowValue = LowStatFunction.f(itemDegree);
            double highValue = HighStatFunction.f(itemDegree);
            double difference = Math.Round(highValue - lowValue, 1);
            double finalValue = RandomDoubleStepper.NextDoubleBeetween(lowValue, highValue, 1);
            double gain = Math.Round(finalValue - lowValue, 1);
            int percentage = (int)Math.Round((gain / difference) * 100);
            return new SingleStat(finalValue, percentage);
        }
    }
}
