using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SugarDecoration.Infrastructure.Migrations
{
	public partial class UpdateOnConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1182e1d8-c799-413d-a9d3-c809966f5ed2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "664c641b-55cd-4708-b246-e61af33c6bac", "AQAAAAEAACcQAAAAEMrTql04o9w3ebG43irWUUt18dWRxEsze6HsvhIowcLfaCwNp9THJavwWdyMnDT97Q==", "de4e8746-9f0d-40d1-aca1-65f7435ae428" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b034442-ee41-4acb-92cb-374f72d60a59",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd2bc12f-53f9-4a12-bea9-99144a9c0350", "AQAAAAEAACcQAAAAEJeHc7TZw1JH7ruOL+kCUUxz9QDj8zaVCHR4ChdNF9Ak7Zyefnhf1M/nBEi0CDNJew==", "35c94506-e15a-43c2-91e9-9ea3736f15c7" });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 20, 20, 13, 15, 667, DateTimeKind.Local).AddTicks(4233), new DateTime(2024, 4, 20, 20, 13, 15, 667, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2198), "~/images/seeding/cake/GoldenRoses.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 13, 15, 665, DateTimeKind.Local).AddTicks(2290));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1182e1d8-c799-413d-a9d3-c809966f5ed2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e18aa56-6d29-478f-bc8d-2d9564e008cd", "AQAAAAEAACcQAAAAEF6qg6RpleLMAdg21a8KzZdvspyc/qBFlZ3pSVxIsAX/VZFHm+dBpqNm18CR45WGfw==", "3a80c33b-39c7-4a42-a68f-c4adfabf0bc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b034442-ee41-4acb-92cb-374f72d60a59",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b025632-58e6-4470-8ffd-6307f06e4129", "AQAAAAEAACcQAAAAEMlinuui1xzh/+LJctBo3SX4oaaUe6GozHAMdcPr8rNPVC0VcKMUhCArMKh1ceGEVA==", "f7935196-bace-4331-8c62-a19316b008be" });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 4, 20, 20, 11, 56, 338, DateTimeKind.Local).AddTicks(8123), new DateTime(2024, 4, 20, 20, 11, 56, 338, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5851), "~/images/seeding/cakes/GoldenRoses.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedOn",
                value: new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5902));
        }
    }
}
