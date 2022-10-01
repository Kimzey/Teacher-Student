class Student: Person{
    private string StudentID;
    public Student(string name,string address,string citizenID,string StudentID)
    : base(name,address,citizenID){
        this.StudentID = StudentID;
    }
}