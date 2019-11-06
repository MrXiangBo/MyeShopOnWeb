using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// 推荐码
        /// </summary>
        public string RegistCode { get; set; }
    }
}
