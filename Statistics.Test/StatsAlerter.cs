using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics.Test
{
    internal class StatsAlerter
    {
        private float maxThreshold;
        private IAlerter[] alerters;

        public StatsAlerter(float maxThreshold, IAlerter[] alerters)
        {
            this.maxThreshold = maxThreshold;
            this.alerters = alerters;
        }

        internal void checkAndAlert(List<double> list)
        {
            if (list.ToArray().Max() > maxThreshold)
            {
                alerters[0].Alert();
                alerters[1].Alert();
            }
            //throw new NotImplementedException();
        }
    }
}