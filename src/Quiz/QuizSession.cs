using Microsoft.Extensions.Options;
using System.Security.Cryptography;
using wordz.src.service;
using wordz.src.words;
using static System.Windows.Forms.Design.AxImporter;

namespace wordz.src.Quiz
{
    public static class QuizSession
    {
        private static WordService question_service;
        public static Queue<QuizQuestion>? questions = new Queue<QuizQuestion>();
        private static int old_num;

        public static void gen_question() => init_quiz();// change later this
        public static (string word, string meaning) get_random_word_and_meaning(WordService service)
        {
            Random rand = new();

            int rand_id = rand.Next(1, service.count() + 1);

            if (old_num == rand_id)
            {
                rand_id = rand.Next(1, service.count());
            }

            old_num = rand_id;

            return (service.GetAllWords()
               .Where(i => i.Id == rand_id).First()._Word, service.GetAllWords()
               .Where(i => i.Id == rand_id).First().Meaning);
        }

        public static List<string> get_random_options(string meaning)
        {
            List<string> options = new();

            for (int i = 0; i < 3; i++)
            {
                string option_meaning = get_random_word_and_meaning(question_service).meaning;
                if (option_meaning == meaning)
                {
                    while (option_meaning != meaning)
                    {
                        option_meaning = get_random_word_and_meaning(question_service).meaning;
                    }
                }

                options.Add(option_meaning);
            }
            options.Add(meaning);

            return options;
        }

        public static void init_quiz()
        {
            List<string> options = new();

            if (questions!.Count == 0)
            {
                for (int i = 0; i < 10; ++i)
                {
                    var whole_word = get_random_word_and_meaning(question_service);

                    options = get_random_options(whole_word.meaning);

                    questions!.Enqueue(new QuizQuestion()
                    {
                        question_word = whole_word.word,
                        options = options
                    });
                }
            }
        }
        public static void set_service(WordService service) => question_service = service;

        public static void next()
        {
            questions.Dequeue();

            if (questions.Count == 0)
            {
                MessageBox.Show("the queue is empty");
                gen_question();
            }
        }

    }

}
