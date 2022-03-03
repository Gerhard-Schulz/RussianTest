using System;
using System.Drawing;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        private bool access;
        private bool bolded;
        private Font standardFont;
        private Font boldFont;
        private Color standardColor;
        private Color greenColor;

        public Form1()
        {
            InitializeComponent();
            standardFont = new Font("Times New Roman", 9.75F, FontStyle.Regular);
            boldFont = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            standardColor = SystemColors.ControlText;
            greenColor = Color.Green;
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FIO.Text))
            {
                MessageBox.Show("Введите данные в поле заполнения ФИО!", "Ошибка!");
                return;
            }
            int current = 0;
            if (!Answer21.Checked && Answer22.Checked && Answer23.Checked && !Answer24.Checked && Answer25.Checked)
            {
                current++;
            }
            if (Answer31.Checked && !Answer32.Checked && Answer33.Checked && Answer34.Checked && !Answer35.Checked)
            {
                current++;
            }
            if (Answer41.Checked && Answer42.Checked && !Answer43.Checked && !Answer44.Checked && Answer45.Checked)
            {
                current++;
            }
            if (!Answer51.Checked && !Answer52.Checked && Answer53.Checked && Answer54.Checked && Answer55.Checked)
            {
                current++;
            }
            if (Answer63.Checked)
            {
                current++;
            }

            MessageBox.Show($"{FIO.Text}, Ваша оценка {current}!", "Ваш результат!");
            access = true;
        }

        private void OpenTrue_Click(object sender, EventArgs e)
        {
            if (access)
            {
                Font currentFont = bolded ? standardFont : boldFont;
                Color currentColor = bolded ? standardColor : greenColor;

                Answer22.Font = currentFont;
                Answer23.Font = currentFont;
                Answer25.Font = currentFont;
                Answer31.Font = currentFont;
                Answer33.Font = currentFont;
                Answer34.Font = currentFont;
                Answer41.Font = currentFont;
                Answer42.Font = currentFont;
                Answer45.Font = currentFont;
                Answer53.Font = currentFont;
                Answer54.Font = currentFont;
                Answer55.Font = currentFont;
                Answer63.Font = currentFont;

                Answer22.ForeColor = currentColor;
                Answer23.ForeColor = currentColor;
                Answer25.ForeColor = currentColor;
                Answer31.ForeColor = currentColor;
                Answer33.ForeColor = currentColor;
                Answer34.ForeColor = currentColor;
                Answer41.ForeColor = currentColor;
                Answer42.ForeColor = currentColor;
                Answer45.ForeColor = currentColor;
                Answer53.ForeColor = currentColor;
                Answer54.ForeColor = currentColor;
                Answer55.ForeColor = currentColor;
                Answer63.ForeColor = currentColor;

                OpenTrue.Text = bolded ? "Показать ответы" : "Скрыть ответы";
                bolded = !bolded;
            }
            else
            {
                MessageBox.Show("Решите тест хотя бы один раз!", "Ошибка!");
            }
        }
    }
}
