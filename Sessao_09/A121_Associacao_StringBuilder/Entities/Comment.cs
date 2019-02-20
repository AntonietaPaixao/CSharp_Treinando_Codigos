using System;
using System.Collections.Generic;
using System.Text;

namespace A121_Associacao_StringBuilder.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment()
        {
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
