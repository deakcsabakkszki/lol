using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LolWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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
        public double attackspeedperlevel { get; set; }

        public Hos(string hossor)
        {
            string[] adat = hossor.Split(';');
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
   
    public partial class MainWindow : Window
    {
        public List<Hos> hoslist = new List<Hos>();
        public MainWindow()
        {
            InitializeComponent();

            foreach (var h in File.ReadAllLines("champions2017.csv", System.Text.Encoding.UTF7).Skip(1))
            {
                hoslist.Add(new Hos(h));
            }
            datagrid.ItemsSource = hoslist;

            List<string> kategoriak = new List<string>();
            foreach (var h in hoslist)
            {
                if (!kategoriak.Contains(h.category))
                {
                    kategoriak.Add(h.category);
                    //Console.WriteLine(h.category);
                }

            }
            combobox.ItemsSource = kategoriak;

           
        }

        private void kereses(object sender, RoutedEventArgs e)
        {
            List<Hos>talalat = new List<Hos>();
            foreach (var h in hoslist)
            {
                if (h.name.Contains(keresett.Text))
                {
                    talalat.Add(h);
                }
            }
            datagrid.ItemsSource=talalat;
        }
    }
}