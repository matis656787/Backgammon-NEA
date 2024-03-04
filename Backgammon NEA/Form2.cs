using Backgammon_NEA.Properties;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backgammon_NEA
{
    public partial class Form2 : Form
    {
        public string turn = "white";
        public static int buttonNumber=0;
        public Form2()
        {    
            InitializeComponent();
            MessageBox.Show("Input name of white player in top text box and black player in bottom text box");
            pictureBoxBackground.Image = Resources.board;
            foreach (Control control in this.Controls)//when a control occurs to a button
            {
                if (control is Button && control.Name.StartsWith("buttonslot"))
                {//checks if the button is one of the button slots
                    ((Button)control).Click += Button_Click;//calls the button_click function
                }
                
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            // calls the clicked button
            Button clickedButton = (Button)sender;
            // removes buttonslot from the buttons name
            int buttonNumber = int.Parse(clickedButton.Name.Replace("buttonslot", ""));
            if (clickedButton.BackColor == Color.White)
            {
                slotClass.whiteMoveOptions(buttonNumber);
            }
            else if (clickedButton.BackColor == Color.Green && turn == "white")
            {
                slotClass.whiteMoveTaken(buttonNumber);
                turn = "black";
                slotClass.enableBlackButtons(this);
            }
            else if (clickedButton.BackColor == Color.Green && turn == "black")
            {
                slotClass.blackMoveTaken(buttonNumber);
                turn = "white";
                slotClass.enableWhiteButtons(this);
            }
            else if (clickedButton.BackColor == Color.Black && turn == "black")
            {

            }
        }
        public int getButtonNumber()
        {
            return buttonNumber;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void buttonRoll_Click(object sender, EventArgs e)
        {
            WhitePlayerNameTextBox.ReadOnly = true;
            BlackPlayerNameTextBox.ReadOnly= true;
            diceTimer.Enabled = true;
            diceTimer.Start(); 
            buttonRoll.Enabled = false;
            if (buttonRoll.Text == "P1 ROLL")
            {
                slotClass.enableWhiteButtons(this);//calls currently running form
                buttonRoll.Enabled = false;
                buttonRoll.Text = "P2 Roll";

            }
            else
            {
                slotClass.enableBlackButtons(this);
                buttonRoll.Enabled = false;
                buttonRoll.Text = "P1 Roll";
            }            
        }
        private void diceTimer_Tick_1(object sender, EventArgs e)
        {
            diceClass.roll();
        }

        public static void setSlotBackColor(Form2 form, int temporaryButtonNumber, string colour, int originalButton)
        {

            if (temporaryButtonNumber < 25 && temporaryButtonNumber > 0)
            {

                string buttonName = "buttonslot" + temporaryButtonNumber;
                Button button = (Button)form.Controls.Find(buttonName, true)[0];
                if (button.BackColor != Color.Black && colour == "white")
                {
                    button.Enabled = true;
                    button.BackColor = Color.Green;

                }
            }
        }
        public static void effectingNumberOfTokens(Form2 form, string originalButton, string colour, int buttonNumber)
        {
            
            string labelName = "slotLabel"+ originalButton;
            string buttonName = "buttonslot" + originalButton;
            Button button = (Button)form.Controls.Find(buttonName, true)[0];
            Label label = (Label)form.Controls.Find(labelName, true)[0];
            int temp = (Convert.ToInt32(label.Text));
            temp = temp - 1;
            label.Text=temp.ToString();
           // MessageBox.Show(temp.ToString());
            if (label.Text == "0")
            {
                button.BackColor = Color.Chocolate;
            }
            labelName = "slotLabel" +buttonNumber;
            buttonName = "buttonslot" + buttonNumber;
           // MessageBox.Show(buttonName);
            button = (Button)form.Controls.Find(buttonName, true)[0];
            label = (Label)form.Controls.Find(labelName, true)[0];
            label.Text = "1";
            if(colour == "white")
            {
                button.BackColor = Color.White;
            }
            else
            {
                button.BackColor= Color.Black;
            }
        }
        public static void deselectGreenButtons(Form2 form, int[] greenButtons)
        {
            string greenButton = "";
            foreach (int number in greenButtons)
            {
                greenButton = greenButton + number.ToString();
                if (number >= 1 && number <= 24)
                {
                    string buttonName = "buttonslot" + number;
                    Button button = (Button)form.Controls.Find(buttonName, true)[0];
                    button.BackColor = Color.Chocolate;
                    button.Enabled = false;
                }
            }
        }
    }
}
