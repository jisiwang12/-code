using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体应用测试
{
    public partial class Form1 : Form
    {
        private int status = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(pictureBox1);
            arrayList.Add(pictureBox2);
            arrayList.Add(pictureBox3);
            arrayList.Add(pictureBox4);
            arrayList.Add(pictureBox5);
            switch (status)
            {
                case 0:
                    for (int i = 0; i < arrayList.Count; i++)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox = (PictureBox)arrayList[i];
                        pictureBox.ImageLocation = "D:\\" + (i + 1) + ".png";
                    }

                    status = 1;
                    break;

                case 1:
                    for (int i = 0; i < arrayList.Count; i++)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox = (PictureBox)arrayList[i];
                        pictureBox.ImageLocation = "D:\\" + (5-i) + ".png";
                    }

                    status = 0;
                    break;
            }

            var class1 = new Class1();
            class1.Test();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
/*
            switch (status)
            {
                case 0:
                    pictureBox1.ImageLocation = "D:\\扇子.png";
                    status = 1;
                    break;
                case 1:
                    pictureBox1.ImageLocation = "D:\\烧酒.png";
                    status = 0;
                    break;
                default:
                    break;*/
          
        }
    }
}

