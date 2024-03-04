using Backgammon_NEA.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Backgammon_NEA
{
    public class diceClass
    {
        public static int dice1Value;
        public static int dice2Value;
        public static int[] diceValues = new int[4];
        public static Form2 f2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();//alows modifying of form2 objects such as buttons
        
        public static int[] getDiceValues(int dice1Value, int dice2Value)
        {
            diceValues[0]= dice1Value;
            diceValues[1]= dice2Value;
            if (dice1Value == dice2Value)
            {
                diceValues[2]=dice1Value;
                diceValues[3]=dice2Value;
            }
            else
            {
                diceValues[2] = 0;
                diceValues[3] = 0;
            }
            return diceValues;
        }
        public static void roll()
        {
            Random random = new Random();//calls random number generator
            f2.progressBar.Increment(5);
            if (f2.progressBar.Value == 80)
            {//checks if progressbar is complete

                f2.diceTimer.Stop();
                f2.progressBar.Value = 0;//resets progress bars
                f2.buttonRoll.Enabled = true;
                int[] diceValues =diceClass.getDiceValues(dice1Value, dice2Value);
                string arrayAsString = string.Join(", ", diceValues);
                MessageBox.Show(arrayAsString);
            }
            else
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                switch (dice1)
                {
                    case 1:
                        f2.dicePicBox1.Image = Resources._1;
                        dice1Value = dice1;
                        break;
                    case 2:
                        dice1Value = dice1;
                        f2.dicePicBox1.Image = Resources._2;
                        break;
                    case 3:
                        dice1Value = dice1;
                        f2.dicePicBox1.Image = Resources._3;
                        break;
                    case 4:
                        dice1Value = dice1;
                        f2.dicePicBox1.Image = Resources._4;
                        break;
                    case 5:
                        dice1Value = dice1;
                        f2.dicePicBox1.Image = Resources._5;
                        break;
                    case 6:
                        dice1Value = dice1;
                        f2.dicePicBox1.Image = Resources._6;
                        break;
                }
                switch (dice2)
                {
                    case 1:
                        dice2Value = dice2;
                        f2.dicePicBox2.Image = Resources._1;
                        break;
                    case 2:
                        dice2Value = dice2;
                        f2.dicePicBox2.Image = Resources._2;
                        break;
                    case 3:
                        dice2Value = dice2;
                        f2.dicePicBox2.Image = Resources._3;
                        break;
                    case 4:
                        dice2Value = dice2;
                        f2.dicePicBox2.Image = Resources._4;
                        break;
                    case 5:
                        dice2Value = dice2;
                        f2.dicePicBox2.Image = Resources._5;
                        break;
                    case 6:
                        dice2Value = dice2;
                        f2.dicePicBox2.Image = Resources._6;
                        break;
                }
            }
        }
    }
}
