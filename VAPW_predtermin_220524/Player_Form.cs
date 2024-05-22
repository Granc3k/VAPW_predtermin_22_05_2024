using System;
using System.Windows.Forms;

namespace VAPW_predtermin_220524
{
    public partial class Player_Form : Form
    {
        public Player player;
        private Form1 mainForm;

        public Player_Form(Player player, Form1 mainForm)
        {
            InitializeComponent();
            this.player = player;
            this.mainForm = mainForm;

            textBox1.Text = player.Name;
            textBox1.TextChanged += TextBox1_TextChanged;

            btn_stop.Click += Btn_stop_Click;
            btn_close.Click += Btn_close_Click;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //po změně jména se propíše do výsledků
            mainForm.UpdatePlayerName(player, textBox1.Text);
        }

        private void Btn_stop_Click(object sender, EventArgs e)
        {
            //získává čísla z hlavního formuláře a následně je promítá do patřičného Player_formu
            //Následně se v seznamu přičítá/odčítá bod danému hráči
            string number1 = mainForm.GetNumber1();
            string number2 = mainForm.GetNumber2();
            string number3 = mainForm.GetNumber3();

            num_on_stop.Text = $"{number1} {number2} {number3}";

            if (mainForm.CheckIfAllNumbersMatch())
            {
                mainForm.UpdatePlayerScore(player, 1);
            }
            else
            {
                mainForm.UpdatePlayerScore(player, -1);
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            //zavření formuláře a zároveň odebrání hráče z tabulky
            mainForm.RemovePlayer(player);
            Close();
        }
    }
}
