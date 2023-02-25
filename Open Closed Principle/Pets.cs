namespace Open_Closed_Principle
{
    public class Pets
    {
        public void SayHello(object[] pets)
        {
            foreach (var pet in pets)
            {
                if (pet is Cat)
                {
                    var cat = (Cat)pet;
                    cat.Say();
                }

                if (pet is Dog)
                {
                    var dog = (Dog)pet;
                    dog.Say();
                }
            }
        }
    }
}
