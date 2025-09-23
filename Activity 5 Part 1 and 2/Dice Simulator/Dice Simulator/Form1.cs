/*
 * Aaron Belschner
 * CST-150
 * Activity 5 Part 2
 * 9/18/25
 * This is my own work
 */

using Dice_Simulator.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;

namespace Dice_Simulator
{
    public partial class Form1 : Form
    {
        Random diceRoll = new Random();

        public Form1()
        {

            InitializeComponent();
        }

        private void BtnRollDice_ClickEvent(object sender, EventArgs e)
        {
            int num1 = diceRoll.Next(1, 7);
            int num2 = diceRoll.Next(1, 7);

            switch(num1)
            {
                case 1:
                    pbDie1.ImageLocation = @"C:\Users\aaron\source\repos\Activity 5 Part 1 and 2\Dice Simulator\Dice Simulator\Resources\Die1.bmp";
                    pbDie1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pbDie1.ImageLocation = @"C:\Users\aaron\source\repos\Activity 5 Part 1 and 2\Dice Simulator\Dice Simulator\Resources\Die2.bmp";
                    pbDie1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pbDie1.ImageLocation = @"C:\Users\aaron\source\repos\Activity 5 Part 1 and 2\Dice Simulator\Dice Simulator\Resources\Die3.bmp";
                    pbDie1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pbDie1.ImageLocation = @"C:\Users\aaron\source\repos\Activity 5 Part 1 and 2\Dice Simulator\Dice Simulator\Resources\Die4.bmp";
                    pbDie1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pbDie1.ImageLocation = @"C:\Users\aaron\source\repos\Activity 5 Part 1 and 2\Dice Simulator\Dice Simulator\Resources\Die5.bmp";
                    pbDie1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pbDie1.ImageLocation = @"C:\Users\aaron\source\repos\Activity 5 Part 1 and 2\Dice Simulator\Dice Simulator\Resources\Die6.bmp";
                    pbDie1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pbDie1.ImageLocation = @"C:\Users\aaron\source\repos\Activity 5 Part 1 and 2\Dice Simulator\Dice Simulator\Resources\Die1.bmp";
                    pbDie1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

            }

            switch (num2)
            {
                case 1:
                    pbDie2.ImageLocation = @"C:\Users\aaron\source\repos\Activity 5 Part 1 and 2\Dice Simulator\Dice Simulator\Resources\Die1.bmp";
                    pbDie2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pbDie2.ImageLocation = @"C:\Users\aaron\source\repos\Activity 5 Part 1 and 2\Dice Simulator\Dice Simulator\Resources\Die2.bmp";
                    pbDie2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pbDie2.ImageLocation = @"C:\Users\aaron\source\repos\Activity 5 Part 1 and 2\Dice Simulator\Dice Simulator\Resources\Die3.bmp";
                    pbDie2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pbDie2.ImageLocation = @"C:\Users\aaron\source\repos\Activity 5 Part 1 and 2\Dice Simulator\Dice Simulator\Resources\Die4.bmp";
                    pbDie2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pbDie2.ImageLocation = @"C:\Users\aaron\source\repos\Activity 5 Part 1 and 2\Dice Simulator\Dice Simulator\Resources\Die5.bmp";
                    pbDie2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pbDie2.ImageLocation = @"C:\Users\aaron\source\repos\Activity 5 Part 1 and 2\Dice Simulator\Dice Simulator\Resources\Die6.bmp";
                    pbDie2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pbDie2.ImageLocation = @"C:\Users\aaron\source\repos\Activity 5 Part 1 and 2\Dice Simulator\Dice Simulator\Resources\Die1.bmp";
                    pbDie2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

            }
        }
    }
}
