using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Petersen
{
    class DeskQuote
    {
        //members
        private string custName;
        private DateTime quoteDate;
        private uint rushOrder;
        private double quoteTotal;

        //methods
        public string CustName { get; set; }
        public uint RushOrder { get; set; }
        public DateTime QuoteDate { get; set; }

        public double QuoteTotal(int material, double shippingCost, double surfaceArea, uint drawers)
        {
            int basePrice = 200;
            drawers *= 50;

            quoteTotal = basePrice + shippingCost + surfaceArea + drawers;

            return quoteTotal;
        }

        public double calcSurfaceArea(double width, double depth)
        {
            double surfaceArea = width * depth;

            return surfaceArea;
        }

        public double calcShippingCost (double surfaceArea, uint rushOrder)
        {
            int shipCost;
            int rushCost;

            if (surfaceArea >= 4000)
                shipCost = 0;
            else if (surfaceArea >= 3000)
                shipCost = 50;
            else if (surfaceArea >= 2000)
                shipCost = 40;
            else
                shipCost = 30;

            switch (rushOrder)
            {
                case 3:
                    if (surfaceArea < 1000)
                        rushCost = 60;
                    else if (surfaceArea <= 2000)
                        rushCost = 70;
                    else
                        rushCost = 80;
                    break;
                case 5:
                    if (surfaceArea < 1000)
                        rushCost = 40;
                    else if (surfaceArea <= 2000)
                        rushCost = 50;
                    else
                        rushCost = 60;
                    break;
                case 7:
                    if (surfaceArea < 1000)
                        rushCost = 30;
                    else if (surfaceArea <= 2000)
                        rushCost = 35;
                    else
                        rushCost = 40;
                    break;
                default:
                    rushCost = 0;
                    break;
            }

                double shippingCost = shipCost + rushCost;

            return shippingCost;
        }
    }
}
