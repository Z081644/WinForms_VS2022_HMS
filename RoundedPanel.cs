using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class RoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 30;

        public RoundedPanel()
        {
            // Improve rendering and support transparent backgrounds if needed
            SetStyle(ControlStyles.UserPaint
                     | ControlStyles.AllPaintingInWmPaint
                     | ControlStyles.OptimizedDoubleBuffer
                     | ControlStyles.ResizeRedraw
                     | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = GetRoundedPath(ClientRectangle, BorderRadius))
            {
                // Fill background using BackColor so the panel looks correct in Designer/runtime
                using (Brush brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Apply region so child controls are clipped to rounded shape
                Region?.Dispose();
                Region = new Region(path);
            }
        }

        private static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            int diameter = radius * 2;
            Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));

            // top-left
            arc.Location = new Point(rect.Left, rect.Top);
            path.AddArc(arc, 180, 90);

            // top-right
            arc.Location = new Point(rect.Right - diameter, rect.Top);
            path.AddArc(arc, 270, 90);

            // bottom-right
            arc.Location = new Point(rect.Right - diameter, rect.Bottom - diameter);
            path.AddArc(arc, 0, 90);

            // bottom-left
            arc.Location = new Point(rect.Left, rect.Bottom - diameter);
            path.AddArc(arc, 90, 90);

            path.CloseAllFigures();
            return path;
        }
    }
}
