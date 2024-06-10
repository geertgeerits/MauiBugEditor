namespace MauiBugEditor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            edtOcrResult.Text = "AAAAA-BBBBB CCCCC-DDDDD EEEEE-FFFFF GGGGG-HHHHH IIIII-JJJJJ KKKKK-LLLLL MMMMM-NNNNN OOOOO-PPPPP QQQQQ-RRRRR SSSSS-TTTTT UUUUU-VVVVV WWWWW-XXXXX YYYYY-ZZZZZ Welcome to .NET Multi-platform App UI";

        }
    }

}
