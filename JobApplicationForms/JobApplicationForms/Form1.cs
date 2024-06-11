using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JobApplicationForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] diller = {"Türkçe","İngilizce","Almanca","Arapça"
            ,"Fransızca","İtalyanca"};
            checkedListBox1.Items.AddRange(diller);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text=="")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text!="")
            {
                if (checkedListBox1.Items.Contains(textBox2.Text)==false)
                    checkedListBox1.Items.Add(textBox2.Text);
                else
                    MessageBox.Show("belirtilen dil ekli");
                textBox2.Text="";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedIndices.Count>0)
            {
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string diller = " ";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                diller +=", " + checkedListBox1.CheckedItems[i];
            }

            if (diller.Length>2)
            {
                diller=diller.Substring(2);

            }
            label7.Text = diller;
            if (radioButton1.Checked)
            {
                label8.Text="İlköğretim";
            }
            else if (radioButton2.Checked)
            {
                label8.Text="Lise";
            }
            else if (radioButton3.Checked)
            {
                label8.Text="Önlisans";
            }
            else if (radioButton4.Checked)
            {
                label8.Text="Lisans";
            }
            else
            {
                MessageBox.Show("lütfen eğitim durumunuzu seçiniz");
            }
            label6.Text=textBox1.Text;
        }
    }
    }
   

