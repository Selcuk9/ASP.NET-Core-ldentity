using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserIdentity.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ViewResult Index() => 
            View(new Dictionary<string, object> 
                { ["Placeholder"] = "Placeholder" });
        
    }
}
