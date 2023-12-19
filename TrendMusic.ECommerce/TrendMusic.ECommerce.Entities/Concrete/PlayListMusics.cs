using TrendMusic.ECommerce.Core.Entities.Abstract;

namespace TrendMusic.ECommerce.Entities.Concrete
{
    public class PlayListMusics : BaseEntity
    {
        public Music Music { get; set; }
        public int MusicId { get; set; }

        public PlayList PlayList { get; set; }
        public int PlayListId { get; set; }

    }
}
