using MYAZ203.Models;

namespace MYAZ203.Repositories.Contracts;

public interface ICourseRepository
{
    Course CreateCourseWithStudents(Course course);
}
