namespace Lab2
{
    public partial class Form1 : Form
    {
        int brojSekundi;
        public Form1()
        {
            InitializeComponent();
            textBoxrad.Text = "25";
            textBoxodmor.Text = "5";
            brojSekundi = int.Parse(textBoxrad.Text) * 60;
            labelrad.ForeColor = Color.Red;
            

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (brojSekundi >= 0)
            {
                int minute = brojSekundi / 60;
                int sekunde = brojSekundi % 60;
                label3.Text = brojSekundi.ToString("D2") + ":" + minute.ToString("D2");
                brojSekundi--;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
