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


        public AddPlayerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.playersForm1.Add(new Player() { Name = nameBox.Text, Number = Convert.ToInt32(numberBox.Text), Attribute = Convert.ToInt32(attributeBox.Text) });
            form1.UpdateSquad();
            //foreach (Player player in form1.playersForm1)
            //{
            //    form1.name.Add(nameBox.Text);
            //    form1.numbers.Add(Convert.ToInt32(numberBox.Text));
            //    form1.attributes.Add(Convert.ToInt32(attributeBox.Text));
            //}
        }
    }
}
