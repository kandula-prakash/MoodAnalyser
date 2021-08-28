using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
   public class moodAnalyze
    {
        private string message;
            public moodAnalyze(string message)
        {
            this.message = message; 
        }
        public string AnalyzeMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.EMPTY_MESSAGE, "Should Not BeEmpty");

                }

           
            if (this.message.Contains ("sad"))
            {
                return "sad";

            }
            else
            {
                return "Happy";
            }
            }
            catch (NullReferenceException)
            {

                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_MESSAGE, "mood should not be null");
            }
        }
    }
}
