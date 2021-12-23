﻿using Domain.Common;


namespace Domain.Models
{
    public class Employer : BaseEntitiy
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Company Company { get; set; }
    }
}
