using MYAZ203.Models;
using MYAZ203.Repositories.Contracts;

namespace MYAZ203.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly RepositoryContext _context;

    public StudentRepository(RepositoryContext context)
    {
        _context = context;
    }

    public void AddStudentToCourse(int courseId, Student student)
    {
        var course = _context.Courses?.Find(courseId);

        if (course is null) return;

        student.CourseId = courseId;
        course.RegisteredStudents?.Add(student);
        _context.SaveChanges();
    }

    public void DeleteAllStudentsByCourse(Course course)
    {
        if (course.RegisteredStudents is null) return;

        foreach (var item in course.RegisteredStudents)
        {
            item.CourseId = 0;
            _context.Students?.Remove(item);
        }

        _context.SaveChanges();
    }
}