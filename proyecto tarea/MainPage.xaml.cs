//namespace proyecto_tarea
//{
//    public partial class MainPage : ContentPage
//    {
//        int frases1 = 0;

//        public MainPage()
//        {
//            InitializeComponent();
//        }

//        private void OnCounterClicked(object sender, EventArgs e)
//        {
//            //count++;
//            string[] frases = { "fuerza", "animo", "tu puedes" };

//            if (frases1 == 1)
//                CounterBtn.Text = $"Clicked {frases} time";
//            else
//                CounterBtn.Text = $"Clicked {frases} times";

//            SemanticScreenReader.Announce(CounterBtn.Text);
//        }
//    }

//}
namespace proyecto_tarea
{
    public partial class MainPage : ContentPage
    {
        int frases1 = 0;
        string[] frases = {
            "tu puedes","vamos","feliz dia"
        };

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            frases1++;
            if (frases1 == frases.Length) frases1 = 0;
            
             CounterBtn.Text = $" {frases[frases1]} ";
                  

         SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}