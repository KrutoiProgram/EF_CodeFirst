using CodeFirst.Models;

Seeder.InitialSeed();

var context = new BlogContext();
foreach (Post post in context.Posts)
{
    Console.WriteLine($"=={post.Name}==");
    Console.WriteLine(post.Text);
    Console.WriteLine(post.PostTime);
}
