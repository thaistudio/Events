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
   
    public partial class AddPlayerForm : Form
    {
        
        Squad squad = new Squad();
        List<Player> updatePlayers = new List<Player>();

        List<string> newName = new List<string>();
        List<int> newNumber = new List<int>();
        List<int> newAttribute = new List<int>();

        public AddPlayerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            //form1.playersForm1.Add(new Player() { Name = nameBox.Text, Number = Convert.ToInt32(numberBox.Text), Attribute = Convert.ToInt32(attributeBox.Text) });
            //form1.AddNewPlayer(nameBox.Text, Convert.ToInt32(numberBox.Text), Convert.ToInt32(attributeBox.Text));
            form1.clear();
            
        }
    }
}
