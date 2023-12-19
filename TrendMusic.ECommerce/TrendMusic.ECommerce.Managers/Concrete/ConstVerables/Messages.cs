using System.Xml.Serialization;

namespace TrendMusic.ECommerce.Managers.Concrete.ConstVerables
{
    public static class Messages
    {
        public static class CRUD
        {
            public const string Added = "Eklendi";
            public const string Updated = "Güncellendi";
            public const string Deleted = "Silindi";
            public const string SoftDeleted = "Silindi.";
        }

        public static class Errors
        {
            public const string MappingError = "Veri dönüşümü esnasında bir hata meydana geldi";
            public const string NotFoundError = "Herhangi bir veri bulunamadı";
        }

    }
}
