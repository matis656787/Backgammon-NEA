using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Backgammon_NEA.Properties;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Backgammon_NEA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vsPlayerbutton_Click(object sender, EventArgs e)//closes menu window and opens game window
        {
            
            Form2 f2=new Form2();
            f2.Show();
            Visible= false;
            slotClass.startSetUp();//allows changes of form objects from external class
        }

        private void instructionsbutton_Click(object sender, EventArgs e)
        {
            string filepath = "Backgammon Rules.txt";
            StreamReader sr = new StreamReader(filepath);
            using (StreamReader reader = new StreamReader(filepath))
            {
                string content = reader.ReadToEnd();
                rulesTextBox.Text = rulesTextBox +content;
                MessageBox.Show(rulesTextBox.Text);

            }
        }

        private void statsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOT IMPLEMENTED");
        }
    }
}
