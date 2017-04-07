using System.Web.Http;

namespace testapi.Controllers
{
    public class testController : ApiController
    {
        [HttpGet]
        public Models.Users apimethod()
        {
            Models.Users users = new Models.Users();
            users.username = "test";
            users.sex = "man";
            return users;
        }
        public void ReturnImg() {
            this.GetType().Assembly.GetManifestResourceStream("");
            int ints = 5;
            ints.GetType();
        }
     
    }
}
