using System;
using System.Collections.Generic;

namespace DietMap.Client.BindingModels
{
    public class AppointmentList
    {
        public List<Appointment> AppointmentsList { get; set; }
    }

    public class Appointment
    {
        public List<string> Notes { get; set; }
        public DateTime Date { get; set; }
        public int AppointmentNumber { get; set; }
        public Measurements Measurements { get; set; }

    }
    public class Measurements
    {
        public decimal Weight { get; set; }
        public decimal BMI { get; set; }
        public decimal BodyFat { get; set; }
        public double BMR { get; set; }
        public decimal BodyWater { get; set; }
        public decimal MuscleMass { get; set; }
        public int MetabolicAge { get; set; }
        public decimal VisceralFat { get; set; }
        public decimal BoneMass { get; set; }
        public int MuscleQuality { get; set; }
        public int PhysiqueRating { get; set; }
    }
}
