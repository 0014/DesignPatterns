using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var goldForKill = 1023;

            var joe = new Person {Name = "Joe"};
            var jake = new Person {Name = "Jake"};
            var emily = new Person {Name = "Emily"};
            var sophia = new Person {Name = "Sophia"};
            var brian = new Person {Name = "Brian"};
            var oldBob = new Person {Name = "Old Bob"};
            var newBob = new Person {Name = "New Bob"};

            var bobs = new Group{Members = {oldBob, newBob}};
            var developers = new Group{Members = {joe, jake, emily, bobs}};

            var parties = new Group {Members = {developers, sophia, brian}};

            parties.Gold += goldForKill;
            parties.Stats();
        }
    }
}
