namespace GameProject
{
    class UservalidationManager : IUserValidationServicee
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "ENGİN" && gamer.LastName == "DEMİROĞ" && gamer.BirtYear == 1985 && gamer.IdentityNumber == 12345678910)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
