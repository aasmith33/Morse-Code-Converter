// This program will translate your input into morse code
// Abigail Smith 2021
using System;
using System.Windows.Forms;

namespace Abigail_Smith_CPT_185_Chapter_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtInput.Focus();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string userInput = txtInput.Text;
            Boolean value = true;
            string codeOutput = " ";

            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput.Contains("0"))
                {
                    txtOutput.Text = "-----";
                }
                if (userInput.Contains("1"))
                {
                    txtOutput.Text = ".----";
                }
                if (userInput.Contains("2"))
                {
                    txtOutput.Text = "..---";
                }
                if (userInput.Contains("3"))
                {
                    txtOutput.Text = "...--";
                }
                if (userInput.Contains("4"))
                {
                    txtOutput.Text = "....-";
                }
                if (userInput.Contains("5"))
                {
                    txtOutput.Text = ".....";
                }
                if (userInput.Contains("6"))
                {
                    txtOutput.Text = "-....";
                }
                if (userInput.Contains("7"))
                {
                    txtOutput.Text = "--...";
                }
                if (userInput.Contains("8"))
                {
                    txtOutput.Text = "---..";
                }
                if (userInput.Contains("9"))
                {
                    txtOutput.Text = "----.";
                }

                switch (char.ToUpper(userInput[i]))
                {
                    case ' ': codeOutput += " " + "\r\n"; break;
                    case ',': codeOutput += "--..--" + "\r\n"; break;
                    case '.': codeOutput += ".-.-.-" + "\r\n"; break;
                    case '?': codeOutput += "..--.." + "\r\n"; break;
                    case 'A': codeOutput += ".-" + "\r\n"; break;
                    case 'B': codeOutput += "-..." + "\r\n"; break;
                    case 'C': codeOutput += "-.-." + "\r\n"; break;
                    case 'D': codeOutput += "-.." + "\r\n"; break;
                    case 'E': codeOutput += "." + "\r\n"; break;
                    case 'F': codeOutput += "..-." + "\r\n"; break;
                    case 'G': codeOutput += "--." + "\r\n"; break;
                    case 'H': codeOutput += "...." + "\r\n"; break;
                    case 'I': codeOutput += ".." + "\r\n"; break;
                    case 'J': codeOutput += ".---" + "\r\n"; break;
                    case 'K': codeOutput += "-.-" + "\r\n"; break;
                    case 'L': codeOutput += ".-.." + "\r\n"; break;
                    case 'M': codeOutput += "---" + "\r\n"; break;
                    case 'N': codeOutput += "-." + "\r\n"; break;
                    case 'O': codeOutput += "---" + "\r\n"; break;
                    case 'P': codeOutput += ".--." + "\r\n"; break;
                    case 'Q': codeOutput += "--.-" + "\r\n"; break;
                    case 'R': codeOutput += ".-." + "\r\n"; break;
                    case 'S': codeOutput += "..." + "\r\n"; break;
                    case 'T': codeOutput += "-" + "\r\n"; break;
                    case 'U': codeOutput += "..-" + "\r\n"; break;
                    case 'V': codeOutput += "...-" + "\r\n"; break;
                    case 'W': codeOutput += ".--" + "\r\n"; break;
                    case 'X': codeOutput += "-..-" + "\r\n"; break;
                    case 'Y': codeOutput += "-.--" + "\r\n"; break;
                    case 'Z': codeOutput += "--.." + "\r\n"; break;
                    default: codeOutput += char.ToUpper(userInput[i]); break;
                }
                txtOutput.Text = codeOutput;
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
