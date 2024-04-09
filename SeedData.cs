using BloggingDemo.Shared.Models;

namespace BloggingDemo;

public class SeedData
{
    public static void Initialize(BlogDemoContext context)
    {
        var posts = new BlogPost[]
        {
            new BlogPost { Id = 1, Title = "Introduction to Blazor", Content = "Lorum Ipsum Sit etc" },
            new BlogPost { Id = 2, Title = "State Management in Blazor", Content = "Lorum Ipsum Sit etc" },
            new BlogPost { Id = 3, Title = "Building a Blog with Blazor", Content = "Lorum Ipsum Sit etc" }
        };


        if (!context.BlogPosts.Any())
        {
            context.BlogPosts.AddRange(posts);
            context.SaveChanges();
        }
    }
}
