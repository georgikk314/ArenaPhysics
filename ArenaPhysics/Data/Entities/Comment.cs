﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ArenaPhysics.Data.Entities
{
    public class Comment : BaseEntity
    {
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        [ForeignKey(nameof(Problem))]
        public int ProblemId { get; set; }
        public string Content { get; set; }
        public virtual List<User>? Users { get; set; }
        public virtual List<Problem>? Problems { get; set; }

    }
}
