using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = new List<AutoPrototype> { new FiatPrototype(), new ChevPrototype(), new VWPrototype() };
            comboBox1.SelectedIndex = -1;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoPrototype autoPrototype = comboBox1.SelectedItem as AutoPrototype;
            AutoPrototype a = autoPrototype.Clonar();

            a.Modelo = textBox1.Text;
            a.Color = textBox2.Text;

            listBox1.Items.Add(a.VerAuto());
        }
    }
}
