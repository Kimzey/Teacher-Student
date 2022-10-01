enum Menu{
    RegisterNewStudent = 1,
    RegisterNewTeacher,
    GetListPersons
}
public class Program{
    static PresonList personList;
     static void Main(string []args){
        PreparePersonListWhenProgramIsLoad();
        PrintMenuScreen();
    }
    static void PrintMenuScreen(){
        Console.Clear();
        PrintListMenu();
        InputMenuFromKeyboard();
    }
    static void PrintListMenu(){
        
        Console.WriteLine("Welcome to regustration new yser school application");
        Console.WriteLine("******************************************************");
        Console.WriteLine("1.Registration new Student");
        Console.WriteLine("2.Registration new Teacher");
        Console.WriteLine("3.Get list Persons");
        Console.WriteLine("******************************************************");
    }
    static void InputMenuFromKeyboard(){
        Console.Write("Please input Menu:");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        PresentMenu(menu);
    }
    static void PresentMenu(Menu menu){
        switch (menu){
            case Menu.RegisterNewStudent:
                ShowInputRegistrationNewStudentScreen();
                break;
            case Menu.RegisterNewTeacher:
                ShowInputRegistrationNewTeacherScreen();
                break;
            default:
                break;
        }
    }

    static void ShowInputRegistrationNewTeacherScreen(){
        Console.Clear();
        PrintHeaderRegisterTeacher();
        int TotalTeacher = TotalNewTeacher();
        InputNewTeacherFromKeyboard(TotalTeacher);
    }
    static void ShowInputRegistrationNewStudentScreen(){
        Console.Clear();
        PrintHeaderRegisterStudent();
        int TotalStudent = TotalNewStudent();
        InputNewStudentFromKeyboard(TotalStudent);
    }
    static void PrintHeaderRegisterTeacher(){
        Console.WriteLine("Reguster New Teacher");
        Console.WriteLine("*********************");
    }
    static void PrintHeaderRegisterStudent(){
        Console.WriteLine("Reguster New student");
        Console.WriteLine("*********************");
    }

    static int TotalNewStudent(){
        Console.Write("Input Total new Student:");
        return int.Parse(Console.ReadLine());
    }
        static int TotalNewTeacher(){
        Console.Write("Input Total new Teacher:");
        return int.Parse(Console.ReadLine());
    }

    static void InputNewStudentFromKeyboard(int TotalNewStudent){
        for(int i = 0; i< TotalNewStudent; i++){
            Console.Clear();
            PrintHeaderRegisterStudent();

            Student student = new Student(InputName(),InputStudentID(),InputAddress(),InputCitizenID());
            Program.personList.AddNewPerson(student);
        }
    }
    static void InputNewTeacherFromKeyboard(int TotalNewTeacher){
        for(int i = 0; i< TotalNewTeacher; i++){
            Console.Clear();
            PrintHeaderRegisterTeacher();

            Teacher teacher = new Teacher(InputName(),InputStudentID(),InputAddress(),InputEmployeeID());
            Program.personList.AddNewPerson(teacher);
        }
    }
    static void PreparePersonListWhenProgramIsLoad(){
        Program.personList = new PresonList();
        
    }
    static string InputName(){
        Console.Write("Name :");
        return Console.ReadLine();
    }
    static string InputStudentID(){
        Console.Write("StudentID :");
        return Console.ReadLine();
    }
    static string InputAddress (){
        Console.Write("Address :");
        return Console.ReadLine();
    }
        static string InputCitizenID (){
        Console.Write("CitizenID :");
        return Console.ReadLine();
    }
    static string InputEmployeeID (){
        Console.Write("employeeID :");
        return Console.ReadLine();
    }

}