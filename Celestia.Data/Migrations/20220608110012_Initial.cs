using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Celestia.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    auth0id = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_accounts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    website_url = table.Column<string>(type: "text", nullable: true),
                    icon_url = table.Column<string>(type: "text", nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    author_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_companies", x => x.id);
                    table.ForeignKey(
                        name: "fk_companies_accounts_author_id",
                        column: x => x.author_id,
                        principalTable: "accounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "folders",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    color = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    author_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_folders", x => x.id);
                    table.ForeignKey(
                        name: "fk_folders_accounts_author_id",
                        column: x => x.author_id,
                        principalTable: "accounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    phone = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    company_id = table.Column<int>(type: "integer", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    author_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_contacts", x => x.id);
                    table.ForeignKey(
                        name: "fk_contacts_accounts_author_id",
                        column: x => x.author_id,
                        principalTable: "accounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_contacts_companies_company_id",
                        column: x => x.company_id,
                        principalTable: "companies",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    posting_url = table.Column<string>(type: "text", nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    folder_id = table.Column<int>(type: "integer", nullable: true),
                    company_id = table.Column<int>(type: "integer", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    author_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_jobs", x => x.id);
                    table.ForeignKey(
                        name: "fk_jobs_accounts_author_id",
                        column: x => x.author_id,
                        principalTable: "accounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_jobs_companies_company_id",
                        column: x => x.company_id,
                        principalTable: "companies",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_jobs_folders_folder_id",
                        column: x => x.folder_id,
                        principalTable: "folders",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "accounts",
                columns: new[] { "id", "address", "auth0id", "created_at", "email", "name" },
                values: new object[] { 1, "Oslo, Norway", "", new DateTime(2022, 6, 8, 11, 0, 12, 706, DateTimeKind.Utc).AddTicks(964), "", "Lillie" });

            migrationBuilder.InsertData(
                table: "companies",
                columns: new[] { "id", "address", "author_id", "created_at", "icon_url", "name", "website_url" },
                values: new object[,]
                {
                    { 46, "Gamle Bekkekroken 4, Tandvik, Congo", 1, new DateTime(2022, 6, 7, 23, 33, 15, 959, DateTimeKind.Utc).AddTicks(957), "https://loremflickr.com/320/240?lock=1506050147", "Rasmussen Gruppen", "https://loremflickr.com/320/240?lock=1767739788" },
                    { 47, "Damtjernet 00, Smehavn, Gibraltar", 1, new DateTime(2022, 6, 8, 5, 3, 53, 724, DateTimeKind.Utc).AddTicks(1136), "https://loremflickr.com/320/240?lock=2025404561", "Glosli ASA", "https://loremflickr.com/320/240?lock=246220858" },
                    { 48, "Øvre Granmyra 9, Stavstrand, Mozambique", 1, new DateTime(2022, 6, 7, 16, 9, 15, 315, DateTimeKind.Utc).AddTicks(7541), "https://loremflickr.com/320/240?lock=1691843900", "Løken - Carlsen", "https://loremflickr.com/320/240?lock=379666226" },
                    { 49, "Bjørkekollen 3, Sandsjøen, Niue", 1, new DateTime(2022, 6, 7, 18, 33, 13, 613, DateTimeKind.Utc).AddTicks(2491), "https://loremflickr.com/320/240?lock=1985511758", "Arnesen, Ødegård and Evensen", "https://loremflickr.com/320/240?lock=1975082147" },
                    { 50, "Håkons Vei 94, Utvik, Sweden", 1, new DateTime(2022, 6, 7, 22, 59, 59, 313, DateTimeKind.Utc).AddTicks(3485), "https://loremflickr.com/320/240?lock=1797938821", "Olstad - Andresen", "https://loremflickr.com/320/240?lock=1615437008" },
                    { 51, "Auroras Vei 58, Loø, Peru", 1, new DateTime(2022, 6, 7, 20, 27, 59, 850, DateTimeKind.Utc).AddTicks(7063), "https://loremflickr.com/320/240?lock=1569197008", "Olstad - Strand", "https://loremflickr.com/320/240?lock=177441712" },
                    { 52, "Østre Heggekollen 0, Staveid, Gabon", 1, new DateTime(2022, 6, 7, 16, 24, 22, 960, DateTimeKind.Utc).AddTicks(6392), "https://loremflickr.com/320/240?lock=452599889", "Bjørnstad - Østli", "https://loremflickr.com/320/240?lock=1138093590" },
                    { 53, "Smogeliveien 84, Smefjord, Swaziland", 1, new DateTime(2022, 6, 8, 1, 43, 37, 752, DateTimeKind.Utc).AddTicks(903), "https://loremflickr.com/320/240?lock=487986900", "Johansen BA", "https://loremflickr.com/320/240?lock=888981035" },
                    { 54, "Østre Bruekra 4, Lofjell, Tunisia", 1, new DateTime(2022, 6, 8, 9, 2, 13, 746, DateTimeKind.Utc).AddTicks(1229), "https://loremflickr.com/320/240?lock=529308714", "Fjeld ASA", "https://loremflickr.com/320/240?lock=1176846228" },
                    { 55, "Nedre Elvekroken 74, Tandsund, Brunei Darussalam", 1, new DateTime(2022, 6, 7, 17, 56, 45, 547, DateTimeKind.Utc).AddTicks(230), "https://loremflickr.com/320/240?lock=113320056", "Bjørnstad og Sønner", "https://loremflickr.com/320/240?lock=1141867536" },
                    { 56, "Pettersensvei 58, Innodden, Belarus", 1, new DateTime(2022, 6, 8, 1, 44, 10, 859, DateTimeKind.Utc).AddTicks(2260), "https://loremflickr.com/320/240?lock=1557596101", "Strand RFH", "https://loremflickr.com/320/240?lock=198860474" },
                    { 57, "Elinesgate 19, Nordfjord, Wallis and Futuna", 1, new DateTime(2022, 6, 8, 5, 17, 7, 3, DateTimeKind.Utc).AddTicks(8986), "https://loremflickr.com/320/240?lock=287419148", "Jørgensen - Jacobsen", "https://loremflickr.com/320/240?lock=2114086709" },
                    { 58, "Carlsens Vei 4, Smeberg, Cayman Islands", 1, new DateTime(2022, 6, 8, 2, 48, 30, 280, DateTimeKind.Utc).AddTicks(151), "https://loremflickr.com/320/240?lock=1907301586", "Christiansen og Sønner", "https://loremflickr.com/320/240?lock=967152272" },
                    { 59, "Eiriks Gate 37, Lilleø, India", 1, new DateTime(2022, 6, 8, 5, 58, 14, 142, DateTimeKind.Utc).AddTicks(1046), "https://loremflickr.com/320/240?lock=967498825", "Moen ASA", "https://loremflickr.com/320/240?lock=1625026820" },
                    { 60, "Kirkeroa 13, Sandfjell, Portugal", 1, new DateTime(2022, 6, 7, 15, 54, 40, 261, DateTimeKind.Utc).AddTicks(2161), "https://loremflickr.com/320/240?lock=2063365430", "Aas - Dahl", "https://loremflickr.com/320/240?lock=1035523760" }
                });

            migrationBuilder.InsertData(
                table: "contacts",
                columns: new[] { "id", "author_id", "company_id", "created_at", "email", "name", "phone" },
                values: new object[,]
                {
                    { 16, 1, null, new DateTime(2022, 6, 8, 4, 38, 23, 814, DateTimeKind.Utc).AddTicks(5826), "Eline_Ryan@gmail.com", "Eline", "79858685" },
                    { 17, 1, null, new DateTime(2022, 6, 7, 12, 31, 51, 225, DateTimeKind.Utc).AddTicks(46), "Maria.Eriksen@yahoo.com", "Maria", "96 89 21 41" },
                    { 18, 1, null, new DateTime(2022, 6, 7, 16, 25, 58, 794, DateTimeKind.Utc).AddTicks(4002), "Elias_Carlsen@yahoo.com", "Elias", "+47 34 82 53 44" },
                    { 19, 1, null, new DateTime(2022, 6, 7, 16, 52, 5, 843, DateTimeKind.Utc).AddTicks(3101), "Malin67@yahoo.com", "Malin", "+47 13 70 79 29" },
                    { 20, 1, null, new DateTime(2022, 6, 7, 16, 53, 25, 420, DateTimeKind.Utc).AddTicks(4149), "Alexander.Moen0@yahoo.com", "Alexander", "51 65 05 79" },
                    { 21, 1, null, new DateTime(2022, 6, 7, 14, 12, 19, 6, DateTimeKind.Utc).AddTicks(534), "Hedda.Solheim27@gmail.com", "Hedda", "361 93 001" },
                    { 22, 1, null, new DateTime(2022, 6, 7, 12, 3, 23, 344, DateTimeKind.Utc).AddTicks(4021), "Sindre_Ryan@gmail.com", "Sindre", "92441479" },
                    { 23, 1, null, new DateTime(2022, 6, 7, 18, 38, 27, 457, DateTimeKind.Utc).AddTicks(4310), "Amalie.Roed33@yahoo.com", "Amalie", "73 00 37 20" },
                    { 24, 1, null, new DateTime(2022, 6, 8, 10, 28, 59, 32, DateTimeKind.Utc).AddTicks(1319), "Ida_Bjerke11@yahoo.com", "Ida", "40374553" },
                    { 25, 1, null, new DateTime(2022, 6, 8, 6, 29, 32, 167, DateTimeKind.Utc).AddTicks(1151), "Lucas79@yahoo.com", "Lucas", "052 48 675" },
                    { 26, 1, null, new DateTime(2022, 6, 8, 3, 48, 29, 906, DateTimeKind.Utc).AddTicks(674), "Emilie.Johansen@yahoo.com", "Emilie", "+47 57 10 95 97" },
                    { 27, 1, null, new DateTime(2022, 6, 7, 21, 48, 10, 850, DateTimeKind.Utc).AddTicks(2730), "Mathilde38@hotmail.com", "Mathilde", "92 71 17 54" },
                    { 28, 1, null, new DateTime(2022, 6, 8, 8, 52, 31, 615, DateTimeKind.Utc).AddTicks(7564), "Synne_Kristensen79@gmail.com", "Synne", "+47 73 87 62 86" },
                    { 29, 1, null, new DateTime(2022, 6, 8, 3, 52, 26, 343, DateTimeKind.Utc).AddTicks(9037), "Johannes.Torgersen@yahoo.com", "Johannes", "994 13 486" },
                    { 30, 1, null, new DateTime(2022, 6, 8, 2, 38, 8, 804, DateTimeKind.Utc).AddTicks(8210), "Elise.Olsen44@yahoo.com", "Elise", "51 70 88 49" }
                });

            migrationBuilder.InsertData(
                table: "jobs",
                columns: new[] { "id", "address", "author_id", "company_id", "created_at", "deadline", "description", "folder_id", "posting_url", "status", "title" },
                values: new object[,]
                {
                    { 61, "Bekkemyra 70, Vesthavn, Taiwan", 1, 49, new DateTime(2022, 6, 7, 17, 29, 20, 487, DateTimeKind.Utc).AddTicks(9920), new DateTime(2022, 6, 11, 6, 36, 42, 404, DateTimeKind.Utc).AddTicks(3722), "Perferendis et dolorem. In eum nemo aut. Cumque et totam sint adipisci. Perspiciatis voluptatem a repellat et ad. Sit quia illum quam tempora sit adipisci nam molestiae voluptatem. Magni nulla fugiat rerum ea.", null, "https://loremflickr.com/320/240?lock=411957554", 1, "Architecto nihil tenetur." },
                    { 62, "Martesgate 41, Smehelle, Russian Federation", 1, 51, new DateTime(2022, 6, 7, 21, 19, 37, 857, DateTimeKind.Utc).AddTicks(856), new DateTime(2022, 6, 14, 17, 50, 29, 429, DateTimeKind.Utc).AddTicks(2497), "Reiciendis minima voluptatem tenetur laudantium occaecati labore molestiae nulla. Ex eos incidunt ipsam deserunt quasi sint. Rerum sunt quasi omnis. Libero possimus vel nihil ipsum.", null, "https://loremflickr.com/320/240?lock=1903067041", 1, "Deserunt est fugit." },
                    { 63, "Furugata 2, Tandsund, Mexico", 1, 47, new DateTime(2022, 6, 7, 14, 42, 28, 812, DateTimeKind.Utc).AddTicks(4492), new DateTime(2022, 6, 16, 7, 6, 10, 225, DateTimeKind.Utc).AddTicks(5510), "Vero aliquam veniam qui. Aut facilis deleniti. Quae animi ut maxime adipisci et maiores amet neque fugiat. Voluptatem aut enim cum consequatur. Et doloremque optio reprehenderit ex.", null, "https://loremflickr.com/320/240?lock=1561840638", 1, "Nobis voluptatum natus." },
                    { 64, "Sebastiangata 49, Lillestrand, Bermuda", 1, 51, new DateTime(2022, 6, 7, 17, 19, 47, 920, DateTimeKind.Utc).AddTicks(5349), new DateTime(2022, 6, 12, 18, 29, 26, 729, DateTimeKind.Utc).AddTicks(5906), "Ab ex rem praesentium. Eos officiis in et. Soluta qui et molestiae eius sunt sed ipsa praesentium. Aut odit fugiat aut ut eveniet enim magnam praesentium. Aperiam qui veritatis aut. Quaerat fuga atque quis qui enim voluptas.", null, "https://loremflickr.com/320/240?lock=378355096", 1, "Assumenda sapiente et." },
                    { 65, "Bakkes Vei 9, Vestbø, Costa Rica", 1, 55, new DateTime(2022, 6, 7, 20, 59, 48, 267, DateTimeKind.Utc).AddTicks(996), new DateTime(2022, 6, 8, 18, 33, 22, 390, DateTimeKind.Utc).AddTicks(5995), "Inventore recusandae placeat sequi facere dicta aperiam omnis est non. Fugit rem voluptatem magnam ipsam exercitationem qui nihil dignissimos adipisci. Voluptatem libero dolores est. Adipisci reprehenderit ratione. Laborum fugit dolorem expedita reiciendis aliquid enim deleniti.", null, "https://loremflickr.com/320/240?lock=1048159024", 1, "Quisquam veritatis dolores." },
                    { 66, "Damskrenten 52, Sandøy, Lao People's Democratic Republic", 1, 46, new DateTime(2022, 6, 7, 15, 58, 32, 569, DateTimeKind.Utc).AddTicks(3210), new DateTime(2022, 6, 8, 11, 0, 12, 707, DateTimeKind.Utc).AddTicks(8034), "In eum deserunt in at. Rerum ut ducimus distinctio nesciunt qui saepe est iure. Aut perspiciatis quis fuga velit impedit et qui modi eum. Sed incidunt voluptas vero quisquam asperiores eveniet est quia aspernatur. Enim incidunt assumenda totam quam. Dolor exercitationem saepe.", null, "https://loremflickr.com/320/240?lock=978747265", 1, "Quaerat quidem et." },
                    { 67, "Haukelidsætersgate 18, Nærø, Turkmenistan", 1, 56, new DateTime(2022, 6, 7, 23, 48, 42, 911, DateTimeKind.Utc).AddTicks(2386), new DateTime(2022, 6, 8, 23, 5, 8, 128, DateTimeKind.Utc).AddTicks(681), "Voluptatem magnam eligendi eos vel beatae harum voluptatibus dolores. Tenetur quia sit laborum est laboriosam non porro voluptas architecto. Exercitationem labore ex et et et. Excepturi ea maxime excepturi sit. Quia ratione id molestias unde.", null, "https://loremflickr.com/320/240?lock=1834166695", 1, "Sit ut voluptatem." },
                    { 68, "Fredriks Gate 9, Innodden, Mexico", 1, 55, new DateTime(2022, 6, 7, 15, 17, 24, 411, DateTimeKind.Utc).AddTicks(1496), new DateTime(2022, 6, 9, 0, 35, 36, 766, DateTimeKind.Utc).AddTicks(1767), "Voluptatem dignissimos quidem iure et. Quia aliquam delectus qui officiis sapiente. Qui et nam est magni cupiditate nesciunt. Cupiditate quo eum quasi sed. Laborum quia non quo harum corrupti similique.", null, "https://loremflickr.com/320/240?lock=1594499946", 1, "Et occaecati et." },
                    { 69, "Malmekra 15, Gjessjøen, Benin", 1, 57, new DateTime(2022, 6, 7, 23, 3, 23, 4, DateTimeKind.Utc).AddTicks(8053), new DateTime(2022, 6, 13, 17, 11, 6, 448, DateTimeKind.Utc).AddTicks(3084), "Dolor voluptas et repudiandae fugiat aperiam voluptas. Sit alias qui. Rerum amet officia. Sint fuga voluptatem iste autem cupiditate et optio ut odit. Veritatis et accusamus.", null, "https://loremflickr.com/320/240?lock=1611050800", 1, "Suscipit sed accusamus." },
                    { 70, "Kristians Vei 86, Nærmark, Wallis and Futuna", 1, 47, new DateTime(2022, 6, 8, 2, 33, 10, 397, DateTimeKind.Utc).AddTicks(3524), new DateTime(2022, 6, 9, 3, 10, 13, 844, DateTimeKind.Utc).AddTicks(6967), "Delectus et ab. Ipsum itaque beatae perferendis reiciendis libero quia voluptates. Et et reprehenderit ab consequatur iusto deleniti veniam. Eligendi eos soluta aut sint dolores omnis aperiam est. Maiores consequatur non reprehenderit beatae et ipsa nemo ipsam aut.", null, "https://loremflickr.com/320/240?lock=336513893", 1, "Eos velit consequatur." },
                    { 71, "Rognekroken 4, Fetfjell, Singapore", 1, 48, new DateTime(2022, 6, 8, 5, 51, 17, 362, DateTimeKind.Utc).AddTicks(513), new DateTime(2022, 6, 9, 22, 24, 31, 976, DateTimeKind.Utc).AddTicks(9559), "In mollitia adipisci provident. Nihil praesentium quam numquam sed possimus et consectetur. Sint nobis soluta. Porro eaque dolorem quisquam ab sed incidunt. Eos qui veritatis eveniet occaecati vel inventore.", null, "https://loremflickr.com/320/240?lock=1032355558", 1, "Et voluptate est." },
                    { 72, "Johansensvei 28, Malborg, Colombia", 1, 50, new DateTime(2022, 6, 8, 5, 20, 16, 146, DateTimeKind.Utc).AddTicks(3177), new DateTime(2022, 6, 10, 22, 51, 21, 708, DateTimeKind.Utc).AddTicks(4706), "Vel cupiditate quod non hic provident quia rerum. Non sapiente quia possimus. Et perspiciatis cum molestias animi molestiae.", null, "https://loremflickr.com/320/240?lock=608813333", 1, "Aliquid accusantium rerum." },
                    { 73, "Søndre Brugrenda 6, Tandnes, Finland", 1, 60, new DateTime(2022, 6, 7, 20, 56, 19, 923, DateTimeKind.Utc).AddTicks(8753), new DateTime(2022, 6, 8, 12, 43, 43, 856, DateTimeKind.Utc).AddTicks(2521), "Et dolores at saepe architecto qui quas animi. Sit quasi dolore ullam voluptatem. Qui quae molestias reprehenderit occaecati autem rerum qui molestiae. Fugiat velit dolorem architecto.", null, "https://loremflickr.com/320/240?lock=1077980646", 1, "Occaecati est eius." },
                    { 74, "Veggeveien 4, Lilledal, Norfolk Island", 1, 55, new DateTime(2022, 6, 8, 3, 46, 39, 536, DateTimeKind.Utc).AddTicks(318), new DateTime(2022, 6, 10, 0, 43, 9, 228, DateTimeKind.Utc).AddTicks(9894), "Nam fugiat nihil totam qui et. Dolorem nobis nisi quia et beatae sint. Est ut quaerat quo. Repellat nesciunt vitae et. Sint atque quis sit cumque culpa.", null, "https://loremflickr.com/320/240?lock=1327433230", 1, "Assumenda eum quidem." },
                    { 75, "Thomassgate 7, Malstad, Anguilla", 1, 48, new DateTime(2022, 6, 7, 11, 5, 10, 304, DateTimeKind.Utc).AddTicks(8379), new DateTime(2022, 6, 8, 11, 0, 12, 708, DateTimeKind.Utc).AddTicks(644), "Quo dolor voluptatem iure dolore sit quia. Nisi doloremque nemo perferendis. Et eum et velit vero numquam consequatur. Et ab maiores vel.", null, "https://loremflickr.com/320/240?lock=652678265", 1, "Aut qui accusantium." },
                    { 76, "Eriksens Vei 6, Høystrand, Falkland Islands (Malvinas)", 1, 47, new DateTime(2022, 6, 8, 6, 3, 33, 602, DateTimeKind.Utc).AddTicks(7002), new DateTime(2022, 6, 9, 6, 7, 28, 455, DateTimeKind.Utc).AddTicks(5865), "Rem eos eum doloremque libero et. Eos alias aut tenetur dolore dolorem quisquam iure aliquam atque. Dignissimos voluptas quia architecto et placeat. Aut voluptatem non.", null, "https://loremflickr.com/320/240?lock=1275511885", 1, "Quidem et voluptatem." },
                    { 77, "Sebastians Gate 2, Sandstrøm, Liberia", 1, 52, new DateTime(2022, 6, 7, 12, 53, 40, 992, DateTimeKind.Utc).AddTicks(6583), new DateTime(2022, 6, 9, 12, 33, 4, 503, DateTimeKind.Utc).AddTicks(6598), "Nihil voluptatibus voluptas et illum nostrum qui aut alias. Ea cum quod dolor inventore quae non ex. Velit rerum quos vel autem recusandae non totam. Rerum similique eos. Tempora neque et tempora quaerat est dolore.", null, "https://loremflickr.com/320/240?lock=152777975", 1, "Pariatur quia sequi." },
                    { 78, "Fossehaugen 94, Loberg, Western Sahara", 1, 55, new DateTime(2022, 6, 7, 11, 43, 43, 369, DateTimeKind.Utc).AddTicks(3467), new DateTime(2022, 6, 14, 16, 21, 32, 951, DateTimeKind.Utc).AddTicks(6557), "Autem temporibus et. Maxime labore placeat. Unde eaque recusandae et sit. Aspernatur reiciendis eveniet itaque doloribus voluptate.", null, "https://loremflickr.com/320/240?lock=345886486", 1, "In nam natus." },
                    { 79, "Moes Vei 0, Storhelle, Lithuania", 1, 55, new DateTime(2022, 6, 8, 5, 46, 26, 137, DateTimeKind.Utc).AddTicks(3442), new DateTime(2022, 6, 11, 7, 32, 21, 367, DateTimeKind.Utc).AddTicks(3412), "Quisquam blanditiis et fugiat quaerat. Quo inventore aut. Dolorum quasi illo pariatur ea voluptates.", null, "https://loremflickr.com/320/240?lock=636024233", 1, "A est iste." },
                    { 80, "Fridasgate 54, Tandfjell, Indonesia", 1, 53, new DateTime(2022, 6, 7, 12, 16, 49, 195, DateTimeKind.Utc).AddTicks(6743), new DateTime(2022, 6, 13, 4, 10, 8, 645, DateTimeKind.Utc).AddTicks(2293), "Laudantium provident doloremque non sunt voluptatem quia veniam. Corrupti distinctio dolor quis molestiae autem facere ipsum reiciendis iste. Vel qui id quo. Eius suscipit et omnis quibusdam quibusdam reiciendis. Et debitis sunt dolorum similique aut reiciendis. Natus eos nemo.", null, "https://loremflickr.com/320/240?lock=138230806", 1, "Ut vel quisquam." },
                    { 81, "Andersensgate 5, Lillevik, Germany", 1, 48, new DateTime(2022, 6, 7, 21, 47, 54, 414, DateTimeKind.Utc).AddTicks(9375), new DateTime(2022, 6, 10, 15, 54, 13, 229, DateTimeKind.Utc).AddTicks(9662), "Est tempore inventore accusamus autem dolorem eos et quam. Quia eum similique porro quo. Consequatur nobis totam sint et saepe dolores sapiente quasi enim. Aut illum ullam est eligendi et. Aut fugiat illo dolorum.", null, "https://loremflickr.com/320/240?lock=1150322860", 1, "Ut blanditiis autem." },
                    { 82, "Østre Brugjerdet 3, Lomark, Angola", 1, 52, new DateTime(2022, 6, 7, 23, 12, 39, 330, DateTimeKind.Utc).AddTicks(2368), new DateTime(2022, 6, 8, 16, 52, 38, 767, DateTimeKind.Utc).AddTicks(9067), "Cum perspiciatis id est veniam odio sunt soluta laboriosam. Illo maiores excepturi pariatur ut sed. Consequatur voluptatem ea est pariatur molestiae nulla aut. Beatae in aut. Et consequatur laborum. Vero repellat nihil impedit aut fugit ut.", null, "https://loremflickr.com/320/240?lock=941861862", 1, "Porro odit iure." },
                    { 83, "Granengen 7, Malodden, Austria", 1, 47, new DateTime(2022, 6, 8, 9, 16, 48, 136, DateTimeKind.Utc).AddTicks(3701), new DateTime(2022, 6, 12, 16, 32, 47, 794, DateTimeKind.Utc).AddTicks(8800), "Iste dicta dolores ducimus. Saepe enim et. Est consequatur totam dolorem voluptatem ut beatae cupiditate nam. Voluptatibus aut magni sunt sint qui pariatur aut. Minus id voluptatem at qui ut quaerat illo totam.", null, "https://loremflickr.com/320/240?lock=512888137", 1, "Quae enim earum." },
                    { 84, "Sondreveien 77, Lilleberg, Hong Kong", 1, 46, new DateTime(2022, 6, 7, 20, 9, 4, 378, DateTimeKind.Utc).AddTicks(8809), new DateTime(2022, 6, 10, 1, 25, 5, 829, DateTimeKind.Utc).AddTicks(4590), "Qui quisquam doloremque et velit dolor. Inventore et nostrum et placeat sit fugit laudantium tempore quia. Omnis sunt illo qui. Quasi fugit provident et ea aperiam. Dicta quidem inventore quae deserunt debitis nam. Error et rerum aliquam.", null, "https://loremflickr.com/320/240?lock=1661337351", 1, "Voluptate molestiae quia." },
                    { 85, "Tingtunet 37, Nordfjord, Bangladesh", 1, 54, new DateTime(2022, 6, 8, 8, 53, 43, 820, DateTimeKind.Utc).AddTicks(9113), new DateTime(2022, 6, 20, 7, 47, 35, 749, DateTimeKind.Utc).AddTicks(1305), "Iusto in laboriosam aut et ea sint. Aliquid molestias illo. Qui quae magni. Explicabo aliquam et. Nostrum ut soluta recusandae sint. Minima eum iusto sunt dolores veritatis perferendis quia vel dolore.", null, "https://loremflickr.com/320/240?lock=1865509517", 1, "Ipsam voluptatem et." },
                    { 86, "Maries Vei 25, Nærstrand, Bahrain", 1, 49, new DateTime(2022, 6, 8, 10, 57, 3, 936, DateTimeKind.Utc).AddTicks(3710), new DateTime(2022, 6, 11, 20, 53, 20, 511, DateTimeKind.Utc).AddTicks(8807), "Earum laborum facere recusandae. Sapiente illum est voluptas ut perspiciatis. In delectus quia perferendis aperiam. Nisi architecto odio rerum ex beatae magni dolore quia. Et et quia eos libero possimus corporis incidunt nulla.", null, "https://loremflickr.com/320/240?lock=476679648", 1, "Voluptatem sint iste." },
                    { 87, "Øvre Malmmoen 4, Stavborg, Uganda", 1, 55, new DateTime(2022, 6, 7, 21, 16, 59, 913, DateTimeKind.Utc).AddTicks(230), new DateTime(2022, 6, 9, 6, 38, 0, 718, DateTimeKind.Utc).AddTicks(7793), "Animi reiciendis voluptatum pariatur eum consequuntur labore doloribus. Vero at adipisci. Culpa libero ut rem vel molestias et molestiae exercitationem quo. Ad minus quia ad quo aspernatur enim. Est sed quaerat veritatis ea. Omnis dolorem est quos voluptatem facilis voluptates.", null, "https://loremflickr.com/320/240?lock=1556424747", 1, "Molestiae sed rem." },
                    { 88, "Malingata 8, Sandby, San Marino", 1, 52, new DateTime(2022, 6, 7, 19, 39, 59, 215, DateTimeKind.Utc).AddTicks(4658), new DateTime(2022, 6, 13, 14, 11, 27, 17, DateTimeKind.Utc).AddTicks(342), "Voluptatem velit fugiat odit magnam. Et quis quia placeat ipsam ipsa. Fugiat est rem quia incidunt ut accusantium. Omnis eveniet voluptatem ut nam laboriosam commodi laudantium.", null, "https://loremflickr.com/320/240?lock=1012145067", 1, "Quia autem aut." },
                    { 89, "Karolinesvei 46, Stavstrøm, Senegal", 1, 46, new DateTime(2022, 6, 7, 21, 14, 33, 810, DateTimeKind.Utc).AddTicks(7015), new DateTime(2022, 6, 8, 14, 4, 40, 309, DateTimeKind.Utc).AddTicks(1528), "Illum quam incidunt et reprehenderit rerum et illo tempore. Earum dolor non animi. Accusantium vel deserunt nihil doloribus mollitia nobis sit debitis error. Aliquid nihil sequi ad quis. Minima aut eum omnis esse quis neque qui iste quia. Aliquid inventore distinctio voluptates alias eum est ea nobis voluptates.", null, "https://loremflickr.com/320/240?lock=693895452", 1, "Sunt ea molestiae." },
                    { 90, "Solbergveien 42, Gjesfjell, Cyprus", 1, 55, new DateTime(2022, 6, 7, 20, 20, 9, 327, DateTimeKind.Utc).AddTicks(5669), new DateTime(2022, 6, 11, 2, 51, 10, 297, DateTimeKind.Utc).AddTicks(3957), "Porro eum blanditiis autem. Alias nam laboriosam in nesciunt sint dolores. Sit hic rerum quia iure non sequi. Dolores eum velit ipsum vel vel eius voluptatum laborum. Numquam corporis veritatis ut.", null, "https://loremflickr.com/320/240?lock=1587278912", 1, "Rerum quia in." }
                });

            migrationBuilder.CreateIndex(
                name: "ix_companies_author_id",
                table: "companies",
                column: "author_id");

            migrationBuilder.CreateIndex(
                name: "ix_contacts_author_id",
                table: "contacts",
                column: "author_id");

            migrationBuilder.CreateIndex(
                name: "ix_contacts_company_id",
                table: "contacts",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "ix_folders_author_id",
                table: "folders",
                column: "author_id");

            migrationBuilder.CreateIndex(
                name: "ix_jobs_author_id",
                table: "jobs",
                column: "author_id");

            migrationBuilder.CreateIndex(
                name: "ix_jobs_company_id",
                table: "jobs",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "ix_jobs_folder_id",
                table: "jobs",
                column: "folder_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropTable(
                name: "companies");

            migrationBuilder.DropTable(
                name: "folders");

            migrationBuilder.DropTable(
                name: "accounts");
        }
    }
}
