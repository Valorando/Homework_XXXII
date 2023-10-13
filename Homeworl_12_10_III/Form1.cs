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
        private const int BodyRadius = 140;  // Радиус круга тела
                             
        
        private const int FootWidth = 60;    // Ширина ноги
        private const int FootHeight = 100;  // Высота ноги
        private const int FootSpacing = -120;  // Расстояние между ногами
        private const int FeetOffset = 80;   // Смещение ног относительно центра тела


        private const int HandWidth = 30;      // Ширина руки
        private const int HandHeight = 90;    // Высота руки
        private const int HandDistance = -20;   // Расстояние от центра тела до рук
        private const int HandHeightFromCenter = 130;   // Высота руки относительно центра тела


        private const int EarRadius = 20;  // Радиус ушей
        private const int EarDistanceFromBody = 5;  // Расстояние от центра тела до ушей
        private const int EarHeightFromCenter = -60; // Высота ушей относительно центра тела


        private const int EyeRadius = 31;     // Радиус глаза
        private const int EyesOffset = 40;    // Расстояние между глазами
        private const int EyesHeightOffset = 30; // Высота глаз над телом


        private const int PupilRadius = 10;  // Радиус зрачка
        private const int PupilHeightOffset = 0;  // Смещение зрачка по высоте относительно центра тела
        private const int PupilHorizontalOffset = 3;  // Горизонтальное смещение зрачка относительно глаза


        private const int GlassesLensRadius = 31;  // Радиус линз очков
        private const int GlassesLensDistance = 70;  // Расстояние между линзами
        private const int GlassesLensHeightOffset = 0;  // Смещение линз по высоте относительно центра тела

        private const float Line1StartX = 256;   // Начальная X-координата для первой линии
        private const float Line1StartY = 276;   // Начальная Y-координата для первой линии
        private const float Line1EndX = 233;    // Конечная X-координата для первой линии
        private const float Line1EndY = 248;    // Конечная Y-координата для первой линии

        private const float Line2StartX = 367;  // Начальная X-координата для второй линии
        private const float Line2StartY = 275;  // Начальная Y-координата для второй линии
        private const float Line2EndX = 449;    // Конечная X-координата для второй линии
        private const float Line2EndY = 247;    // Конечная Y-координата для второй линии

        private const int LineThickness = 5;    // Толщина линии

        private const float Line3StartX = 275;   // Начальная X-координата для линии рта
        private const float Line3StartY = 373;   // Начальная Y-координата для  линии рта
        private const float Line3EndX = 350;    // Конечная X-координата для  линии рта
        private const float Line3EndY = 373;    // Конечная Y-координата для  линии рта

        private const int LineThickness1 = 3;    // Толщина линии рта

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Цвет тела (малиновый)
            Brush bodyBrush = new SolidBrush(Color.FromArgb(219, 58, 83));

            // Рисуем тело (круг)
            float bodyX = (ClientSize.Width - BodyRadius * 2) / 2;
            float bodyY = (ClientSize.Height - BodyRadius * 2) / 2;
            g.FillEllipse(bodyBrush, bodyX, bodyY, BodyRadius * 2, BodyRadius * 2);

            // Цвет ног (малиновый)
            Brush feetBrush = new SolidBrush(Color.FromArgb(219, 58, 83));

            // Рисуем левую ногу (прямоугольник)
            float leftFootX = (ClientSize.Width - BodyRadius * 2) / 2 - FootSpacing - FootWidth;
            float leftFootY = bodyY + BodyRadius + FeetOffset;
            g.FillRectangle(feetBrush, leftFootX, leftFootY, FootWidth, FootHeight);

            // Рисуем правую ногу (прямоугольник)
            float rightFootX = (ClientSize.Width + BodyRadius * 2) / 2 + FootSpacing;
            float rightFootY = bodyY + BodyRadius + FeetOffset;
            g.FillRectangle(feetBrush, rightFootX, rightFootY, FootWidth, FootHeight);

            // Цвет рук (малиновый)
            Brush handBrush = new SolidBrush(Color.FromArgb(219, 58, 83));

            // Рисуем левую руку (эллипс)
            float leftHandX = bodyX - HandWidth - HandDistance;
            float leftHandY = bodyY + (BodyRadius * 2 - HandHeightFromCenter);
            g.FillEllipse(handBrush, leftHandX, leftHandY, HandWidth, HandHeight);

            // Рисуем правую руку (эллипс)
            float rightHandX = bodyX + BodyRadius * 2 + HandDistance;
            float rightHandY = bodyY + (BodyRadius * 2 - HandHeightFromCenter);
            g.FillEllipse(handBrush, rightHandX, rightHandY, HandWidth, HandHeight);

            // Рисуем левое ухо (круг)
            float leftEarX = bodyX - EarDistanceFromBody;
            float leftEarY = bodyY - EarHeightFromCenter;
            g.FillEllipse(bodyBrush, leftEarX, leftEarY, EarRadius * 2, EarRadius * 2);

            // Рисуем правое ухо (круг)
            float rightEarX = bodyX + BodyRadius * 2 + EarDistanceFromBody - EarRadius * 2;
            float rightEarY = bodyY - EarHeightFromCenter;
            g.FillEllipse(bodyBrush, rightEarX, rightEarY, EarRadius * 2, EarRadius * 2);

            Brush eyesBrush = Brushes.White;

            // Рисуем левый глаз (круг)
            float leftEyeX = bodyX + BodyRadius - EyesOffset - EyeRadius;
            float leftEyeY = bodyY + BodyRadius - EyesHeightOffset;
            g.FillEllipse(eyesBrush, leftEyeX - EyeRadius, leftEyeY - EyeRadius, EyeRadius * 2, EyeRadius * 2);

            // Рисуем правый глаз (круг)
            float rightEyeX = bodyX + BodyRadius + EyesOffset - EyeRadius;
            float rightEyeY = bodyY + BodyRadius - EyesHeightOffset;
            g.FillEllipse(eyesBrush, rightEyeX - EyeRadius, rightEyeY - EyeRadius, EyeRadius * 2, EyeRadius * 2);

            Brush pupilBrush = Brushes.Black;

            // Рисуем левый зрачок (круг)
            float leftPupilX = leftEyeX + PupilHorizontalOffset;
            float leftPupilY = leftEyeY + PupilHeightOffset;
            g.FillEllipse(pupilBrush, leftPupilX - PupilRadius, leftPupilY - PupilRadius, PupilRadius * 2, PupilRadius * 2);

            // Рисуем правый зрачок (круг)
            float rightPupilX = rightEyeX + PupilHorizontalOffset;
            float rightPupilY = rightEyeY + PupilHeightOffset;
            g.FillEllipse(pupilBrush, rightPupilX - PupilRadius, rightPupilY - PupilRadius, PupilRadius * 2, PupilRadius * 2);

            Pen glassesPen = new Pen(Color.Black, 10);

            // Рисуем левую линзу (круг)
            float leftLensX = bodyX + BodyRadius - GlassesLensDistance / 2 - GlassesLensRadius;
            float leftLensY = bodyY + BodyRadius - GlassesLensHeightOffset - GlassesLensRadius;
            g.DrawEllipse(glassesPen, leftLensX - GlassesLensRadius, leftLensY - GlassesLensRadius, GlassesLensRadius * 2, GlassesLensRadius * 2);

            // Рисуем правую линзу (круг)
            float rightLensX = bodyX + BodyRadius + GlassesLensDistance / 2 - GlassesLensRadius;
            float rightLensY = bodyY + BodyRadius - GlassesLensHeightOffset - GlassesLensRadius;
            g.DrawEllipse(glassesPen, rightLensX - GlassesLensRadius, rightLensY - GlassesLensRadius, GlassesLensRadius * 2, GlassesLensRadius * 2);

            Pen linePen = new Pen(Color.Black, LineThickness);
            Pen linePen2 = new Pen(Color.Black, LineThickness1);

            // Рисуем первую линию
            g.DrawLine(linePen, Line1StartX, Line1StartY, Line1EndX, Line1EndY);

            // Рисуем вторую линию
            g.DrawLine(linePen, Line2StartX, Line2StartY, Line2EndX, Line2EndY);

            // Рисуем рот
            g.DrawLine(linePen2, Line3StartX, Line3StartY, Line3EndX, Line3EndY);
        }

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
