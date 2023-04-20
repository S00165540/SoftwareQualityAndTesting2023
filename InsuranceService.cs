using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assign_TestingS00165540
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
                    premium = 2.50;
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
