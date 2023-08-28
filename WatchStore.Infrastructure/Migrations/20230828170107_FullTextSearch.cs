using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WatchStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FullTextSearch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
    sql: "CREATE FULLTEXT CATALOG ftCatalog AS DEFAULT;",
    suppressTransaction: true);
            migrationBuilder.Sql(
    sql: "CREATE FULLTEXT INDEX ON WristWatches (Name) KEY INDEX PK_WristWatches;",
    suppressTransaction: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
