using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_12_10
{
    public partial class Form1 : Form
    {
        private const int BoardSize = 8;
        private const int SquareSize = 50;
        private int boardWidth = BoardSize * SquareSize;
        private int boardHeight = BoardSize * SquareSize;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            int x = (ClientSize.Width - boardWidth) / 2;
            int y = (ClientSize.Height - boardHeight) / 2;

            using (SolidBrush whiteBrush = new SolidBrush(Color.AntiqueWhite))
            using (SolidBrush blackBrush = new SolidBrush(Color.SaddleBrown))
            {
                for (int i = 0; i < BoardSize; i++)
                {
                    for (int j = 0; j < BoardSize; j++)
                    {
                        x = j * SquareSize + (ClientSize.Width - boardWidth) / 2;
                        y = i * SquareSize + (ClientSize.Height - boardHeight) / 2;

                        
                        Brush brush = ((i + j) % 2 == 0) ? whiteBrush : blackBrush;

                        
                        e.Graphics.FillRectangle(brush, x, y, SquareSize, SquareSize);
                    }
                }
            }

            Pen borderPen = new Pen(Color.Black, 3);
            e.Graphics.DrawRectangle(borderPen,
                (ClientSize.Width - boardWidth) / 2 - SquareSize,
                (ClientSize.Height - boardHeight) / 2 - SquareSize,
                boardWidth + 2 * SquareSize,
                boardHeight + 2 * SquareSize);

            Font font = new Font("Arial", 12);
            Brush textBrush = Brushes.Black;
            for (int i = 0; i < BoardSize; i++)
            {
                char upperChar = (char)('A' + i);
                char lowerChar = (char)('A' + i);
                e.Graphics.DrawString(upperChar.ToString(), font, textBrush,
                    i * SquareSize + (ClientSize.Width - boardWidth) / 2 + SquareSize / 2 - 10,
                    (ClientSize.Height - boardHeight) / 2 - SquareSize / 2 - 20);

                e.Graphics.DrawString(lowerChar.ToString(), font, textBrush,
                    i * SquareSize + (ClientSize.Width - boardWidth) / 2 + SquareSize / 2 - 10,
                    (ClientSize.Height + boardHeight) / 2 + SquareSize / 2);

                e.Graphics.DrawString((BoardSize - i).ToString(), font, textBrush,
                (ClientSize.Width - boardWidth) / 2 - SquareSize / 2 - 20,
                i * SquareSize + (ClientSize.Height - boardHeight) / 2 + SquareSize / 2 - 10);

                e.Graphics.DrawString((BoardSize - i).ToString(), font, textBrush,
                    (ClientSize.Width + boardWidth) / 2 + SquareSize / 2,
                    i * SquareSize + (ClientSize.Height - boardHeight) / 2 + SquareSize / 2 - 10);
            }
        }
    }


}
