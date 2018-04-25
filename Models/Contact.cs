using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Models
{
    public class Contact
    {
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private string _email;
        private string _street;
        private string _city;
        private string _state;
        private string _zip;
        private int _id;
        private static List<Contact> _instances = new List<Contact> {};

        public Contact(string First, string Last, string Number, string Email, string Street, string City, string State, string Zip)
        {
            _firstName = First;
            _lastName = Last;
            _phoneNumber = Number;
            _email = Email;
            _street = Street;
            _city = City;
            _state = State;
            _zip = Zip;
            _instances.Add(this);
            _id = 1;
        }

        public string GetFirst()
        {
            return _firstName;
        }
        public void SetFirst(string newFirst)
        {
            _firstName = newFirst;
        }

        public string GetLast()
        {
            return _lastName;
        }
        public void SetLast(string newLast)
        {
            _lastName = newLast;
        }

        public string GetNumber()
        {
            return _phoneNumber;
        }
        public void SetNumber(string newNumber)
        {
            _phoneNumber = newNumber;
        }

        public string GetEmail()
        {
            return _email;
        }
        public void SetEmail(string newEmail)
        {
            _email = newEmail;
        }

        public string GetStreet()
        {
            return _street;
        }
        public void SetStreet(string newStreet)
        {
            _street = newStreet;
        }

        public string GetCity()
        {
            return _city;
        }
        public void SetCity(string newCity)
        {
            _city = newCity;
        }

        public string GetState()
        {
            return _state;
        }
        public void SetState(string newState)
        {
            _state = newState;
        }

        public string GetZip()
        {
            return _zip;
        }
        public void SetZip(string newZip)
        {
            _zip = newZip;
        }

        public static List<Contact> GetAll()
        {
            return _instances;
        }

        public int GetId()
        {
            return _id;
        }

        public static Contact Find(int searchId)
        {
            return _instances[searchId++];
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

    }
}
