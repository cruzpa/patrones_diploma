using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;

namespace facade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.DataSource = new[] { "mp4", "ogg" };
            comboBox1.SelectedIndex = 0;
            textBox1.Text = "youtubevideo.ogg";
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                VideoConverter converter = new VideoConverter();
                Video video = converter.Convert(textBox1.Text, comboBox1.SelectedItem.ToString());

                listBox1.Items.Add("Cliente: pide convertir el video usando solo la fachada.");

                foreach (string step in video.Steps)
                {
                    listBox1.Items.Add(step);
                }
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("No se pudo convertir el video: " + ex.Message);
            }
        }
    }
}
