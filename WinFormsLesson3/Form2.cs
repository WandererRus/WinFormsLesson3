using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsLesson3
{
    public partial class Form2 : Form
    {
        public string PubText // публичное свойство для приёма/отдачи данных от/в родительской формы 
        {
            get 
            {
                return textBox1.Text;
            }
            set 
            {
                lb_outText.Text = value;
            }
        }
        public Form2(string s) // конструктор с переменной типа строка для получения данных от родительской формы
        {
            InitializeComponent();
            this.Text = s; // назначение заголовка формы из переменной конструктора
        }
        public DialogResult ShowDialog(string s)
        {
            lb_DRText.Text = s;  //создал лейбл с именем lb_DRText и поместил в него данные из перегрузки ShowDialog
            return ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
