using static SmartEnum.ConsoleApp.Enums.CreditCard2;

//CreditCard creditCardValue = CreditCard.Platinum;

//var discount = creditCardValue switch
//{
//    CreditCard.Standard => 0.01,
//    CreditCard.Platinum => 0.10,
//    CreditCard.Premium => 0.20,
//    CreditCard.Gold => 0.30,
//    _=> throw new NotImplementedException()
//};

//var discount = creditCardValue switch
//{
//    { Name: "Standard" } => 0.01,
//    { Name: "Platinum" } => 0.10,
//    { Name: "Premium" } => 0.20,
//    _ => throw new ArgumentOutOfRangeException("Unknown CreditCard2 type")
//};

//CreditCard2 creditCardValue = CreditCard2.FromValue(2);
//var discount = creditCardValue.GetDiscountRate();

//Console.WriteLine($"Credit card type: { creditCardValue} discount: {discount}");

CreditCard3? creditCard3 = CreditCard3.FromName("Standard");



