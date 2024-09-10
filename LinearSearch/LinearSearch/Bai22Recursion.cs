namespace  Dung.LinearSearch
{
    public class Bai22Recursion
    {
		private static double targetMoney = 0;

		public int calMonth(double money, double rate)
		{ 
			if ( targetMoney == 0 ) { targetMoney = money; }
			if (money >= 2 * targetMoney) 
			{
				//Console.WriteLine("Current money" + money); 
				return 0;
			}
			return 1 + calMonth(money * (1 + rate/100), rate);
		}


		public double calculateMonth(double money, double rate)
        {
			int months = 0;
            double doubleMoney = 2 * money;
			while (money < doubleMoney && rate > 0)
			{
				money = money + money * (rate / 100);
				months++;
			}
            //Console.WriteLine("Current money" + money);
            return months;
		}
    }
}