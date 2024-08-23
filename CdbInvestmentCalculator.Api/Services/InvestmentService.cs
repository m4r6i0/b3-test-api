using CdbInvestmentCalculator.Api.Models;

namespace CdbInvestmentCalculator.Api.Services
{
    public class InvestmentService
    {
        private const decimal TB = 1.08m;
        private const decimal CDI = 0.009m;

        public InvestmentResult CalculateCdb(InvestmentRequest request)
        {
            decimal grossAmount = request.InitialAmount;

            for (int i = 0; i < request.Months; i++)
            {
                grossAmount *= 1 + (CDI * TB);
            }

            decimal netAmount = grossAmount - CalculateTax(grossAmount - request.InitialAmount, request.Months);
            return new InvestmentResult
            {
                GrossAmount = grossAmount,
                NetAmount = netAmount
            };
        }

        private decimal CalculateTax(decimal profit, int months)
        {
            decimal taxRate = months <= 6 ? 0.225m :
                              months <= 12 ? 0.20m :
                              months <= 24 ? 0.175m : 0.15m;

            return profit * taxRate;
        }
    }
}
