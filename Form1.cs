namespace Postfix_Express
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void process(string fix)
        {
           Stack newStack = new Stack(); 
            string[] postFix = fix.Split(' ');
            int result = 0;
            int num1 = 0;
            int num2 = 0;

            foreach (string token in postFix)
            {
                if (token == "+")
                {
                    num1 = int.Parse(newStack.Pop().ToString());
                    num2 = int.Parse(newStack.Pop().ToString());
                    result = num1 + num2;

                    newStack.Push(result);
                    listBox1.Items.Add("After + operation: " + result);
                    listBox1.Items.Add("After push operation: " + newStack.ToString());
                }
                else if (token == "-")
                {
                    num1 = int.Parse(newStack.Pop().ToString());
                    num2 = int.Parse(newStack.Pop().ToString());
                    result = num1 - num2;

                    newStack.Push(result);
                    listBox1.Items.Add("After - operation: " + result);
                    listBox1.Items.Add("After push operation: " + newStack.ToString());
                }
                else if (token == "/")
                {
                    num1 = int.Parse(newStack.Pop().ToString());
                    num2 = int.Parse(newStack.Pop().ToString());
                    result = num1 / num2;

                    newStack.Push(result);
                    listBox1.Items.Add("After / operation: " + result);
                    listBox1.Items.Add("After push operation: " + newStack.ToString());
                }
                else if (token == "*")
                {
                    num1 = int.Parse(newStack.Pop().ToString());
                    num2 = int.Parse(newStack.Pop().ToString());
                    result = num1 * num2;

                    newStack.Push(result);
                    listBox1.Items.Add("After * operation: " + result);
                    listBox1.Items.Add("After push operation: " + newStack.ToString());
                }
                else
                {
                    newStack.Push(token);
                    listBox1.Items.Add("After push operation: " + newStack.ToString());
                }

            }

            textBox2.Text = newStack.Peek().ToString();

        }
      
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor= Color.Red;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Gray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fix = textBox1.Text; //Set variable to save textbox info to string

            if (textBox1.Text.Length == 0) //If Postfix expressinis empty result will notify user and crash the program
            {
                textBox2.Text = "Postfix Expression is empty.";
            }//End if
            else
            {   
                process(fix); //Send Postfix Expression to process function
            }//End else
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gray;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Gray;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
        }
      
    }//End Class

}//End NameSpace