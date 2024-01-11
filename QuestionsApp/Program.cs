using System;
using System.Collections.Generic;
using QuestionsConsoleApp;

class Program
{
	static void Main()
	{


		Console.Write("Neçə sual cavablandırmaq istəyirsiniz? ");
		int questionCount = TakeQuestionsCount();
		QuestionLogic questionLogic = new QuestionLogic();
		questionLogic.PlayLogic(questionCount);
		Console.WriteLine($"Ümumilikdə {questionLogic.RightAnswersCount} suala düzgün {questionCount - questionLogic.RightAnswersCount} suala yanlış cavab verdiniz!");
	}

	static int TakeQuestionsCount()
	{
		int questionCount;
		while (!int.TryParse(Console.ReadLine(), out questionCount) || questionCount <= 0)
		{
			Console.WriteLine("Zəhmət olmasa keçərli bir say girin");
		}
		return questionCount;
	}

}





