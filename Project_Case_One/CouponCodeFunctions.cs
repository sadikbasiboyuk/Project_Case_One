using System.Text;

namespace Project_Case_One
{
    public static class CouponCodeFunctions
    {
        public static List<string> GenerateCouponCode(int codeCount)
        {
            var uniqueSet = new HashSet<string>();
            var couponCodeList = new List<string>();
            var random = new Random();

            for (int i = 0; i < codeCount; i++)
            {
                var sb = new StringBuilder();
                var sum = 0;
                for (int k = 0; k < 5; k++)
                {
                    var choice = CouponCodeConstants.couponCodeChoiceList[random.Next(0, CouponCodeConstants.couponCodeChoiceList.Count)];
                    sb.Append(choice);
                    sum += choice;
                }
                var numberStr = sum.ToString();
                
                foreach (var number in numberStr)
                    sb.Append(CouponCodeConstants.checkSumDict[number]);

                if(!uniqueSet.Add(sb.ToString()))
                {
                    i--;
                    continue;
                }

                couponCodeList.Add(sb.ToString());
            }

            return couponCodeList;
        }

        public static bool CheckCouponCode(string couponCode)
        {
            try
            {
                var codeBase = couponCode.Substring(0, 5);
                var checkSum = couponCode.Substring(5, 3);
                var sb = new StringBuilder();

                var sum = 0;
                foreach (var item in codeBase)
                    sum += item;

                foreach (var number in checkSum)
                    sb.Append(CouponCodeConstants.checkSumDict.First(k => k.Value == number).Key);

                return sum == int.Parse(sb.ToString());
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
