namespace C__Course
{
    internal class RefOutKeyword
    {
        public void SetAge(ref int age)
        {
            age += 10;
        }
        public void SetAge2(out int age)
        {
            age = 10;
        }
    }
}
