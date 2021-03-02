using System;

namespace _04.TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Input : numberTables (int), lenghtTable(double), wightTable(double).
            // 2. Calculate area of the table
            // 3. Calculate lenght of the tablecloth.
            // 4. Calculate wight of the tablecloth.
            // 5. Calculate area of the tablecloth.
            // 6. Calculate side of the quad.
            // 7. Calculate area of the quad.
            // 8. Input price per square meter tableclouth in USD.
            // 9. Input price per square meter quad in USD.
            // 10. Input dollar exchange rate.
            // 11. Calculate total square meters of tablecloth.
            // 12. Calculate total square meters of quads.
            // 13. Calculate total price of the tablecloths.
            // 14. Calculate total price of the quads.
            // 15. Print total prices of the tableclouths and the quads.

            int numberTables = int.Parse(Console.ReadLine());
            double lenghtTable = double.Parse(Console.ReadLine());
            double wightTable = double.Parse(Console.ReadLine());

            double areaTable = lenghtTable * wightTable;

            double lenghtTableclouth = lenghtTable + (2 * 0.3);
            double wightTableclouth = wightTable + (2 * 0.3);
            double areaTableclouth = lenghtTableclouth * wightTableclouth;

            double sideQuad = lenghtTable * 0.5;
            double areaQuad = sideQuad * sideQuad;

            double priceSquareMeterTablecloth = 7;
            double priceSquareMeterQuad = 9;

            double totalSquareMetersTableclouths = numberTables * areaTableclouth;
            double totalSquareMetersQuads = numberTables * areaQuad;

            double totalPriceTableclouths = totalSquareMetersTableclouths * priceSquareMeterTablecloth;
            double totalPriceQuads = totalSquareMetersQuads * priceSquareMeterQuad;
            double totalPriceAllUSD = totalPriceTableclouths + totalPriceQuads;
            double totalPriceAllBGN = totalPriceAllUSD * 1.85;

            Console.WriteLine($"{totalPriceAllUSD:F2} USD");
            Console.WriteLine($"{totalPriceAllBGN:F2} BGN");



        }
    }
}
