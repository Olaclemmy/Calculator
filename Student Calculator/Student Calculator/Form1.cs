using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private float number;
        private float result;
        private float input;
        private double inPut;
        private float answer;

        private Boolean zero_display;
        private Boolean decimal_display;
        private Boolean isComputed;
        private Boolean isEqualTo;

        private int count;
        private String current_answer;

        private void isEnable()
        {
            button1.ForeColor = Color.DarkOrange;

            button7.Show();
            button7.ForeColor = Color.DarkOrange;

            button11.Show();
            button11.ForeColor = Color.DarkOrange;

            button12.Show();
            button12.ForeColor = Color.DarkOrange;

            button50.Show();
            button50.ForeColor = Color.DarkOrange;

            button53.Show();
            button53.ForeColor = Color.DarkOrange;

            button54.Show();
            button54.ForeColor = Color.DarkOrange;

            button14.Show();
            button14.ForeColor = Color.DarkOrange;

            button21.Show();
            button21.ForeColor = Color.DarkOrange;

            button55.Show();
            button55.ForeColor = Color.DarkOrange;

            button56.Show();
            button56.ForeColor = Color.DarkOrange;

            button57.Show();
            button57.ForeColor = Color.DarkOrange;

            button58.Show();
            button58.ForeColor = Color.DarkOrange;

            button41.Hide();
            button47.Hide();
            button48.Hide();
            button49.Hide();
            button17.Hide();
            button18.Hide();

            button19.Hide();
            button20.Hide();
            button30.Hide();
            button31.Hide();
            button35.Hide();
            button36.Hide();
        }

        private void isDisabled()
        {
            button1.ForeColor = Color.Black;

            button41.Show();
            button47.Show();
            button48.Show();
            button49.Show();
            button17.Show();
            button18.Show();

            button19.Show();
            button20.Show();
            button30.Show();
            button31.Show();
            button35.Show();
            button36.Show();

        }

        private void button46_Click(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {
            //Zero (0)
            if (!zero_display && !decimal_display)
            {
                main_display.Text = null;
            }

            if (isComputed)
            {
                main_display.Clear();
            }
            main_display.Text += "0";
            zero_display = true;
            isComputed = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            //One (1)
            if (!zero_display && !decimal_display)
            {
                main_display.Text = null;
            }

            if (isComputed)
            {
                main_display.Clear();
            }
            main_display.Text += "1";
            zero_display = true;
            isComputed = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            //Two (2)
            if (!zero_display && !decimal_display)
            {
                main_display.Text = null;
            }

            if (isComputed)
            {
                main_display.Clear();
            }
            main_display.Text += "2";
            zero_display = true;
            isComputed = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            //Three (3)
            if (!zero_display && !decimal_display)
            {
                main_display.Text = null;
            }

            if (isComputed)
            {
                main_display.Clear();
            }
            main_display.Text += "3";
            zero_display = true;
            isComputed = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            //Four (4)
            if (!zero_display && !decimal_display)
            {
                main_display.Text = null;
            }

            if (isComputed)
            {
                main_display.Clear();
            }
            main_display.Text += "4";
            zero_display = true;
            isComputed = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //Five (5)
            if (!zero_display && !decimal_display)
            {
                main_display.Text = null;
            }

            if (isComputed)
            {
                main_display.Clear();
            }
            main_display.Text += "5";
            zero_display = true;
            isComputed = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //Six (6)
            if (!zero_display && !decimal_display)
            {
                main_display.Text = null;
            }

            if (isComputed)
            {
                main_display.Clear();
            }
            main_display.Text += "6";
            zero_display = true;
            isComputed = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //Seven (7)
            if (!zero_display && !decimal_display)
            {
                main_display.Text = null;
            }

            if (isComputed)
            {
                main_display.Clear();
            }
            main_display.Text += "7";
            zero_display = true;
            isComputed = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //Eight (8)
            if (!zero_display && !decimal_display)
            {
                main_display.Text = null;
            }

            if (isComputed)
            {
                main_display.Clear();
            }
            main_display.Text += "8";
            zero_display = true;
            isComputed = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //Nine (9)
            if (!zero_display && !decimal_display)
            {
                main_display.Text = null;
            }
            if (isComputed)
            {
                main_display.Clear();
            }
            main_display.Text += "9";
            zero_display = true;
            isComputed = false;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            //Dot (.)
            if (!decimal_display)
            {
                if (!main_display.Text.Contains("."))
                {
                    main_display.Text += ".";
                }
               
            }
            zero_display = true;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            //Plus/Miuns ()
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //Multiplcation (x)
            number = float.Parse(main_display.Text);
            main_display.Clear();
            main_display.Focus();
            count = 1;
            sub_display.Text = number.ToString() + " x ";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            //Addition (+)
            number = float.Parse(main_display.Text);
            main_display.Clear();
            main_display.Focus();
            count = 2;
            sub_display.Text = number.ToString() + " + ";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //Division (÷)
            number = float.Parse(main_display.Text);
            main_display.Clear();
            main_display.Focus();
            count = 3;
            sub_display.Text = number.ToString() + " ÷ ";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //Substraction (-)
            number = float.Parse(main_display.Text);
            main_display.Clear();
            main_display.Focus();
            count = 4;
            sub_display.Text = number.ToString() + " - ";
        }

        private void compute()
        {
            switch (count)
            {
                case 1:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    input = float.Parse(main_display.Text);
                    result = number * input;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = number.ToString() + " x " + input.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 2:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    input = float.Parse(main_display.Text);
                    result = number + input;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = number.ToString() + " + " + input.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 3:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    input = float.Parse(main_display.Text);
                    result = number / input;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = number.ToString() + " ÷ " + input.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 4:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    input = float.Parse(main_display.Text);
                    result = number - input;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = number.ToString() + " - " + input.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 5:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    input = float.Parse(main_display.Text);
                    inPut = Math.Sin((Double)input);
                    result = (float)inPut;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = "sin " + input.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 6:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    input = float.Parse(main_display.Text);
                    inPut = Math.Cos((Double)input);
                    result = (float)inPut;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = "cos " + input.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 7:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    input = float.Parse(main_display.Text);
                    inPut = Math.Tan((Double)input);
                    result = (float)inPut;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = "tan " + input.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 8:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    input = float.Parse(main_display.Text);
                    inPut = Math.Sinh((Double)input);
                    result = (float)inPut;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = "sin-¹ " + input.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 9:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    input = float.Parse(main_display.Text);
                    inPut = Math.Cosh((Double)input);
                    result = (float)inPut;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = "cos-¹ " + input.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 10:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    input = float.Parse(main_display.Text);
                    inPut = Math.Tanh((Double)input);
                    result = (float)inPut;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = "tan-¹ " + input.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 11:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    input = float.Parse(main_display.Text);
                    inPut = Math.Pow(10,(Double)input);
                    result = (float)inPut;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = "10^" + input.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 12:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    input = float.Parse(main_display.Text);
                    inPut = Math.Pow(Math.E, (Double)input);
                    result = (float)inPut;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = "ℓ^" + input.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 13:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    input = float.Parse(main_display.Text);
                    inPut = Math.Log((Double)input);
                    result = (float)inPut;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = "In " + input.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 14:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    input = float.Parse(main_display.Text);
                    inPut = Math.Log10((Double)input);
                    result = (float)inPut;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = "log " + input.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 15:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    inPut = Math.Sqrt((Double)number);
                    result = (float)inPut;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = "√" + number.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 16:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    inPut = Math.Sqrt((Double)number);
                    result = (float)inPut;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = "√" + input.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 17:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    answer = result / 100;
                    main_display.Text = answer.ToString();
                    sub_display.Text = number.ToString() + " x " + input.ToString() + "%" + "=";
                    current_answer = main_display.Text;
                    break;

                case 18:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    input = float.Parse(main_display.Text);
                    inPut = Math.Pow((Double)number, (Double)input);
                    result = (float)inPut;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = number.ToString() + "^" + input.ToString() + "=";
                    current_answer = main_display.Text;
                    break;

                case 19:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    result = number * number;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = number.ToString() + "²" + "=";
                    current_answer = main_display.Text;
                    break;

                case 20:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    result = number * number * number;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = number.ToString() + "³" + "=";
                    current_answer = main_display.Text;
                    break;

                case 21:
                    if (isComputed)
                    {
                        main_display.Text = main_display.Text;
                        main_display.Focus();
                        main_display.Text = main_display.Text;
                        return;
                    }
                    result = 1 / number;
                    answer = result;
                    main_display.Text = answer.ToString();
                    sub_display.Text = number.ToString() + "-¹" + "=";
                    current_answer = main_display.Text;
                    break;

                default:
                    main_display.Focus();
                    main_display.Text = main_display.Text;
                    break;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //Reset (CE)
            main_display.Text = "0";
            sub_display.Text = null;
            zero_display = false;
            decimal_display = false;
            number = 0;
            result = 0;
            input = 0;
            answer = 0;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //Clear (C)
            main_display.Text = "0";
            zero_display = false;
            decimal_display = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Delete (DEL)
            String backspace = null;
            if(main_display.Text.Length > 0)
            {
                StringBuilder sBuilder = new StringBuilder(main_display.Text);
                sBuilder.Remove(main_display.Text.Length - 1, 1);
                backspace = sBuilder.ToString();
                main_display.Text = backspace.ToString();
            }

            if(main_display.Text == "")
            {
                main_display.Text = "0";
            }
            zero_display = false;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            //Equal (=)
            try
            {
                compute();
                isComputed = true;
            }
            catch (Exception exc)
            {
                main_display.Text = "Error!";
                sub_display.Text = exc.Message;

            }
            isComputed = true;
        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            //x²
            number = float.Parse(main_display.Text);
            main_display.Clear();
            main_display.Focus();
            count = 19;
            main_display.Text = "0";
            sub_display.Text = number.ToString() + "²";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //x³
            number = float.Parse(main_display.Text);
            main_display.Clear();
            main_display.Focus();
            count = 20;
            main_display.Text = "0";
            sub_display.Text = number.ToString() + "³";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //x-¹ 
            number = float.Parse(main_display.Text);
            main_display.Clear();
            main_display.Focus();
            count = 21;
            main_display.Text = "0";
            sub_display.Text = number.ToString()+ "-¹";
            isDisabled();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //yx
            number = float.Parse(main_display.Text);
            main_display.Clear();
            main_display.Focus();
            count = 18;
            sub_display.Text = number.ToString() + "^";
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //√
            number = float.Parse(main_display.Text);
            main_display.Clear();
            main_display.Focus();
            count = 15;
            main_display.Text = "0";
            sub_display.Text = "√" + number.ToString() ;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //³√
            number = float.Parse(main_display.Text);
            main_display.Clear();
            main_display.Focus();
            count = 16;
            sub_display.Text = "³√" + number.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //% ;
            input = float.Parse(main_display.Text);
            main_display.Clear();
            main_display.Focus();
            result = number * input;
            count = 17;
            main_display.Text = "0";
            sub_display.Text = number.ToString() + " x " + input.ToString() + "%";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //π
            inPut = Math.PI;
            answer = (float)inPut;
            main_display.Text = answer.ToString();
            sub_display.Text = "PI"; //"π";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //MS

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //MC
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //MR
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Right arrow (-->)
            if(main_display.Text == null)
            {
                main_display.SelectionStart = main_display.Text.Length;
                main_display.SelectionLength = main_display.Text.Length - 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //2ndF
            isEnable();
        }

       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {
            //Sin
            count = 5;
            sub_display.Text = "sin";
        }

        private void button48_Click(object sender, EventArgs e)
        {
            //Cos
            count = 6;
            sub_display.Text = "cos";
        }

        private void button47_Click(object sender, EventArgs e)
        {
            //tan
            count = 7;
            sub_display.Text = "tan";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Sinh (sin-¹)
            count = 8;
            sub_display.Text = "sin-¹";
            isDisabled();
        }


        private void button11_Click(object sender, EventArgs e)
        {
            //Cosh (cos-¹)
            count = 9;
            sub_display.Text = "cos-¹";
            isDisabled();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Tanh (tan-¹)
            count = 10;
            sub_display.Text = "tan-¹";
            isDisabled();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            //Answer 
            main_display.Text = current_answer;
            sub_display.Text = "Ans =" + current_answer;
            isDisabled();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            //10ᵡ
            count = 11;
            sub_display.Text = "10^";
            isDisabled();

        }

        private void button53_Click(object sender, EventArgs e)
        {
            //ℓᵡ
            count = 12;
            sub_display.Text = "ℓ^";
            isDisabled();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //In
            count = 13;
            sub_display.Text = "In";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Log
            count = 14;
            sub_display.Text = "log";
        }

        private void button55_Click(object sender, EventArgs e)
        {
            //HEX
            isDisabled();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            //BIN
            isDisabled();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            //DEC
            isDisabled();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            //OCT
            isDisabled();
        }
    }
}
