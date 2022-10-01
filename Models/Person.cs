class Person{
    private string name;
    private string address;
    private string citizenID;

    public Person(string name,string address,string citizenID){
        this.name = name;
        this.address = address;
        this.citizenID = citizenID;
    }

    public string Getname() {
        return this.name;
    }
    public string Getaddress(){
        return this.address;
    }
    public string GetcitizenID(){
        return this.citizenID;
    }
}