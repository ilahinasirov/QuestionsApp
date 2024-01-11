namespace QuestionsConsoleApp
{
	public class Question
	{
		public string Text { get;  set; }
		public List<string> Options { get;  set; } 
		public int RightAnswerNumber { get;  set; }

		public Question(string text, List<string> options, int rightAnswer)
		{
			Text = text;
			Options = options;
			RightAnswerNumber = rightAnswer;
		}

		public void ShowQuestion()
		{
			Console.WriteLine(Text);

			for (int i = 0; i < Options.Count; i++)
			{
				Console.WriteLine($"{i +1}. {Options[i]}");
			}
		}

		public bool RightAnswer(int userAnswer)
		{
			return userAnswer == RightAnswerNumber;
		}
	}
}
