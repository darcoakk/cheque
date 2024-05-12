using CalcResult = Either<decimal,string>;

public class AugmentedSignerData
{
    public CalcResult MaxDelayedPaymentLast3Months { get; set; }
    public List<object> MaxDelayedPaymentLast3MonthsLog { get; set; }

    public CalcResult AverageTotalLimitFactoringToTotalLimitLast12Months { get; set; }
    public List<object> AverageTotalLimitFactoringToTotalLimitLast12MonthsLog { get; set; }

    public CalcResult RatioOfDeferredChequesToPaidAndBouncedCheques { get; set; }
    public List<object> RatioOfDeferredChequesToPaidAndBouncedChequesLog { get; set; }

    public CalcResult RatioOfChequesPaidLastMonthToLast3Months { get; set; }
    public List<object> RatioOfChequesPaidLastMonthToLast3MonthsLog { get; set; }

    public CalcResult MaxRatioOfTotalRiskCashProductsToGeneralLimitLast6Months { get; set; }
    public List<object> MaxRatioOfTotalRiskCashProductsToGeneralLimitLast6MonthsLog { get; set; }

    public CalcResult RatioOfTotalRiskCashProductsToPrevious12Months { get; set; }
    public List<object> RatioOfTotalRiskCashProductsToPrevious12MonthsLog { get; set; }

    
}


