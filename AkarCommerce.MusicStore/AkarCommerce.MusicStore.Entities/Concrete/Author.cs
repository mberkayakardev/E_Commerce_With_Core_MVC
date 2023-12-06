using AkarCommerce.MusicStore.Core.Entities.Abstract;

namespace AkarCommerce.MusicStore.Entities.Concrete
{
    public class Author : BaseEntity
    {
        public int AuthorName { get; set; }

        #region Navigation Property
        public List<Music> Musics { get; set; }
        #endregion
    }
}
