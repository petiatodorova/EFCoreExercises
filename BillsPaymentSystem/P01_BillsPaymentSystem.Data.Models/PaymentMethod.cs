

using P01_BillsPaymentSystem.Data.Models.Attributes;
using P01_BillsPaymentSystem.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace P01_BillsPaymentSystem.Data.Models
{
    public class PaymentMethod
    {
        [Key]
        public int Id { get; set; }

        public PaymentType Type { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        [MethodOfPayment(nameof(BankAccountId))]
        public CreditCard CreditCard { get; set; }
        public int? CreditCardId { get; set; }

        public BankAccount BankAccount { get; set; }
        public int? BankAccountId { get; set; }
    }
}
