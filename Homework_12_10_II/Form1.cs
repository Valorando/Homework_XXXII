using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_12_10_II
{
    public partial class Form1 : Form
    {

        private float rect_x;
        private float rect_y;
        private float rect_w;
        private float rect_h;

        private float line_x1;
        private float line_y1;
        private float line_x2;
        private float line_y2;

        private float bezier_x1;
        private float bezier_y1;
        private float bezier_x2;
        private float bezier_y2;
        private float bezier_x3;
        private float bezier_y3;
        private float bezier_x4;
        private float bezier_y4;

        private float ellipse_center_x;
        private float ellipse_center_y;
        private float ellipse_w;
        private float ellipse_h;

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void AttachEventHandlers()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).KeyPress += NumericTextBox_KeyPress;
                }
            }
        }

        private bool isEditingFigure = false;

        public Form1()
        {
            InitializeComponent();
            AttachEventHandlers();
            label1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;

            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;

            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;

            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = false;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "BMP Image|*.bmp";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);

                   
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        
                        Rectangle rect = panel1.RectangleToScreen(panel1.ClientRectangle);
                        g.CopyFromScreen(rect.Location, Point.Empty, panel1.Size);
                    }

                    
                    bmp.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (isEditingFigure)
            {
                MessageBox.Show("Завершите редактирование текущей фигуры перед редактированием другой.");
                return;
            }

            label1.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            button2.Visible = true;

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

            label2.Text = "X1:";
            label3.Text = "Y1:";
            label4.Text = "X2";
            label5.Text = "Y2";

            isEditingFigure = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (isEditingFigure)
            {
                MessageBox.Show("Завершите редактирование текущей фигуры перед редактированием другой.");
                return;
            }

            label1.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
            textBox15.Visible = true;
            textBox16.Visible = true;
            button3.Visible = true;

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;

            label2.Text = "X1:";
            label3.Text = "Y1:";
            label4.Text = "X2";
            label5.Text = "Y2";
            label6.Text = "X3:";
            label7.Text = "Y3:";
            label8.Text = "X4:";
            label9.Text = "Y4:";

            isEditingFigure = true;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (isEditingFigure)
            {
                MessageBox.Show("Завершите редактирование текущей фигуры перед редактированием другой.");
                return;
            }

            label1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            button1.Visible = true;

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

            label2.Text = "X:";
            label3.Text = "Y:";
            label4.Text = "W:";
            label5.Text = "H:";

            isEditingFigure = true;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (isEditingFigure)
            {
                MessageBox.Show("Завершите редактирование текущей фигуры перед редактированием другой.");
                return;
            }

            label1.Visible = true;
            textBox17.Visible = true;
            textBox18.Visible = true;
            textBox19.Visible = true;
            textBox20.Visible = true;
            button4.Visible = true;

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

            label2.Text = "X:";
            label3.Text = "Y:";
            label4.Text = "W:";
            label5.Text = "H:";

            isEditingFigure = true;
        }

        private void FinishEditing()
        {
            isEditingFigure = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button1.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            rect_x = float.Parse(textBox1.Text);
            rect_y = float.Parse(textBox2.Text);
            rect_w = float.Parse(textBox3.Text);
            rect_h = float.Parse(textBox4.Text);

            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, rect_x, rect_y, rect_w, rect_h);

            FinishEditing();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            button2.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            line_x1 = float.Parse(textBox5.Text);
            line_y1 = float.Parse(textBox6.Text);
            line_x2= float.Parse(textBox7.Text);
            line_y2 = float.Parse(textBox8.Text);

            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, line_x1, line_y1, line_x2, line_y2);

            FinishEditing();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            button3.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            bezier_x1 = float.Parse(textBox9.Text);
            bezier_y1 = float.Parse(textBox10.Text);
            bezier_x2 = float.Parse(textBox11.Text);
            bezier_y2 = float.Parse(textBox12.Text);
            bezier_x3 = float.Parse(textBox13.Text);
            bezier_y3 = float.Parse(textBox14.Text);
            bezier_x4 = float.Parse(textBox15.Text);
            bezier_y4 = float.Parse(textBox16.Text);

            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            g.DrawBezier(pen,bezier_x1,bezier_y1,bezier_x2,bezier_y2,bezier_x3,bezier_y3,bezier_x4,bezier_y4 );

            FinishEditing();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = false;
            button4.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            ellipse_center_x = float.Parse(textBox17.Text);
            ellipse_center_y = float.Parse(textBox18.Text);
            ellipse_w = float.Parse(textBox19.Text);
            ellipse_h = float.Parse(textBox20.Text);

            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            RectangleF rect = new RectangleF(ellipse_center_x, ellipse_center_y, ellipse_w, ellipse_h);
            g.DrawEllipse(pen, rect);

            FinishEditing();
        }
    }
}
