namespace TrendMusic.ECommerce.Entities.Concrete
{
    // ilerleyen zamanlarda Playlist satımı oluşabilmesi sebebi ile productlar için bu şekilde bir geliştirme yapıldı.
    public class Music: Product
    {
        public string MusicPath { get; set; } // müziğin yüklü olduğu path bilgisi
        public bool DemoMusic { get; set; }  // müziğin demo olabilme sürecide mevcuttur
    }
}
