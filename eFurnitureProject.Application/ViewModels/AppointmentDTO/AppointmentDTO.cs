﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFurnitureProject.Application.ViewModels.AppointmentDTO
{
    public class AppointmentDTO
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int Status { get; set; }
        public int Time { get; set; }
        public Guid? CreatedBy { get; set; }
        public ICollection<AppointmentParticipantDTO> Participants { get; set; }
    }
}
