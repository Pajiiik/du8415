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

namespace _23._03._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream datovy_tok = new FileStream("cisla.dat", FileMode.Create,FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(datovy_tok, Encoding.UTF8);
            foreach (string s in textBox1.Lines)
            {
                    bw.Write(int.Parse(s));
            }

            BinaryReader br = new BinaryReader(datovy_tok, Encoding.UTF8);
            br.BaseStream.Position = 0;
            while(br.BaseStream.Position < br.BaseStream.Length)
            { 
            listBox1.Items.Add(br.ReadInt32());
            }
            datovy_tok.Close();
        }
    }
}
