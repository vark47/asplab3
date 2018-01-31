using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;
namespace FanSite.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public RedirectToActionResult ReceiveForm(int q1, int q2, int q3, int q4, int q5)
        {
            TempData["q1"] = q1;
            TempData["q2"] = q2;
            TempData["q3"] = q3;
            TempData["q4"] = q4;
            TempData["q5"] = q5;
           
            return RedirectToAction(nameof(Data));

        }
        public ViewResult Data()
        {
            string q1Ans = "";
            string q2Ans = "";
            string q3Ans = "";
            string q4Ans = "";
            string q5Ans = "";

            int correctAns = 0;


            int q1 = int.Parse(TempData["q1"].ToString());
            int q2 = int.Parse(TempData["q2"].ToString());
            int q3 = int.Parse(TempData["q3"].ToString());
            int q4 = int.Parse(TempData["q4"].ToString());
            int q5 = int.Parse(TempData["q5"].ToString());

            if(q1 == 24)
            {
                q1Ans = "Question 1 was correct!";
                correctAns++;
            }
            else
            {
                q1Ans = "Question 1 was incorrect";
            }

            if (q2 == 1993)
            {
                q2Ans = "Question 2 was correct!";
                correctAns++;
            }
            else
            {
                q2Ans = "Question 2 was incorrect";
            }
            if (q3 == 1)
            {
                q3Ans = "Question 3 was correct!";
                correctAns++;
            }
            else
            {
                q3Ans = "Question 3 was incorrect";
            }

            if (q4 == 2)
            {
                q4Ans = "Question 4 was correct!";
                correctAns++;
            }
            else
            {
                q4Ans = "Question 4 was incorrect";
            }
            if (q5 == 1)
            {
                q5Ans = "Question 5 was correct!";
                correctAns++;
            }
            else
            {
                q5Ans = "Question 5 was incorrect";
            }



            return View("QuizResults", $"{q1Ans},{q2Ans},{q3Ans},{q4Ans},{q5Ans} Total Questions Answered Correctly: {correctAns}");
        }
    }
}
