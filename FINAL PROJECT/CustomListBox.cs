using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public class CustomListBox : ListBox
    {
        private int lineHeight = 40; // Adjust as needed

        public CustomListBox()
        {
            // Enable owner drawing
            this.DrawMode = DrawMode.OwnerDrawFixed;
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            // Set the height of each item
            e.ItemHeight = lineHeight;
            base.OnMeasureItem(e);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // Ensure we have a valid index
            if (e.Index >= 0 && e.Index < this.Items.Count)
            {
                // Draw the background
                e.DrawBackground();

                // Get the item text
                string text = this.Items[e.Index].ToString();

                // Create a rectangle to draw the text
                Rectangle textRect = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);

                // Draw the item text with the specified line height
                TextRenderer.DrawText(e.Graphics, text, this.Font, textRect, this.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                // Draw the focus rectangle if the item has focus
                e.DrawFocusRectangle();
            }
            else
            {
                // Draw the default item
                base.OnDrawItem(e);
            }
        }

        // Allow customization of the line height
        public int LineHeight
        {
            get { return lineHeight; }
            set { lineHeight = value; }
        }
    }
}
