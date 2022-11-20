namespace Jul.Forms
{
    public static class CustomTabRender
    {
        public static void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            var appTabs = sender as TabControl;

            Graphics g = e.Graphics;
            Brush _textBrush;
            

            // Get the item from the collection.
            TabPage _tabPage = appTabs.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = appTabs.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Tan, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 17.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }
    }
}
