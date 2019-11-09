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
using System.IO;
using TreeLib;

namespace FunctionGeneration
{
    public partial class ClassForm : Form
    {
        public ClassForm()
        {
            InitializeComponent();
            n = -1;
        }
        private int n;


        /// <summary>
        /// проверка ввода на корректность с соответствие с тз
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool isCorrectInput(string s)
        {
            if (int.TryParse(s, out n) && 1 <= n && n <= 8)
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// кнопка подсчёта ответа на для этой формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ansButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isCorrectInput(nTextBox.Text))
                {
                    MessageBox.Show("Введено некорректное значение");
                    return;
                }

                if (!Gfunction.Checked && !Ffunction.Checked)
                {
                    MessageBox.Show("Вы не выбрали ни одного типа функций");
                    return;
                }

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {


                    if (n == 1)
                    {
                        if (Gfunction.Checked && !Ffunction.Checked)
                        {
                            File.WriteAllText(Name,
                            "Graph[{ 0->0}]\nCollect[GroebnerBasis[{ G == x + a1, a1 == x * (G * G - G * G)}, { x, G}," +
                            " { a1, b1, c1, d1, e1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, " +
                            "w1, z1, a2, b2, c2, d2, e2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, " +
                            "v2, w2, z2, a3, b3, c3, d3, e3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3," +
                            " v3, w3, z3}, MonomialOrder->EliminationOrder], G]");
                        }

                        if (!Gfunction.Checked && Ffunction.Checked)
                        {
                            File.WriteAllText(Name,
                             "Graph[{ 0->0}]\nCollect[GroebnerBasis[{ F == x + a1, a1 == " +
                             "x * (F * F + (y - 1) * F * F)}, { x, y, F}, { a1, b1, c1, d1, e1, f1, g1, h1, i1, j1, k1, l1, m1" +
                             ", n1, o1, p1, q1, r1, s1, t1, u1, v1, w1, z1, a2, b2, c2, d2, e2, f2, g2, h2, i2, j2, k2, l2, m2," +
                             " n2, o2, p2, q2, r2, s2, t2, u2, v2, w2, z2, a3, b3, c3, d3, e3, f3, g3, h3, i3, j3, k3, l3, m3, " +
                             "n3, o3, p3, q3, r3, s3, t3, u3, v3, w3, z3}, MonomialOrder->EliminationOrder], F]");
                        }

                        if (Gfunction.Checked && Ffunction.Checked)
                        {
                            File.WriteAllText(Name,
                            "Graph[{ 0->0}]\nCollect[GroebnerBasis[{ G == x + a1, a1 == x * (G * G - G * G)}, { x, G}," +
                            " { a1, b1, c1, d1, e1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, " +
                            "w1, z1, a2, b2, c2, d2, e2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, " +
                            "v2, w2, z2, a3, b3, c3, d3, e3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3," +
                            " v3, w3, z3}, MonomialOrder->EliminationOrder], G]\nCollect[GroebnerBasis[{ F == x + a1, a1 == " +
                            "x * (F * F + (y - 1) * F * F)}, { x, y, F}, { a1, b1, c1, d1, e1, f1, g1, h1, i1, j1, k1, l1, m1" +
                            ", n1, o1, p1, q1, r1, s1, t1, u1, v1, w1, z1, a2, b2, c2, d2, e2, f2, g2, h2, i2, j2, k2, l2, m2," +
                            " n2, o2, p2, q2, r2, s2, t2, u2, v2, w2, z2, a3, b3, c3, d3, e3, f3, g3, h3, i3, j3, k3, l3, m3, " +
                            "n3, o3, p3, q3, r3, s3, t3, u3, v3, w3, z3}, MonomialOrder->EliminationOrder], F]");
                        }

                        MessageBox.Show("Файл создан и готов к открытию)");
                        return;
                    }

                    if (n == 2)
                    {
                        if (Gfunction.Checked && !Ffunction.Checked)
                        {
                            File.WriteAllText(Name,
                             "Graph[{ 0->1,0->2}]\nCollect[GroebnerBasis[{ G == x + a1, a1 == x * (G * G - G * G)}, " +
                             "{ x, G}, { a1, b1, c1, d1, e1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1," +
                             " u1, v1, w1, z1, a2, b2, c2, d2, e2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, " +
                             "t2, u2, v2, w2, z2, a3, b3, c3, d3, e3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, " +
                             "s3, t3, u3, v3, w3, z3}, MonomialOrder->EliminationOrder], G]");
                        }

                        if (!Gfunction.Checked && Ffunction.Checked)
                        {
                            File.WriteAllText(Name,
                            "Graph[{ 0->1,0->2}]\nCollect[GroebnerBasis[{ F == x " +
                            "+ a1, a1 == x * (F * F + (y - 1) * F * F)}, { x, y, F}, { a1, b1, c1, d1, e1, f1, g1, h1, i1, " +
                            "j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1, z1, a2, b2, c2, d2, e2, f2, g2, h2, i2, " +
                            "j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2, z2, a3, b3, c3, d3, e3, f3, g3, h3, i3, " +
                            "j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3, z3}, MonomialOrder->EliminationOrder], F]");
                        }

                        if (Gfunction.Checked && Ffunction.Checked)
                        {
                            File.WriteAllText(Name,
                            "Graph[{ 0->1,0->2}]\nCollect[GroebnerBasis[{ G == x + a1, a1 == x * (G * G - G * G)}, " +
                            "{ x, G}, { a1, b1, c1, d1, e1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1," +
                            " u1, v1, w1, z1, a2, b2, c2, d2, e2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, " +
                            "t2, u2, v2, w2, z2, a3, b3, c3, d3, e3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, " +
                            "s3, t3, u3, v3, w3, z3}, MonomialOrder->EliminationOrder], G]\nCollect[GroebnerBasis[{ F == x " +
                            "+ a1, a1 == x * (F * F + (y - 1) * F * F)}, { x, y, F}, { a1, b1, c1, d1, e1, f1, g1, h1, i1, " +
                            "j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1, z1, a2, b2, c2, d2, e2, f2, g2, h2, i2, " +
                            "j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2, z2, a3, b3, c3, d3, e3, f3, g3, h3, i3, " +
                            "j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3, z3}, MonomialOrder->EliminationOrder], F]");
                        }
                        
                        MessageBox.Show("Файл создан и готов к открытию)");
                        return;
                    }

                    string[] ans = new string[0];

                    Tree[] AlreadyCounted = new Tree[1] {new Tree(new[] {true, true, true})}; // массив деревьев с n листьями
                                                                                              // (n - изменяется) для который мы уже составил системы
                    Tree[] Counting = new Tree[0]; // массив деревьев с n + 1 листьями (n - изменяется)
                                                   // для который мы ещё не составили системы

                    for (int i = 3; i <= n; i++) // цикл по размерности массива Counting
                                                 // (то есть в данный момент строим все деревья с i листьями )
                    {
                        for (int j = 0; j < AlreadyCounted.Length; j++) // цикл перебирает все деревья с i - 1 листьями
                                                                        // (которые вес уже построены и лежат в массиве AlreadyCounted),
                                                                        // чтобы к каждому из них добавить по листу всевозможными способами
                        {
                            Tree[] newTrees = new Tree[0]; // массив со всевозможными деревьями с i листьями,
                                                           // которые можно получить из дерева AlreadyCounted[j]
                            Tree.AddLeaf(0, AlreadyCounted[j], ref newTrees);
                            Array.Resize(ref Counting, Counting.Length + newTrees.Length);
                            for (int k = Counting.Length - newTrees.Length;
                                    k < Counting.Length;
                                    k++) // добавляем все полученные деревья с i в массив Counting
                            {
                                Counting[k] = newTrees[k - Counting.Length + newTrees.Length];
                            }
                        }

                        AlreadyCounted = (Tree[]) Counting.Clone();
                        Counting = new Tree[0];
                    }

                    for (int j = 0; j < AlreadyCounted.Length; j++)
                    {
                        // проверка на повторяемость (нужна для того чтобы в файле Вольфрама не было
                        // одинаковых графов)
                        bool isRepeated = false;
                        for (int k = 0; k < j; k++)
                        {
                            if (Tree.IsSame(AlreadyCounted[k], AlreadyCounted[j]))
                            {
                                isRepeated = true;
                                break;
                            }
                        }

                        if (!isRepeated)
                        {
                            Tree.GetSystem(AlreadyCounted[j], out string systemX, out string systemXY);
                            if (Gfunction.Checked && !Ffunction.Checked)
                            {
                                Array.Resize(ref ans, ans.Length + 2);
                                ans[ans.Length - 2] = AlreadyCounted[j].WolframForm();
                                ans[ans.Length - 1] = systemX;
                            }

                            if (!Gfunction.Checked && Ffunction.Checked)
                            {
                                Array.Resize(ref ans, ans.Length + 2);
                                ans[ans.Length - 2] = AlreadyCounted[j].WolframForm();
                                ans[ans.Length - 1] = systemXY;
                            }

                            if (Gfunction.Checked && Ffunction.Checked)
                            {
                                Array.Resize(ref ans, ans.Length + 3);
                                ans[ans.Length - 3] = AlreadyCounted[j].WolframForm();
                                ans[ans.Length - 2] = systemX;
                                ans[ans.Length - 1] = systemXY;
                            }
                        }
                    }

                    Name = saveFileDialog1.FileName;
                    File.WriteAllLines(Name, ans);
                    MessageBox.Show("Файл создан и готов к открытию)");
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