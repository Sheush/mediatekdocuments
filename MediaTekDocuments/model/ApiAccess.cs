using Newtonsoft.Json.Linq;
namespace MediaTekDocuments.model
{   public class ApiAccess
    {
        private static ApiAccess instance = null;

        private ApiAccess()
        {
            
        }

        public static ApiAccess Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApiAccess();
                }
                return instance;
            }
        }
    }
}
