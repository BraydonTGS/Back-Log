namespace Back_Log.Global.Identifiers
{
    public class VideoGameId
    {
        public Guid Value { get; }

        public VideoGameId(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new ArgumentException("Invalid ID value", nameof(value));
            }

            Value = value;
        }
    }
}
