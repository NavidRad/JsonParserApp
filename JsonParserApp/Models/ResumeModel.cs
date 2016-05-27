using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonParserApp.Models
{
    public class ResumeModel
    {
        public List<BasicModel> Basics { get; set; }
        public List<WorkModel> Works { get; set; }
        public List<EducationModel> Educations { get; set; }
        public List<SkillModel> Skills { get; set; }
        public List<OrganizationalSkillModel> OrganizationalSkills { get; set; }
        public List<LanguageModel> Languages { get; set; }
    }
}