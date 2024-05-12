using CalcResult = Either<decimal,string>;


    public class BenchmarkCalculator
    {
        private readonly AugmentedSignerData _augmentedSignerData;

        // Constants for model score calculation
        private const decimal Factor = 144.2695041M;
        private const decimal OffsetValue = -425M;
        private const decimal InterceptScore = 587M;
        private const decimal InitialScore = 162M;
        private const decimal MinScore = -385M;
        private const decimal MaxScore = 352M;
        
              
        public BenchmarkCalculator(AugmentedSignerData augmentedSignerData)
        {
            _augmentedSignerData = augmentedSignerData;
        }
    
    // Calculate the final model score
        public decimal CalculateModelScore()
        {
            int[] indicatorScores = new int[]
            {
                CalculateDelayedPaymentScore(),
                CalculateRiskChangeScore(),
                CalculateChequePaymentRatioScore(),
                CalculateDeferredChequeRatioScore(),
                CalculateFactoringLimitRateScore(),
                CalculateMaxTotalCashRiskLoanRatioScore()
            };

            decimal totalIndicatorScores = indicatorScores.Sum();
            decimal modelScore = InitialScore + totalIndicatorScores;
            
            // Ensure the score does not exceed defined boundaries
            if (modelScore < MinScore) modelScore = MinScore;
            if (modelScore > MaxScore) modelScore = MaxScore;
            
            return modelScore;
        }
        
    // Score Calculation for Max Delayed Payment over the Last 3 Months
    public int CalculateDelayedPaymentScore()
    {
        return CalculateScore(
            _augmentedSignerData.MaxDelayedPaymentLast3Months,
            delayedPayment => delayedPayment switch
            {
                < 1.24m => 28,
                >= 1.24m and < 43.17m => -44,
                >= 43.17m => -115
            },
            -55  
        );
    }

    // Score Calculation for Change in Total Risk Last Month Compared to the Previous Year
    public int CalculateRiskChangeScore()
    {
        return CalculateScore(
            _augmentedSignerData.MaxRatioOfTotalRiskCashProductsToGeneralLimitLast6Months,
            ratio => ratio switch
            {
                < -0.62m => 36,
                >= -0.62m and < -0.36m => 28,
                >= -0.36m and < -0.19m => 12,
                >= -0.19m and < -0.14m => -4,
                >= -0.14m and < 0.12m => -13,
                >= 0.12m => -42
            }
            ,-33);  
    }

    // Score Calculation for Cheque Paid Last Month to Last Three Months Ratio
    public int CalculateChequePaymentRatioScore()
    {
        return CalculateScore(
            _augmentedSignerData.RatioOfChequesPaidLastMonthToLast3Months,
            ratio => ratio switch
            {
                < 0.15m => -35,
                >= 0.15m and < 0.50m => 13,
                >= 0.50m => 30,
            }
            ,-116);
    }

    // Score Calculation for Deferred Cheque to Paid and Bounced Cheque Ratio
    public int CalculateDeferredChequeRatioScore()
    {
        return CalculateScore(
            _augmentedSignerData.RatioOfDeferredChequesToPaidAndBouncedCheques,
            ratio => ratio switch
            {
                < 0.035m => 37,
                >= 0.035m and < 0.040m => 21,
                >= 0.040m and < 0.072m => -4,
                >= 0.072m and < 0.092m => -26,
                >= 0.092m and < 0.178m => -36,
                >= 0.178m and < 51.0m => -51,
                _ => -73
            }
            , -73);  
    }

    // Score Calculation for Average Factoring Limit Rate Over Last 12 Months
    public int CalculateFactoringLimitRateScore()
    {
        return CalculateScore(
            _augmentedSignerData.AverageTotalLimitFactoringToTotalLimitLast12Months,
            ratio => ratio switch
            {
                < 0.022m => 28,
                >= 0.022m and < 0.134m => -67,
                >= 0.134m and < 0.416m => -123,
                >= 0.416m => -171,
            }
            ,-22);       
    }

    // Score Calculation for Maximum Total Cash Risk to Loan Ratio Over Last 6 Months
    public int CalculateMaxTotalCashRiskLoanRatioScore()
    {
        return CalculateScore(
            _augmentedSignerData.MaxRatioOfTotalRiskCashProductsToGeneralLimitLast6Months,
            ratio => ratio switch
            {
                < 0.118m => 31,
                >= 0.118m and < 0.272m => 24,
                >= 0.272m and < 0.422m => 10,
                >= 0.422m and < 0.642m => -19,
                >= 0.642m => -30,
            }
            ,-25);
    }

    public int CalculateScore(CalcResult result, Func<decimal, int> scoreCalculator, int defaultScore)
    {
        return result.IsLeft ? scoreCalculator(result.Left) : defaultScore;
    }
}


