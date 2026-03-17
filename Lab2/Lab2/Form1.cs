namespace Lab2
{
    public partial class Form1 : Form
    {
        int brojSekundi;
        private bool rad;
        private Pomodoro pomodoro;
        public Form1()
        {
            InitializeComponent();
            pomodoro = new Pomodoro();
            textBoxrad.Text = pomodoro.WorkDuration.ToString();
            textBoxodmor.Text = pomodoro.RestDuration.ToString();
            labelrad.ForeColor = Color.Red;

            //brojSekundi = int.Parse(textBoxrad.Text) * 60;
            //labelrad.ForeColor = Color.Red;
            brojSekundi = 25 * 60;
            rad = true;
            postaviBrojNaRad;

        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pomodoro.CurrentSeconds >= 0)
            {
                labelVrijeme.text = pomodoro.ToString();
                
                //int minute = brojSekundi / 60;
                //int sekunde = brojSekundi % 60;
                //label3.Text = brojSekundi.ToString("D2") + ":" + minute.ToString("D2");
                //brojSekundi--;
            }
            else
            {
                //rad = rad ? false : true;
                pomodoro.WorkInProgress = !pomodoro.WorkInProgress;
            }
            if (!pomodoro.WorkInProgress)

            {
                pomodoro.CurrentSeconds = Pomodoro.ConvertMinutesToSeconds(pomodoro.RestDuration);
               // brojSekundi = int.Parse(textBoxrad.Text) * 60;
                labelrad.ForeColor = Color.Red;
                labelodmor.ForeColor = Color.Black;
                // rad = false;
                pomodoro.WorkInProgress = false;
            }

            else
            {
                //brojSekundi = int.Parse(textBoxrad.Text) * 60;
                pomodoro.CurrentSeconds = Pomodoro.ConvertMinutesToSeconds(pomodoro.WorkDuration);
                labelrad.ForeColor = Color.Red;
                labelodmor.ForeColor = Color.Black;
                // rad = true;
                pomodoro.WorkInProgress = true; 
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pomodoro = new Pomodoro();
            //brojSekundi = int.Parse(textBoxrad.Text) * 60;
            labelrad.ForeColor = Color.Red;
            rad = true;
            int.Parse(textBoxodmor.Text)    ;
            int.Parse(textBoxrad.Text) ;
           

        }
      /* private void postaviBrojNaRad()
        {
            brojSekundi = int.Parse(textBoxrad.Text) * 60;
            labelrad.ForeColor = Color.Red;
            rad = true; 
        }*/

        private void labelrad_Click(object sender, EventArgs e)
        {

        }

        private void textBoxrad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
