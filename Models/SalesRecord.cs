using CRUD.Models.Enums;
using System;
using System.ComponentModel;

namespace CRUD.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        [DisplayName("Data")]
        public DateTime Date { get; set; }
        [DisplayName("Valor")]
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        [DisplayName("Vendedor")]
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
