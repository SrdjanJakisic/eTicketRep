using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class ActorId1Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Actors_ActorId1",
                table: "Actor_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Movies_ActorId",
                table: "Actor_Movies");

            migrationBuilder.DropIndex(
                name: "IX_Actor_Movies_ActorId1",
                table: "Actor_Movies");

            migrationBuilder.DropColumn(
                name: "ActorId1",
                table: "Actor_Movies");

            migrationBuilder.CreateIndex(
                name: "IX_Actor_Movies_MovieId",
                table: "Actor_Movies",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Actors_ActorId",
                table: "Actor_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Movies_MovieId",
                table: "Actor_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Actors_ActorId",
                table: "Actor_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Movies_MovieId",
                table: "Actor_Movies");

            migrationBuilder.DropIndex(
                name: "IX_Actor_Movies_MovieId",
                table: "Actor_Movies");

            migrationBuilder.AddColumn<int>(
                name: "ActorId1",
                table: "Actor_Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Actor_Movies_ActorId1",
                table: "Actor_Movies",
                column: "ActorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Actors_ActorId1",
                table: "Actor_Movies",
                column: "ActorId1",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Movies_ActorId",
                table: "Actor_Movies",
                column: "ActorId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
