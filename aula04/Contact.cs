namespace aula04
{
    public class Contato
    {
        private string Name { get; set; }
        private string PhoneNumber { get; set; }

        public Contato(string name, string phoneNumber){
            this.Name=name;
            this.PhoneNumber=phoneNumber;
        }

        public string getName(){
            return this.Name;
        }
        public string getPhoneNumber(){
            return this.PhoneNumber;
        }

        public void setName(string name){
            this.Name=name;
        }
        public void setPhoneNumber(string phoneNumber){
            this.PhoneNumber=phoneNumber;
        }

        public string toString(){
            return "Nome: "+this.Name+" PhoneNumber: "+this.PhoneNumber;
        }

        public void updateObject(string newName, string newPhoneNumber){
            this.Name=newName;
            this.PhoneNumber=newPhoneNumber;
        }
    }
}