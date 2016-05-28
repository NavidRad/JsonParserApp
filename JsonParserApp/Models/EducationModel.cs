using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonParserApp.Models
{
    public class EducationModel
    {
        public string Institution { get; set; }
        public string FieldOfStudy { get; set; }
        public string StudyLevel { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public float Gpa { get; set; }
        public string ThesisTitle { get; set; }
    }
}