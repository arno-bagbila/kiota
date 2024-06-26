using Lexis.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

var authProvider = new AnonymousAuthenticationProvider();
var adapter = new HttpClientRequestAdapter(authProvider);
var client = new LexisClient(adapter);

try
{
    // GET /users/
    var users = await client.Api.Users.GetAsync();
    Console.WriteLine($"Retrieved {users?.Count} users.");

    // GET /users/{id}
    var user = await client.Api.Users[users?[0].Id].GetAsync();
    Console.WriteLine($"Retrieved user {user?.FirstName}.");

    // POST /users/
    var newUser = new Lexis.Client.Models.CreateUser
    {
        FirstName = "John",
        LastName = "Doe"

    };
    var createdUser = await client.Api.Users.PostAsync(newUser);
    Console.WriteLine($"Created user {createdUser?.FirstName}.");

    // GET /blogs/
    var blogs = await client.Api.Blogs.GetAsync();
    Console.WriteLine($"Retrieved {blogs?.Count} blogs.");

    // GET /blogs/{id}
    var blog = await client.Api.Blogs[blogs?[0].Id].GetAsync();
    Console.WriteLine($"Retrieved blog {blog?.Text}.");

    // GET /blogs/authors/{id}
    var authorBlogs = await client.Api.Blogs.Author[users?[0].Id].GetAsync();
    Console.WriteLine($"Retrieved {authorBlogs?.Count} blogs by author {users?[0].FirstName} {users?[0].LastName}.");

    // POST /blogs
    var newBlog = new Lexis.Client.Models.CreateBlog
    {
        Text = "Hello, World!",
        AuthorId = users?[0].Id,
        PublishedOn = DateTimeOffset.Now.AddHours(1),
        Category = "General"
    };
    var createdBlog = await client.Api.Blogs.PostAsync(newBlog);
    Console.WriteLine($"Created blog {createdBlog?.Text}.");


}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
    Console.WriteLine(ex.StackTrace);
}