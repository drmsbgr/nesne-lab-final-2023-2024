using MYAZ203.Models;

namespace MYAZ203.Repositories.Contracts;

public interface IStudentRepository
{
    void DeleteAllStudentsByCourse(Course course);
    void AddStudentToCourse(int courseId, Student student);
}