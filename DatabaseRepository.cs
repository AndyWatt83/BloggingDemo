using BloggingDemo.Shared;
using BloggingDemo.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BloggingDemo;

public class DatabaseRepository : IBlogRepository
{
    private readonly BlogDemoContext _context;

    public DatabaseRepository(BlogDemoContext context)
    {
        _context = context;
    }

    public Task<bool> CreateBlogPost(BlogPost post)
    {
        throw new NotImplementedException();
    }

    public async Task<List<BlogPost>> GetAllPostsAsync() => await _context.BlogPosts.ToListAsync();

    public async Task<BlogPost?> GetPostByIdAsync(int id) => await _context.BlogPosts.FindAsync(id);
}
