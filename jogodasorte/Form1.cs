using System;

namespace jogodasorte
{

    public partial class Form1 : Form
    {
        Random random = new Random();
        int aleatorio;
        int palpites = 0;
        public Form1()
        {
            InitializeComponent();

            iniciar();



        }

        private void iniciar()
        {
            aleatorio = random.Next(1, 10);
            palpites = 0;

            testar.Text = "";
            sorte.Text = "";
            total.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {




            int tent;
            if (int.TryParse(testar.Text, out tent))

            {/*
                Random random = new Random();
                int aleatorio = random.Next(1, 10);
                int palpites = 0;
                */



                //ir acrescentar o total de tentativas
                palpites++;


                if (tent == aleatorio)
                {

                    MessageBox.Show("Parabens tu acertaste", "Jogo da sorte", MessageBoxButtons.OK);


                    sorte.Text = aleatorio.ToString();

                    total.Text = palpites.ToString();

                    MessageBox.Show("Fim do Jogo", "Jogo da sorte", MessageBoxButtons.OK);

                    iniciar();


                }

                else
                {
                    MessageBox.Show("Tu Erraste,tenta novamente", "Jogo da sorte", MessageBoxButtons.OK);
                }





            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}












   