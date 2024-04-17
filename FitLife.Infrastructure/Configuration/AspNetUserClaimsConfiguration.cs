using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static FitLife.GlobalConstants.CustomClaims;

namespace FitLife.Data.Configuration
{
	public class AspNetUserClaimsConfiguration : IEntityTypeConfiguration<IdentityUserClaim<string>>
	{
		public void Configure(EntityTypeBuilder<IdentityUserClaim<string>> builder)
		{
			builder.HasData(SeedUserClaims());
		}

		private IdentityUserClaim<string>[] SeedUserClaims()
		{
			return new IdentityUserClaim<string>[]
			{
				new IdentityUserClaim<string>()
				{
					Id = 1,
					ClaimType = UserFullNameClaim,
					ClaimValue = "Tom Johnson",
					UserId = "dea12856-c198-4129-b3f3-b893d8395082"
				},
				new IdentityUserClaim<string>()
				{
					Id = 2,
					ClaimType = UserFullNameClaim,
					ClaimValue = "Freddy Philips",
					UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
				},
				new IdentityUserClaim<string>()
				{
					Id = 3,
					ClaimType = UserFullNameClaim,
					ClaimValue = "Chris Stevens",
					UserId = "ad1cc9c3-9fda-440a-a729-1baa02aef94d"

				},
				new IdentityUserClaim<string>()
				{
					Id = 4,
					ClaimType = UserFullNameClaim,
					ClaimValue = "TEST SOFTUNI",
					UserId = "e04b5ff6-29e7-44d5-9b3b-0099d18debd7"
				},
				new IdentityUserClaim<string>()
				{
					Id = 5,
					ClaimType = UserFullNameClaim,
					ClaimValue = "Admin ItSelf",
					UserId = "e04b5ff6-29e7-44d5-9b3b-0099d18de007"
				},
			};
		}
	}
}
