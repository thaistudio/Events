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

            CreateSquad();
            UpdateSquad();
           

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
                listBox1.Items.Add(player.Name);
                listBox2.Items.Add(player.Number);
                listBox3.Items.Add(player.Attribute);
            }
            //listBox1.DataSource = name;
            //listBox2.DataSource = numbers;
            //listBox3.DataSource = attributes;
        }

        public void AddNewPlayer(string name, int number, int att)
        {
            listBox1.Items.Add(name);
            listBox1.Refresh();
            listBox1.Update();
            listBox2.Items.Add(number);
            listBox3.Items.Add(att);
        }
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public event EventHandler<string> UpdateEvent;
        AddPlayerForm addPlayerForm = new AddPlayerForm();
        private void button1_Click(object sender, EventArgs e)
        {
            
            addPlayerForm.Show();
        }

        public void nutin()
        {
            UpdateEvent += AddPlayerForm_UpdateEvent;
        }

        public void clear()
        {
            UpdateEvent?.Invoke(this, "aaaa");
            
        }

        private void AddPlayerForm_UpdateEvent(object sender, string e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
