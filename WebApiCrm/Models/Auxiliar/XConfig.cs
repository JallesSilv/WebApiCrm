
namespace WebApiCrm.Models.Auxiliar
{
    public class XConfig : XConfigArq
    {
        public static string DataSource
        {
            get
            {
                return Get(() => DataSource);
            }
        }

        public static string InitialCatalog
        {
            get
            {
                return Get(() => InitialCatalog);
            }
        }

        public static string UserID
        {
            get
            {
                return Get(() => UserID);
            }
        }

        public static string Password
        {
            get
            {
                return Get(() => Password);
            }
        }
    }
}