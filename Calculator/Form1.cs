using System.Collections.Generic;
using first;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Class1 class1;


        

        int? first, second;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void clickCnopochka(Button obj)
        {
            Label errorLabel;
            Label messageLabel;
            Label lastLabel;
            Label currentLabel;
            if(tabControl1.SelectedIndex == 0)
            {
                currentLabel = label14;
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                currentLabel = label24;
            }
            else
            {
                currentLabel = label34;
            }
                
            switch (obj.Text)
            {
                case "<-":
                    {
                        if(currentLabel.Text.Length > 0)
                        {
                            currentLabel.Text = currentLabel.Text.Remove(currentLabel.Text.Length - 1);
                        }
                        
                        break;
                    }
                
                case "Enter":
                    {
                        currentLabel.Text = "Ну да и что";
                        //Class1 start = new Class1(errorLabel, printLabel);
                        break;
                    }
                case "Done":
                    {
                        currentLabel.Text = "Дан";
                        break;
                    }
                case ",":
                    {
                        if (!currentLabel.Text.Contains(','))
                            currentLabel.Text += ',';
                        break;
                    }
                default:
                    {
                        currentLabel.Text += obj.Text;
                        break;
                    }
            }
            
        }

        

        private void delete_Click(object sender, EventArgs e)
        {
            clickCnopochka(delete);
        }

        private void dot_Click(object sender, EventArgs e)
        {
            clickCnopochka(dot);
        }

        private void enter_Click(object sender, EventArgs e)
        {
            clickCnopochka(enter);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    
        private void done_Click(object sender, EventArgs e)
        {
            clickCnopochka(done);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            clickCnopochka(button0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            clickCnopochka(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickCnopochka(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickCnopochka(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clickCnopochka(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clickCnopochka(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clickCnopochka(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clickCnopochka(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clickCnopochka(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clickCnopochka(button9);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    }