using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace register.Models
{
    public class ApplicationUser: IdentityUser
    {

        //personalDetail
     
        public string? Name { get; set; }

        public string? Tagline { get; set; }

        public string? MobileNumber { get; set; }
    
        public string? City { get; set; }


        public string? UserEmail { get; set; }


        //socialMedia

      
        public string? LinkedIn { get; set; }
  
        public string? Github { get; set; }
 
        public string? LeetCode { get; set; }

        //CareerObjective
      
        public string? CareerObjective { get; set; }

        //EducationDetails


        public string? College { get; set; }
    
        public string? Course { get; set; }

        public string? PassingYear { get; set; }
      
        public string? CGPA { get; set; }


        //diploma/12
     
        public string? dCollege { get; set; }
     
        public string? dCourse { get; set; }

        public string? dPassingYear { get; set; }
    
        public string? dPercetange { get; set; }

        //10th

        public string? school { get; set; }
   
        public string? SchoolPassingYear { get; set; }
    
        public string? SchoolPercentage { get; set; }


        //projects
     

        public string? ProjectTitle { get; set; }
        public string? TechStack { get; set; }
   
        public string? ProjectLink { get; set; }
     
        public string? ProjectDescription { get; set; }

        //project2

        public string? Project2Title { get; set; }
        public string? Project2TechStack { get; set; }

        public string? Project2Link { get; set; }

        public string? Project2Description { get; set; }

        //project3

        public string? Project3Title { get; set; }
        public string? Project3TechStack { get; set; }

        public string? Project3Link { get; set; }

        public string? Project3Description { get; set; }

        //Achievement

        public string? AchievedName { get; set; }
     
        public string? AchievementDesc { get; set; }


        //Achievement2

        public string? Achievement2Title { get; set; }

        public string? Achievement2Desc { get; set; }


        //course

        public string? CourseTitle { get; set; }
       
        public string? IssuedBy { get; set; }
        //course 2
        public string? Course2Title { get; set; }

        public string? Course2IssuedBy { get; set; }

        //technicalskill

        public string? Language { get; set; }
    
        public string? FrontEnd { get; set; }
      
        public string? Database { get; set; }
      
        public string? FamaliarWith { get; set; }



    }
}
