namespace Project_Case_One
{
    public static class CouponCodeConstants
    {
        public static Dictionary<char, char> checkSumDict = new()
        {
            {'0', 'A'},
            {'1', 'K'},
            {'2', 'P'},
            {'3', '7'},
            {'4', '5'},
            {'5', 'X'},
            {'6', 'M'},
            {'7', 'G'},
            {'8', 'L'},
            {'9', '3'},
        };

        public static List<char> couponCodeChoiceList = new()
        {
            'A', 'C', 'D', 'E', 'F', 'G', 'H', 'K', 'L', 'M', 'N', 'P', 'R', 'T', 'X', 'Y', 'Z',
            '2', '3', '4', '5', '7', '9'
        };

        public static string ValidCouponCode = "Valid";
        public static string InvalidCouponCode = "Invalid";

    }
}
