
namespace Homeworks_Const_Readonly_Access_Modifiers.Models
{
    internal class Book:BaseEntity
    {
        public const string title = "Bashliq";
        public readonly string autor;

        public Book()
        {
            autor = "sagol";
        }
    }
}
