using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Utilities
{
    public static class CheckedListBoxHelper
    {
        public static int GetMaxItemWidth(CheckedListBox checkedListBox)
        {
            using (Graphics graphics = checkedListBox.CreateGraphics())
            {
                int maxWidth = 0;

                foreach (var item in checkedListBox.Items)
                {
                    string text = item.ToString();
                    SizeF size = graphics.MeasureString(text, checkedListBox.Font);
                    int width = (int)size.Width + 25;

                    if (width > maxWidth)
                    {
                        maxWidth = width;
                    }
                }

                return maxWidth;
            }
        }

        public static void SetItemsChecked<T>(CheckedListBox checkedListBox, Func<T, bool> shouldBeChecked) 
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.Items[i] is T item)
                {
                    checkedListBox.SetItemChecked(i, shouldBeChecked(item));
                }
            }
        }
    }
}
