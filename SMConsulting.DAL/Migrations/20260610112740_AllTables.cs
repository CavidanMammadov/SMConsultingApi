using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMConsulting.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts1",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts1", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "Applyments1",
                columns: table => new
                {
                    AppylmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplymentName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ApplymentEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ApplymentPhone = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    ApplymentCompany = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ApplymentPosition = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    ApplymentMessage = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    ApplymentCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applyments1", x => x.AppylmentId);
                });

            migrationBuilder.CreateTable(
                name: "Blogs1",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogMainImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogSecondaryImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogMainContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogSubcontent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogTags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs1", x => x.BlogId);
                });

            migrationBuilder.CreateTable(
                name: "Cards1",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards1", x => x.CardId);
                });

            migrationBuilder.CreateTable(
                name: "CardSpecifications1",
                columns: table => new
                {
                    CardSpecificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardSpecificationTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardSpecificationIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardSpecificationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardSpecificationCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardSpecifications1", x => x.CardSpecificationId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts1",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ContactCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts1", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Heros1",
                columns: table => new
                {
                    HeroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeroTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeroDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeroImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeroCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heros1", x => x.HeroId);
                });

            migrationBuilder.CreateTable(
                name: "Members1",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members1", x => x.MemberId);
                });

            migrationBuilder.CreateTable(
                name: "Partners1",
                columns: table => new
                {
                    PartnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartnerDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartnerImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartnerWebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartnerCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners1", x => x.PartnerId);
                });

            migrationBuilder.CreateTable(
                name: "Sectors1",
                columns: table => new
                {
                    SectorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectorDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectorCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors1", x => x.SectorId);
                });

            migrationBuilder.CreateTable(
                name: "Services1",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceFooter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceFooterDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services1", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias1",
                columns: table => new
                {
                    SocialMediaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialMediaFacebookUrl = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    SocialMediaInstagramUrl = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    SocialMediaLinekdinUrl = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    SocialMediaYoutubeUrl = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    SocailMediaCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias1", x => x.SocialMediaId);
                });

            migrationBuilder.CreateTable(
                name: "Teams1",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamTitleHiglight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams1", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "Trainings1",
                columns: table => new
                {
                    TrainingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings1", x => x.TrainingId);
                });

            migrationBuilder.CreateTable(
                name: "Users1",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRole = table.Column<int>(type: "int", nullable: false),
                    UserUserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserPasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIsAcTive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users1", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Values1",
                columns: table => new
                {
                    ValueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValueDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValueFooterTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValueFooterDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValueCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values1", x => x.ValueId);
                });

            migrationBuilder.CreateTable(
                name: "Visions1",
                columns: table => new
                {
                    VisionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisionSubDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisionCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visions1", x => x.VisionId);
                });

            migrationBuilder.CreateTable(
                name: "SectorHelps1",
                columns: table => new
                {
                    SectorHelpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectorHelpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectorHelpSectorId = table.Column<int>(type: "int", nullable: false),
                    SectorHelpCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectorHelps1", x => x.SectorHelpId);
                    table.ForeignKey(
                        name: "FK_SectorHelps1_Sectors1_SectorHelpSectorId",
                        column: x => x.SectorHelpSectorId,
                        principalTable: "Sectors1",
                        principalColumn: "SectorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens1",
                columns: table => new
                {
                    RefreshTokenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefreshTokenToken = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RefreshTokenUserId = table.Column<int>(type: "int", nullable: false),
                    RefreshTokenExpireTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefreshTokenIsRevoked = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RefreshTokenCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens1", x => x.RefreshTokenId);
                    table.ForeignKey(
                        name: "FK_RefreshTokens1_Users1_RefreshTokenUserId",
                        column: x => x.RefreshTokenUserId,
                        principalTable: "Users1",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Difficulties1",
                columns: table => new
                {
                    DifficultyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DifficultyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DifficultSectorHelpId = table.Column<int>(type: "int", nullable: false),
                    DifficultyCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Difficulties1", x => x.DifficultyId);
                    table.ForeignKey(
                        name: "FK_Difficulties1_SectorHelps1_DifficultSectorHelpId",
                        column: x => x.DifficultSectorHelpId,
                        principalTable: "SectorHelps1",
                        principalColumn: "SectorHelpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abouts1_AboutId",
                table: "Abouts1",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_Applyments1_AppylmentId",
                table: "Applyments1",
                column: "AppylmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs1_BlogId",
                table: "Blogs1",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards1_CardId",
                table: "Cards1",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSpecifications1_CardSpecificationId",
                table: "CardSpecifications1",
                column: "CardSpecificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts1_ContactId",
                table: "Contacts1",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Difficulties1_DifficultSectorHelpId",
                table: "Difficulties1",
                column: "DifficultSectorHelpId");

            migrationBuilder.CreateIndex(
                name: "IX_Heros1_HeroId",
                table: "Heros1",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_Members1_MemberId",
                table: "Members1",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Partners1_PartnerId",
                table: "Partners1",
                column: "PartnerId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens1_RefreshTokenToken",
                table: "RefreshTokens1",
                column: "RefreshTokenToken",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens1_RefreshTokenUserId",
                table: "RefreshTokens1",
                column: "RefreshTokenUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SectorHelps1_SectorHelpSectorId",
                table: "SectorHelps1",
                column: "SectorHelpSectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Sectors1_SectorId",
                table: "Sectors1",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Services1_ServiceId",
                table: "Services1",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias1_SocialMediaId",
                table: "SocialMedias1",
                column: "SocialMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams1_TeamId",
                table: "Teams1",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings1_TrainingId",
                table: "Trainings1",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_Users1_UserEmail",
                table: "Users1",
                column: "UserEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users1_UserUserName",
                table: "Users1",
                column: "UserUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts1");

            migrationBuilder.DropTable(
                name: "Applyments1");

            migrationBuilder.DropTable(
                name: "Blogs1");

            migrationBuilder.DropTable(
                name: "Cards1");

            migrationBuilder.DropTable(
                name: "CardSpecifications1");

            migrationBuilder.DropTable(
                name: "Contacts1");

            migrationBuilder.DropTable(
                name: "Difficulties1");

            migrationBuilder.DropTable(
                name: "Heros1");

            migrationBuilder.DropTable(
                name: "Members1");

            migrationBuilder.DropTable(
                name: "Partners1");

            migrationBuilder.DropTable(
                name: "RefreshTokens1");

            migrationBuilder.DropTable(
                name: "Services1");

            migrationBuilder.DropTable(
                name: "SocialMedias1");

            migrationBuilder.DropTable(
                name: "Teams1");

            migrationBuilder.DropTable(
                name: "Trainings1");

            migrationBuilder.DropTable(
                name: "Values1");

            migrationBuilder.DropTable(
                name: "Visions1");

            migrationBuilder.DropTable(
                name: "SectorHelps1");

            migrationBuilder.DropTable(
                name: "Users1");

            migrationBuilder.DropTable(
                name: "Sectors1");
        }
    }
}
