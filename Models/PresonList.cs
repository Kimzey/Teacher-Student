using System.Collections.Generic;

class PresonList{
    private List<Person> personList;
    public PresonList(){
        this.personList = new List<Person>();
    }
    public void AddNewPerson(Person person){
        this.personList.Add(person);
    }
    public void FetchPersonList(){
        Console.WriteLine("List Person");
        Console.WriteLine("***************");
        
        foreach(Person person in this.personList){
            if (person is Student) {
                Console.WriteLine("Name {0} \n type: student \n",person.Getname());
            } else if (person is Teacher) {
                Console.WriteLine("Name {0} \n type: Teacher \n",person.Getname());
            }
        }
    }
}