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

        int? height, width, length;

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
                        if (tabControl1.SelectedIndex == 0)
                        {
                            label11.Text = "Нет комманды";
                        }
                        else if (tabControl1.SelectedIndex == 1)
                        {
                            label21.Text = "Нет комманды";
                            //Class1 start = new Class1(label24, label21, label22);
                        }
                        else
                        {
                            if(label34.Text != "")
                            {
                                height = Convert.ToInt32(label34.Text);
                                label33.Text = "Высота: " + label34.Text;
                                label34.Text = "";
                            }
                            //Class1 start = new Class1(label24, label21, label22);
                        }
                        //Class1 start = new Class1(errorLabel, printLabel);
                        break;
                    }
                case "Done":
                    {
                        if (tabControl1.SelectedIndex == 0)
                        {
                            Class1 start = new Class1(label14, label11, label12);
                        }
                        else if (tabControl1.SelectedIndex == 1)
                        {
                            if(label24.Text.Length > 0)
                            {
                                height = Convert.ToInt32(label24.Text);
                                label33.Text = "Высота: " + height;
                                Class1 start = new Class1(label24, label21, label22, Convert.ToInt32(label24.Text));
                                label21.Text = "";
                            }
                            else
                            {
                                label21.Text = "Введите данные";
                            }
                        }
                        else
                        {
                            if (height != null && label34.Text.Length > 0)
                            {
                                label31.Text = "";
                                Class1 start = new Class1(label34, label31, label32, height ?? 0, Convert.ToInt32(label34.Text));
                            }
                            else
                            {
                                label31.Text = "Вы ввели не все данные";
                            }
                            
                        }
                        
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

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void done_Click_1(object sender, EventArgs e)
        {
            clickCnopochka(done);
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void enter_Click_1(object sender, EventArgs e)
        {
            clickCnopochka(enter);
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    }