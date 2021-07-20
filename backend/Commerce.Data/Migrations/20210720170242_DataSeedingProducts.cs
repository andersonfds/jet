using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Commerce.Data.Migrations
{
    public partial class DataSeedingProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CascadeMode", "Description", "Name", "PhotoUri", "Price" },
                values: new object[] { new Guid("449fed22-3db3-47a9-a564-03f15c8e5e61"), 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Produto Teste 1", "https://picsum.photos/seed/1/200/200", 10.989999771118164 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CascadeMode", "Description", "Name", "PhotoUri", "Price" },
                values: new object[] { new Guid("a3d35592-7090-47a7-8841-7a423c319e2d"), 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Produto Teste 2", "https://picsum.photos/seed/2/200/200", 15.989999771118164 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CascadeMode", "Description", "Name", "PhotoUri", "Price" },
                values: new object[] { new Guid("238476e4-323e-4eb2-9032-96f15e63be78"), 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Produto Teste 3", "https://picsum.photos/seed/3/200/200", 599.989990234375 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CascadeMode", "Description", "Name", "PhotoUri", "Price" },
                values: new object[] { new Guid("c5635503-ebec-4fd9-9d00-c816cfae215a"), 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Produto Teste 4", "https://picsum.photos/seed/4/200/200", 599.989990234375 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CascadeMode", "Description", "Name", "PhotoUri", "Price" },
                values: new object[] { new Guid("9c51a7c1-a189-44bb-8b22-4d74999dc43b"), 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Produto Teste 5", "https://picsum.photos/seed/5/200/200", 599.989990234375 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("238476e4-323e-4eb2-9032-96f15e63be78"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("449fed22-3db3-47a9-a564-03f15c8e5e61"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9c51a7c1-a189-44bb-8b22-4d74999dc43b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a3d35592-7090-47a7-8841-7a423c319e2d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c5635503-ebec-4fd9-9d00-c816cfae215a"));
        }
    }
}
