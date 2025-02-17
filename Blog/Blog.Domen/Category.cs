﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Domain
{
    public class Category : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<CategoryPost> CategoryPosts { get; set; } = new HashSet<CategoryPost>();
    }
}
