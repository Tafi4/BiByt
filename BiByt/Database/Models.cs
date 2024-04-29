using System.Collections.Generic;

namespace BiByt.Database
{
    // public class Models { }

    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<int>? TransactionIds { get; set; }
    }

    public class Transaction
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Description { get; set; }
    }
}