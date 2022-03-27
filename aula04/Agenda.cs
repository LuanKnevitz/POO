using System.Collections.Generic;
using System;

namespace aula04
{
    public class Agenda
    {
        private List<Contato> contacts= new List<Contato>();

        public Contato getByIndex(int index){
            return contacts[index];
        }
          public Contato getByName(string name){
            return contacts.Find(contact => contact.getName().Equals(name, StringComparison.OrdinalIgnoreCase));
        }

         public Contato getByPhoneNumber(string phoneNumber){
            return contacts.Find(contact => contact.getPhoneNumber().Equals(phoneNumber));
        }

        public void seeAllContacts(){
            List<Contato> list= getAllContacts();
            foreach (Contato contact in list)
            {
                Console.WriteLine(contact.toString());
            }
        }
        private List<Contato> getAllContacts(){
            List<Contato> listOfContacts=new List<Contato>();
            contacts.ForEach(contact => listOfContacts.Add(contact));
            return listOfContacts;
        }
        public void addContato(Contato contact){
            contacts.Add(contact);
        }

        public void removeContact(string name){
            contacts.Remove(getByName(name));
        }

        public void updateContact(string nameForSearch, string newName, string newPhoneNumber){
            getByName(nameForSearch).updateObject(newName, newPhoneNumber);
        }

      
    }
}