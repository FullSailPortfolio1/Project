using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyMaids
{
    public partial class Form1 : Form
    {
        public class Room
        {
            public string Name;
            public double Width;
            public double length;
            public double SquareFeet;
        }
        private List<Room> Rooms = new List<Room>();

        public Form1()
        {
            InitializeComponent();
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //name text box
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // number of rooms text box

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //room length text bo
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim();
            MessageBox.Show("Hello "+ userName + "! Welcome to the Happy Maids price quoting application.\r\n                                         Press OK to contuniue.");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            txtWidth.Clear();
            txtLength.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Double length;
            Double width;
            if (!System.Double.TryParse(txtLength.Text, out length) || !System.Double.TryParse(txtWidth.Text, out width)) return;
            Room newroom = new Room();
            newroom.length = length;
            newroom.Width = width;
            newroom.SquareFeet = width * length;
            Rooms.Add(newroom);
            UpdateRoomList();
        }
        private void UpdateRoomList()
        {
            lvRoomList.Clear();
            foreach(Room temproom in Rooms)
            {
                lvRoomList.Items.Add(temproom.SquareFeet + " sqft");
            }
        }

        private void lvRoomList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvRoomList.SelectedIndices.Count <= 0) return;
            Rooms.RemoveAt(lvRoomList.SelectedIndices[0]);
            UpdateRoomList();
        }
        private double GetTotalSqFeet()
        {
            double ret = 0;
            foreach (Room temproom in Rooms)
            {
                ret += temproom.SquareFeet;
            }
            return ret;
        }

    }
}
