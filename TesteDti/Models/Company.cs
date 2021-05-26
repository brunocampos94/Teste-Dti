using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteDti.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Display(Name = "Company Name")]
        public string Name { get; set; }
        [Display(Name = "Interest Rate")]
        [DisplayFormat(DataFormatString = "{0:F3}")]
        public double InterestRate { get; set; }
        public Company(int id, string name, double interestRate)
        {
            Id = id;
            Name = name;
            InterestRate = interestRate / 100;
        }

        public Company()
        {
        }
    }
}