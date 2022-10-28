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
            Form2 f = new Form2("Форма без переключения"); // использование конструктора для передачи данных дочерней формы
            f.PubText = "Привет от материнской формы"; // использование свойства для передачи данных дочерней формы
            f.ShowDialog(); //ждет ответа вида DialogResult, препятствует дальнейшему выполнению кода
            f.Close(); //разрушение объекта
            Form2 f2 = new Form2("Форма с переключением");
            f2.Show(); // не препятствует дальнейшейму выполнению когда
            f2.Close();
        }
    }
}