using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        
    }

    public class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Attribute { get; set; }
       
    }

    public class Squad
    {
        public List<Player> players;

        public Squad()
        {
            players = new List<Player>();
        }

        public List<Player> CreateSquad()
        {
            players.Add(new Player() { Name = "Thai", Number = 20, Attribute = 90 });
            players.Add(new Player() { Name = "Lingard", Number = 14, Attribute = 82 });
            players.Add(new Player() { Name = "Pogba", Number = 6, Attribute = 86 });
            players.Add(new Player() { Name = "Dalot", Number = 22, Attribute = 72 });

            return players;
        }

        public bool CheckSquad()
        {
            if (players.Count > 6)
                return false;
            else
                return true;
        }
    }
}
