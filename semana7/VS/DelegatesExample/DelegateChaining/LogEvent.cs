namespace DelegateChaining
{
    public class LogEvent
    {
        public string Text { get; set; }
        public LogEvent(string text)
        {
            Text = text;
        }
    }
}
