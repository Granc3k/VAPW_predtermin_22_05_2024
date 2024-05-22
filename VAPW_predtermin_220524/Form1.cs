using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;


namespace VAPW_predtermin_220524
{
    public partial class Form1 : Form
    {
        private List<Player> players = new List<Player>();
        private List<Player_Form> active_players = new List<Player_Form>();
        private Timer timer1;
        private Timer timer2;
        private Timer timer3;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeTimers();
        }

        private void InitializeTimers()
        {
            //nastavení defaultních intervalů
            timer1 = new Timer { Interval = 500 };
            timer2 = new Timer { Interval = 500 };
            timer3 = new Timer { Interval = 500 };

            //Nastavení, co se má dělat na tick
            timer1.Tick += (s, e) => number1.Text = random.Next(1, 4).ToString();
            timer2.Tick += (s, e) => number2.Text = random.Next(1, 4).ToString();
            timer3.Tick += (s, e) => number3.Text = random.Next(1, 4).ToString();

            //nastavení min a max pro intervaly + setnutí defaultní hodnoty do boxu
            period_number1.Minimum = 100;
            period_number1.Maximum = 2000;
            period_number1.Value = 500;

            period_number2.Minimum = 100;
            period_number2.Maximum = 2000;
            period_number2.Value = 500;

            period_number3.Minimum = 100;
            period_number3.Maximum = 2000;
            period_number3.Value = 500;

            //Nastavení min a max počtu hráčů pro jedno přidání
            num_of_players.Minimum = 1;
            num_of_players.Maximum = 4;
            num_of_players.Value = 1;

            //Startnutí timerů
            timer1.Start();
            timer2.Start();
            timer3.Start();
            
            //Přiřazení intervalů do výběrových boxů
            period_number1.Value = timer1.Interval;
            period_number2.Value = timer2.Interval;
            period_number3.Value = timer3.Interval;

            //přenastavení periody
            period_number1.ValueChanged += (sender, e) => timer1.Interval = (int)period_number1.Value;
            period_number2.ValueChanged += (sender, e) => timer2.Interval = (int)period_number2.Value;
            period_number3.ValueChanged += (sender, e) => timer3.Interval = (int)period_number3.Value;

            btn_start.Click += Btn_start_Click;
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            //zavření aktuálních otevřených formů s hráči
            foreach (Player_Form p in active_players)
            {
                players.Remove(p.player);
                p.Close();
            }

            //vytvoření hry - přidání hráčů do listu a následné propsání do výsledkové tabulky
            int numberOfPlayers = (int)num_of_players.Value;
            for (int i = 0; i < numberOfPlayers; i++)
            {
                var player = new Player { Name = $"Player {i + 1}" };
                players.Add(player);

                var playerForm = new Player_Form(player, this);
                active_players.Add(playerForm);
                playerForm.StartPosition = FormStartPosition.Manual;
                playerForm.Left = 100+(i*400);
                playerForm.Top = 500;
                playerForm.Show();
            }

            UpdatePlayerList();
        }

        public void UpdatePlayerList()
        {
            //updatnutí listu s výsledky

            players = players.OrderByDescending(p => p.Score).ToList();

            list_of_players.Items.Clear();
            foreach (var player in players)
            {
                list_of_players.Items.Add($"{player.Name}: {player.Score}");
            }
        }

        //getry pro Player_Form
        public string GetNumber1() => number1.Text;

        public string GetNumber2() => number2.Text;

        public string GetNumber3() => number3.Text;

        //check stejných čísel
        public bool CheckIfAllNumbersMatch() => number1.Text == number2.Text && number2.Text == number3.Text;


        //update jména hráče z playe_form do výsledků
        public void UpdatePlayerName(Player _player, string newName)
        {
            _player.Name = newName;
            UpdatePlayerList();
        }

        //update score hráče ve výsledcích
        public void UpdatePlayerScore(Player _player, int scoreChange)
        {
            _player.Score += scoreChange;
            UpdatePlayerList();
        }

        //odebrání hráče z výsledkové tabulky
        public void RemovePlayer(Player _player)
        {
            players.Remove(_player);
            UpdatePlayerList();
        }
    }


    //třída pro data handle
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
