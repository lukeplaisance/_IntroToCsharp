using System;
using System.Drawing;
using System.Windows.Forms;


namespace _8.BackPack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenItem_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            richTextBox1.Clear();
            foreach(var packable in BackPack.packables)
            {
                comboBox1.Items.Add(packable.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var item in BackPack.packables)
            {
                if(item.Name == comboBox1.Text)
                {
                    richTextBox1.Text = item.ToString();
                    pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Item pics\" + item.Name + ".png");
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "BackPack.json");
            //var backpack_root = JsonConvert.SerializeObject(BackPack.packables);
            System.IO.File.WriteAllText(path, backpack_root);
        }
    }
}
