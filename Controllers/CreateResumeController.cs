using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using register.Data;
using register.Models.ViewModel;
using register.Models;
using register.Models.ViewModel.ResumeSections;

namespace register.Controllers
{
    public class CreateResumeController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        public CreateResumeController(UserManager<ApplicationUser> userManager,
                                 SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            SignInManager = signInManager;
        }

        public SignInManager<ApplicationUser> SignInManager { get; set; }

        [HttpGet]
        public IActionResult Resume()
        {

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Resume(ResumeDetail model)
                {
           
            if (ModelState.IsValid)
            {

                var user = await userManager.GetUserAsync(User);


                if (user != null)
                {
                    // Assign the personal details to the user
                    user.Name = model.Name;
                    user.Tagline = model.Tagline;
                    user.MobileNumber = model.MobileNumber;
                    user.City = model.City;
                    user.UserEmail = model.UserEmail;
                    
                    user.LinkedIn = model.LinkedIn;
                    user.Github = model.Github;
                    user.LeetCode = model.LeetCode;

                    user.CareerObjective = model.CareerObjective;

                    user.College = model.College;
                    user.PassingYear = model.PassingYear;
                    user.Course = model.Course;
                    user.CGPA = model.CGPA;

                    user.dCollege = model.dCollege;
                    user.dCourse = model.dCourse;
                    user.dPassingYear = model.dPassingYear;
                    user.dPercetange = model.dPercetange;

                    user.school = model.school;
                    user.SchoolPassingYear = model.SchoolPassingYear;
                    user.SchoolPercentage = model.SchoolPercentage;

                    user.ProjectTitle = model.ProjectTitle;
                    user.TechStack  = model.TechStack;
                    user.ProjectDescription = model.ProjectDescription;
                    user.ProjectLink = model.ProjectLink;

                    user.Project2Title = model.Project2Title;
                    user.Project2TechStack = model.Project2TechStack;
                    user.Project2Description = model.Project2Description;
                    user.Project2Link = model.Project2Link;

                    user.Project3Title = model.Project3Title;
                    user.Project3TechStack = model.Project3TechStack;
                    user.Project3Description = model.Project3Description;
                    user.Project3Link = model.Project3Link;



                    user.AchievedName = model.AchievedName;
                    user.AchievementDesc = model.AchievementDesc;

                    user.Achievement2Title = model.Achievement2Title;
                    user.Achievement2Desc = model.Achievement2Desc;

                    user.CourseTitle = model.CourseTitle;
                    user.IssuedBy = model.IssuedBy;

                    user.Course2Title = model.Course2Title;
                    user.Course2IssuedBy = model.Course2IssuedBy;

                    user.Language = model.Language;
                    user.FrontEnd = model.FrontEnd;
                    user.Database= model.Database;
                    user.FamaliarWith  = model.FamaliarWith;

                    // Update the user
                    var result = await userManager.UpdateAsync(user);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("ShowResume", "Show"); // Redirect to a suitable page
                    }
                 
                }
                else
                {
                    ModelState.AddModelError("", "User not found");
                }
            }

            return View(model);

        }
    }
}
    
