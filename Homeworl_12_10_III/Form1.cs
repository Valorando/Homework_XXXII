using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homeworl_12_10_III
{
    public partial class Form1 : Form
    {
        // Тело:
        private const int BodyRadius = 140;  // Радиус круга тела
             
        // Ноги:
        private const int FootWidth = 60;    // Ширина ноги
        private const int FootHeight = 100;  // Высота ноги
        private const int FootSpacing = -120;  // Расстояние между ногами
        private const int FeetOffset = 80;   // Смещение ног относительно центра тела

        // Руки:
        private const int HandWidth = 30;      // Ширина руки
        private const int HandHeight = 90;    // Высота руки
        private const int HandDistance = -20;   // Расстояние от центра тела до рук
        private const int HandHeightFromCenter = 130;   // Высота руки относительно центра тела

        // Уши:
        private const int EarRadius = 20;  // Радиус ушей
        private const int EarDistanceFromBody = 5;  // Расстояние от центра тела до ушей
        private const int EarHeightFromCenter = -60; // Высота ушей относительно центра тела

        // Белки глаз:
        private const int EyeRadius = 31;     // Радиус глаза
        private const int EyesOffset = 40;    // Расстояние между глазами
        private const int EyesHeightOffset = 30; // Высота глаз над телом

        // Зрачки глаз:
        private const int PupilRadius = 10;  // Радиус зрачка
        private const int PupilHeightOffset = 0;  // Смещение зрачка по высоте относительно центра тела
        private const int PupilHorizontalOffset = 3;  // Горизонтальное смещение зрачка относительно глаза

        // Рамки оправы очков:
        private const int GlassesLensRadius = 31;  // Радиус линз очков
        private const int GlassesLensDistance = 70;  // Расстояние между линзами
        private const int GlassesLensHeightOffset = 0;  // Смещение линз по высоте относительно центра тела

        // Дужки очков:
        private const float Line1StartX = 256;   // Начальная X-координата для первой линии
        private const float Line1StartY = 276;   // Начальная Y-координата для первой линии
        private const float Line1EndX = 233;    // Конечная X-координата для первой линии
        private const float Line1EndY = 248;    // Конечная Y-координата для первой линии

        private const float Line2StartX = 367;  // Начальная X-координата для второй линии
        private const float Line2StartY = 275;  // Начальная Y-координата для второй линии
        private const float Line2EndX = 449;    // Конечная X-координата для второй линии
        private const float Line2EndY = 247;    // Конечная Y-координата для второй линии
        private const int LineThickness = 5;    // Толщина линии

        // Рот:
        private const float Line3StartX = 275;   // Начальная X-координата для линии рта
        private const float Line3StartY = 373;   // Начальная Y-координата для  линии рта
        private const float Line3EndX = 350;    // Конечная X-координата для  линии рта
        private const float Line3EndY = 373;    // Конечная Y-координата для  линии рта
        private const int LineThickness1 = 3;    // Толщина линии рта

        // Иголки:
        private const int NeedleHeightFromCenter = -140;  // Высота центральной иглы
        private const int NeedleHeightFromCenter1 = -100;  // Высота левой и правой игл
        private const int NeedleSize = 170;               // Размер иглы
        private const int NeedleDistance = -120;  // Расстояние между левой и правой иглами

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            // Центральная игла
            Brush needleBrush = new SolidBrush(Color.Purple);
            float needleX = (ClientSize.Width - NeedleSize) / 2;
            float needleY = (ClientSize.Height - BodyRadius * 2) / 2 + NeedleHeightFromCenter;
            PointF[] needlePoints = new PointF[]
            {
                  new PointF(needleX, needleY + NeedleSize),                                        
                  new PointF(needleX + NeedleSize / 2, needleY),                                    
                  new PointF(needleX + NeedleSize, needleY + NeedleSize)                             
            };

            g.FillPolygon(needleBrush, needlePoints);



            // Левая игла
            float needle2X = needleX + NeedleSize + NeedleDistance;
            float needle2Y = (ClientSize.Height - BodyRadius * 2) / 2 + NeedleHeightFromCenter1;
            PointF[] needle2Points = new PointF[]
            {
                new PointF(needle2X, needle2Y + NeedleSize),  
                new PointF(needle2X + NeedleSize / 2, needle2Y),  
                new PointF(needle2X + NeedleSize, needle2Y + NeedleSize)  
            };
            g.FillPolygon(needleBrush, needle2Points);



            // Правая игла
            float needle3X = needleX - NeedleSize - NeedleDistance;
            float needle3Y = (ClientSize.Height - BodyRadius * 2) / 2 + NeedleHeightFromCenter1;
            PointF[] needle3Points = new PointF[]
            {
                new PointF(needle3X, needle3Y + NeedleSize),  
                new PointF(needle3X + NeedleSize / 2, needle3Y),  
                new PointF(needle3X + NeedleSize, needle3Y + NeedleSize)  
            };
            g.FillPolygon(needleBrush, needle3Points);



            // Тело
            Brush bodyBrush = new SolidBrush(Color.FromArgb(219, 58, 83));
            float bodyX = (ClientSize.Width - BodyRadius * 2) / 2;
            float bodyY = (ClientSize.Height - BodyRadius * 2) / 2;
            g.FillEllipse(bodyBrush, bodyX, bodyY, BodyRadius * 2, BodyRadius * 2);



            Brush feetBrush = new SolidBrush(Color.FromArgb(219, 58, 83));
            // Левая нога
            float leftFootX = (ClientSize.Width - BodyRadius * 2) / 2 - FootSpacing - FootWidth;
            float leftFootY = bodyY + BodyRadius + FeetOffset;
            g.FillRectangle(feetBrush, leftFootX, leftFootY, FootWidth, FootHeight);
            // Правая нога
            float rightFootX = (ClientSize.Width + BodyRadius * 2) / 2 + FootSpacing;
            float rightFootY = bodyY + BodyRadius + FeetOffset;
            g.FillRectangle(feetBrush, rightFootX, rightFootY, FootWidth, FootHeight);



            Brush handBrush = new SolidBrush(Color.FromArgb(219, 58, 83));
            // Левая рука
            float leftHandX = bodyX - HandWidth - HandDistance;
            float leftHandY = bodyY + (BodyRadius * 2 - HandHeightFromCenter);
            g.FillEllipse(handBrush, leftHandX, leftHandY, HandWidth, HandHeight);
            // Правая рука
            float rightHandX = bodyX + BodyRadius * 2 + HandDistance;
            float rightHandY = bodyY + (BodyRadius * 2 - HandHeightFromCenter);
            g.FillEllipse(handBrush, rightHandX, rightHandY, HandWidth, HandHeight);



            // Левое ухо
            float leftEarX = bodyX - EarDistanceFromBody;
            float leftEarY = bodyY - EarHeightFromCenter;
            g.FillEllipse(bodyBrush, leftEarX, leftEarY, EarRadius * 2, EarRadius * 2);
            // Правое ухо
            float rightEarX = bodyX + BodyRadius * 2 + EarDistanceFromBody - EarRadius * 2;
            float rightEarY = bodyY - EarHeightFromCenter;
            g.FillEllipse(bodyBrush, rightEarX, rightEarY, EarRadius * 2, EarRadius * 2);



            Brush eyesBrush = Brushes.White;
            // Левый глаз
            float leftEyeX = bodyX + BodyRadius - EyesOffset - EyeRadius;
            float leftEyeY = bodyY + BodyRadius - EyesHeightOffset;
            g.FillEllipse(eyesBrush, leftEyeX - EyeRadius, leftEyeY - EyeRadius, EyeRadius * 2, EyeRadius * 2);
            // Правй глаз
            float rightEyeX = bodyX + BodyRadius + EyesOffset - EyeRadius;
            float rightEyeY = bodyY + BodyRadius - EyesHeightOffset;
            g.FillEllipse(eyesBrush, rightEyeX - EyeRadius, rightEyeY - EyeRadius, EyeRadius * 2, EyeRadius * 2);



            Brush pupilBrush = Brushes.Black;
            // Левый зрачок
            float leftPupilX = leftEyeX + PupilHorizontalOffset;
            float leftPupilY = leftEyeY + PupilHeightOffset;
            g.FillEllipse(pupilBrush, leftPupilX - PupilRadius, leftPupilY - PupilRadius, PupilRadius * 2, PupilRadius * 2);
            // Правый зрачок
            float rightPupilX = rightEyeX + PupilHorizontalOffset;
            float rightPupilY = rightEyeY + PupilHeightOffset;
            g.FillEllipse(pupilBrush, rightPupilX - PupilRadius, rightPupilY - PupilRadius, PupilRadius * 2, PupilRadius * 2);



            Pen glassesPen = new Pen(Color.Black, 10);
            // Левая оправа для линзы
            float leftLensX = bodyX + BodyRadius - GlassesLensDistance / 2 - GlassesLensRadius;
            float leftLensY = bodyY + BodyRadius - GlassesLensHeightOffset - GlassesLensRadius;
            g.DrawEllipse(glassesPen, leftLensX - GlassesLensRadius, leftLensY - GlassesLensRadius, GlassesLensRadius * 2, GlassesLensRadius * 2);
            // Правая оправа для линзы
            float rightLensX = bodyX + BodyRadius + GlassesLensDistance / 2 - GlassesLensRadius;
            float rightLensY = bodyY + BodyRadius - GlassesLensHeightOffset - GlassesLensRadius;
            g.DrawEllipse(glassesPen, rightLensX - GlassesLensRadius, rightLensY - GlassesLensRadius, GlassesLensRadius * 2, GlassesLensRadius * 2);




            // Левая и правая дужки очков
            Pen linePen = new Pen(Color.Black, LineThickness);
            Pen linePen2 = new Pen(Color.Black, LineThickness1);
            g.DrawLine(linePen, Line1StartX, Line1StartY, Line1EndX, Line1EndY);
            g.DrawLine(linePen, Line2StartX, Line2StartY, Line2EndX, Line2EndY);



            // Рот
            g.DrawLine(linePen2, Line3StartX, Line3StartY, Line3EndX, Line3EndY);
        }


        // Это использовал для получения координат пикселя, чтобы потом провести по ним линии
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = PointToClient(MousePosition);
            int x = point.X;
            int y = point.Y;


            label1.Text = x.ToString();
            label2.Text = y.ToString();

        }
    }
}
