using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsConsoleApp
{
	internal class QuestionLogic
	{
		private List<Question> questions;
		public int RightAnswersCount { get; set; }

		public QuestionLogic()
		{

			questions = CreateQuestion();
			RightAnswersCount = 0;
		}

		private List<Question> CreateQuestion()
		{
			List<Question> questions = new List<Question>();

			questions.Add(new Question("A ilə başlayan sözü tapın ", new List<string> { "Akşin", "Bayram", "Cavid", "Davud", "Emil" }, 1));
			questions.Add(new Question("B ilə başlayan sözü tapın ", new List<string> { "Akşin", "Bayram", "Cavid", "Davud", "Emil" }, 2));
			questions.Add(new Question("C ilə başlayan sözü tapın  ", new List<string> { "Akşin", "Bayram", "Cavid", "Davud", "Emil" }, 3));
			questions.Add(new Question("D ilə başlayan sözü tapın ", new List<string> { "Akşin", "Bayram", "Cavid", "Davud", "Emil" }, 4));
			questions.Add(new Question("E ilə başlayan sözü tapın ", new List<string> { "Akşin", "Bayram", "Cavid", "Davud", "Emil" }, 5));
			questions.Add(new Question("Ə ilə başlayan sözü tapın ", new List<string> { "Əmrah", "Faiq", "Günay", "Xəyal", "İlkin" }, 1));
			questions.Add(new Question("F ilə başlayan sözü tapın ", new List<string> { "Əmrah", "Faiq", "Günay", "Xəyal", "İlkin" }, 2));
			questions.Add(new Question("G ilə başlayan sözü tapın ", new List<string> { "Əmrah", "Faiq", "Günay", "Xəyal", "İlkin" }, 3));
			questions.Add(new Question("X ilə başlayan sözü tapın ", new List<string> { "Əmrah", "Faiq", "Günay", "Xəyal", "İlkin" }, 4));
			questions.Add(new Question("Ə ilə başlayan sözü tapın ", new List<string> { "Əmrah", "Faiq", "Günay", "Xəyal", "İlkin" }, 5));




			return questions;
		}

		private int TakeAnswer()
		{
			int answer;
			do
			{
				Console.WriteLine("Cavabınızı daxil edin");
			} while (!int.TryParse(Console.ReadLine(), out answer) || answer < 1 || answer > 5);

			return answer;
		}

		public void PlayLogic(int questionCount)
		{
			for (int i = 0; i < questionCount; i++)
			{
				questions[i].ShowQuestion();
				int userAnswer = TakeAnswer();

				if (questions[i].RightAnswer(userAnswer))
				{
					Console.WriteLine("Doğrudur!\n");
					RightAnswersCount++;
				}
				else
				{
					Console.WriteLine($"Yanlışdır!  Doğru cavab {questions[i].RightAnswerNumber}");
				}

			}
		}

		
	}
}
