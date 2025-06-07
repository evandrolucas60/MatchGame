using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MatchGame
{
    using System.Windows.Threading;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int tentsOfSecondsElapsed;
        int matchesFound;

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;

            SetUpGame();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            tentsOfSecondsElapsed++;
            timeTextBlock.Text = (tentsOfSecondsElapsed / 10F).ToString("0.0s");
            if(matchesFound == 8)
            {
                timer.Stop();
                timeTextBlock.Text += " - Play again!";
            }
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🐙", "🐙",
                "🦆", "🦆",
                "🦁", "🦁",
                "🐘", "🐘",
                "🐪", "🐪",
                "🦒", "🦒",
                "🐒", "🐒",
                "🐸", "🐸",
            };

            Random random = new Random();

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "timeTextBlock")
                {
                    int index = random.Next(animalEmoji.Count);
                    string nextEmoji = animalEmoji[index];
                    textBlock.Text = nextEmoji;
                    animalEmoji.RemoveAt(index);
                }
            }
            timer.Start();
            tentsOfSecondsElapsed = 0;
            matchesFound = 0;
        }

        TextBlock? lastClickedTextBlock = null;
        bool findingMatch = false;

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = (TextBlock)sender;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastClickedTextBlock = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lastClickedTextBlock.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastClickedTextBlock.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void timeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (matchesFound == 8)
            {
                SetUpGame();
            }
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "timeTextBlock")
                {
                    textBlock.Visibility = Visibility.Visible;
                }
            }
        }
    }
}