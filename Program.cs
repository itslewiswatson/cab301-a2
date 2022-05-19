using System;

class Program {
    static readonly String[] pinTests = new String[] { "0000", "00000", "000000", "-10000", "1234567", "aaaaa" };
    static readonly String[] contactNumberTests = new String[] { "0404925759", "4404925759", "0111", "0000000000", "000000000000", "aaaa", "0abcdefghi" };

    static void Main()
    {
        Console.WriteLine("Testing CAB301 for n10221131");
        Console.WriteLine("");

        //TestPins();
        //TestContactNumbers();

        /*
        MemberCollection mc = new MemberCollection(10);
        mc.Add(new Member("Timothy", "Watson"));
        mc.Add(new Member("Lewis", "Watson"));
        mc.Add(new Member("Ethan", "Andrews"));
        mc.Add(new Member("Daniel", "Andrews"));
        mc.Add(new Member("Joshua", "Smith"));
        mc.Add(new Member("Lewis", "Watson"));
        mc.Add(new Member("Anthony", "Watson"));
        mc.Add(new Member("Anthony", "QQQ"));
        mc.Add(new Member("Anthony", "WWW"));
        mc.Add(new Member("Anthony", "XXX"));
        mc.Add(new Member("Anthony", "LLL"));
        mc.Add(new Member("Anthony", "ZZZ"));
        mc.Add(new Member("Anthony", "CCC"));
        mc.Add(new Member("Anthony", "GGG"));

        Console.WriteLine(mc.ToString());
        Console.WriteLine("");

        mc.Delete(new Member("Lewis", "Watson"));
        Console.WriteLine(mc.ToString());
        Console.WriteLine("");

        mc.Delete(new Member("Daniel", "Andrews"));
        Console.WriteLine(mc.ToString());
        Console.WriteLine("");

        bool search = mc.Search(new Member("Daniel", "Andrews"));
        Console.WriteLine("mc.Search(Daniel, Andrews) -> " + search.ToString());
        bool search2 = mc.Search(new Member("Joshua", "Smith"));
        Console.WriteLine("mc.Search(Joshua, Smith) -> " + search2.ToString());
        */

        MovieCollection fc = new MovieCollection();
        fc.Insert(new Movie("Taxi Driver"));
        fc.Insert(new Movie("Dog Day Afternoon"));
        fc.Insert(new Movie("Goodfellas"));
        fc.Insert(new Movie("28 Weeks Later"));
        fc.Insert(new Movie("The Deer Hunter"));
        fc.Insert(new Movie("Casino"));

        IMovie[] shit = fc.ToArray();

        for (int i = 0; i < shit.Length; i++)
        {
            if (shit[i] == null)
            {
                Console.WriteLine("null detected at index = " + i.ToString());
            }
            else
            {
                Console.WriteLine(shit[i].ToString());
            }
        }

        Console.Read();
    }

    static void TestPins()
    {
        for (int i = 0; i < pinTests.Length; i++)
        {
            String pin = pinTests[i];
            bool pinResult = IMember.IsValidPin(pin);
            Console.WriteLine("IsValidPin(\"" + pin + "\") -> " + pinResult.ToString());
        }

        Console.WriteLine("");
    }

    static void TestContactNumbers()
    {
        for (int i = 0; i < contactNumberTests.Length; i++)
        {
            String contactNumber = contactNumberTests[i];
            bool contactNumberResult = IMember.IsValidContactNumber(contactNumber);
            Console.WriteLine("IsValidContactNumber(\"" + contactNumber + "\") -> " + contactNumberResult.ToString());
        }

        Console.WriteLine("");
    }
}