using System.Threading.Tasks;

public interface ICommentService
{
    Task AddComment(string content, string authorName);
}