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

namespace FunctionGeneration
{
    public partial class MenuForm : Form
    {
        
        public MenuForm()
        {
            InitializeComponent();
            this.Height = 400;
        }


        /// <summary>
        /// создание формы с деревом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeButton_Click(object sender, EventArgs e)
        {
            TreeForm tf = new TreeForm();
            tf.Show();
        }

        /// <summary>
        /// создание формы с классом деревьев
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void systemButton_Click(object sender, EventArgs e)
        {
            ClassForm cf = new ClassForm();
            cf.Show();
        }

        /// <summary>
        /// создание формы с проверкой гипотезы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testingButton_Click(object sender, EventArgs e)
        {
            HypothesisTestingForm htf = new HypothesisTestingForm();
            htf.Show();
        }
    }
}