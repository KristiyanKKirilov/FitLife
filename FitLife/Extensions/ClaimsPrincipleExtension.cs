namespace System.Security.Claims
{
    public static class ClaimsPrincipleExtension
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public static string Email(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.Email);
        }        
    }
}
