using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace Assistente_Virtual.Design
{
    class RoundedProgrees:UserControl
    {
        //Fields
        float val = 0, max = 100;
        int barSize = 9;
        Color barColor = Color.DeepSkyBlue, circleBackColor = Color.Black,TextColor = Color.White;
        
        //Properties
        [Category("Progress Values")]
        public float Value
        {
            get { return val; }
            set
            {
                val =  (value > max)? max :value;
                Invalidate();
            }
        }
        [Category("Progress Values")]
        public float Max
        {
            get { return max; }
            set { max = value;Invalidate(); }
        }
        [Category("Progress Values")]
        public int BarSize
        {
            get { return barSize; }
            set { barSize = value;Invalidate(); }
        }
        [Category("Progress Circle Colors")]
        public Color BarColor
        {
            get { return barColor; }
            set { barColor = value;Invalidate(); }
        }
        [Category("Progress Circle Colors")]
        public Color CircleBackColor
        {
            get { return circleBackColor; }
            set { circleBackColor = value; }
        }

        //Constructors
        public RoundedProgrees()
        {
            DoubleBuffered = true;
        }
        //Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int va = (int)((val * 100)/ max);
            //Creating a new pen 
            Pen pen = new Pen(barColor, barSize) { StartCap = LineCap.Round, EndCap = LineCap.Round };

            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            //Paiting the circle
            g.FillPie(new SolidBrush(circleBackColor), new Rectangle(10, 10, Width - 20, Height - 20), 0, 360);
            g.DrawArc(pen, new Rectangle(5, 5, Width - 10, Height - 10), -90,(val/max)*360);

            //Show the percent
            StringFormat sf = new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center };
            g.DrawString(va+"%",Font,new SolidBrush(TextColor),ClientRectangle,sf);
            base.OnPaint(e);

        }

        protected override void OnResize(EventArgs e)
        {
            Height = Width;
            base.OnResize(e);
        }
    }
}
