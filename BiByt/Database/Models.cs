using System.Collections.Generic;

namespace BiByt.Database;

public class User
{
    public long Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}

public class Transaction
{
    public enum TransactionType
    {
        Translation,
        Cash = 6010,
        Clothes = 5094,
        CarService = 5511,
        Pharmacy = 5122,
        House = 1520,
        Other,
    }

    public long Id { get; set; }
    public long UserId { get; set; }
    public long Cost { get; set; }
    public TransactionType Type { get; set; }
}