

class Quiz
{
    private List<Question> listObjetsQuestions;

    public Quiz(string filePath)
    {
        LoadQuestions(filePath);
        StartQuiz();
    }

    private void LoadQuestions(string filePath)
    {
        string[] tableauQuestions = File.ReadAllLines(filePath);
        List<string[]> listDesQuestionsCoupees = tableauQuestions
                    .Select(line => line.Split(';')).ToList();
        listObjetsQuestions = listDesQuestionsCoupees
            .Select(parts => new Question
            {
                    Intitule= parts[0],
                    Reponses= parts[1],
                    CorrectAnswer= parts[2]
            }).ToList();
    }

    public void StartQuiz()
    {

        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine(".______    __   _______ .__   __. ____    ____  _______ .__   __.  __    __   _______ ");
        Console.WriteLine("|   _  \\  |  | |   ____||  \\ |  | \\   \\  /   / |   ____||  \\ |  | |  |  |  | |   ____|");
        Console.WriteLine("|  |_)  | |  | |  |__   |   \\|  |  \\   \\/   /  |  |__   |   \\|  | |  |  |  | |  |__   ");
        Console.WriteLine("|   _  <  |  | |   __|  |  . `  |   \\      /   |   __|  |  . `  | |  |  |  | |   __|  ");
        Console.WriteLine("|  |_)  | |  | |  |____ |  |\\   |    \\    /    |  |____ |  |\\   | |  `--'  | |  |____ ");
        Console.WriteLine("|______/  |__| |_______||__| \\__|     \\__/     |_______||__| \\__|  \\______/  |_______|");

        Console.WriteLine("                                   _______. __    __  .______      ");
        Console.WriteLine("                                  /       ||  |  |  | |   _  \\     ");
        Console.WriteLine("                                 |   (----`|  |  |  | |  |_)  |    ");
        Console.WriteLine("                                  \\   \\    |  |  |  | |      /     ");
        Console.WriteLine("                              .----)   |   |  `--'  | |  |\\  \\----.");
        Console.WriteLine("                              |_______/     \\______/  | _| `._____|");

        Console.WriteLine("  ______       __    __   __   ________    _______      ___      .___  ___.  _______ ");
        Console.WriteLine(" /  __  \\     |  |  |  | |  | |       /   /  _____|    /   \\     |   \\/   | |   ____|");
        Console.WriteLine("|  |  |  |    |  |  |  | |  | `---/  /   |  |  __     /  ^  \\    |  \\  /  | |  |__   ");
        Console.WriteLine("|  |  |  |    |  |  |  | |  |    /  /    |  | |_ |   /  /_\\  \\   |  |\\/|  | |   __|  ");
        Console.WriteLine("|  `--'  '--. |  `--'  | |  |   /  /----.|  |__| |  /  _____  \\  |  |  |  | |  |____ ");
        Console.WriteLine(" \\_____/\\_____\\ \\______/  |__|  /________| \\______| /__/     \\__\\ |__|  |__| |_______|");

        Console.WriteLine("Choisissez votre catégorie :");
        Console.WriteLine("1. Une catégorie");
        Console.WriteLine("2. Une seconde catégorie");
        Console.WriteLine("Votre choix : ");
        Console.ReadLine();
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        int score = 0;
        foreach (var question in listObjetsQuestions)
        {   
            Console.WriteLine(question.Intitule);
            Console.WriteLine(question.Reponses);
            Console.WriteLine("Votre réponse:");
            string userAnswer = Console.ReadLine();

            if (userAnswer.Trim().Equals(question.CorrectAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"La réponse est incorrect: {question.CorrectAnswer}");
            }
        }

        Console.WriteLine($"Quiz Terminer! Votre score est de : {score}/{listObjetsQuestions.Count}");
    }
}