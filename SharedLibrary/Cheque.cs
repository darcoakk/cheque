namespace SharedLibrary
{
    public class Cheque
    {
        public int Id { get; set; }
        public string Drawer { get; set; }
        public string Payee { get; set; }
        public string? Guarantor { get; set; }
    
        public List<string> Validate()
        {
            var errors = new List<string>();

            var drawerIdentifier = Identifier.Create(Drawer);
            if (drawerIdentifier.IsRight)
            {
                errors.Add($"Invalid signer for cheque {Id}: {drawerIdentifier.Right}");
            }

            var payeeIdentifier = Identifier.Create(Payee);
            if (payeeIdentifier.IsRight)
            {
                errors.Add($"Invalid holder for cheque {Id}: {payeeIdentifier.Right}");
            }

            if (Guarantor != null)
            {
                var guarantorIdentifier = Identifier.Create(Guarantor);
                if (guarantorIdentifier.IsRight)
                {
                    errors.Add($"Invalid guarantor for cheque {Id}: {guarantorIdentifier.Right}");
                }
            }

            return errors;
        }
    }
}

