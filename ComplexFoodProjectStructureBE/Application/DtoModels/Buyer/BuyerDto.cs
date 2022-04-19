using Domain.ValueObjects;

namespace Application.DtoModels.Buyer
{
    public class BuyerDto
    {
        public Email Email { get; set; }
        public Password Password { get; set; }
        public Name FirstName { get; set; }
        public Name LastName { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public bool Confirmed { get; set; }
        public Balance Balance { get; set; }
    }
}
