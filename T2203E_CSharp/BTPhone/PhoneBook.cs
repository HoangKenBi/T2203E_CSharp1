using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace T2203E_CSharp.BTPhone
{
    public abstract class PhoneBook : Phone
    {
        private List<PhoneEntry> PhoneList;

    public PhoneBook()
    {
        PhoneList = new List<PhoneEntry>();
    }

    public override void InsertPhone(string name, string phone)
    {
        bool found = false;
        foreach (var entry in PhoneList)
        {
            if (entry.Name == name)
            {
                found = true;
                if (!entry.PhoneNumbers.Contains(phone))
                {
                    entry.PhoneNumbers.Add(phone);
                }
                break;
            }
        }

        if (!found)
        {
            PhoneList.Add(new PhoneEntry { Name = name, PhoneNumbers = new List<string> { phone } });
        }
    }

    public override void RemovePhone(string name)
    {
        PhoneList.RemoveAll(entry => entry.Name == name);
    }

    public override void UpdatePhone(string name, string newphone)
    {
        foreach (var entry in PhoneList)
        {
            if (entry.Name == name)
            {
                entry.PhoneNumbers.Clear();
                entry.PhoneNumbers.Add(newphone);
                break;
            }
        }
    }

    public override void SearchPhone(string name)
    {
        foreach (var entry in PhoneList)
        {
            if (entry.Name == name)
            {
                Console.WriteLine($"Phone number(s) for {name}: {string.Join(", ", entry.PhoneNumbers)}");
                return;
            }
        }

        Console.WriteLine($"No phone number(s) found for {name}.");
    }

    public override void Sort()
    {
        PhoneList.Sort((entry1, entry2) => string.Compare(entry1.Name, entry2.Name, StringComparison.Ordinal));
    }
}

public class PhoneEntry
{
    public string Name { get; set; }
    public List<string> PhoneNumbers { get; set; }
}

}

