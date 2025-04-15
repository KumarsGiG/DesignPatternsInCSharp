namespace CreationalDesignPattern_Prototype
{
    public class Person
    {
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; } = string.Empty;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public IdInfo IdInfo { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        public Person ShallowCopy() => (Person)this.MemberwiseClone();

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = new String(Name.ToArray()); //String.Copy(Name);
            return clone;
        }
    }
}
