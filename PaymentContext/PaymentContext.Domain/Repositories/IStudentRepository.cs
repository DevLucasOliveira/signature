using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Repositories
{
    public interface IStudentRepository
    {
        bool DocumentsExists(string document);
        bool EmailExists(string email);
        void CreateSubscription(Student student);
    }
}