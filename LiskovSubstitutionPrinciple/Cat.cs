namespace LiskovSubstitutionPrinciple
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Miau!");
        }
    }
}