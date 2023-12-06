using AkarCommerce.MusicStore.Core.Entities.Abstract;

namespace AkarCommerce.MusicStore.Entities.Concrete
{
    /// <summary>
    /// Musics entity
    /// </summary>
    public class Music : BaseEntity
    {
        public string Name { get; set; }
        public int AuthorId { get; set; } // Muzik Sahibi Foregn Key 

        #region MyRegion
        public Author Author { get; set; }
        #endregion
    }
}
