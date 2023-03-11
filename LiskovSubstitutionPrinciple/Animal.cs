namespace LiskovSubstitutionPrinciple
{
    public abstract class Animal
    {
        public virtual void MakeSound() => System.Console.WriteLine(nameof(Animal) + " sound.");
    }
}