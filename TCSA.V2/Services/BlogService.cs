using Microsoft.EntityFrameworkCore;
using TCSA.V2.Data;
using TCSA.V2.Models;
using TCSA.V2.Models.Responses;

namespace TCSA.V2.Services;

public interface IBlogService
{
    Task<ApplicationUser> GetUserByIdWithBlogs(string id);
    Task<BaseResponse> GetBlogs();
    Task<BaseResponse> AddOrUpdateBlog(Blog blog);
    Task<BaseResponse> DeleteBlog(int blogId);
    Task<BaseResponse> GetBlog(int blogId);
}

public class BlogService : IBlogService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public BlogService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }

    public async Task<ApplicationUser> GetUserByIdWithBlogs(string id)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.AspNetUsers
                .Include(x => x.DashboardProjects)
                .Include(x => x.ShowcaseItems)
                .FirstOrDefaultAsync(x => x.Id.Equals(id));
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<BaseResponse> GetBlogs()
    {
        var response = new BaseResponse();

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var blogs = await context.Blogs.ToListAsync();

                var articles = blogs.Select(x => new Article()
                {
                    CardImgUrl = x.CardImgUrl,
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    Author = x.ApplicationUser.DisplayName ?? x.ApplicationUser.GithubUsername ?? $"{x.ApplicationUser.FirstName} {x.ApplicationUser.LastName}"
                });

                response.Status = ResponseStatus.Success;
                response.Data = articles;
            }
        }
        catch (Exception ex)
        {
            response.Status = ResponseStatus.Fail;
            response.Message = $"Error occurred: {ex.Message}";
        }

        return response;
    }

    public async Task<BaseResponse> AddOrUpdateBlog(Blog blog)
    {
        var response = new BaseResponse();

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                if (blog.Id == 0)
                {
                    await context.Blogs.AddAsync(blog);
                    response.Message = "Blog added successfully.";
                }
                else
                {
                    var existingBlog = await context.Blogs.FindAsync(blog.Id);
                    if (existingBlog == null)
                    {
                        response.Status = ResponseStatus.Fail;
                        response.Message = "Blog not found.";
                        return response;
                    }

                    existingBlog.Title = blog.Title;
                    existingBlog.Content = blog.Content;
                    existingBlog.AppUserId = blog.AppUserId;
                    existingBlog.PublishedDate = blog.PublishedDate;

                    context.Blogs.Update(existingBlog);
                    response.Message = "Blog updated successfully.";
                }

                await context.SaveChangesAsync();

                response.Status = ResponseStatus.Success;
            }
        }
        catch (Exception ex)
        {
            response.Status = ResponseStatus.Fail;
            response.Message = $"Error occurred: {ex.Message}";
        }

        return response;
    }

    public async Task<BaseResponse> DeleteBlog(int blogId)
    {
        var response = new BaseResponse();

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var blog = await context.Blogs.FindAsync(blogId);
                if (blog == null)
                {
                    response.Status = ResponseStatus.Fail;
                    response.Message = "Blog not found.";
                    return response;
                }

                context.Blogs.Remove(blog);
                await context.SaveChangesAsync();

                response.Status = ResponseStatus.Success;
                response.Message = "Blog deleted successfully.";
            }
        }
        catch (Exception ex)
        {
            response.Status = ResponseStatus.Fail;
            response.Message = $"Error occurred: {ex.Message}";
        }

        return response;
    }

    public async Task<BaseResponse> GetBlog(int blogId) 
    { 
        var response = new BaseResponse();

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var blog = await context.Blogs.FindAsync(blogId);
                if (blog == null)
                {
                    response.Status = ResponseStatus.Fail;
                    response.Message = "Blog not found.";
                    return response;
                }

                //var article = BlogHelper.Convert(blog);

                response.Status = ResponseStatus.Success;
                response.Data = blog;
            }
        }
        catch (Exception ex)
        {
            response.Status = ResponseStatus.Fail;
            response.Message = $"Error occurred: {ex.Message}";
        }

        return response;
    }
}

