using System;

namespace _07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Input height house - front and back walls (x).
            // 2. Input lenght side wall (y). 
            // 3. Input height roof (h). 

            //       Calculate Green area.

            // 4. Calculate side wall area.
            // 5. Calculate window area.
            // 6. Calculate side wall painting area.
            // 7. Calculate total side walls painting area.

            // 8. Calculate front and back area.
            // 9. Calculate door area.
            // 10. Calculate total front and back painting area.

            // 11. Calculate total green area.

            //      Caculate Red area.

            // 12. Calculate Reactangle area.
            // 13. Calculate total rectangle area.
            // 14. Calculate triangle area.
            // 15. Calcuate total triangle area.
            // 16. Calculate total Red Area.

            //     Calculate litters paint. 

            // 17. Calculate green paint litters.
            // 18. Calculate red paint litters.

            // 19. Print green paint litters.
            // 20. Print red paint litters.

            double heightHouseX = double.Parse(Console.ReadLine());
            double lenghtSideWallY = double.Parse(Console.ReadLine());
            double heightRoofH = double.Parse(Console.ReadLine());

            double sideWallArea = heightHouseX * lenghtSideWallY;
            double windowArea = 1.5 * 1.5;
            double sideWallPaintingArea = sideWallArea - windowArea;
            double totalSideWallsPaintingArea = sideWallPaintingArea * 2;

            double frontAndBackArea = (heightHouseX * heightHouseX) * 2;
            double doorArea = 1.2 * 2.0;
            double totalFrontAndBackPaintingArea = frontAndBackArea - doorArea;

            double totalGreenArea = totalSideWallsPaintingArea + totalFrontAndBackPaintingArea;

            double rectangleRoofArea = heightHouseX * lenghtSideWallY;
            double totalRectangleRoofArea = rectangleRoofArea + rectangleRoofArea;

            double triangleRoofArea = (heightHouseX * heightRoofH) / 2;
            double totalTriangleRoofArea = triangleRoofArea + triangleRoofArea;

            double totalRedArea = totalRectangleRoofArea + totalTriangleRoofArea;

            double greenPaintLitters = totalGreenArea / 3.4;
            double redPaintLitters = totalRedArea / 4.3;

            Console.WriteLine("{0:F2}", greenPaintLitters);
            Console.WriteLine("{0:F2}", redPaintLitters);



        }
    }
}
