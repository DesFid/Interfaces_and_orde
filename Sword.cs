using System;
using System.Collections.Generic;
    interface ISword
    {      
        string name { get; set; }
        int damage { get; set; }
        void newDamage(int _value);
    }
    interface IPowers
    {
        List<string> powers { get; set; }
    }
    public class Sword : ISword, IPowers
    {
        public string name { get; set; }
        public int damage { get; set; }
        public List<string> powers { get; set; }
        public Sword (string _name)
        {
            name = _name;
            damage = 100;
            powers = new List<string> (new string[] {"Fire", "Air", "Wather", "Ice", "Earth", "Neon", "Dark"});
        }
        public void newDamage(int _value)
        {
            damage = damage - _value;
            Console.WriteLine("New damage sword: " + damage);
        }
    }