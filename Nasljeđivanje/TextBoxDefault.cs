using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nasljeđivanje
{
    class TextBoxDefault : TextBox
    {
        public TextBoxDefault()
        {
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetStyle(ControlStyles.UserPaint, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            
            base.OnPaint(e);
            if (TextLength == 0)
            {
                DrawDefaultText(e);
            }
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            SetStyle(ControlStyles.UserPaint, TextLength==0);
            if (TextLength == 0)
            {
                Invalidate();
            }
        }

        private void DrawDefaultText(PaintEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics, defaultText,Font, new Point(-2, 1), SystemColors.GrayText, TextFormatFlags.TextBoxControl);
            //using (Brush brush = new SolidBrush(SystemColors.GrayText))
            //e.Graphics.DrawString(defaultText, Font, brush,0,0);
        }
        private string defaultText = "Podrazumijevana vrijednost";
    }
}
