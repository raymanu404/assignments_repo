namespace BehavioralPatterns.Abstractions
{
    public interface IClientData
    {
        string Address { get; set; }
        string City { get; set; }
        string Province { get; set; }
        string PostalCode { get; set; }
        string Country { get; set; }

        void ShowClientInfo();
    }
}
