
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using WildcatMicroFund.Data.Context;
using WildcatMicroFund.Data.Models;

namespace WildcatMicroFund.Controllers
{
    public class TakeSurveyViewModelPOC : Controller
    {
        private readonly WildcatMicroFundDatabaseContext _context;

        public TakeSurveyViewModelPOC(WildcatMicroFundDatabaseContext context)
        {
            _context = context;
        }

        // GET: SurveyPOC
        public async Task<IActionResult> Index()
        {
            var wildcatMicroFundDatabaseContext = _context.SurveyCodes;
            return View(await wildcatMicroFundDatabaseContext.ToListAsync());
        }

        //GET: SurveyPOC/TakeSurvey/ID
        public async Task<IActionResult> TakeSurvey(int id)
        {
            var surveyContents = _context.SurveyCodes
                .Include(sc => sc.Questions)
                .ThenInclude(q => q.QuestionType)
                .Include(sc => sc.Questions)
                .ThenInclude(q => q.Choices)
                .Where(sc => sc.ID == id);

            return View(await surveyContents.FirstOrDefaultAsync<SurveyCode>());
        }

        //GET: SurveyPOC/TakeSurveyWithSurveyID/ID
        public async Task<IActionResult> TakeSurveyWithSurveyID(int id)
        {
            // Temp
            int userID = 1;

            // Should check to see if a surveyID already exists.   

            // Create a new survey 
            Survey survey = new Survey { SurveyCodeID = id };
            _context.Surveys.Add(survey);
            _context.SaveChanges();

            //Go through every question in survey and create a response 
            var surveyQuestions = (_context.Questions
                /*                .Include(q => q.DateResponses)
                                .ThenInclude(dr => dr.Response)
                                .Include(q => q.MultipleChoiceResponses)
                                .ThenInclude(mcr => mcr.Response)
                                .Include(q => q.MultipleChoiceResponses)
                                .ThenInclude(mcr => mcr.Response)*/
                .Include(q => q.QuestionType)
                .Where(q => q.SurveyCodeID == survey.SurveyCodeID)).ToList<Question>();



            const int dateResponseID = 4;
            const int multipleChoiceResponseID = 1;
            const int numericResponseID = 5;
            const int singleChoiceResponseID = 2;
            const int textResponseID = 6;
            const int yesNoResponseID = 3;


            foreach (var question in surveyQuestions)
            {
                //TODO check if response has been previously recorded

                // Create the new response
                Response response = new Response { SurveyID = survey.ID, UserID = userID, ResponseDate = DateTime.Now };
                _context.Add(response);
                _context.SaveChanges();

                // Create the specific response type

                switch (question.QuestionTypeID)
                {
                    case dateResponseID:
                        DateResponse dateResponse = new DateResponse { QuestionID = question.ID, ResponseID = response.ID };
                        _context.Add(dateResponse);
                        break;
                    case multipleChoiceResponseID:
                        //There might be multiple of these
                        //MultipleChoiceResponse multipleChoiceResponse = new MultipleChoiceResponse
                        break;
                    case singleChoiceResponseID:
                        SingleChoiceResponse singleChoiceResponse = new SingleChoiceResponse { QuestionID = question.ID, ResponseID = response.ID };
                        _context.Add(singleChoiceResponse);
                        break;
                    case numericResponseID:
                        NumericResponse numericResponse = new NumericResponse { QuestionID = question.ID, ResponseID = response.ID };
                        _context.Add(numericResponse);
                        break;
                    case textResponseID:
                        TextResponse textResponse = new TextResponse { QuestionID = question.ID, ResponseID = response.ID };
                        _context.Add(textResponse);
                        break;
                    case yesNoResponseID:
                        YesNoResponse yesNoResponse = new YesNoResponse { QuestionID = question.ID, ResponseID = response.ID };
                        _context.Add(yesNoResponse);
                        break;

                }


            }




            var surveyContents = _context.Surveys
                .Include(s => s.SurveyCode)
                .ThenInclude(sc => sc.Questions)
                .ThenInclude(q => q.QuestionType)
                .Include(s => s.SurveyCode)
                .ThenInclude(sc => sc.Questions)
                .ThenInclude(q => q.Choices)
                .Include(s => s.Responses)
                .ThenInclude(r => r.SingleChoiceResponse)
                .Include(s => s.Responses)
                .ThenInclude(r => r.DateResponse)
                .Include(s => s.Responses)
                .ThenInclude(r => r.NumericResponse)
                .Include(s => s.Responses)
                .ThenInclude(r => r.TextResponse)
                .Include(s => s.Responses)
                .ThenInclude(r => r.YesNoResponse)
                .Where(s => s.ID == survey.ID);

            return View(await surveyContents.FirstOrDefaultAsync<Survey>());
        }



    }
}
