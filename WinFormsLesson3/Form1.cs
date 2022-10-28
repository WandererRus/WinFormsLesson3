namespace WinFormsLesson3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2("Форма без переключения");
            f.PubText = "Привет от материнской формы";
            f.ShowDialog();
            f.Close();
            Form2 f2 = new Form2("Форма с переключением");
            f2.Show();
            f2.Close();
        }
    }
}