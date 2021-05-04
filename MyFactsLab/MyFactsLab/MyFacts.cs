using System;
using System.Collections.Generic;
using System.Text;

namespace MyFactsLab
{
    class MyFacts
    {

        public MyFacts() { }
        public static IEnumerable<MyFacts> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string Img { get; set; }
        static MyFacts()
        {
            List<MyFacts> all = new List<MyFacts>();
            all.Add(new MyFacts() { TheFact = "Scorpion's Iconic line was originally voiced by the creater", ShortFact = "Iconic Line", Img = "scorpion.jfif" });
            all.Add(new MyFacts() { TheFact = "Noob Saibot was a joke character turned menacing bad guy", ShortFact = "Tobias Boon", Img = "noobsaibot.jpg" });
            all.Add(new MyFacts() { TheFact = "It took 10 games to explain Johnny Cage's Green aura", ShortFact = "Green Power", Img ="johnnycage.jpg" });
            all.Add(new MyFacts() { TheFact = "Shang Tsung's duplicate mechanic was due to low memory", ShortFact = "No memory left", Img = "shangtsung.jpg"});
            all.Add(new MyFacts() { TheFact = "An error in the arcade machine hardware and fan theories created Ermac", ShortFact = "Error Macintosh", Img = "ermac.jpg" });
            All = all;

        }
    }
}
