﻿namespace CKK.Logic.Models
{
    public class Customer
    {
        private int _id;
        private string _name;
        private string _address;

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void Setddress(string address)
        {
            _address = address;
        }

        public string GetAddress()
        {
            return _address;
        }
    }
}
