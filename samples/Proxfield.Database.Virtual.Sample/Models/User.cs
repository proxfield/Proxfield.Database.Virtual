namespace Proxfield.Database.Virtual.Sample.Models
{
    public class User : BaseEntity
    {
        public override string? Id {get; set;}
        public string? Name {get; set;}
    }
}
