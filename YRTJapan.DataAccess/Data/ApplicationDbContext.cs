using YRTJapan.Core;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YRTJapan.Core.Entities;
using Microsoft.AspNetCore.Identity;
using YRTJapan.Utility;
using System.Reflection.Emit;

namespace YRTJapan.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<API_Configuration> API_Configuration { get; set; }
        public DbSet<API_Log> API_Log { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<DashboardSetting> DashboardSetting { get; set; }
        public DbSet<Inquiry> Inquiry { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<YRTBankAccount> YRTBankAccount { get; set; }
        public DbSet<YRTClientTestimonial> YRTClientTestimonial { get; set; }
        public DbSet<YRTConfiguration> YRTConfiguration { get; set; }
        public DbSet<YRTCountry> YRTCountry { get; set; }
        public DbSet<YRTDesignation> YRTDesignation { get; set; }
        public DbSet<YRTMaker> YRTMaker { get; set; }
        public DbSet<YRTUserReview> YRTUserReview { get; set; }
        public DbSet<YRTWebsiteConfiguration> YRTWebsiteConfiguration { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<FreeQuote> FreeQuotes { get; set; }
        public DbSet<GeneralInquiry> GeneralInquiries { get; set; }
        public DbSet<SalesInquiries> SalesInquiries { get; set; }

        //public override int SaveChanges()
        //{
        //    var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseModel && (x.State == EntityState.Added || x.State == EntityState.Modified));

        //    foreach (var entity in entities)
        //    {
        //        ((BaseModel)entity.Entity).Updated = DateTime.Now;

        //        if (entity.State == EntityState.Added)
        //        {
        //            ((BaseModel)entity.Entity).Created = DateTime.Now;
        //        }
        //    }
        //    return base.SaveChanges();
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedCountries(modelBuilder);
            SeedRoles(modelBuilder);
            SeedAdminUser(modelBuilder);
            SeedOtherData(modelBuilder);
        }

        public async Task ClearIdentityTables(ApplicationDbContext context)
        {
            // Remove all data from tables
            context.UserRoles.RemoveRange(context.UserRoles);
            context.UserClaims.RemoveRange(context.UserClaims);
            context.UserLogins.RemoveRange(context.UserLogins);
            context.UserTokens.RemoveRange(context.UserTokens);
            context.Users.RemoveRange(context.Users);
            context.Roles.RemoveRange(context.Roles);

            // Save changes in the database
            await context.SaveChangesAsync();
        }
        private void SeedCountries(ModelBuilder modelBuilder)
        {
            var countries = CommonData.GetCountriesList.Select(country => new YRTCountry
            {
                Name = country.Name,
                Code = country.Code,
                LogoImg = $"/images/countries/{country.Name.Replace(" ", "_")}.jpg"
            }).ToList();

            for (int i = 0; i < countries.Count; i++)
            {
                countries[i].Id = i + 1; // Assign IDs starting from 1
            }

            modelBuilder.Entity<YRTCountry>().HasData(countries);
        }
        private void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData
                (
                new IdentityRole() { Id="1", Name = StaticDetails.ROLE_ADMIN, ConcurrencyStamp = Guid.NewGuid().ToString(), NormalizedName = StaticDetails.ROLE_ADMIN.ToUpper() },
                new IdentityRole() { Id = "2", Name = StaticDetails.ROLE_EMPLOYEE, ConcurrencyStamp = Guid.NewGuid().ToString(), NormalizedName = StaticDetails.ROLE_EMPLOYEE.ToUpper() },
                new IdentityRole() { Id = "3", Name = StaticDetails.ROLE_CUSTOMER, ConcurrencyStamp = Guid.NewGuid().ToString(), NormalizedName = StaticDetails.ROLE_CUSTOMER.ToUpper() },
                new IdentityRole() { Id = "4", Name = StaticDetails.ROLE_DATAENTRYOPERATOR, ConcurrencyStamp = Guid.NewGuid().ToString(), NormalizedName = StaticDetails.ROLE_DATAENTRYOPERATOR.ToUpper() },
                new IdentityRole() { Id = "5", Name = StaticDetails.ROLE_SALE, ConcurrencyStamp = Guid.NewGuid().ToString(), NormalizedName = StaticDetails.ROLE_SALE.ToUpper() },
                new IdentityRole() { Id = "6", Name = StaticDetails.ROLE_ACCOUNTANT, ConcurrencyStamp = Guid.NewGuid().ToString(), NormalizedName = StaticDetails.ROLE_ACCOUNTANT.ToUpper() }

                );
        }
        private void SeedAdminUser(ModelBuilder modelBuilder)
        {
            var adminUserId = Guid.NewGuid().ToString(); // Use a constant GUID you've defined

            var hasher = new PasswordHasher<ApplicationUser>();
            var adminUser = new ApplicationUser
            {
                Id = adminUserId,
                UserName = "waheedtariq@msn.com",
                NormalizedUserName = "WAHEEDTARIQ@MSN.COM",
                Email = "waheedtariq@msn.com",
                NormalizedEmail = "WAHEEDTARIQ@MSN.COM",
                EmailConfirmed = true,
                SecurityStamp = string.Empty,
                FullName = "Waheed Tariq",
                Gender = "Male",
                CountryId = 1,
            };
            string password = "Engrvidhu@321";
            adminUser.PasswordHash = hasher.HashPassword(adminUser, password);
            modelBuilder.Entity<ApplicationUser>().HasData(adminUser);

            // Map user to role
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "1",  // Ensure this matches the role defined
                UserId = adminUserId   // Ensure this matches the user defined
            });
        }
        private void SeedOtherData(ModelBuilder modelBuilder)
        {
            Category cat1 = new Category { Id = Guid.NewGuid(), Name = "Scifi", DisplayOrder = 1 };
            Category cat2 = new Category { Id = Guid.NewGuid(), Name = "Action", DisplayOrder = 2 };
            Category cat3 = new Category { Id = Guid.NewGuid(), Name = "History", DisplayOrder = 3 };

            modelBuilder.Entity<Category>().HasData(cat1, cat2, cat3);

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = Guid.NewGuid(),
                    Name = "Tech Solution",
                    StreetAddress = "123 Tech St",
                    City = "Tech City",
                    PostalCode = "12121",
                    State = "IL",
                    PhoneNumber = "6669990000"
                },
                new Company
                {
                    Id = Guid.NewGuid(),
                    Name = "Vivid Books",
                    StreetAddress = "999 Vid St",
                    City = "Vid City",
                    PostalCode = "66666",
                    State = "IL",
                    PhoneNumber = "7779990000"
                },
                new Company
                {
                    Id = Guid.NewGuid(),
                    Name = "Readers Club",
                    StreetAddress = "999 Main St",
                    City = "Lala land",
                    PostalCode = "99999",
                    State = "NY",
                    PhoneNumber = "1113335555"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Leviathan Wakes",
                    Author = "Corey, James S. A.",
                    Description = "<p>Humanity has colonized the solar system&mdash;Mars, the Moon, the Asteroid Belt and beyond&mdash;but the stars are still out of our reach.<br><br>Jim Holden is XO of an ice miner making runs from the rings of Saturn to the mining stations of the Belt. When he and his crew stumble upon a derelict ship, the&nbsp;<em>Scopuli</em>, they find themselves in possession of a secret they never wanted. A secret that someone is willing to kill for&mdash;and kill on a scale unfathomable to Jim and his crew. War is brewing in the system unless he can find out who left the ship and why.<br><br>Detective Miller is looking for a girl. One girl in a system of billions, but her parents have money and money talks. When the trail leads him to the&nbsp;<em>Scopuli</em>&nbsp;and rebel sympathizer Holden, he realizes that this girl may be the key to everything.<br><br>Holden and Miller must thread the needle between the Earth government, the Outer Planet revolutionaries, and secretive corporations&mdash;and the odds are against them. But out in the Belt, the rules are different, and one small ship can change the fate of the universe.</p>",
                    ISBN = "978-0-316-12908-4",
                    ListPrice = 300000,
                    Price = 290000,
                    Price50 = 280000,
                    Price100 = 260000,
                    CategoryId = cat1.Id,
                    ImageUrl = "\\images\\product\\LeviathanWakes.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Caliban's War",
                    Author = "Corey, James S. A.",
                    Description = "<p>We are not alone. On Ganymede, breadbasket of the outer planets, a Martian marine watches as her platoon is slaughtered by a monstrous supersoldier. On Earth, a high-level politician struggles to prevent interplanetary war from reigniting. And on Venus, an alien protomolecule has overrun the planet, wreaking massive, mysterious changes and threatening to spread out into the solar system.<br><br>In the vast wilderness of space, James Holden and the crew of the&nbsp;<em>Rocinante</em> have been keeping the peace for the Outer Planets Alliance. When they agree to help a scientist search war-torn Ganymede for a missing child, the future of humanity rests on whether a single ship can prevent an alien invasion that may have already begun.</p>",
                    ISBN = "978-0-316-12906-0",
                    ListPrice = 310000,
                    Price = 295000,
                    Price50 = 285000,
                    Price100 = 265000,
                    CategoryId = cat1.Id,
                    ImageUrl = "\\images\\product\\CalibansWar.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Abaddon's Gate",
                    Author = "Corey, James S. A.",
                    Description = "<p>Abaddon's Gate is the third book in the New York Times bestselling Expanse series.<br><br>For generations, the solar system - Mars, the Moon, the Asteroid Belt - was humanity's great frontier. Until now. The alien artefact working through its program under the clouds of Venus has emerged to build a massive structure outside the orbit of Uranus: a gate that leads into a starless dark.<br><br>Jim Holden and the crew of the Rocinante are part of a vast flotilla of scientific and military ships going out to examine the artefact. But behind the scenes, a complex plot is unfolding, with the destruction of Holden at its core. As the emissaries of the human race try to find whether the gate is an opportunity or a threat, the greatest danger is the one they brought with them.</p>",
                    ISBN = "978-0-316-12907-7",
                    ListPrice = 320000,
                    Price = 300000,
                    Price50 = 290000,
                    Price100 = 275000,
                    CategoryId = cat1.Id,
                    ImageUrl = "\\images\\product\\AbaddonsGate.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Cibola Burn",
                    Author = "Corey, James S. A.",
                    Description = "<p>The gates have opened the way to thousands of habitable planets, and the land rush has begun. Settlers stream out from humanity's home planets in a vast, poorly controlled flood, landing on a new world. Among them, the Rocinante, haunted by the vast, posthuman network of the protomolecule as they investigate what destroyed the great intergalactic society that built the gates and the protomolecule.<br><br>But Holden and his crew must also contend with the growing tensions between the settlers and the company which owns the official claim to the planet. Both sides will stop at nothing to defend what's theirs, but soon a terrible disease strikes and only Holden - with help from the ghostly Detective Miller - can find the cure.</p>",
                    ISBN = "978-0-316-21762-0",
                    ListPrice = 270000,
                    Price = 260000,
                    Price50 = 250000,
                    Price100 = 240000,
                    CategoryId = cat1.Id,
                    ImageUrl = "\\images\\product\\CibolaBurn.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Nemesis Games",
                    Author = "Corey, James S. A.",
                    Description = "<p>The fifth novel in Corey's New York Times bestselling Expanse series--now being produced for television by the SyFy Channel!<br><br>A thousand worlds have opened, and the greatest land rush in human history has begun. As wave after wave of colonists leave, the power structures of the old solar system begin to buckle.<br><br>Ships are disappearing without a trace. Private armies are being secretly formed. The sole remaining protomolecule sample is stolen. Terrorist attacks previously considered impossible bring the inner planets to their knees. The sins of the past are returning to exact a terrible price.<br><br>And as a new human order is struggling to be born in blood and fire, James Holden and the crew of the Rocinante must struggle to survive and get back to the only home they have left.</p>",
                    ISBN = "978-0-316-21758-3",
                    ListPrice = 300000,
                    Price = 290000,
                    Price50 = 280000,
                    Price100 = 260000,
                    CategoryId = cat1.Id,
                    ImageUrl = "\\images\\product\\NemesisGames.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Babylon's Ashes",
                    Author = "Corey, James S. A.",
                    Description = "<p>A revolution brewing for generations has begun in fire. It will end in blood.</p>\r\n<p>The Free Navy - a violent group of Belters in black-market military ships - has crippled the Earth and begun a campaign of piracy and violence among the outer planets. The colony ships heading for the thousand new worlds on the far side of the alien ring gates are easy prey, and no single navy remains strong enough to protect them.</p>\r\n<p>James Holden and his crew know the strengths and weaknesses of this new force better than anyone. Outnumbered and outgunned, the embattled remnants of the old political powers call on the&nbsp;<em>Rocinante&nbsp;</em>for a desperate mission to reach Medina Station at the heart of the gate network.</p>\r\n<p>But the new alliances are as flawed as the old, and the struggle for power has only just begun. As the chaos grows, an alien mystery deepens. Pirate fleets, mutiny and betrayal may be the least of the&nbsp;<em>Rocinante</em>'s problems. And in the uncanny spaces past the ring gates, the choices of a few damaged and desperate people may determine the fate of more than just humanity.</p>",
                    ISBN = "978-0-316-33474-7",
                    ListPrice = 320000,
                    Price = 300000,
                    Price50 = 290000,
                    Price100 = 275000,
                    CategoryId = cat1.Id,
                    ImageUrl = "\\images\\product\\BabylonsAshes.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Persepolis Rising\t",
                    Author = "Corey, James S. A.",
                    Description = "<p>In the thousand-sun network of humanity's expansion, new colony worlds are struggling to find their way. Every new planet lives on a knife edge between collapse and wonder, and the crew of the aging gunship Rocinante have their hands more than full keeping the fragile peace.<br><br>In the vast space between Earth and Jupiter, the inner planets and belt have formed a tentative and uncertain alliance still haunted by a history of wars and prejudices. On the lost colony world of Laconia, a hidden enemy has a new vision for all of humanity and the power to enforce it.<br><br>New technologies clash with old as the history of human conflict returns to its ancient patterns of war and subjugation. But human nature is not the only enemy, and the forces being unleashed have their own price. A price that will change the shape of humanity -- and of the Rocinante -- unexpectedly and forever...</p>",
                    ISBN = "978-0-316-33283-5",
                    ListPrice = 300000,
                    Price = 290000,
                    Price50 = 280000,
                    Price100 = 260000,
                    CategoryId = cat1.Id,
                    ImageUrl = "\\images\\product\\PersepolisRising.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Tiamat's Wrath",
                    Author = "Corey, James S. A.",
                    Description = "<p>Thirteen hundred gates have opened to solar systems around the galaxy. But as humanity builds its interstellar empire in the alien ruins, the mysteries and threats grow deeper.<br><br>In the dead systems where gates lead to stranger things than alien planets, Elvi Okoye begins a desperate search to discover the nature of a genocide that happened before the first human beings existed, and to find weapons to fight a war against forces at the edge of the imaginable. But the price of that knowledge may be higher than she can pay.<br><br>At the heart of the empire, Teresa Duarte prepares to take on the burden of her father's godlike ambition. The sociopathic scientist Paolo Cort&aacute;zar and the Mephistophelian prisoner James Holden are only two of the dangers in a palace thick with intrigue, but Teresa has a mind of her own and secrets even her father the emperor doesn't guess.<br><br>And throughout the wide human empire, the scattered crew of the Rocinante fights a brave rear-guard action against Duarte's authoritarian regime. Memory of the old order falls away, and a future under Laconia's eternal rule -- and with it, a battle that humanity can only lose - seems more and more certain. Because against the terrors that lie between worlds, courage and ambition will not be enough...</p>",
                    ISBN = "978-0-316-33286-6",
                    ListPrice = 320000,
                    Price = 300000,
                    Price50 = 290000,
                    Price100 = 275000,
                    CategoryId = cat1.Id,
                    ImageUrl = "\\images\\product\\TiamatsWrath.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Title = "Leviathan Falls",
                    Author = "Corey, James S. A.",
                    Description = "<p>The Laconian Empire has fallen, setting the thirteen hundred solar systems free from the rule of Winston Duarte. But the ancient enemy that killed the gate builders is awake, and the war against our universe has begun again.<br><br>In the dead system of Adro, Elvi Okoye leads a desperate scientific mission to understand what the gate builders were and what destroyed them, even if it means compromising herself and the half-alien children who bear the weight of her investigation. Through the wide-flung systems of humanity, Colonel Aliana Tanaka hunts for Duarte&rsquo;s missing daughter. . . and the shattered emperor himself. And on the Rocinante, James Holden and his crew struggle to build a future for humanity out of the shards and ruins of all that has come before.<br><br>As nearly unimaginable forces prepare to annihilate all human life, Holden and a group of unlikely allies discover a last, desperate chance to unite all of humanity, with the promise of a vast galactic civilization free from wars, factions, lies, and secrets if they win.<br><br>But the price of victory may be worse than the cost of defeat.</p>",
                    ISBN = "978-0-316-33291-0",
                    ListPrice = 330000,
                    Price = 320000,
                    Price50 = 310000,
                    Price100 = 300000,
                    CategoryId = cat1.Id,
                    ImageUrl = "\\images\\product\\LeviathanFalls.jpg"
                }
                );
        }
    }
}
