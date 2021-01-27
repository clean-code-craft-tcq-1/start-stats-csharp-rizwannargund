namespace Statistics.Test
{
    internal class EmailAlert : IAlerter
    {
        internal bool emailSent;

        public EmailAlert()
        {
            emailSent = false;
        }

        public bool Alert()
        {
            emailSent = true;
            //throw new System.NotImplementedException();
            return emailSent;
        }
    }
}