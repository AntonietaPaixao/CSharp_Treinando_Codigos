using System;
using System.Collections.Generic;
using System.Text;

namespace A121_Associacao_StringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComments(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComments(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine(Title);
            st.Append(Likes);
            st.Append(" Likes - ");
            st.AppendLine(Moment.ToString("dd/MM/yy HH:mm:ss") );
            st.Append(Content);
            st.AppendLine("Comments:");

            foreach (Comment com in Comments)
            {
                st.AppendLine(com.Text);
            }
                     return st.ToString();
        }
    }
}

