namespace swagger_demo.Controllers;

public class ArtDemoController : IArtDemoContractController
{
    public async Task<ICollection<User>> GetUsersAsync(int? limit)
    {
        var data = new List<User>()
        {
            new User() { Id = 1, Name = "John" },
            new User() { Id = 2, Name = "Jane" },
            new User() { Id = 3, Name = "Jack" },
            new User() { Id = 4, Name = "Jill" },
            new User() { Id = 5, Name = "Jim" },
            new User() { Id = 6, Name = "Joe" },
            new User() { Id = 7, Name = "Bob" },
            new User() { Id = 8, Name = "Bill" },
            new User() { Id = 9, Name = "Mavis" },
            new User() { Id = 10, Name = "Mary" },
            new User() { Id = 11, Name = "Molly" },
        };
        return limit==null 
            ? data 
            : data.Take(limit.Value).ToList();
    }
}