using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             
            comboBox1.DataSource = new List<PizzaBuilder> { new PizzaItalianaBuilder(), new PizzaLightBuilder() };
            comboBox1.SelectedIndex = -1;

            listBox1.Items.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PizzaBuilder pizzaBuilder = comboBox1.SelectedItem as PizzaBuilder;

            listBox1.Items.Add(pizzaBuilder.BuildPizza());
        }
    }
}
