namespace LoLCLI
{
    internal class Program
    {
        public class Hos
        {
            public string name { get; set; }
            public string title { get; set; }
            public string category { get; set; }
            public string[] tag { get; set; }
            public string blurb { get; set; }
            public double hp { get; set; }
            public double hpperlevel { get; set; }
            public int movespeed { get; set; }
            public double armor { get; set; }
            public int attackrange { get; set; }
            public double hpregen { get; set; }
            public double attackdamage { get; set; }
            public double attackdamageperlevel { get; set; }
            public double attackspeedperlevel{ get; set; }

            public Hos(string hossor)
            {
                string[] adat=hossor.Split(';');
                this.name = adat[0];
                this.title = adat[1];
                this.category = adat[2];
                this.tag = adat[3].Split(',');
                this.blurb = adat[4];
                this.hp = double.Parse(adat[5]);
                this.hpperlevel = double.Parse(adat[6]);
                this.movespeed = int.Parse(adat[7]);
                this.armor = double.Parse(adat[8]);
                this.attackrange = int.Parse(adat[9]);
                this.hpregen = double.Parse(adat[10]);
                this.attackdamage = double.Parse(adat[11]);
                this.attackdamageperlevel = double.Parse(adat[12]);
                this.attackspeedperlevel = double.Parse(adat[13]);
            }
        }
        static void Main(string[] args)
        {
            List<Hos> hoslist = new List<Hos>();
            foreach (var h in File.ReadAllLines("champions2017.csv", System.Text.Encoding.UTF7).Skip(1))
            {
                hoslist.Add(new Hos(h));
            }
            Console.WriteLine($"2. Feladat, hősök száma:{hoslist.Count()}");
            Console.WriteLine(hoslist[119].blurb);

            //3.feladat
            bool joABekertHos = false;
            while (!joABekertHos)
            {
                Console.Write("Kérem egy hős nevét: ");
                string bekertHos = Console.ReadLine().ToLower();

                foreach (var h in hoslist)
                {
                    if (bekertHos == h.name.ToLower())
                    {
                        Console.WriteLine($"{h.name} adatai: HP: {h.hp}; Kategória: {h.category}");
                        joABekertHos = true;
                    }
                }                
            }
        }
    }
}
