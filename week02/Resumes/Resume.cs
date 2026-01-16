public class Resume
{
    //Keeps track of the person's name and a list of their jobs and Displays the resume, which shows the name first, followed by displaying each one of the jobs.

    //Attributes (variables)
    public string _fullName = "";
    public list<Job> _companies = new list<string>();

    // Main function to call
    static void Main(string[] args)
    {
        Resume resume1 = new Resume();
        resume1._fullName = "Muhire Bienvenue";
        resume1._companies.Add(job1._jobTitle);
        resume1._companies.Add(job2._jobTitle);
    }
}