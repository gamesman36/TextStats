namespace TextStats
{
    internal class Analysis
    {
        public string Text { get; private set; }
        public string Alphabet { get; private set; }
        public Dictionary<char, int> Counters { get; private set; }

        public Analysis(string text)
        {
            Text = text.ToLower();
            Alphabet = "abcdefghijklmnopqrstuvwxyz";
            Counters = new Dictionary<char, int>();

            foreach (char ch in Alphabet)
            {
                Counters[ch] = 0;
            }
        }

        public void CountChars()
        {
            foreach (char ch in Text)
            {
                if (Counters.ContainsKey(ch))
                {
                    Counters[ch]++;
                }
            }
        }

        public int GetCharCount(char ch)
        {
            return Counters[ch];
        }
    }
}