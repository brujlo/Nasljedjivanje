using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nasljeđivanje
{
    class TextBoxWithDefault : TextBox
    {
        public TextBoxWithDefault()
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            if (TextLength == 0)
                DrawDefaultText(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            SetStyle(ControlStyles.UserPaint, true);
            if (TextLength == 0)
                Invalidate();
        }

        private void DrawDefaultText(PaintEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics, defaultText, Font, new Point(-2, 1), SystemColors.GrayText, TextFormatFlags.TextBoxControl);
            //using (Brush brush = new SolidBrush(SystemColors.GrayText))
            //    e.Graphics.DrawString(defaultText, Font, brush, 0, 0);
            //ggggg

        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetStyle(ControlStyles.UserPaint, true);
        }

        private string defaultText = "Podrazumjevana vrijednost";
    }
}
