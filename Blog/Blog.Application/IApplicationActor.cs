﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application
{
    public interface IApplicationActor
    {
        public int Id { get; }
        public string Identity { get; }
        public IEnumerable<int> AllowedUseCases { get; }
    }
}
