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
        Movie td = new Movie("Taxi Driver", MovieGenre.Drama, MovieClassification.M15Plus, 120, 17);
        fc.Insert(td);

        Movie dda = new Movie("Dog Day Afternoon", MovieGenre.Drama, MovieClassification.M15Plus, 120, 5);
        fc.Insert(dda);

        Movie dda1 = new Movie("Dog Day Afternoon", MovieGenre.Drama, MovieClassification.M15Plus, 250, 8);
        fc.Insert(dda1);

        Movie gf = new Movie("Goodfellas", MovieGenre.Drama, MovieClassification.M15Plus, 200, 8);
        fc.Insert(gf);

        fc.Insert(new Movie("28 Weeks Later"));
        fc.Insert(new Movie("The Deer Hunter"));
        fc.Insert(new Movie("Casino"));
        fc.Insert(new Movie("Casino"));
        fc.Insert(new Movie("Casino"));
        fc.Insert(new Movie("Casino"));
        fc.Insert(new Movie("The Irishman"));
        fc.Insert(new Movie("Spider-Man"));
        fc.Insert(new Movie("Citizen Kane"));
        fc.Insert(new Movie("Jumanji"));
        fc.Insert(new Movie("Meet The Fockers"));
        fc.Insert(new Movie("A Bug's Life"));

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

        //fc.Clear();

        Console.WriteLine("--");

        td.AddBorrower(new Member("Lewis", "Watson"));
        td.AddBorrower(new Member("Quagmire", "Watson"));
        td.AddBorrower(new Member("David", "Watson"));
        td.AddBorrower(new Member("Aaron", "Watson"));
        td.AddBorrower(new Member("Tom", "Watson"));
        td.AddBorrower(new Member("Tim", "Watson"));
        td.AddBorrower(new Member("Gerald", "Watson"));
        td.AddBorrower(new Member("Dwayne", "Watson"));
        td.AddBorrower(new Member("Clark", "Watson"));
        td.AddBorrower(new Member("Jim", "Watson"));
        td.AddBorrower(new Member("Jackie", "Watson"));
        td.AddBorrower(new Member("Katie", "Watson"));
        td.AddBorrower(new Member("Fred", "Watson"));
        td.AddBorrower(new Member("Jenny", "Watson"));
        td.AddBorrower(new Member("Wanda", "Watson"));
        td.AddBorrower(new Member("Spunk", "Watson"));
        td.AddBorrower(new Member("Bob", "Watson"));
        td.AddBorrower(new Member("Bob", "Watson"));
        td.AddBorrower(new Member("Bob", "Watson"));
        td.AddBorrower(new Member("Bob", "Watson"));
        td.AddBorrower(new Member("Bob", "Watson"));

        dda.AddBorrower(new Member("Lewis", "Watson"));
        dda.AddBorrower(new Member("Quagmire", "Watson"));
        dda.AddBorrower(new Member("David", "Watson"));
        dda.AddBorrower(new Member("Aaron", "Watson"));
        dda.AddBorrower(new Member("Tom", "Watson"));
        dda.AddBorrower(new Member("Tim", "Watson"));
        dda.AddBorrower(new Member("Gerald", "Watson"));

        gf.AddBorrower(new Member("Lewis", "Watson"));
        gf.AddBorrower(new Member("Quagmire", "Watson"));
        gf.AddBorrower(new Member("Tom", "Watson"));

        Console.WriteLine("--");

        // td.RemoveBorrower(new Member("Lewis", "Watson"));

        IMovie[] shit2 = fc.ToArray();

        for (int i = 0; i < shit2.Length; i++)
        {
            if (shit2[i] == null)
            {
                Console.WriteLine("null detected at index = " + i.ToString());
            }
            else
            {
                Console.WriteLine(shit2[i].ToString());
            }
        }

        /*
        fc.Insert(new Movie("28 Weeks Later"));
        fc.Insert(new Movie("The Deer Hunter"));
        fc.Insert(new Movie("Casino"));
        fc.Insert(new Movie("Casino"));
        fc.Insert(new Movie("Casino"));
        fc.Insert(new Movie("Casino"));
        fc.Insert(new Movie("The Irishman"));
        fc.Insert(new Movie("Spider-Man"));
        fc.Insert(new Movie("Citizen Kane"));
        fc.Insert(new Movie("Jumanji"));
        fc.Insert(new Movie("Meet The Fockers"));
        fc.Insert(new Movie("A Bug's Life"));

        Console.WriteLine("--");

        IMovie[] shit3 = fc.ToArray();

        for (int i = 0; i < shit3.Length; i++)
        {
            if (shit3[i] == null)
            {
                Console.WriteLine("null detected at index = " + i.ToString());
            }
            else
            {
                Console.WriteLine(shit3[i].ToString());
            }
        }
        */

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