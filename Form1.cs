using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Work
{
    public partial class Student_work : Form
    {
        public Student_work()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.name = textBox1.Text;
            stud.rost = (int)numericUpDown1.Value;
            MessageBox.Show(string.Format($"Студент: {stud.name} \n Рост: {stud.rost} \n Вес: {stud.GetEat()}"));
            stud.Eat(1);
            double ed = 1.0;
            MessageBox.Show(string.Format($"Студент: {stud.name} \n Cъел: {ed} кг еды \n \n Рост: {stud.rost} \n Вес: {stud.GetEat()}"));
            stud.Eat(5);
            ed = 5.0;
            MessageBox.Show(string.Format($"Студент: {stud.name} \n Cъел: {ed} кг еды \n \n Рост: {stud.rost} \n Вес: {stud.GetEat()}"));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Tel tel = new Tel();
                tel.day = Convert.ToInt32(textBox2.Text);
                tel.t = Convert.ToDouble(textBox3.Text);
                if (tel.Day(tel.day))
                {
                    if (tel.t > 0)
                    {
                        double money = tel.money();
                        tel.prices(tel.t);
                        MessageBox.Show(string.Format($"День недели: {tel.day} \n Время разговора: {tel.t} \n Стоимость минуты: {money} \n Цена за разговор: {tel.money()}"));
                    }
                    else MessageBox.Show("Введенно отрицательное значение времени!", "Сообщение", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Введен некорректный день недели", "Сообщение", MessageBoxButtons.OK);
            }
            catch { MessageBox.Show("Ошибка при вводе данных", "Сообщение", MessageBoxButtons.OK); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Two two = new Two();
            two.Tw();
        }
    }
}
