﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
   public class MedicalHistory
    {
        string allergies;
        string heartDisease;
        string bloodPressure;

        public MedicalHistory(string allergies, string heartDisease, string bloodPressure)
        {
            this.allergies = allergies;
            this.heartDisease = heartDisease;
            this.bloodPressure = bloodPressure;
        }

        public MedicalHistory()
        {
            this.allergies = null;
            this.heartDisease = null;
            this.bloodPressure = null;
        }

        public string Allergies { get => allergies; set => allergies = value; }
        public string HeartDisease { get => heartDisease; set => heartDisease = value; }
        public string BloodPressure { get => bloodPressure; set => bloodPressure = value; }

        public override string ToString()
        {
            return "Medical History: " + allergies;
        }

    }
}
