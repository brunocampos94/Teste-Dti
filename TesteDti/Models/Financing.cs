using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteDti.Models
{
    public class Financing
    {
        public int Id { get; set; }
        [Display(Name = "Down Payment")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double DownPayment { get; set; }
        public Company Company { get; set; }
        [Display(Name = "Installment Value")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double InstallmentValue { get; set; }
        public int NumberMonths { get; set; }
        [Display(Name = "Number of Years")]
        public int NumberYears { get; set; }
        [Display(Name = "Financed Amout")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double FinancedAmountPayed { get; set; }
        [Display(Name = "Total Payed")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double TotalPayed { get; set; }

        public Financing(int id, double downPayment, Company company, double installmentValue, int numberYears)
        {
            Id = id;
            DownPayment = downPayment;
            Company = company;
            InstallmentValue = installmentValue;
            NumberMonths = numberYears * 12;
            NumberYears = numberYears;
            FinancedAmountPayed = FinancedTotal();
            TotalPayed = TotalPayment();
        }

        public Financing()
        {
        }

        public double FinancedTotal()
        {
            double total = Math.Pow(1 + Company.InterestRate, NumberMonths);
            total--;
            total /= Company.InterestRate;
            total *= InstallmentValue;
            return total;
        }
        public double TotalPayment()
        {
            return FinancedTotal() + DownPayment;
        }
    }
}