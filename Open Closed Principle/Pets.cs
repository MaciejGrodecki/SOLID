namespace Open_Closed_Principle
{
    public class Pets
    {
        public void SayHello(Pet[] pets)
        {
            foreach (var pet in pets)
            {
                pet.Say();
            }
        }
    }
}
