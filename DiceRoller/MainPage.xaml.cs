namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public virtual int Next (int minValue, int maxValue)
        {
            return 0;
        }

        private void DiceRoller(object sender, EventArgs e)
        {
            
        }

    }
}
