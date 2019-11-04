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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeLib;
using System.IO;

namespace FunctionGeneration
{
    public partial class TreeForm : Form
    {
        /// <summary>
        /// устанавливает начальные размеры формы и рисует рёбра
        /// </summary>
        public TreeForm()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 430;
            Buttons = new RadioButton[31] { radioButton0, radioButton1, radioButton2, radioButton3,
                radioButton4, radioButton5, radioButton6, radioButton7, radioButton8, radioButton9, radioButton10,
                radioButton11, radioButton12, radioButton13, radioButton14, radioButton15, radioButton16, radioButton17,
                radioButton18, radioButton19, radioButton20, radioButton21, radioButton22, radioButton23, radioButton24,
                radioButton25, radioButton26, radioButton27, radioButton28, radioButton29, radioButton30};
            
            DrawEdge();
        }

        /// <summary>
        /// текущее дерево
        /// </summary>
        public bool[] Vertexes = new bool[31];

        /// <summary>
        /// все кнопки-вершины
        /// </summary>
        public RadioButton[] Buttons = new RadioButton[31]; 


        /// <summary>
        /// рисует ребро между радиобатонами 
        /// </summary>
        private void DrawEdge()
        {
            try
            {
                Bitmap bmp = new Bitmap(this.Width, this.Height);
                Graphics gr = Graphics.FromImage(bmp);
                Pen myPen = new Pen(Color.Blue, 3);

                // нарисуем рёбра между вершинамимна форме 
                // A - веришина "отец", B - вершина "левый сын", C - вершина "правый сын"
                for (int i = 0; i < 15; i++)
                {
                    int AluX = Buttons[i].Location.X; // координата левого верхнего угла A по x (A left up X)
                    int AluY = Buttons[i].Location.Y; // координата левого верхнего угла A по y (A left up Y)

                    int BluX = Buttons[2 * i + 1].Location.X; // координата левого верхнего угла B по x (B left up X)
                    int BluY = Buttons[2 * i + 1].Location.Y; // координата левого верхнего угла B по y (B left up Y)

                    int CluX = Buttons[2 * i + 2].Location.X; // координата левого верхнего угла C по x (C left up X)
                    int CluY = Buttons[2 * i + 2].Location.Y; // координата левого верхнего угла C по y (C left up Y)

                    int Aw = Buttons[i].Width; // ширина A
                    int Ah = Buttons[i].Height; // длина A

                    int Bw = Buttons[2 * i + 1].Width; // ширина B
                    int Bh = Buttons[2 * i + 1].Height; // длина B

                    int Cw = Buttons[2 * i + 2].Width; // ширина C
                    int Ch = Buttons[2 * i + 2].Height; // длина C

                    // ресуем ребро с левым сыном
                    gr.DrawLine(myPen, new Point(AluX + Aw / 2, AluY + Ah / 2),
                        new Point(BluX + Bw / 2, BluY + Bh / 2));
                    // ресуем ребро с правым сыном
                    gr.DrawLine(myPen, new Point(AluX + Aw / 2, AluY + Ah / 2),
                        new Point(CluX + Cw / 2, CluY + Ch / 2));
                }
                this.BackgroundImage = bmp;
            }
            catch (Exception)
            {
                MessageBox.Show("Во время выполнения программы возникла ошибка");
            }
        }

        
        private void radioButton0_Click(object sender, EventArgs e)
        {
            switch (radioButton0.Checked)
            {
                case true:
                    radioButton0.Checked = false;
                    break;
                case false:
                    radioButton0.Checked = true;
                    break;
            }
            Vertexes[0] = radioButton0.Checked;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            switch (radioButton1.Checked)
            {
                case true:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    break;
                case false:
                    radioButton1.Checked = true;
                    radioButton2.Checked = true;
                    break;
            }
            Vertexes[1] = radioButton1.Checked;
            Vertexes[2] = radioButton2.Checked;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            switch (radioButton2.Checked)
            {
                case true:
                    radioButton2.Checked = false;
                    radioButton1.Checked = false;
                    break;
                case false:
                    radioButton2.Checked = true;
                    radioButton1.Checked = true;
                    break;
            }
            Vertexes[2] = radioButton2.Checked;
            Vertexes[1] = radioButton1.Checked;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            switch (radioButton3.Checked)
            {
                case true:
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case false:
                    radioButton3.Checked = true;
                    radioButton4.Checked = true;
                    break;
            }
            Vertexes[3] = radioButton3.Checked;
            Vertexes[4] = radioButton4.Checked;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            switch (radioButton4.Checked)
            {
                case true:
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case false:
                    radioButton3.Checked = true;
                    radioButton4.Checked = true;
                    break;
            }
            Vertexes[4] = radioButton4.Checked;
            Vertexes[3] = radioButton3.Checked;
        }


        private void radioButton5_Click(object sender, EventArgs e)
        {
            switch (radioButton5.Checked)
            {
                case true:
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case false:
                    radioButton5.Checked = true;
                    radioButton6.Checked = true;
                    break;
            }
            Vertexes[5] = radioButton5.Checked;
            Vertexes[6] = radioButton6.Checked;
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            switch (radioButton6.Checked)
            {
                case true:
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case false:
                    radioButton5.Checked = true;
                    radioButton6.Checked = true;
                    break;
            }
            Vertexes[6] = radioButton6.Checked;
            Vertexes[5] = radioButton5.Checked;
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            switch (radioButton7.Checked)
            {
                case true:
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    break;
                case false:
                    radioButton7.Checked = true;
                    radioButton8.Checked = true;
                    break;
            }
            Vertexes[7] = radioButton7.Checked;
            Vertexes[8] = radioButton8.Checked;
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            switch (radioButton8.Checked)
            {
                case true:
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    break;
                case false:
                    radioButton7.Checked = true;
                    radioButton8.Checked = true;
                    break;
            }
            Vertexes[8] = radioButton8.Checked;
            Vertexes[7] = radioButton7.Checked;
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            switch (radioButton9.Checked)
            {
                case true:
                    radioButton9.Checked = false;
                    radioButton10.Checked = false;
                    break;
                case false:
                    radioButton9.Checked = true;
                    radioButton10.Checked = true;
                    break;
            }
            Vertexes[9] = radioButton9.Checked;
            Vertexes[10] = radioButton10.Checked;
        }

        private void radioButton10_Click(object sender, EventArgs e)
        {
            switch (radioButton10.Checked)
            {
                case true:
                    radioButton9.Checked = false;
                    radioButton10.Checked = false;
                    break;
                case false:
                    radioButton9.Checked = true;
                    radioButton10.Checked = true;
                    break;
            }
            Vertexes[10] = radioButton10.Checked;
            Vertexes[9] = radioButton9.Checked;
        }

        private void radioButton11_Click(object sender, EventArgs e)
        {
            switch (radioButton11.Checked)
            {
                case true:
                    radioButton11.Checked = false;
                    radioButton12.Checked = false;
                    break;
                case false:
                    radioButton11.Checked = true;
                    radioButton12.Checked = true;
                    break;
            }
            Vertexes[11] = radioButton11.Checked;
            Vertexes[12] = radioButton12.Checked;
        }

        private void radioButton12_Click(object sender, EventArgs e)
        {
            switch (radioButton12.Checked)
            {
                case true:
                    radioButton12.Checked = false;
                    radioButton11.Checked = false;
                    break;
                case false:
                    radioButton12.Checked = true;
                    radioButton11.Checked = true;
                    break;
            }
            Vertexes[12] = radioButton12.Checked;
            Vertexes[11] = radioButton11.Checked;
        }


        private void radioButton13_Click(object sender, EventArgs e)
        {
            switch (radioButton13.Checked)
            {
                case true:
                    radioButton13.Checked = false;
                    radioButton14.Checked = false;
                    break;
                case false:
                    radioButton13.Checked = true;
                    radioButton14.Checked = true;
                    break;
            }
            Vertexes[13] = radioButton13.Checked;
            Vertexes[14] = radioButton14.Checked;
        }

        private void radioButton14_Click(object sender, EventArgs e)
        {
            switch (radioButton14.Checked)
            {
                case true:
                    radioButton13.Checked = false;
                    radioButton14.Checked = false;
                    break;
                case false:
                    radioButton13.Checked = true;
                    radioButton14.Checked = true;
                    break;
            }
            Vertexes[14] = radioButton14.Checked;
            Vertexes[13] = radioButton13.Checked;
        }

        private void radioButton15_Click(object sender, EventArgs e)
        {
            switch (radioButton15.Checked)
            {
                case true:
                    radioButton15.Checked = false;
                    radioButton16.Checked = false;
                    break;
                case false:
                    radioButton15.Checked = true;
                    radioButton16.Checked = true;
                    break;
            }
            Vertexes[15] = radioButton15.Checked;
            Vertexes[16] = radioButton16.Checked;
        }

        private void radioButton16_Click(object sender, EventArgs e)
        {
            switch (radioButton16.Checked)
            {
                case true:
                    radioButton15.Checked = false;
                    radioButton16.Checked = false;
                    break;
                case false:
                    radioButton15.Checked = true;
                    radioButton16.Checked = true;
                    break;
            }
            Vertexes[16] = radioButton16.Checked;
            Vertexes[15] = radioButton15.Checked;
        }

        private void radioButton17_Click(object sender, EventArgs e)
        {
            switch (radioButton17.Checked)
            {
                case true:
                    radioButton17.Checked = false;
                    radioButton18.Checked = false;
                    break;
                case false:
                    radioButton17.Checked = true;
                    radioButton18.Checked = true;
                    break;
            }
            Vertexes[17] = radioButton17.Checked;
            Vertexes[18] = radioButton18.Checked;
        }

        private void radioButton18_Click(object sender, EventArgs e)
        {
            switch (radioButton18.Checked)
            {
                case true:
                    radioButton17.Checked = false;
                    radioButton18.Checked = false;
                    break;
                case false:
                    radioButton17.Checked = true;
                    radioButton18.Checked = true;
                    break;
            }
            Vertexes[18] = radioButton18.Checked;
            Vertexes[17] = radioButton17.Checked;
        }

        private void radioButton19_Click(object sender, EventArgs e)
        {
            switch (radioButton19.Checked)
            {
                case true:
                    radioButton19.Checked = false;
                    radioButton20.Checked = false;
                    break;
                case false:
                    radioButton19.Checked = true;
                    radioButton20.Checked = true;
                    break;
            }
            Vertexes[19] = radioButton19.Checked;
            Vertexes[20] = radioButton20.Checked;
        }

        private void radioButton20_Click(object sender, EventArgs e)
        {
            switch (radioButton20.Checked)
            {
                case true:
                    radioButton19.Checked = false;
                    radioButton20.Checked = false;
                    break;
                case false:
                    radioButton19.Checked = true;
                    radioButton20.Checked = true;
                    break;
            }
            Vertexes[20] = radioButton20.Checked;
            Vertexes[19] = radioButton19.Checked;
        }

        private void radioButton21_Click(object sender, EventArgs e)
        {
            switch (radioButton21.Checked)
            {
                case true:
                    radioButton21.Checked = false;
                    radioButton22.Checked = false;
                    break;
                case false:
                    radioButton21.Checked = true;
                    radioButton22.Checked = true;
                    break;
            }
            Vertexes[22] = radioButton22.Checked;
            Vertexes[21] = radioButton21.Checked;
        }

        private void radioButton22_Click(object sender, EventArgs e)
        {
            switch (radioButton22.Checked)
            {
                case true:
                    radioButton21.Checked = false;
                    radioButton22.Checked = false;
                    break;
                case false:
                    radioButton21.Checked = true;
                    radioButton22.Checked = true;
                    break;
            }
            Vertexes[22] = radioButton22.Checked;
            Vertexes[21] = radioButton21.Checked;
        }

        private void radioButton23_Click(object sender, EventArgs e)
        {
            switch (radioButton23.Checked)
            {
                case true:
                    radioButton23.Checked = false;
                    radioButton24.Checked = false;
                    break;
                case false:
                    radioButton23.Checked = true;
                    radioButton24.Checked = true;
                    break;
            }
            Vertexes[24] = radioButton24.Checked;
            Vertexes[23] = radioButton23.Checked;
        }

        private void radioButton24_Click(object sender, EventArgs e)
        {
            switch (radioButton24.Checked)
            {
                case true:
                    radioButton23.Checked = false;
                    radioButton24.Checked = false;
                    break;
                case false:
                    radioButton23.Checked = true;
                    radioButton24.Checked = true;
                    break;
            }
            Vertexes[24] = radioButton24.Checked;
            Vertexes[23] = radioButton23.Checked;
        }

        private void radioButton25_Click(object sender, EventArgs e)
        {
            switch (radioButton25.Checked)
            {
                case true:
                    radioButton25.Checked = false;
                    radioButton26.Checked = false;
                    break;
                case false:
                    radioButton25.Checked = true;
                    radioButton26.Checked = true;
                    break;
            }
            Vertexes[26] = radioButton26.Checked;
            Vertexes[25] = radioButton25.Checked;
        }

        private void radioButton26_Click(object sender, EventArgs e)
        {
            switch (radioButton26.Checked)
            {
                case true:
                    radioButton25.Checked = false;
                    radioButton26.Checked = false;
                    break;
                case false:
                    radioButton25.Checked = true;
                    radioButton26.Checked = true;
                    break;
            }
            Vertexes[26] = radioButton26.Checked;
            Vertexes[25] = radioButton25.Checked;
        }

        private void radioButton27_Click(object sender, EventArgs e)
        {
            switch (radioButton27.Checked)
            {
                case true:
                    radioButton27.Checked = false;
                    radioButton28.Checked = false;
                    break;
                case false:
                    radioButton27.Checked = true;
                    radioButton28.Checked = true;
                    break;
            }
            Vertexes[28] = radioButton28.Checked;
            Vertexes[27] = radioButton27.Checked;
        }

        private void radioButton28_Click(object sender, EventArgs e)
        {
            switch (radioButton28.Checked)
            {
                case true:
                    radioButton27.Checked = false;
                    radioButton28.Checked = false;
                    break;
                case false:
                    radioButton27.Checked = true;
                    radioButton28.Checked = true;
                    break;
            }
            Vertexes[28] = radioButton28.Checked;
            Vertexes[27] = radioButton27.Checked;
        }

        private void radioButton29_Click(object sender, EventArgs e)
        {
            switch (radioButton29.Checked)
            {
                case true:
                    radioButton29.Checked = false;
                    radioButton30.Checked = false;
                    break;
                case false:
                    radioButton29.Checked = true;
                    radioButton30.Checked = true;
                    break;
            }
            Vertexes[30] = radioButton30.Checked;
            Vertexes[29] = radioButton29.Checked;
        }

        private void radioButton30_Click(object sender, EventArgs e)
        {
            switch (radioButton30.Checked)
            {
                case true:
                    radioButton29.Checked = false;
                    radioButton30.Checked = false;
                    break;
                case false:
                    radioButton29.Checked = true;
                    radioButton30.Checked = true;
                    break;
            }
            Vertexes[30] = radioButton30.Checked;
            Vertexes[29] = radioButton29.Checked;
        }


        /// <summary>
        /// "обрезает" несвязные куски графа
        /// </summary>
        /// <param name="v">текущая вершина запуска</param>
        /// <param name="stopedCorrectInput">бул который сообщает прервалась ли уже ветка графа</param>
        /// <param name="VertexesClone">массив булов который в итоге не будет содержать лишние компоненты связности</param>
        private void InPutCheck(int v, bool stopedCorrectInput, ref bool[] VertexesClone)
        {
            try
            {
                if (!VertexesClone[v])
                {
                    stopedCorrectInput = true;
                }

                if (stopedCorrectInput)
                {
                    VertexesClone[v] = false;
                }

                if (2 * v + 2 < VertexesClone.Length)
                {
                    InPutCheck(2 * v + 1, stopedCorrectInput, ref VertexesClone);
                    InPutCheck(2 * v + 2, stopedCorrectInput, ref VertexesClone);
                }

                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Во время выполнения программы возникла ошибка");
            }
        }


        /// <summary>
        /// кнопка для записи запросных строк в, заданный пользователем, файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileAnsButton_Click(object sender, EventArgs e)
        {
            if (!Gfunction.Checked && !Ffunction.Checked)
            {
                MessageBox.Show("Вы не выбрали ни одного типа функций");
                return;
            }
            if (!radioButton0.Checked)
            {
                MessageBox.Show("У Вас пустой корень!\nПометьте его");
                return;
            }
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    
                    bool[] VertexesClone = (bool[]) Vertexes.Clone();
                    InPutCheck(0, false, ref VertexesClone);

                    Tree bigTree = new Tree(VertexesClone);

                    Tree.GetSystem(bigTree, out string systemX, out string systemXY);
                    outPutText.Text += $"запрос сделан в {DateTime.Now} по времени на Вашем компьере\n";
                    outPutText.Text += bigTree.WolframForm();
                    Name = saveFileDialog1.FileName;
                    if (Gfunction.Checked && !Ffunction.Checked)
                    {
                        outPutText.Text += '\n' + systemX + "\n\n\n";
                        File.WriteAllText(Name, bigTree.WolframForm() + '\n' + systemX);
                    }

                    if (!Gfunction.Checked && Ffunction.Checked)
                    {
                        outPutText.Text += '\n' + systemXY + "\n\n\n";
                        File.WriteAllText(Name, bigTree.WolframForm() + '\n' + systemXY);
                    }

                    if (Gfunction.Checked && Ffunction.Checked)
                    {
                        outPutText.Text += '\n' + systemX + '\n' + systemXY + "\n\n\n";
                        File.WriteAllText(Name, bigTree.WolframForm() + '\n' + systemX + '\n' + systemXY);
                    }
                    MessageBox.Show("Файл создан и готов к открытию)");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Во время выполнения программы возникла ошибка");
            }
        }


        /// <summary>
        /// кнопка для вывода запросных строк в текст бокс в правой нижней части формы 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbAnsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Gfunction.Checked && !Ffunction.Checked)
                {
                    MessageBox.Show("Вы не выбрали ни одного типа функций");
                    return;
                }

                if (!radioButton0.Checked)
                {
                    MessageBox.Show("У Вас пустой корень!\nПометьте его");
                    return;
                }

                bool[] VertexesClone = (bool[]) Vertexes.Clone();
                InPutCheck(0, false, ref VertexesClone);

                Tree bigTree = new Tree(VertexesClone);

                Tree.GetSystem(bigTree, out string systemX, out string systemXY);
                outPutText.Text += $"запрос сделан в {DateTime.Now} по времени на Вашем компьере\n";
                outPutText.Text += bigTree.WolframForm();
                if (Gfunction.Checked && !Ffunction.Checked)
                {
                    outPutText.Text += '\n' + systemX + "\n\n\n";
                }

                if (!Gfunction.Checked && Ffunction.Checked)
                {
                    outPutText.Text += '\n' + systemXY + "\n\n\n";
                }

                if (Gfunction.Checked && Ffunction.Checked)
                {
                    outPutText.Text += '\n' + systemX + '\n' + systemXY + "\n\n\n";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Во время выполнения программы возникла ошибка");
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
    }
}