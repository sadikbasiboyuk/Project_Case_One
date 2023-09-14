using Project_Case_One;

Console.WriteLine("Coupon Code Menu");
Console.WriteLine("1. Generate Code");
Console.WriteLine("2. Check Code [Input]");
Console.WriteLine("3. Check Code [List]");
Console.WriteLine("4. Exit");
var couponList = new List<string>();


while (true)
{
    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine("Enter valid number of coupon code count.");
            var couponCodeCount = Console.ReadLine();
            Console.WriteLine("Coupon Codes are generating.");
            couponList = CouponCodeFunctions.GenerateCouponCode(Int32.Parse(couponCodeCount));
            foreach (var coupon in couponList)
                Console.WriteLine(coupon);
            break;
        case "2":
            Console.WriteLine("Enter a coupon code and let me check that.");
            var couponCode = Console.ReadLine();
            Console.WriteLine(CouponCodeFunctions.CheckCouponCode(couponCode) ? "Valid" : "Invalid");
            break;
        case "3":
            Console.WriteLine("Coupon code list:");
            couponList.ForEach(l => Console.WriteLine($"{l} - {CouponCodeFunctions.CheckCouponCode(l)}"));
            break;
        case "4":
            Console.WriteLine("Exit");
            return;
    }
}
