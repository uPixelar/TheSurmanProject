using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLayer {
    public static class SurveyManager {
        public static List<tb_surveys> getSurveys() {
            surmanEntities entities = new surmanEntities();
            return entities.tb_surveys.OrderByDescending(row => row.createdAt).ToList();
        }

        public static List<tb_surveys> getSurveys(int userId) {
            surmanEntities entities = new surmanEntities();
            return entities.tb_surveys.Where(survey => survey.userId == userId).OrderByDescending(row => row.createdAt).ToList();
        }

        public static void SaveSurvey(tb_surveys survey) {
            survey.createdAt = DateTime.Now;
            surmanEntities entities = new surmanEntities();
            entities.tb_surveys.Add(survey);
            entities.SaveChanges();
        }
    }
}
