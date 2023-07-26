﻿namespace ContaComigoAPI.Models
{
    public class Expense
    {
        public int IdExpense { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public DateOnly PayDay { get; set; }
    }
}
