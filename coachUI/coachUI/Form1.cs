using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coachUI
{
    public partial class Form1 : Form
    {
        public Coach myCoach = new Coach();
        public Form1()
        {
            InitializeComponent();
        }

        private void getButton_Click(object sender, EventArgs e)
        {

            myCoach.GetSeatByName();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {



            // create a Person with correct name and age 

            Person p1 = new Person(nameTextbox.Text, Convert.ToInt32(ageTextbox.Text));

            // add to the Coach; it passes back the seat number 

            int seat = myCoach.AddPerson(p1);

            //  now display the seat number 

            seatTextbox.Text = seat + "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
        
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();
        }

        private void ageTextbox_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();
        }

        private void seatTextbox_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
