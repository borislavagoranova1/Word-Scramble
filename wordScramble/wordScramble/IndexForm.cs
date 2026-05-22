namespace wordScramble
{
    public partial class WordScramble : Form
    {
        private const string wordsTextFile = @"../../../words.txt";
        private readonly List<string> failedAttempts = new();
        private readonly List<string> wordList = new();

        private int attempts = 0;
        private int guessedWords = 0;
        private string currentWord;
        public WordScramble()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            GetAllWords();
            GenerateNewWord();
        }
        private void GetAllWords()
        {
            using (StreamReader reader = new(wordsTextFile))
            {
                while (!reader.EndOfStream)
                {
                    wordList.Add(reader.ReadLine());
                }
            }
        }
        private void GenerateNewWord()
        {
            Random random = new();
            currentWord = wordList[random.Next(0, wordList.Count)];

            ResetGameInfo();
        }
        private void ResetGameInfo()
        {
            attempts = 0;
            failedAttempts.Clear();
            this.labelScrambledWord.Text = ScrambleWord(currentWord);
        }
        private static string ScrambleWord(string word)
        {
            char[] chars = word.ToCharArray();
            Random rng = new();
            int n = word.Length;

            while (n > 1)
            {
                n--;
                int k = rng.Next(0, n);
                (chars[n], chars[k]) = (chars[k], chars[n]);
            }
            return new string(chars);
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckTheWord();
            UpdateLables();
        }
        private void CheckTheWord()
        {
            string input = this.textBoxInput.Text.Trim();
            if (currentWord == input)
            {
                SuccesfulAttempt();
            }
            else if (!string.IsNullOrEmpty(input))
            {
                UnsuccesfulAttempt(input);
            }
        }
        private void SuccesfulAttempt()
        {
            GenerateNewWord();
            guessedWords++;
            this.labelGuessedWordsValue.Text = guessedWords.ToString();
            wordList.Remove(textBoxInput.Text);
        }
        private void UnsuccesfulAttempt(string input)
        {
            attempts++;
            failedAttempts.Add(textBoxInput.Text);
            if (attempts > 9)
            {
                GenerateNewWord();
            }
        }
        private void UpdateLables()
        {
            this.textBoxFailedAttempts.Text = string.Join(", ", failedAttempts.ToArray());
            this.txtAttempts.Text = attempts.ToString();
            this.textBoxInput.Text = String.Empty;
        }
        private void btnSkip_Click(object sender, EventArgs e)
        {
            GenerateNewWord();
            UpdateLables();
        }
        

    }
}
