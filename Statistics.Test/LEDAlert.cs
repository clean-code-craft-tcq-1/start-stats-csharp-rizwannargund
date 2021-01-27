namespace Statistics.Test
{
    internal class LEDAlert : IAlerter
    {
        internal bool ledGlows;

        public LEDAlert()
        {
            ledGlows = false;
        }

        public bool Alert()
        {
            ledGlows = true;
            //throw new System.NotImplementedException();
            return ledGlows;
        }
    }
}