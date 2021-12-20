namespace AdApp
{
    public class TVAd: Advert
    {
        private bool _isPrime;
        private int _seconds;
        private int _rate;
        public TVAd(int fee, int seconds, int rate, bool isPrime) : base(fee)
        {
            _seconds = seconds;
            _rate = rate;
            _isPrime = isPrime;
        }
        
        public new int Cost() 
        {
            return base.Cost();
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}