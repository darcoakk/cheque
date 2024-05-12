using SharedLibrary;
public class ChequeResult
    {
        public Cheque Cheque { get; set; }
        public AugmentedSignerData DrawerData { get; set; }
        public AugmentedSignerData PayeeData { get; set; }
        public AugmentedSignerData? GuarantorData { get; set; }
    }