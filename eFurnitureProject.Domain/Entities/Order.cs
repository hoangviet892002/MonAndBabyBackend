﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFurnitureProject.Domain.Entities
{
    public class Order : BaseEntity
    {
        public DateTime DateTime { get; set; }
        public int Price { get; set; }
        public Guid? StatusId { get; set; }
        [ForeignKey("StatusId")]
        public StatusOrder? StatusOrder { get; set; }
        public Guid? TransactionId { get; set; }
        [ForeignKey("TransactionId")]
        public Transaction? Transaction { get; set; }
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }

        public virtual ICollection<OrderDetail>? OrderDetail { get; set; }


    }
}
