﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFurnitureProject.Application.ViewModels.AppointmentViewModel
{
    public  class CreateAppointmentDTO
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
      
        public int Time { get; set; }
    }
}
