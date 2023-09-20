namespace C__Course
{
    public class User : BaseEntity
    {
    }
    public class Product : BaseEntity
    {

    }
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }

}
