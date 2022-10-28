using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLesson3
{
    public partial class Form2 : Form
    {
        public string PubText // публичное свойство для приёма данных от родительской формы 
        {
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
    }
}
