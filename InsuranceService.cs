using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace SQTA_2023
{
    //Dependency injecttion with Interface and Mocking 
    public interface IDiscountService
    {
        double GetDiscount();
    }
    public class InsuranceService
    {

        private readonly IDiscountService discountService;
        public InsuranceService(IDiscountService discountService)
        {
            this.discountService = discountService;
        }

        public double CalcPremium(int age, string location)
        {
            double discount = discountService.GetDiscount();
            double premium;

            if (location == "rural")
                if ((age >= 18) && (age < 30))
                    premium = 5.0;
                else
                if (age >= 31)
                    premium = 3.50;
                else
                    premium = 0.0;
            else
    if (location == "urban")
                if ((age >= 18) && (age <= 35))
                    premium = 6.0;
                else
                   if (age >= 36)
                    premium = 5.0;
                else
                    premium = 0.0;
            else

                premium = 0.0;

            if (age >= 50)
            {
                premium *= discount;
            }
            return premium;
        }
    }
}
