using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace CourseProject
{
    public partial class SMO : Form
    {
        Cashbox cashbox;
        Excel excel;

        bool orderType; // true - равномерный закон, false - нормальный закон
        int timer;      // текущее время симуляции
        int globaltime; // общее время симуляции
        int rnd;
        int prev;
        bool flag = true;
        bool start = false;
        private EventArgs e; // нужно для того, чтобы задействовать кнопку "Stop" (51 строка)
        double res1, res2, sum1, sum2;

        public SMO() => InitializeComponent();

        private void Simulation_run()
        {
            while(start)
            {
                if (timer >= globaltime)
                {
                    if (cashbox.currentBuyer != null) // если время работы закончилось, а покупатель не успел обслужиться, то он не обслужен
                    {
                        cashbox.declineBuyers++;
                        cashbox.currentBuyer = null;
                        if (cashbox.GetNumberBuyers() != 0) // если на кассе остались не обслуженные клиенты, то они не обслужены
                        {
                            cashbox.declineBuyers += cashbox.GetNumberBuyers();
                        }
                    }

                    for (int i = 0; i < cashbox.GetFinNumberBuyers(); i++)
                    {
                        sum1 += cashbox.GetTimeStayingOfCashbox()[i];
                        sum2 += cashbox.GetDownTimeCashbox()[i];
                    }
                    res1 = sum1 / cashbox.GetFinNumberBuyers();
                    res2 = (sum2 / globaltime) * 100;

                    label1.Text = "Время работы: " + textBox_time_simulation_days.Text + " дней, " + textBox_time_simulation_hours.Text + " часов " + "("+ globaltime.ToString() + " минут)";
                    label2.Text = "Всего клиентов: " + cashbox.GetTotalBuyers().ToString() + " человек";
                    label3.Text = "Обслужено клиентов: " + cashbox.GetFinNumberBuyers().ToString() + " человек";
                    label4.Text = "Количество отказов: " + cashbox.GetDeclineBuyers().ToString() + " человек";
                    label5.Text = "Среднее время пребывания покупателя у кассы: " + res1.ToString("F") + " минут";
                    label6.Text = "Процент непроизводительного времени продавца: " + res2.ToString("F") +" %";

                    start = false;
                    Button_Stop_Click(e, e);
                    return;
                }

                int distTime = TimeOneByer();
                if (flag)
                {
                    rnd = TimeBetweenByer();
                    if ((timer % rnd) == 0)
                    {
                        cashbox.AddBuyer(timer, distTime);
                        flag = false;
                        prev = timer;
                    }
                }
                else
                {
                    rnd = TimeBetweenByer();
                    if (Math.Abs(timer - prev) >= rnd)
                    {
                        cashbox.AddBuyer(timer, distTime);
                        prev = timer;
                    }
                }
                cashbox.Check(timer);
                timer++;
            }
        }

        private int TimeOneByer() // закон распределения времени обслуживания одного покупателя
        {
            Random rnd = new Random();
            int timeFrom =   int.Parse(textBox_interval_service_time_from.  Text); // обслуживание одного покупателя время от
            int timeBefore = int.Parse(textBox_interval_service_time_before.Text); // обслуживание одного покупателя время до
            if (timeFrom == timeBefore)
            {
                return timeFrom;
            }
            if (orderType)
            {
                return rnd.Next(timeFrom, timeBefore);
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < 9; i++)
                {
                    sum += rnd.Next(timeFrom, timeBefore);
                }
                return sum / 8;
            }
        }

        private int TimeBetweenByer() // закон распределения времени между покупателями
        {
            Random rnd = new Random();
            int timeFrom =   int.Parse(textBox_interval_between_byers_from.  Text); // время между покупателями от
            int timeBefore = int.Parse(textBox_interval_between_byers_before.Text); // время между покупателями до
            if(timeFrom == timeBefore)
            {
                return timeFrom;
            }
            if (orderType)
            {
                return rnd.Next(timeFrom, timeBefore + 1);
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < 9; i++)
                {
                    sum += rnd.Next(timeFrom, timeBefore + 1);
                }
                return (sum / 8);
            }
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            if (comboBox_order_distribution.Text == "")
            {
                MessageBox.Show("Для начала симуляции должен быть выбран закон распределения!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_order_distribution.Focus();
                return;
            }
            if (textBox_max_queue.Text == "" || int.Parse(textBox_max_queue.Text) <= 0)
            {
                MessageBox.Show("Поле \"Максимальный размер очереди\" не должно быть пустым или содержать число \"0\", также число должно быть положительным!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_max_queue.Focus();
                return;
            }
            if (textBox_time_simulation_hours.Text == "" || int.Parse(textBox_time_simulation_hours.Text) <= 0 || int.Parse(textBox_time_simulation_hours.Text) > 8)
            {
                MessageBox.Show("Поле \"Время симуляции в часах\" не должно быть пустым, не должно содержать число \"0\" или быть больше числа \"8\", также число должно быть положительным!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_time_simulation_hours.Focus();
                return;
            }
            if (textBox_time_simulation_days.Text == "" || int.Parse(textBox_time_simulation_days.Text) < 0)
            {
                MessageBox.Show("Поле \"Время симуляции в днях\" не должно быть пустым или содержать отрицательное число!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_time_simulation_days.Focus();
                return;
            }
            if (textBox_interval_between_byers_from.Text == "" || int.Parse(textBox_interval_between_byers_from.Text) < 0)
            {
                MessageBox.Show("Поле \"Интервал между покупателями в минутах от\" не должно быть пустым или содержать отрицательное число!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_interval_between_byers_from.Focus();
                return;
            }
            if (textBox_interval_between_byers_before.Text == "" || int.Parse(textBox_interval_between_byers_before.Text) <= 0)
            {
                MessageBox.Show("Поле \"Интервал между покупателями в минутах до\" не должно быть пустым или содержать отрицательное число!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_interval_between_byers_before.Focus();
                return;
            }
            if (int.Parse(textBox_interval_between_byers_from.Text) > int.Parse(textBox_interval_between_byers_before.Text))
            {
                MessageBox.Show("В поле \"Интервал между покупателями в минутах от\" не должно содержаться число большее, чем в поле \"Интервал между покупателями в минутах до\"!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_interval_between_byers_from.Focus();
                return;
            }

            if (textBox_interval_service_time_from.Text == "" || int.Parse(textBox_interval_service_time_from.Text) < 0)
            {
                MessageBox.Show("Поле \"Интервал обслуживания одного клиента в минутах от\" не должно быть пустым или содержать отрицательное число!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_interval_service_time_from.Focus();
                return;
            }
            if (textBox_interval_service_time_before.Text == "" || int.Parse(textBox_interval_service_time_before.Text) <= 0)
            {
                MessageBox.Show("Поле \"Интервал обслуживания одного клиента в минутах до\" не должно быть пустым или содержать отрицательное число!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_interval_service_time_before.Focus();
                return;
            }
            if (int.Parse(textBox_interval_service_time_from.Text) > int.Parse(textBox_interval_service_time_before.Text))
            {
                MessageBox.Show("В поле \"Интервал между покупателями в минутах от\" не должно содержаться число большее, чем в поле \"Интервал между покупателями в минутах до\"!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_interval_service_time_from.Focus();
                return;
            }

            label1.Text = "Время работы: 0 дней, 0 часов (0 минут)";
            label2.Text = "Всего клиентов: 0 человек";
            label3.Text = "Обслужено клиентов: 0 человек";
            label4.Text = "Количество отказов: 0 человек";
            label5.Text = "Среднее время пребывания покупател у кассы: 0 минут";
            label6.Text = "Процент непроизводительного времени продавца: 0 %";
            start = true; flag = true;
            timer = 1; globaltime = 0; rnd = 0; prev = 0; res1 = 0; res2 = 0; sum1 = 0; sum2 = 0;

            cashbox = new Cashbox(int.Parse(textBox_max_queue.Text));
            if (comboBox_order_distribution.SelectedIndex == 0) // нормальный
            {
                orderType = false;
            }
            else if (comboBox_order_distribution.SelectedIndex == 1) // равномерный
            {
                orderType = true;
            }

            globaltime = int.Parse(textBox_time_simulation_days.Text) * 480 + int.Parse(textBox_time_simulation_hours.Text) * 60;
            start = true;
            Simulation_run();
        }

        private async void Button_Stop_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Записать данные в файл Excel?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                start = false;
                await Task.Run(() => WriteToExcel());
            }
            else
            {
                start = false;
            }
        }

        private void button_clearFields_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите очистить содержимое всех полей?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                label1.Text = "Время работы: 0 дней, 0 часов (0 минут)";
                label2.Text = "Всего клиентов: 0 человек";
                label3.Text = "Обслужено клиентов: 0 человек";
                label4.Text = "Количество отказов: 0 человек";
                label5.Text = "Среднее время пребывания покупател у кассы: 0 минут";
                label6.Text = "Процент непроизводительного времени продавца: 0 %";
                textBox_time_simulation_days.Clear();
                textBox_time_simulation_hours.Clear();
                textBox_max_queue.Clear();
                textBox_interval_between_byers_from.Clear();
                textBox_interval_between_byers_before.Clear();
                textBox_interval_service_time_from.Clear();
                textBox_interval_service_time_before.Clear();
                start = true;
                timer = 1;
                globaltime = 0;
                rnd = 0;
                prev = 0;
                flag = true;
            }
        }

        private void WriteToExcel()
        {
            excel = new Excel();
            excel.CreateNewFile();
            //excel.SaveAs(@"DataAll");
            excel.SaveAs(System.IO.Directory.GetCurrentDirectory() + "\\DataAll.xlsx");
            
            excel.Close();
            
            int row = 1;
            int col = 0;
            int count = 0;
            //excel = new Excel(@"DataAll.xlsx", 1);
            excel = new Excel(System.IO.Directory.GetCurrentDirectory() + "\\DataAll.xlsx", 1);

            excel.WriteToCell(0, col++, "Покупатель");
            excel.WriteToCell(0, col++, "Время в моменты прибытия покупателей, мин");
            excel.WriteToCell(0, col++, "Начало обслуживания, мин");
            excel.WriteToCell(0, col++, "Конец обслуживания, мин");
            excel.WriteToCell(0, col++, "Время обслуживания, мин");
            excel.WriteToCell(0, col++, "Время пребывания покупателя у кассы, мин");
            excel.WriteToCell(0, col++, "Время простоя продавца, мин");

            // номер покупателя
            row = 1; count = 0;
            foreach (int el in cashbox.GetNumByers())
            {
                excel.WriteToCell(row++, 0, cashbox.GetNumByers()[count++].ToString());
            }

            // время в моменты прибытия покупателей
            row = 1; count = 0;
            foreach (int el in cashbox.GetTimeByers())
            {
                excel.WriteToCell(row++, 1, cashbox.GetTimeByers()[count++].ToString());
            }

            // начало обслуживания
            row = 1; count = 0;
            foreach (int el in cashbox.GetTimeStartProcessing())
            {
                excel.WriteToCell(row++, 2, cashbox.GetTimeStartProcessing()[count++].ToString());
            }

            // конец обслуживания
            row = 1; count = 0;
            foreach (int el in cashbox.GetTimeFinishProcessing())
            {
                excel.WriteToCell(row++, 3, cashbox.GetTimeFinishProcessing()[count++].ToString());
            }

            // время обслуживания
            row = 1; count = 0;
            foreach (int el in cashbox.GetWaitTime())
            {
                excel.WriteToCell(row++, 4, cashbox.GetWaitTime()[count++].ToString());
            }

            // время пребывания покупателя у кассы
            row = 1; count = 0;
            foreach (int el in cashbox.GetTimeStayingOfCashbox())
            {
                excel.WriteToCell(row++, 5, cashbox.GetTimeStayingOfCashbox()[count++].ToString());
            }

            // всего (время пребывания покупателей у кассы)
            excel.WriteToCell(++row, 5, "Всего (мин) = " + sum1.ToString());

            // среднее время пребывания покупателя у прилавка
            excel.WriteToCell(++row, 5, "Среднее время пребывания покупателя у кассы (мин) = " + res1.ToString("F", CultureInfo.CurrentCulture));

            // время простоя продавца
            row = 1; 
            for (int i = 0; i < cashbox.GetFinNumberBuyers(); i++)
            {
                excel.WriteToCell(row++, 6, cashbox.GetDownTimeCashbox()[i].ToString());
            }

            // процент непроизводительного времени продавца
            excel.WriteToCell(++row, 6, "Процент непроизводительного времени продавца (%) = " + res2.ToString("F", CultureInfo.CurrentCulture));

            // суммарное время простоя продавца
            int sumTime = 0;
            for (int i = 0; i < cashbox.GetFinNumberBuyers(); i++)
            {
                sumTime += cashbox.GetDownTimeCashbox()[i];
            }
            excel.WriteToCell(++row, 6, "Суммарный простой продавца (мин) = " + sumTime.ToString());

            excel.Save();
            excel.Close();
            DialogResult result = MessageBox.Show("Запись данных успешно завершена! Открыть файл c данными?", "Уведомление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FileInfo fi = new FileInfo(System.IO.Directory.GetCurrentDirectory() + "\\DataAll.xlsx");
                if (fi.Exists)
                {
                    System.Diagnostics.Process.Start(System.IO.Directory.GetCurrentDirectory() + "\\DataAll.xlsx");
                }
                else
                {
                    MessageBox.Show("Не удалось открыть файл!", "Ошибка!");
                }
            } 
        }
    }
}