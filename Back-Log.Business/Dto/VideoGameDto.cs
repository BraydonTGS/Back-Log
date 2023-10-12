using Back_Log.Global.Constants;

namespace Back_Log.Business.Dto
{
    public class VideoGameDto
    {
        public string Title { get; set; }
        public Enums.VideoGameGenre GameGenre { get; set; }
        public Enums.ESRBRating ESRBRating { get; set; }
        public bool IsCompleted { get; set; }

    }
}
