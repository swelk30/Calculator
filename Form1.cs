using System;
using System.Windows.Forms;

namespace TextRedactror
{
    public partial class Form1 : Form
    {
        string otvetbox = "";
        string znak = "";
        string buffer = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void reset()
        {
            richTextBox1.Text = "";
            otvetbox = "";
            label1.Text = "";
            znak = "";
            label2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                otvetbox = "1";
            }
            else
                otvetbox = otvetbox + "1";
            richTextBox1.Text = otvetbox;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                otvetbox = "2";
            }
            else
            otvetbox = otvetbox + "2";
            richTextBox1.Text = otvetbox;
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                otvetbox = "3";
            }
            else
                otvetbox = otvetbox + "3";
            richTextBox1.Text = otvetbox;

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                otvetbox = "4";
            }
            else
                otvetbox = otvetbox + "4";
            richTextBox1.Text = otvetbox;

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                otvetbox = "5";
            }
            else
                otvetbox = otvetbox + "5";
            richTextBox1.Text = otvetbox;

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                otvetbox = "6";
            }
            else
                otvetbox = otvetbox + "6";
            richTextBox1.Text = otvetbox;

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                otvetbox = "7";
            }
            else
                otvetbox = otvetbox + "7";
            richTextBox1.Text = otvetbox;

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                otvetbox = "8";
            }
            else
                otvetbox = otvetbox + "8";
            richTextBox1.Text = otvetbox;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                otvetbox = "9";
            }
            else
                otvetbox = otvetbox + "9";
            richTextBox1.Text = otvetbox;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                otvetbox = "0";
            }
            else

                otvetbox = otvetbox + "0";
            richTextBox1.Text = otvetbox;
            
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                znak = "÷";
                label1.Text = znak;
                string bufferznak = znak;
                string smallotvetboxbuffer = otvetbox;
                buffer = otvetbox;
                reset();
                znak = bufferznak;
                label1.Text = znak;
                label2.Text = smallotvetboxbuffer;
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                znak = "×";
                label1.Text = znak;
                string bufferznak = znak;
                string smallotvetboxbuffer = otvetbox;
                buffer = otvetbox;
                reset();
                znak = bufferznak;
                label1.Text = znak;
                label2.Text = smallotvetboxbuffer;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                znak = "-";
                label1.Text = znak;
                string bufferznak = znak;
                string smallotvetboxbuffer = otvetbox;
                buffer = otvetbox;
                reset();
                znak = bufferznak;
                label1.Text = znak;
                label2.Text = smallotvetboxbuffer;
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                znak = "+";
                label1.Text = znak;
                string bufferznak = znak;
                string smallotvetboxbuffer = otvetbox;
                buffer = otvetbox;
                reset();
                znak = bufferznak;
                label1.Text = znak;
                label2.Text = smallotvetboxbuffer;
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            reset();

        }

        private void Button19_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            { 
            string otvetbox1 = otvetbox.Remove (otvetbox.Length-1);
            otvetbox = otvetbox1;
            richTextBox1.Text = otvetbox;
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text != "")
            {
                otvetbox = otvetbox + ",";
                richTextBox1.Text = otvetbox;
            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                otvetbox = Convert.ToString(Math.Sin(Convert.ToDouble(otvetbox)));
                richTextBox1.Text = otvetbox;
            }
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                otvetbox = Convert.ToString(Math.Cos(Convert.ToDouble(otvetbox)));
                richTextBox1.Text = otvetbox;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                switch (znak)
                {
                    case "+":
                        buffer = Convert.ToString(Convert.ToDouble(buffer) + Convert.ToDouble(otvetbox));
                        reset();
                        richTextBox1.Text = buffer;
                        otvetbox = buffer;
                        break;
                    case "-":
                        buffer = Convert.ToString(Convert.ToDouble(buffer) - Convert.ToDouble(otvetbox));
                        reset();
                        richTextBox1.Text = buffer;
                        otvetbox = buffer;
                        break;
                    case "×":
                        buffer = Convert.ToString(Convert.ToDouble(buffer) * Convert.ToDouble(otvetbox));
                        reset();
                        richTextBox1.Text = buffer;
                        otvetbox = buffer;
                        break;
                    case "÷":
                        buffer = Convert.ToString(Convert.ToDouble(buffer) / Convert.ToDouble(otvetbox));
                        reset();
                        richTextBox1.Text = buffer;
                        otvetbox = buffer;
                        break;
                    default:
                        richTextBox1.Text = richTextBox1.Text;
                        break;
                } 
            }
            else richTextBox1.Text = richTextBox1.Text;
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                otvetbox = Convert.ToString(Math.Log(Convert.ToDouble(otvetbox)));
                richTextBox1.Text = otvetbox;
            }
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                otvetbox = Convert.ToString(Math.Tan(Convert.ToDouble(otvetbox)));
                richTextBox1.Text = otvetbox;
            }
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                otvetbox = "3,14";
                richTextBox1.Text = otvetbox;
            }
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                otvetbox = Convert.ToString((Convert.ToDouble(otvetbox))* Convert.ToDouble(otvetbox));
                richTextBox1.Text = otvetbox;
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                otvetbox = Convert.ToString((Convert.ToDouble(otvetbox)) - (Convert.ToDouble(otvetbox))*2);
                richTextBox1.Text = otvetbox;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*char symbol = e.KeyChar;
            switch (symbol)
            {
                case '1':
                    Button1_Click(button1, null);
                    break;
                case '2':
                    Button2_Click (button2, null);
                    break;
                case '3':
                    Button3_Click(button3, null);
                    break;
                case '4':
                    Button4_Click(button4, null);
                    break;
                case '5':
                    Button5_Click(button5, null);
                    break;
                case '6':
                    Button6_Click(button6, null);
                    break;
                case '7':
                    Button7_Click(button7, null);
                    break;
                case '8':
                    Button8_Click(button8, null);
                    break;
                case '9':
                    Button9_Click(button9, null);
                    break;
                case '0':
                    Button10_Click(button14, null);
                    break;
                case ',':
                    Button16_Click(button16, null);
                    break;
                case '.':
                    Button16_Click(button16, null);
                    break;
            }*/
        }
    }
}
