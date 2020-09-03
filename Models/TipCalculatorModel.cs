
using System;
using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage = "Please enter a meal cost.")]
        [Range(0.01, Double.MaxValue, ErrorMessage = "Subtotal must be greater than 0")]
        public double? MealCost { get; set; }

        public double? CalculateTip(int tip)
        {
            double tipPercentage = tip * 0.01;
            return MealCost * tipPercentage;
        }
        
    }
}