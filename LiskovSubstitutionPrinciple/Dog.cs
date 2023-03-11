namespace LiskovSubstitutionPrinciple
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("hau");
        }
    }
}