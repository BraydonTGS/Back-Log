using Back_Log.Global.Constants;
using Back_Log.Global.Identifiers;

namespace Back_Log.Business.Dto
{
    public class VideoGameDto
    {      
        public VideoGameId VideoGameId { get; private set; }
        public string Title { get; set; }
        public Enums.VideoGameGenre GameGenre { get; set; }
        public Enums.ESRBRating ESRBRating { get; set; }
        public bool IsCompleted { get; set; }
        public VideoGameDto()
        {
          VideoGameId = new VideoGameId(Guid.NewGuid());
        }
    }
}
