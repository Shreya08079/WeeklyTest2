using System;

namespace WEAK_EVAL2.Models
{
    // Represents money coming in
    public class IncomeTransaction : Transaction
    {
        public string Source { get; set; }

        public IncomeTransaction(
            int id,
            DateTime date,
            decimal amount,
            string description,
            string source)
            : base(id, date, amount, description)
        {
            Source = source;
        }

        public override string GetSummary()
        {
            return $"[INCOME] {Date.ToShortDateString()} | Amount: {Amount} | Source: {Source}";
        }
    }
}