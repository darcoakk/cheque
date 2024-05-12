using Memzuc;
using KKB;
using CalcResult = Either<decimal,string>;

namespace SharedLibrary
{
 
public class ToAugmentedSignerData
{
    public static AugmentedSignerData Map(MemzucEntResponse memzucResponse, KKBChequeResponse kkbChequeResponse)
    {
    // Example of logging with thread ID
    Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId} - Starting mapping");

    var (maxDelayedPaymentLast3Months, maxDelayedPaymentLast3MonthsLog) = CalculateMaxDelayedPaymentLast3Months(memzucResponse);
    var (averageTotalLimitFactoringToTotalLimitLast12Months, averageTotalLimitFactoringToTotalLimitLast12MonthsLog) = CalculateAverageRatioOfTotalLimitInFactoringToSystemLast12Months(memzucResponse);
    var (ratioOfDeferredChequesToPaidAndBouncedCheques, ratioOfDeferredChequesToPaidAndBouncedChequesLog) = CalculateRatioOfDeferredChequesToPaidAndBouncedCheques(kkbChequeResponse);
    var (ratioOfChequesPaidLastMonthToLast3Months, ratioOfChequesPaidLastMonthToLast3MonthsLog) = CalculateRatioOfChequesPaidLastMonthToLast3Months(kkbChequeResponse);
    var (maxRatioOfTotalRiskCashProductsToGeneralLimitLast6Months, maxRatioOfTotalRiskCashProductsToGeneralLimitLast6MonthsLog) = CalculateMaxRatioOfTotalRiskCashProductsToGeneralLimitLast6Months(memzucResponse);
    var ( ratioOfTotalRiskCashProductsToPrevious12Months, ratioOfTotalRiskCashProductsToPrevious12MonthsLog )= CalculateRatioOfTotalRiskCashProductsToPrevious12Months(memzucResponse);
    Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId} - Ending mapping");

    return new AugmentedSignerData
    {
        MaxDelayedPaymentLast3Months = maxDelayedPaymentLast3Months,
        MaxDelayedPaymentLast3MonthsLog = maxDelayedPaymentLast3MonthsLog,

        AverageTotalLimitFactoringToTotalLimitLast12Months = averageTotalLimitFactoringToTotalLimitLast12Months,
        AverageTotalLimitFactoringToTotalLimitLast12MonthsLog = averageTotalLimitFactoringToTotalLimitLast12MonthsLog,

        RatioOfDeferredChequesToPaidAndBouncedCheques = ratioOfDeferredChequesToPaidAndBouncedCheques,
        RatioOfDeferredChequesToPaidAndBouncedChequesLog = ratioOfDeferredChequesToPaidAndBouncedChequesLog,

        RatioOfChequesPaidLastMonthToLast3Months = ratioOfChequesPaidLastMonthToLast3Months,
        RatioOfChequesPaidLastMonthToLast3MonthsLog = ratioOfChequesPaidLastMonthToLast3MonthsLog,

        MaxRatioOfTotalRiskCashProductsToGeneralLimitLast6Months = maxRatioOfTotalRiskCashProductsToGeneralLimitLast6Months,
        MaxRatioOfTotalRiskCashProductsToGeneralLimitLast6MonthsLog = maxRatioOfTotalRiskCashProductsToGeneralLimitLast6MonthsLog,

        RatioOfTotalRiskCashProductsToPrevious12Months = ratioOfTotalRiskCashProductsToPrevious12Months,
        RatioOfTotalRiskCashProductsToPrevious12MonthsLog = ratioOfTotalRiskCashProductsToPrevious12MonthsLog
    };
}
    //Bankalarda Nakdi Ürünlerdeki Gecikme Tutarının Son 3 Aydaki Maksimum Değeri $
    private static (CalcResult, List<object>) CalculateMaxDelayedPaymentLast3Months(MemzucEntResponse memzucResponse)
    {
        decimal someDecimal = 0.0m;
        List<object> someList = new List<object>();

        // Implement your logic here

        return (new CalcResult(someDecimal), someList);
    }

    /// <summary>
    /// Calculates the average ratio of the total limit in factoring to the total limit in the system for the last 12 months.
    /// </summary>
    /// <param name="memzucResponse">The MemzucEntResponse object containing the data for the calculation.</param>
    /// <returns>A tuple containing the average ratio and a list of calculation details.</returns>
    // TODO: her ay sonundaki döviz kurları ile TL değerlerini USD'ye çevirerek hesaplama yapılacak.
    private static (CalcResult, List<object>) CalculateAverageRatioOfTotalLimitInFactoringToSystemLast12Months(MemzucEntResponse memzucResponse)
    {
        Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId} - Starting calculation of average ratio of total limit in factoring to the total limit in the system for the last 12 months");

        List<object> calculationDetails = new List<object>();

        // Get the data for the last 13 months assuming the current month might not be available
        var last13MonthsData = memzucResponse.Data.MemzucEntResults
            .Where(m => m.PeriodDate >= DateTime.Now.AddMonths(-13))
            .OrderByDescending(m => m.PeriodDate);

        // Get the distinct months for the last 12 months
        var distinctMonths = last13MonthsData.Select(m => m.Period).Distinct().Take(12).ToList();

        decimal sumOfRatios = 0;
        int countOfMonthsWithData = 0;

        for (int i = 0; i < distinctMonths.Count; i++)
        {
            var monthData = last13MonthsData
                .Where(m => m.Period == distinctMonths[i]);

            if (monthData.Any())
            {
                // Calculate the total limit in factoring and the total limit in the system for the month

                decimal totalLimitFactoring = monthData.Where(m => 
                    (int.TryParse(m.RiskKod, out int riskkod) && riskkod >= 700 && riskkod < 800)).Sum(m => m.Limit);
                decimal totalLimitSystem = monthData.Where(m => m.RiskKod == "Toplam").Sum(m => m.Limit);

                decimal ratio = totalLimitSystem != 0 ? totalLimitFactoring / totalLimitSystem : 0;
                sumOfRatios += ratio;
                countOfMonthsWithData++;
                
                    calculationDetails.Add(new
                    {
                        Month = distinctMonths[i],
                        TotalLimitFactoring = totalLimitFactoring,
                        TotalLimitSystem = totalLimitSystem,
                        Ratio = ratio,
                    });
                }
        }

        decimal averageRatio = countOfMonthsWithData > 0 ? sumOfRatios / countOfMonthsWithData : 0;

        calculationDetails.Add(new 
        {
            AverageRatio = averageRatio
        });

        return (new CalcResult(averageRatio), calculationDetails);
    }

    
    //Vadeli Çek Statusunde Olan Çek Adedinin Ödenmiş ve Karşılıksız Çek Adedine Oranı 
    private static (CalcResult, List<object>) CalculateRatioOfDeferredChequesToPaidAndBouncedCheques(KKBChequeResponse kkbChequeResponse)
    {
        decimal someDecimal = 0.0m;
        List<object> someList = new List<object>();

        // Implement your logic here

        return (new CalcResult(someDecimal), someList);
    }

    //Son Ay İçerisinde Ödenen Çek Tutarının Son 3 Ay İçerisinde Ödenen Çek Tutarına Oranı
    private static (CalcResult, List<object>) CalculateRatioOfChequesPaidLastMonthToLast3Months(KKBChequeResponse kkbChequeResponse)
    {
        decimal someDecimal = 0.0m;
        List<object> someList = new List<object>();

        // Implement your logic here

        return (new CalcResult(someDecimal), someList);
    }

    //Sistemdeki Nakdi Ürünlerdeki Toplam Riskin Sistemdeki Genel Limite Oranının Son 6 Aydaki Maksimum Değeri
    private static (CalcResult, List<object>) CalculateMaxRatioOfTotalRiskCashProductsToGeneralLimitLast6Months(MemzucEntResponse memzucResponse)
    {
        List<object> calculationDetails = new List<object>();

        // Get the data for the last 13 months assuming the current month might not be available
        var last7MonthsData = memzucResponse.Data.MemzucEntResults
            .Where(m => m.PeriodDate >= DateTime.Now.AddMonths(-7))
            .OrderByDescending(m => m.PeriodDate);

        // Get the distinct months for the last 12 months
        var distinctMonths = last7MonthsData.Select(m => m.Period).Distinct().Take(6).ToList();

        decimal maxRatio = 0;

        for (int i = 0; i < distinctMonths.Count; i++)
        {
            var monthData = last7MonthsData.Where(m => m.Period == distinctMonths[i]);

            if (monthData.Any())
            {
                // Calculate the total limit in factoring and the total limit in the system for the month
                    
                decimal totalRiskCashProducts;
                try
                {
                    totalRiskCashProducts = monthData.Where(m => m.RiskKod == "Nakit").Single().ToplamRisk;
                }
                catch
                {
                    totalRiskCashProducts = 0;
                }
                decimal generalLimit = monthData.Where(m => m.RiskKod == "Toplam").Single().Limit;
                decimal ratio = generalLimit != 0 ? totalRiskCashProducts / generalLimit : 0;
                if(ratio > maxRatio)
                {
                    maxRatio = ratio;
                }
                calculationDetails.Add(new
                {
                    Month = distinctMonths[i],
                    TotalRiskCashProducts = totalRiskCashProducts,
                    GeneralLimit = generalLimit,
                    Ratio = ratio,
                });
            }
        }
        return (new CalcResult(maxRatio), calculationDetails);           
    }   
    //Sistemdeki Nakdi Ürünlerdeki Son Aydaki Toplam Riskin Önceki 12 Aydaki Sistemdeki Nakdi Ürünlerdeki Toplam Riske Göre Değişimi
    private static (CalcResult, List<object>) CalculateRatioOfTotalRiskCashProductsToPrevious12Months(MemzucEntResponse memzucResponse)
    {
        decimal someDecimal = 0.0m;
        List<object> someList = new List<object>(); 

        // Implement your logic here
        return (new CalcResult(someDecimal), someList);       
    }

}
}