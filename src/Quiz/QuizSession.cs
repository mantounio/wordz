using wordz.src.dbContext;
using wordz.src.words;
using wordz.src.service;

namespace wordz.src.Quiz
{
    public static class QuizSession
    {
        // i need a list of random meaning for anwser that one of them is the real awnser
        public static Queue<Word> _word_q;
        public static IEnumerable<string> _anwser_candidates;
        public static int _offset;

        public static void init_quiz(Queue<Word> word_q, IEnumerable<string> anwser_candidates, int offset)
        {
            _word_q = word_q;
            _anwser_candidates = anwser_candidates;
            _offset = offset;
        }

        internal static void gen_quiz_queue(WordService service, string lang)
        {
            for (int i = 0; i < 10; ++i)
            {
                _word_q.Enqueue(get_random_entity(service, lang));
            }
        }
        internal static Word get_random_entity(WordService service, string lang)
        {
            Random random = new();

            int rand_id = random.Next(1, service.count());

            MessageBox.Show(rand_id.ToString());

            return Util.db.words.Where(i => i.Id == rand_id).First(); //service.GetWordById(rand_id);
        }

        internal static void next_word(WordService service, string lang)
        {
            _word_q.Dequeue();

            if (_word_q.Count == 0)
            {
                MessageBox.Show("Test");
                gen_quiz_queue(service, lang);
            }
        }

    }
}
