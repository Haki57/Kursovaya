/*
 * Выполнил Черкасов Андрей Тимофеевич
 * БПИ 182
 * Курсовая 2019 года
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionGeneration
{
    /// <summary>
    /// здесь я проверяю гипотезу Роуланда, то есть, что если у двух деревьев равны функции G(x), то равны 
    /// и функции F(x, y) и наоборот  
    /// </summary>
    public partial class HypothesisTestingForm : Form
    {
        public HypothesisTestingForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// кнокпа тестировки гипотезы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hypTestingButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Name = openFileDialog1.FileName;
                    string inPut = File.ReadAllText(Name);

                    // массив строк-комманд полученных из заданного файла
                    string[] commands = inPut.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    string[] SystemX = new string[0] { };
                    string[] SystemXY = new string[0] { };

                    int cnt = 0;
                    int mod = 3;  // индикатор того что сколько видов функций в файле 
                                  // 3 если G(x) и F(x, y)
                    if (Gfunction.Checked)
                    {
                        mod = 2;
                    }

                    for (int i = 0; i < commands.Length; i++)
                    {
                        if (commands[i].StartsWith("Out")) cnt++;

                        if (cnt > 0 && cnt % mod != 1)
                        {
                            int ravnoIndex = commands[i].IndexOf('=');
                            commands[i] = commands[i].Substring(ravnoIndex + 2, commands[i].Length - ravnoIndex - 2);
                            if (!Gfunction.Checked)
                            {
                                if (cnt % 3 == 0)
                                {
                                    Array.Resize(ref SystemXY, SystemXY.Length + 1);
                                    SystemXY[SystemXY.Length - 1] = commands[i];
                                }

                                if (cnt % 3 == 2)
                                {
                                    Array.Resize(ref SystemX, SystemX.Length + 1);
                                    SystemX[SystemX.Length - 1] = commands[i];
                                }
                            } else {
                                if (cnt % 2 == 0)
                                {
                                    Array.Resize(ref SystemX, SystemX.Length + 1);
                                    SystemX[SystemX.Length - 1] = commands[i];
                                }
                            }
                        }
                    }
                    if (cnt == 0)
                    {
                        MessageBox.Show("Ваш файл ни разу не был скомпилирован!\n" +
                                "Скомпилируйте его)");
                        return;
                    }
                    
                    // последний элемент обрезается, поэтому добавим к ниму этот символ вручную
                    if (!Gfunction.Checked) SystemXY[SystemXY.Length - 1] += '\r';
                    
                    int[][] XGroups = new int[0][] { };  // массив массивов в котормом каждый массив содержит
                                                         // в себе те и только те функйии по X которые равны

                    int[][] XYGroups = new int[0][] { }; // массив массивов в котормом каждый массив содержит
                                                         // в себе те и только те функйии по XY которые равны

                    bool[] usedX = new bool[] { }; // массим булов. Каждый бул соответствует по номеру функции
                                                   // из массива SystemX и означает закинули ли мы уже эту функцию
                                                   // в какуюто группу из XGroups или нет
                    Array.Resize(ref usedX, SystemX.Length);

                    bool[] usedXY = new bool[] { }; // массим булов. Каждый бул соответствует по номеру функции
                                                    // из массива SystemXY и означает закинули ли мы уже эту 
                                                    // функцию в какуюто группу из XYGroups или нет
                    Array.Resize(ref usedXY, SystemXY.Length);


                    // построение XGroups
                    for (int i = 0; i < SystemX.Length; i++)
                    {
                        if (!usedX[i])
                        {
                            Array.Resize(ref XGroups, XGroups.Length + 1);
                            XGroups[XGroups.Length - 1] = new int[1] { i };
                            for (int j = i + 1; j < SystemX.Length; j++)
                            {
                                if (!usedX[j] && SystemX[i] == SystemX[j])
                                {
                                    usedX[j] = true;
                                    Array.Resize(ref XGroups[XGroups.Length - 1],
                                        XGroups[XGroups.Length - 1].Length + 1);
                                    XGroups[XGroups.Length - 1][XGroups[XGroups.Length - 1].Length - 1] = j;
                                }
                            }

                            Array.ForEach(XGroups[XGroups.Length - 1], y => Console.Write(y + " "));
                            Console.WriteLine();
                        }
                    }


                    if (Gfunction.Checked) goto AvoidanceCase;
                    
                    // построение XYGroups
                    for (int i = 0; i < SystemXY.Length; i++)
                    {
                        if (!usedXY[i])
                        {
                            Array.Resize(ref XYGroups, XYGroups.Length + 1);
                            XYGroups[XYGroups.Length - 1] = new int[1] { i };
                            for (int j = i + 1; j < SystemXY.Length; j++)
                            {
                                if (!usedXY[j] && SystemXY[i] == SystemXY[j])
                                {
                                    usedXY[j] = true;
                                    Array.Resize(ref XYGroups[XYGroups.Length - 1],
                                        XYGroups[XYGroups.Length - 1].Length + 1);
                                    XYGroups[XYGroups.Length - 1][XYGroups[XYGroups.Length - 1].Length - 1] = j;
                                }
                            }

                            Array.ForEach(XYGroups[XYGroups.Length - 1], y => Console.Write(y + " "));
                            Console.WriteLine();
                        }
                    }


                    //просто проверяем совпадают ли 2 массива массивов XGroups и XYGroups
                    if (XGroups.Length != XYGroups.Length)
                    {
                        verdictTextBox.Text += $"Rouland hypothesis is FALSE for given input\n";
                        return;
                    }
                    for (int i = XGroups.Length - 1; i > -1; i--)
                    {
                        if (XGroups[i].Length != XYGroups[i].Length)
                        {
                            verdictTextBox.Text += $"Rouland hypothesis is FALSE for given input\n";
                            return;
                        }

                        for (int j = 0; j < XGroups[i].Length; j++)
                        {
                            if (XYGroups[i][j] != XGroups[i][j])
                            {
                                verdictTextBox.Text += $"Rouland hypothesis is FALSE for given input\n";
                                return;
                            }
                        }

                    }

                    verdictTextBox.Text += $"\nRouland hypothesis is TRUE for given input\n\n" +
                        $"Количество функций в группах:\n";
                    int sum = 0;
                    for (int i = XGroups.Length - 1; i > -1; i--)
                    {
                        sum += XGroups[i].Length;
                        verdictTextBox.Text += XGroups[i].Length + " ";
                    }
                    verdictTextBox.Text += $"\nВсего деревьев: {sum}";
                    if (sum != SystemX.Length)
                        MessageBox.Show("Сумма групп размеров НЕ совпала с данным количеством \n" +
                                        "дереавьев во входном файле");
                    return;

                    AvoidanceCase:
                        verdictTextBox.Text +=  $"Количество функций в группах:\n";
                        sum = 0;
                        for (int i = XGroups.Length - 1; i > -1; i--)
                        {
                            sum += XGroups[i].Length;
                            verdictTextBox.Text += XGroups[i].Length + " ";
                        }
                        verdictTextBox.Text += $"\nВсего деревьев: {sum}";
                        if (sum != SystemX.Length)
                            MessageBox.Show("Сумма групп размеров НЕ совпала с данным количеством \n" +
                                            "дереавьев во входном файле");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Во время выполнения программы возникла ошибка\n" +
                                "скорее всего дело в некорректном входном файле");
            }
        }


        /// <summary>
        /// возвращение в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
        }


        /// <summary>
        /// вызывает окно генерации нового файла нового класса 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void makeNewFileButton_Click(object sender, EventArgs e)
        {
            ClassForm cf = new ClassForm();
            cf.Show();
        }
    }
}
