using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Crestiki
{
   
    public partial class GUI : Window
    {
        string player = "X";
       

        public GUI()
        {
            InitializeComponent();
            enabledfalse();
            
        }
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
           
            Button b = (Button)sender;
            if (player == "X")
            {
                b.Content = "X";
                b.IsEnabled = false;
            }
            if (b1.Content != null && b2.Content != null && b3.Content != null && b4.Content != null && b5.Content != null && b6.Content != null && b7.Content != null && b8.Content != null && b9.Content != null)
            {
                checkwin();
            }
            else
            {
                comp();
            }
            checkwin();
        }

        private void checkwin()
        {
            bool pob = false;
            if (b1.Content == "X" && b2.Content == "X" && b3.Content == "X")
            {
                sost.Content = "Winner  X";
                Start.IsEnabled = false;
                enabledfalse();

                pob = true;
            }
            if (b4.Content == "X" && b5.Content == "X" && b6.Content == "X")
            {
                sost.Content = "Winner  X";
                Start.IsEnabled = false;
                enabledfalse();
                pob = true;
            }
            if (b7.Content == "X" && b8.Content == "X" && b9.Content == "X")
            {
                sost.Content="Winner  X";
                Start.IsEnabled = false;
                enabledfalse();
                pob = true;
            }
            if (b1.Content == "X" && b4.Content == "X" && b7.Content == "X")
            {
                sost.Content = "Winner  X";
                Start.IsEnabled = false;
                enabledfalse();
                pob = true;
            }
            if (b2.Content == "X" && b5.Content == "X" && b8.Content == "X")
            {
                sost.Content="Winner  X";
                Start.IsEnabled = false;
                enabledfalse();
                pob = true;
            }
            if (b3.Content == "X" && b6.Content == "X" && b9.Content == "X")
            {
                sost.Content = "Winner  X";
                Start.IsEnabled = false;
                enabledfalse();
                pob = true;
            }
            if (b1.Content == "X" && b5.Content == "X" && b9.Content == "X")
            {
                sost.Content = "Winner  X";
                Start.IsEnabled = false;
                enabledfalse();
                pob = true;
            }
            if (b3.Content == "X" && b5.Content == "X" && b7.Content == "X")
            {
                sost.Content = "Winner  X";
                Start.IsEnabled = false;
                enabledfalse();
                pob = true;
            }

            if (b1.Content == "O" && b2.Content == "O" && b3.Content == "O")
            {
                sost.Content="Winner  O";
                Start.IsEnabled = false;
                enabledfalse();
                pob = true;
            }
            if (b4.Content == "O" && b5.Content == "O" && b6.Content == "O")
            {
                sost.Content=$"Winner  O";
                Start.IsEnabled = false;
                enabledfalse();
                pob = true;
            }
            if (b7.Content == "O" && b8.Content == "O" && b9.Content == "O")
            {
                sost.Content=$"Winner  O";
                Start.IsEnabled = false;
                enabledfalse();
                pob = true;
            }
            if (b1.Content == "O" && b4.Content == "O" && b7.Content == "O")
            {
                sost.Content=$"Winner  O";
                Start.IsEnabled = false;
                enabledfalse();
                pob = true;
            }
            if (b2.Content == "O" && b5.Content == "O" && b8.Content == "O")
            {
                sost.Content=$"Winner  O";
                Start.IsEnabled = false;
                enabledfalse();
                pob = true;
            }
            if (b3.Content == "O" && b6.Content == "O" && b9.Content == "O")
            {
                sost.Content=$"Winner  O";
                Start.IsEnabled = false;
                enabledfalse();
                pob = true;
            }
            if (b1.Content == "O" && b5.Content == "O" && b9.Content == "O")
            {
                sost.Content=$"Winner  O";
                Start.IsEnabled = false;
                enabledfalse();
                pob = true;
            }
            if (b3.Content == "O" && b5.Content == "O" && b7.Content == "O")
            {
                sost.Content=$"Winner  O";
                Start.IsEnabled = false;
                enabledfalse();
                pob = true;
            }
            if (pob == false && b1.Content != null && b2.Content != null && b3.Content != null && b4.Content != null && b5.Content != null && b6.Content != null && b7.Content != null && b8.Content != null && b9.Content != null)
            {

                sost.Content="Game over. Push buttons";
                Start.IsEnabled = false;
                enabledfalse();
            }
        }

        public void comp() 
        {
            Button[] nol = new Button[9];  
            nol[0] = b1;
            nol[1] = b2;
            nol[2] = b3;
            nol[3] = b4;
            nol[4] = b5;
            nol[5] = b6;
            nol[6] = b7;
            nol[7] = b8;
            nol[8] = b9;
            bool ok = false;
            do
            {
                Random rand = new Random();
                int randed = rand.Next(0, 9);
                if (nol[randed].Content == null && nol[randed].IsEnabled) //если какое то место от 0 до 9 пусто, то туда мы пишем свой нолик
                {
                    nol[randed].Content = "O";
                    nol[randed].IsEnabled = false;
                    ok = true;
                }
            }
            while (ok == false);
        }

        private void restart_Click(object sender, RoutedEventArgs e) // сброс
        {
            b1.Content = null; b1.IsEnabled = false;
            b2.Content = null; b2.IsEnabled = false;
            b3.Content = null; b3.IsEnabled = false;
            b4.Content = null; b4.IsEnabled = false;
            b5.Content = null; b5.IsEnabled = false;
            b6.Content = null; b6.IsEnabled = false;
            b7.Content = null; b7.IsEnabled = false;
            b8.Content = null; b8.IsEnabled = false;
            b9.Content = null; b9.IsEnabled = false;
            Start.IsEnabled = true;
            sost.Content = "";

        }

        private void Start_Click(object sender, RoutedEventArgs e) //выход, закрытие окна
        {
           
            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = true;
            b5.IsEnabled = true;
            b6.IsEnabled = true;
            b7.IsEnabled = true;
            b8.IsEnabled = true;
            b9.IsEnabled = true;
           
            Start.IsEnabled = false;
        }

        private void enabledfalse()
        {
           
            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b3.IsEnabled = false;
            b4.IsEnabled = false;
            b5.IsEnabled = false;
            b6.IsEnabled = false;
            b7.IsEnabled = false;
            b8.IsEnabled = false;
            b9.IsEnabled = false;
            
        }
    }
}


