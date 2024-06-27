namespace StaticPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = Speaker.Multi((int)Mult1.Value, (int)Mult2.Value);
            MessageBox.Show("Your result is " + result.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = Speaker.Divide((int)Divide1.Value, (int)Divide2.Value);
            MessageBox.Show("Your result is " + result.ToString());
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int result = Speaker.Add((int)Add1.Value, (int)Add2.Value);
            MessageBox.Show("Your result is " + result.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int result = Speaker.Sub((int)Sub1.Value, (int)Sub2.Value);
            MessageBox.Show("Your result is " + result.ToString());
        }
    }
}