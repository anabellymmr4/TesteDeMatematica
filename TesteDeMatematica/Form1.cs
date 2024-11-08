using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace TesteDeMatematica
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int adi��o1;
        int adi��o2;

        int minuendo;
        int subtra��o;

        int multiplicando;
        int multiplicador;

        int dividendo;
        int divisor;

        int temporestante;

        public Form1()
        {
            InitializeComponent();
        }

        public void StartTheQuiz()
        {
            adi��o1 = randomizer.Next(51);
            adi��o2 = randomizer.Next(51);
            EsquerdaLbl.Text = adi��o1.ToString();
            DireitaLbl.Text = adi��o2.ToString();
            Soma.Value = 0;


            minuendo = randomizer.Next(1, 101);
            subtra��o = randomizer.Next(1, minuendo);
            MenosEsquerdaLbl.Text = minuendo.ToString();
            MenosDireitaLbl.Text = subtra��o.ToString();
            Diferenca.Value = 0;


            multiplicando = randomizer.Next(2, 11);
            multiplicador = randomizer.Next(2, 11);
            VezesDireitaLbl.Text = multiplicando.ToString();
            VezesEsquerdaLbl.Text = multiplicando.ToString();
            Produto.Value = 0;


            divisor = randomizer.Next(2, 11);
            int quocientetemporario = randomizer.Next(2, 11);
            dividendo = divisor * quocientetemporario;
            DivisaoEsquerdaLbl.Text = dividendo.ToString();
            DivisaoDireitaLbl.Text = (dividendo.ToString());
            Quonsciente.Value = 0;


            temporestante = 30;
            TimeLbl.Text = " 30 segundos ";
            timer1.Start();
        }


        private bool CheckTheAnswer()
        {
            if ((adi��o1 + adi��o2 == Soma.Value)
                && (minuendo - subtra��o == Diferenca.Value)
                && (multiplicando * multiplicador == Produto.Value)
                && (divisor / divisor == Quonsciente.Value))
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {

                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                StartBtn.Enabled = true;
            }
            else if (temporestante > 0)
            {

                temporestante = temporestante - 1;
                TimeLbl.Text = temporestante + " seconds";
            }
            else
            {

                timer1.Stop();
                TimeLbl.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                Soma.Value = adi��o1 + adi��o2;
                Diferenca.Value = minuendo - subtra��o;
                Produto.Value = multiplicando * multiplicador;
                Quonsciente.Value = dividendo / divisor;
                StartBtn.Enabled = true;
            }
        }









        private void Diferenca_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {


            StartTheQuiz();
            StartBtn.Enabled = false;

        }
    }
}
