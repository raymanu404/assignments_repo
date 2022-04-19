using Domain.ValueObjects;

namespace Application.DtoModels.Buyer
{
    public class BuyerDtoUpdate
    {
        public Email Email { get; set; }
        public Password Password { get; set; }
        public Name FirstName { get; set; }
        public Name LastName { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Gender Gender { get; set; }
    }
}
