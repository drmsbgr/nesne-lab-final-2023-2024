namespace MYAZ203.Models;

public class Student
{
    private int studentId;
    private string studentName = string.Empty;
    private string major = string.Empty;
    private double gpa;
    public int StudentId { get => studentId; set => studentId = value; }
    public string StudentName { get => studentName; set => studentName = value; }
    public string Major { get => major; set => major = value; }
    public double GPA { get => gpa; set => gpa = value; }
    public int CourseId { get; set; }
    public Course? Course { get; set; }

    public static Student CreateStudent() => new();
    public Student SetStudentId(int id)
    {
        StudentId = id;
        return this;
    }

    public Student SetStudentName(string name)
    {
        StudentName = name;
        return this;
    }

    public Student SetStudentMajor(string major)
    {
        Major = major;
        return this;
    }

    public Student SetStudentGPA(double gpa)
    {
        GPA = gpa;
        return this;
    }
}