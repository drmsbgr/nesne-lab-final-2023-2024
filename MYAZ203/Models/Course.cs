namespace MYAZ203.Models;

public class Course
{
    private int courseId;
    private string courseName = string.Empty;
    private int creditHours;
    private string instructor = string.Empty;

    public int CourseId { get => courseId; set => courseId = value; }
    public string CourseName { get => courseName; set => courseName = value; }
    public int CreditHours { get => creditHours; set => creditHours = value; }
    public string Instructor { get => instructor; set => instructor = value; }
    public ICollection<Student>? RegisteredStudents { get; set; }
}
