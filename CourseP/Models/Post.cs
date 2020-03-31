using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Post
    {
        private int id;
        private string name;

        public Post(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

        public override bool Equals(object obj)
        {
            return obj is Post post &&
                   id == post.id &&
                   name == post.name;
        }
    }
}
