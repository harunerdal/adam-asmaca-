using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adam_asmaca_son_hali_ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // hocam bildiklerimle yaptım o yüzden çok uzun oldu kusura bakmayın
        //interneten kopyala yapıştıra gönlüm izin vermedi ne olursa razıyım:D
        //Berbat kodlamacı Harun Yusuf Erdal
        //bide doğru bildikten sonra butona 1 kere daha tıklanmalı bu sayede teyit etiriyorum
        int hak = 0;
        int yeni = 0;
        int can = 8;

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
            button2.BackColor = Color.Blue;
            button3.BackColor = Color.Blue;
            button1.Text = "Dene";
            button2.Text = "Başla";
            button3.Text = "Sıradaki soru";
            label1.Text = "_";
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
            label5.Text = "_";
            label6.Text = "_";
            label7.Text = "Arkadaştan 1 tık fazlası"+" 4 harf";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            button1.Visible=false;
            button3.Visible = false;
            this.BackColor = Color.White;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            string[] harf = new string[12];
            {
                harf[0] = "D";
                harf[1] = "O";
                harf[2] = "S";
                harf[3] = "T";
                harf[4] = "İ";
                harf[5] = "Ş";
                harf[6] = "B";
                harf[7] = "Ü";
                harf[8] = "L";
                harf[9] = "E";
                harf[10] = "N";
                harf[11] = "T";


            }


            textBox1.Text = textBox1.Text.ToUpper();

            if (yeni == 0)
            {
                label7.Text = "Arkadaştan 1 tık fazlası" + " 4 harf";
                if (label1.BackColor == Color.Green && label2.BackColor == Color.Green && label3.BackColor == Color.Green
                && label4.BackColor == Color.Green)
                {
                    MessageBox.Show("Kazandınız");
                    button1.Enabled = false;
                    button3.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    label1.Text = "_";
                    label2.Text = "_";
                    label3.Text = "_";
                    label4.Text = "_";
                    label5.Text = "";
                    label6.Text = "";
                    label1.BackColor = Color.White;
                    label2.BackColor = Color.White;
                    label3.BackColor = Color.White;
                    label4.BackColor = Color.White;
                    label5.BackColor = Color.White;
                    label6.BackColor = Color.White;
                }
                if (textBox1.Text == "")
                {
                    MessageBox.Show("BİR HARF GİRİNİZ");
                }
                else
                {

                    if (textBox1.Text == harf[0].ToString())
                    {
                        label1.Text = "D";
                        label1.BackColor = Color.Green;
                    }
                    else
                    {
                        if (textBox1.Text == harf[1].ToString())
                        {
                            label2.Text = "O";
                            label2.BackColor = Color.Green;
                        }
                        else
                        {
                            if (textBox1.Text == harf[2].ToString())
                            {
                                label3.Text = "S";
                                label3.BackColor = Color.Green;
                            }
                            else
                            {
                                if (textBox1.Text == harf[3].ToString())
                                {
                                    label4.Text = "T";
                                    label4.BackColor = Color.Green;
                                }
                                else
                                {
                                    hak++;
                                    if (hak == 1)
                                    {
                                        can = hak;
                                        label8.Text = "Hak:" + can.ToString();
                                        pictureBox1.Visible = true;
                                    }
                                    if (hak == 2)
                                    {
                                        can = hak;
                                        label8.Text = "Hak:" + can.ToString();
                                        pictureBox2.Visible = true;
                                    }
                                    if (hak == 3)
                                    {
                                        can = hak;
                                        label8.Text = "Hak:" + can.ToString();
                                        pictureBox3.Visible = true;
                                    }
                                    if (hak == 4)
                                    {
                                        can = hak;
                                        label8.Text = "Hak:" + can.ToString();
                                        pictureBox4.Visible = true;
                                    }
                                    if (hak == 5)
                                    {
                                        can = hak;
                                        label8.Text = "Hak:" + can.ToString();
                                        pictureBox5.Visible = true;
                                    }
                                    if (hak == 6)
                                    {
                                        can = hak;
                                        label8.Text = "Hak:" + can.ToString();
                                        pictureBox6.Visible = true;
                                    }
                                    if (hak == 7)
                                    {
                                        can = hak;
                                        label8.Text = "Hak:" + can.ToString();
                                        pictureBox7.Visible = true;
                                    }
                                    if (hak == 8)
                                    {
                                        can = hak;
                                        label8.Text = "Hak:" + can.ToString();
                                        pictureBox8.Visible = true;
                                        button1.Enabled = false;
                                        MessageBox.Show("Oyunu kaybetiniz");
                                        label1.Text = "_";
                                        label2.Text = "_";
                                        label3.Text = "_";
                                        label4.Text = "_";
                                        label5.Text = "_";
                                        label6.Text = "_";
                                        label1.BackColor = Color.White;
                                        label2.BackColor = Color.White;
                                        label3.BackColor = Color.White;
                                        label4.BackColor = Color.White;
                                        label5.BackColor = Color.White;
                                        label6.BackColor = Color.White;
                                        pictureBox1.Visible = false;
                                        pictureBox2.Visible = false;
                                        pictureBox3.Visible = false;
                                        pictureBox4.Visible = false;
                                        pictureBox5.Visible = false;
                                        pictureBox6.Visible = false;
                                        pictureBox7.Visible = false;
                                        pictureBox8.Visible = false;
                                       
                                        button1.Visible = false;
                                        
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (yeni == 1)
            {
                label7.Text = "para kazandıran şey" + " 2 harf";
                if (label1.BackColor == Color.Green && label2.BackColor == Color.Green)
                {
                    MessageBox.Show("Kazandınız");
                    button1.Enabled = false;
                    button3.Visible = true;
                    label1.Text = "_";
                    label2.Text = "_";
                    label3.Text = "";
                    label4.Text = "";
                    label5.Text = "";
                    label6.Text = "";
                    label1.BackColor = Color.White;
                    label2.BackColor = Color.White;
                    label3.BackColor = Color.White;
                    label4.BackColor = Color.White;
                    label5.BackColor = Color.White;
                    label6.BackColor = Color.White;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                }
                if (textBox1.Text == "")
                {
                    MessageBox.Show("BİR HARF GİRİNİZ");
                }
                else
                {

                    if (textBox1.Text == harf[4].ToString())
                    {
                        label1.Text = "İ";
                        label1.BackColor = Color.Green;
                    }
                    else
                    {
                        if (textBox1.Text == harf[5].ToString())
                        {
                            label2.Text = "Ş";
                            label2.BackColor = Color.Green;
                        }

                        else
                        {
                            hak++;
                            if (hak == 1)
                            {
                                can = hak;
                                label8.Text = "Hak:" + can.ToString();
                                pictureBox1.Visible = true;
                            }
                            if (hak == 2)
                            {
                                can = hak;
                                label8.Text = "Hak:" + can.ToString();
                                pictureBox2.Visible = true;
                            }
                            if (hak == 3)
                            {
                                can = hak;
                                label8.Text = "Hak:" + can.ToString();
                                pictureBox3.Visible = true;
                            }
                            if (hak == 4)
                            {
                                can = hak;
                                label8.Text = "Hak:" + can.ToString();
                                pictureBox4.Visible = true;
                            }
                            if (hak == 5)
                            {
                                can = hak;
                                label8.Text = "Hak:" + can.ToString();
                                pictureBox5.Visible = true;
                            }
                            if (hak == 6)
                            {
                                can = hak;
                                label8.Text = "Hak:" + can.ToString();
                                pictureBox6.Visible = true;
                            }
                            if (hak == 7)
                            {
                                can = hak;
                                label8.Text = "Hak:" + can.ToString();
                                pictureBox7.Visible = true;
                            }
                            if (hak == 8)
                            {
                                can = hak;
                                label8.Text = "Hak:" + can.ToString();
                                pictureBox8.Visible = true;
                                button1.Enabled = false;
                                MessageBox.Show("Oyunu kaybetiniz");
                                label1.Text = "_";
                                label2.Text = "_";
                                label3.Text = "_";
                                label4.Text = "_";
                                label5.Text = "_";
                                label6.Text = "_";
                                label1.BackColor = Color.White;
                                label2.BackColor = Color.White;
                                label3.BackColor = Color.White;
                                label4.BackColor = Color.White;
                                label5.BackColor = Color.White;
                                label6.BackColor = Color.White;
                                pictureBox1.Visible = false;
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = false;
                                pictureBox4.Visible = false;
                                pictureBox5.Visible = false;
                                pictureBox6.Visible = false;
                                pictureBox7.Visible = false;
                                pictureBox8.Visible = false;
                                button1.Visible = false;
                               

                            }
                        }


                    }
                }
            }
            if (yeni == 3)
            {
                label7.Text = "ATP 11/A Atolye öğretmedni ismi "+" 6 harf";
                if (label1.BackColor == Color.Green && label2.BackColor == Color.Green && label3.BackColor == Color.Green
                && label4.BackColor == Color.Green && label5.BackColor == Color.Green && label6.BackColor == Color.Green)
                {
                    MessageBox.Show("Kazandınız Oyun burda sona eriyor oynadığınız için teşekürler");
                    button1.Enabled = false;
                    label1.Text = "_";
                    label2.Text = "_";
                    label3.Text = "_";
                    label4.Text = "_";
                    label5.Text = "_";
                    label6.Text = "_";
                    label1.BackColor = Color.White;
                    label2.BackColor = Color.White;
                    label3.BackColor = Color.White;
                    label4.BackColor = Color.White;
                    label5.BackColor = Color.White;
                    label6.BackColor = Color.White;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                }
                if (textBox1.Text == "")
                {
                    MessageBox.Show("BİR HARF GİRİNİZ");
                }
                else
                {

                    if (textBox1.Text == harf[6].ToString())
                    {
                        label1.Text = "B";
                        label1.BackColor = Color.Green;
                    }
                    else
                    {
                        if (textBox1.Text == harf[7].ToString())
                        {
                            label2.Text = "Ü";
                            label2.BackColor = Color.Green;
                        }
                        else
                        {
                            if (textBox1.Text == harf[8].ToString())
                            {
                                label3.Text = "L";
                                label3.BackColor = Color.Green;
                            }
                            else
                            {
                                if (textBox1.Text == harf[9].ToString())
                                {
                                    label4.Text = "E";
                                    label4.BackColor = Color.Green;
                                }
                                else
                                {
                                    if (textBox1.Text == harf[10].ToString())
                                    {
                                        label5.Text = "N";
                                        label5.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (textBox1.Text == harf[11].ToString())
                                        {
                                            label6.Text = "T";
                                            label6.BackColor = Color.Green;
                                        }
                                        else
                                        {
                                            hak++;
                                            if (hak == 1)
                                            {
                                                can = hak;
                                                label8.Text = "Hak:" + can.ToString();
                                                pictureBox1.Visible = true;
                                            }
                                            if (hak == 2)
                                            {
                                                can = hak;
                                                label8.Text = "Hak:" + can.ToString();
                                                pictureBox2.Visible = true;
                                            }
                                            if (hak == 3)
                                            {
                                                can = hak;
                                                label8.Text = "Hak:" + can.ToString();
                                                pictureBox3.Visible = true;
                                            }
                                            if (hak == 4)
                                            {
                                                can = hak;
                                                label8.Text = "Hak:" + can.ToString();
                                                pictureBox4.Visible = true;
                                            }
                                            if (hak == 5)
                                            {
                                                can = hak;
                                                label8.Text = "Hak:" + can.ToString();
                                                pictureBox5.Visible = true;
                                            }
                                            if (hak == 6)
                                            {
                                                can = hak;
                                                label8.Text = "Hak:" + can.ToString();
                                                pictureBox6.Visible = true;
                                            }
                                            if (hak == 7)
                                            {
                                                can = hak;
                                                label8.Text = "Hak:" + can.ToString();
                                                pictureBox7.Visible = true;
                                            }
                                            if (hak == 8)
                                            {
                                                can = hak;
                                                label8.Text = "Hak:" + can.ToString();
                                                pictureBox8.Visible = true;
                                                button1.Enabled = false;
                                                MessageBox.Show("Oyunu kaybetiniz");
                                                label1.Text = "_";
                                                label2.Text = "_";
                                                label3.Text = "_";
                                                label4.Text = "_";
                                                label5.Text = "_";
                                                label6.Text = "_";
                                                label1.BackColor = Color.White;
                                                label2.BackColor = Color.White;
                                                label3.BackColor = Color.White;
                                                label4.BackColor = Color.White;
                                                label5.BackColor = Color.White;
                                                label6.BackColor = Color.White;
                                                pictureBox1.Visible = false;
                                                pictureBox2.Visible = false;
                                                pictureBox3.Visible = false;
                                                pictureBox4.Visible = false;
                                                pictureBox5.Visible = false;
                                                pictureBox6.Visible = false;
                                                pictureBox7.Visible = false;
                                                pictureBox8.Visible = false;
                                                button1.Visible = false;
                                               
                                            }
                                        }
                                    }

                                }
                            }

                        }
                    }
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            can = 8;
            yeni++;
            button1.Enabled = true;
            label1.Text = "_";
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
            label5.Text = "_";
            label6.Text = "_";
            label1.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;
            label4.BackColor = Color.White;
            label5.BackColor = Color.White;
            label6.BackColor = Color.White;
        }

        
    }
}

