namespace MGP.Authentication.Application.UseCase.V1.User.Update.Request
{
    public class AddressUpdateUserRequest
    {
        public string Street { get; set; }

        public string StreetNumber { get; set; }

        public string Floor { get; set; }

        public string Apartment { get; set; }

        public string BetweenStreetOne { get; set; }

        public string BetweenStreetTwo { get; set; }

        public int? LocalityId { get; set; }
    }
}
