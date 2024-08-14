namespace API.Entities;

public class AppUser
{
    //entity framework need public properties
    // the primary key of DB
    // [Key], use this header if using different name for Id (entity standart)
    public int Id { get; set; }
    public required string UserName { get; set; }
    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }

}