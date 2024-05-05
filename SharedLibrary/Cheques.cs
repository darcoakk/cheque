namespace SharedLibrary;

public class Cheque
{
    public List<string> SignerIds { get; set; }
    public decimal Amount { get; set; }
    public string? Decision { get; set; }
}

public class DataService1Response
{
    public string SignerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

public class DataService2Response
{
    public string SignerId { get; set; }
    public int TotalTransactionsLastYear { get; set; }
    public decimal AverageTransactionAmount { get; set; }
}

public class AugmentedSignerData
{
    public string SignerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int TotalTransactionsLastYear { get; set; }
    public decimal AverageTransactionAmount { get; set; }
}

public class ResponseData
{
    public List<Cheque> Cheques { get; set; }
    public List<AugmentedSignerData> AugmentedSignerDataList { get; set; }
}