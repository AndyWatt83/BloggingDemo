using BloggingDemo.Shared.Models;

namespace BloggingDemo.Shared;

public interface IBlogRepository
{
    Task<List<BlogPost>> GetAllPostsAsync();
    Task<bool> CreateBlogPost(BlogPost post);
    Task<BlogPost?> GetPostByIdAsync(int id);
}
