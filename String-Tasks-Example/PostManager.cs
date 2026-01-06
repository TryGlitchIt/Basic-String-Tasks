using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public class PostManager
{
    public static List<Post> LoadPosts(string path)
    {
        var json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<List<Post>>(json);
    }

    public static List<Post> PostsWithExactly190Likes(List<Post> posts)
    {
        return posts.Where(p => p.Likes == 190).ToList();
    }

    public static List<Post> PublicPostsWithLikesAbove300(List<Post> posts)
    {
        return posts.Where(p => p.IsPublic && p.Likes > 300).ToList();
    }

    public static Post LastPostWith250Likes(List<Post> posts)
    {
        return posts.LastOrDefault(p => p.Likes == 250);
    }

    public static List<Post> PostsByWomen(List<Post> posts)
    {
        return posts.Where(p => p.FirstName.EndsWith("a", StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public static void CleanAndSavePosts(List<Post> posts, string outputPath)
    {
        var cleaned = posts
            .Where(p => p.IsPublic && p.Likes >= 200)
            .ToList();

        var json = JsonSerializer.Serialize(cleaned, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(outputPath, json);
    }

    public static void GenerateTextFromTemplate(Post post, string templatePath, string outputPath)
    {
        string template = File.ReadAllText(templatePath);
        string filled = template
            .Replace("{FirstName}", post.FirstName)
            .Replace("{LastName}", post.LastName)
            .Replace("{Likes}", post.Likes.ToString())
            .Replace("{Text}", post.Text);

        File.WriteAllText(outputPath, filled);
    }
}
