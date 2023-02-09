
namespace Seb7a
{
    public partial class Form1 : Form
    {
        #region Variables
        int Tasbe7 = 0;
        int Takber = 0;
        int El7amed = 0;
        int Allah = 0;
        int DoubleTasbe7 = 0;
        int ALL = 0;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tasbe7 += 1;
            lblTasbe7.Text=Convert.ToString(Tasbe7);
            /*if (Tasbe7 == )
            {
                Tasbe7= 0;
                lblTasbe7.Text = Convert.ToString(Tasbe7);

            }*/
            ALL += 1;
            lblAll.Text = Convert.ToString(ALL);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Takber+= 1;
            lblTakber.Text = Convert.ToString(Takber);
            /*if (Takber == 33)
            {
                Takber = 0;
                lblTakber.Text = Convert.ToString(Takber);

            }*/
            ALL += 1;
            lblAll.Text = Convert.ToString(ALL);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            El7amed+= 1;
            lblEl7amed.Text = Convert.ToString(El7amed);
            /*if (El7amed == 33)
            {
                El7amed = 0;
                lblEl7amed.Text = Convert.ToString(El7amed);

            }*/
            ALL += 1;
            lblAll.Text = Convert.ToString(ALL);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Allah+= 1;
            lblAllah.Text = Convert.ToString(Allah);
            /*if (Allah == 33)
            {
                Allah = 0;
                lblAllah.Text = Convert.ToString(Allah);

            }*/
            ALL += 1;
            lblAll.Text = Convert.ToString(ALL);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DoubleTasbe7+= 1;
            lblDobleTasbe7.Text = Convert.ToString(DoubleTasbe7);
            /*if (DoubleTasbe7 == 33)
            {
                DoubleTasbe7 = 0;
                lblDobleTasbe7.Text = Convert.ToString(DoubleTasbe7);

            }*/
            ALL += 1;
            lblAll.Text = Convert.ToString(ALL);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tasbe7 = 0;
            lblTasbe7.Text = Convert.ToString(Tasbe7);

            Takber = 0;
            lblTakber.Text = Convert.ToString(Takber);

            El7amed = 0;
            lblEl7amed.Text = Convert.ToString(El7amed);

            Allah = 0;
            lblAllah.Text = Convert.ToString(Allah);

            DoubleTasbe7 = 0;
            lblDobleTasbe7.Text = Convert.ToString(DoubleTasbe7);

            
            MessageBox.Show($" „ Õ–› { lblAll.Text }  ”»ÌÕ…", " „  ‰›Ì– ÿ·»ﬂ »‰Ã«Õ");

            ALL = 0;
            lblAll.Text = Convert.ToString(ALL);
        }
    }
}