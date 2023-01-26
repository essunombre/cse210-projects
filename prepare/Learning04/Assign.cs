using System;
using System.IO;

public class Assign 
{
    private string _studentName = "";
    private string _topic = "";

    public Assign(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
    public string GetStudentName()
    {
        return _studentName;
    }
    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }

}