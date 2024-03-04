using Backgammon_NEA.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backgammon_NEA
{
    public class slotClass :Form2//inherits variables and functions from form2
    {
        public static int temporaryButtonNumber = buttonNumber;
        public static string whitePlayer = "white";
        public static string blackPlayer = "black";
        public static int[] temporaryNumberArray = new int[4];

        public slotClass()
        {   
        }
        public static Form2 f2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();//alows modifying of form2 objects such as buttons
        public static void startSetUp()//modifies values and colour of form2 objects from external class
        {
            f2.slotLabel1.Text = f2.slotLabel1.Text.Replace("0", "2");
            f2.slotLabel12.Text = f2.slotLabel12.Text.Replace("0", "5");
            f2.slotLabel17.Text = f2.slotLabel17.Text.Replace("0", "3");
            f2.slotLabel19.Text = f2.slotLabel19.Text.Replace("0", "5");
            f2.buttonslot24.BackColor = Color.Black;
            f2.slotLabel24.BackColor = Color.Black;
            f2.slotLabel24.Text = f2.slotLabel24.Text.Replace("0", "2");
            f2.buttonslot13.BackColor = Color.Black;
            f2.slotLabel13.BackColor = Color.Black;
            f2.slotLabel13.Text = f2.slotLabel13.Text.Replace("0", "5");
            f2.buttonslot8.BackColor = Color.Black;
            f2.slotLabel8.BackColor = Color.Black;
            f2.slotLabel8.Text = f2.slotLabel8.Text.Replace("0", "3");
            f2.buttonslot6.BackColor = Color.Black;
            f2.slotLabel6.BackColor = Color.Black;
            f2.slotLabel6.Text = f2.slotLabel6.Text.Replace("0", "5");
            f2.buttonslot1.BackColor = Color.White;
            f2.buttonslot12.BackColor = Color.White;
            f2.buttonslot17.BackColor = Color.White;
            f2.buttonslot19.BackColor = Color.White;
            f2.slotLabel1.BackColor = Color.White;
            f2.slotLabel12.BackColor = Color.White;
            f2.slotLabel17.BackColor = Color.White;
            f2.slotLabel19.BackColor = Color.White;
        }
        public static void enableWhiteButtons(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is Button && control.BackColor == Color.White)//selects all buttons with white background
                {
                    ((Button)control).Enabled = true; // enables buttons
                }
                else if(control is Button && control.BackColor == Color.Black)//seelects all buttons with black background
                {
                    ((Button)control).Enabled = false;
                }
            }
        }
        public static void enableBlackButtons(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is Button && control.BackColor == Color.White)//selects all buttons with white background
                {
                    ((Button)control).Enabled = false; // disables buttons
                }
                else if (control is Button && control.BackColor == Color.Black)
                {
                    ((Button)control).Enabled = true;
                }
            }
        }
        public static void disableButtons(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is Button && control.BackColor == Color.White || control is Button && control.BackColor == Color.Black)//selects all buttons
                {
                    ((Button)control).Enabled = false; // disables buttons
                }
            }
        }
        

        public static void whiteMoveOptions(int clickedButton)
        {
            f2.previousButtonLabel.Text = clickedButton.ToString();
            int[] diceValues = diceClass.diceValues;
            disableButtons(f2);
            int[] possibleMoves = {0, 0, 0, 0};
            possibleMoves[0] = diceValues[0] + clickedButton;
            possibleMoves[1] = diceValues[1] + clickedButton;
            if (diceValues[1] == diceValues[0])
            {
                possibleMoves[2] = clickedButton+(diceValues[3] + diceValues[2] + diceValues[1]);
                possibleMoves[3] = clickedButton+(diceValues[3] + diceValues[2] + diceValues[1] + diceValues[0]);
            }
            else
            {
                possibleMoves[2] = diceValues[1] + clickedButton + diceValues[0];
            }
            
            for (int i = 0; i < 4; i++)
            {
                if (possibleMoves[i] != clickedButton && possibleMoves[i]<25)
                {
                   // MessageBox.Show(clickedButton.ToString());
                    temporaryButtonNumber = possibleMoves[i];
                    temporaryNumberArray[i] = clickedButton;
                   // MessageBox.Show(temporaryButtonNumber.ToString());
                    setSlotBackColor(f2,temporaryButtonNumber,whitePlayer, clickedButton);
                }
            }
            
        }
        public static void whiteMoveTaken(int clickedButton)
        {
            string previousButton = f2.previousButtonLabel.Text;
            effectingNumberOfTokens(f2,previousButton,whitePlayer,clickedButton);
            deselectGreenButtons(f2, temporaryNumberArray);
            
        }
       public static void blackMoveOptions(int clickedButton)
        {
            f2.previousButtonLabel.Text = clickedButton.ToString();
            int[] diceValues = diceClass.diceValues;
            disableButtons(f2);
            int[] possibleMoves = {0, 0, 0, 0};
            possibleMoves[0] = clickedButton- diceValues[0];
            possibleMoves[1] = clickedButton- diceValues[1];
            if (diceValues[1] == diceValues[0])
            {
                possibleMoves[2] = clickedButton-(diceValues[3] + diceValues[2] + diceValues[1]);
                possibleMoves[3] = clickedButton-(diceValues[3] + diceValues[2] + diceValues[1] + diceValues[0]);
            }
            else
            {
                possibleMoves[2] = clickedButton- diceValues[1] - diceValues[0];
            }
            
            for (int i = 0; i < 4; i++)
            {
                if (possibleMoves[i] != clickedButton && possibleMoves[i]>0)
                {
                   // MessageBox.Show(clickedButton.ToString());
                    temporaryButtonNumber = possibleMoves[i];
                    temporaryNumberArray[i] = clickedButton;
                   // MessageBox.Show(temporaryButtonNumber.ToString());
                    setSlotBackColor(f2,temporaryButtonNumber,blackPlayer, clickedButton);
                }
            }
            
       }
        public static void blackMoveTaken(int clickedButton)
        {
            string previousButton = f2.previousButtonLabel.Text;
            effectingNumberOfTokens(f2, previousButton, blackPlayer, clickedButton);
            deselectGreenButtons(f2, temporaryNumberArray);
            if (checkWin()==true)
            {
                disableButtons(f2);
            }
        }
        public static bool checkWin()
        {
            if ((f2.blackScoreLabel.Text == "15"))
            {
                disableButtons(f2);
                MessageBox.Show("BLACK IS THE WINNER");
                return true;
            }
            else if (f2.whiteScoreLabel.Text == "15")
            {
                disableButtons(f2);
                MessageBox.Show("WHITE IS THE WINNER");
                return true;
            }
            return false;
        }
    }
}
