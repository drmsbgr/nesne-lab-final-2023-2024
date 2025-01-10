using MYAZ203.Models;
using MYAZ203.Repositories;

var context = new RepositoryContext();
var courseRepo = new CourseRepository(context);

courseRepo.CreateCourseWithStudents(new Course()
{
    CourseId = 1,
    CourseName = "Nesne Yönelimli Programlama",
    CreditHours = 3,
    Instructor = "Zafer CÖMERT",
    RegisteredStudents =
    [
        new Student()
        {
            StudentId = 101,
            StudentName = "Ahmet",
            Major = "Bilgisayar Mühendisliği",
            GPA = 3.5,
            CourseId = 1
        },
        new Student()
        {
            StudentId = 102,
            StudentName = "Ayşe",
            Major = "Elektrik Mühendisliği",
            GPA = 3.2,
            CourseId = 1
        },
        new Student()
        {
            StudentId = 103,
            StudentName = "Mustafa",
            Major = "Matematik",
            GPA = 3.8,
            CourseId = 1
        },
        new Student()
        {
            StudentId = 104,
            StudentName = "Fatma",
            Major = "Fizik",
            GPA = 3.4,
            CourseId = 1
        },
        new Student()
        {
            StudentId = 105,
            StudentName = "Mehmet",
            Major = "Kimya",
            GPA = 3.6,
            CourseId = 1
        },
    ]
});