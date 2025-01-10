using MYAZ203.Models;
using MYAZ203.Repositories.Contracts;

namespace MYAZ203.Repositories;

public class CourseRepository : ICourseRepository
{
    private readonly RepositoryContext _context;

    public CourseRepository(RepositoryContext context)
    {
        _context = context;
    }

    public Course CreateCourseWithStudents(Course course)
    {
        _context.Add(course);
        _context.SaveChanges();
        return course;
    }
}
