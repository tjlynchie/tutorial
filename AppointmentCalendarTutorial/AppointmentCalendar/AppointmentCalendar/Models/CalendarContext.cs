using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AppointmentCalendar.Models
{
    public class CalendarContext : DbContext
    {
        public CalendarContext()
            : base()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CalendarContext>());
        }
        public System.Data.Entity.DbSet<AppointmentCalendar.Models.Appointment> Appointments { get; set; }
    }
}
