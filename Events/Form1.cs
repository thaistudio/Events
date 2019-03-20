using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        public Squad squad;
        public List<Player> playersForm1;
        public List<string> name = new List<string>();
        public List<int> numbers = new List<int>();
        public List<int> attributes = new List<int>();

        public Form1()
        {
            InitializeComponent();

            // Default player name, number, attribute

            CreateSquad();
            UpdateSquad();
            
            

            //AddPlayerForm add = new AddPlayerForm();
            //add.updateSquad();

        }

        public void CreateSquad()
        {
            squad = new Squad();
            playersForm1 = squad.CreateSquad();
        }

        public void UpdateSquad()
        {
            name.Clear();
            numbers.Clear();
            attributes.Clear();

            foreach (Player player in playersForm1)
            {
                name.Add(player.Name);
                numbers.Add(player.Number);
                attributes.Add(player.Attribute);
            }
            listBox1.DataSource = name;
            listBox2.DataSource = numbers;
            listBox3.DataSource = attributes;
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm = new AddPlayerForm();
            addPlayerForm.Show();
        }
    }
}
