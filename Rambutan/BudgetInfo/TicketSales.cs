using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals;

namespace Zoo.BudgetInfo
{
    class TicketSales
    {
        private const int ticketAdult = 10;
        private const int ticketReduced = 5;
        //private const int averageVisitors = 50;
        private const decimal visitorsReducedPercentage = 0.4m;
        private const decimal visitorsAdultPercentage = 0.6m;
        
        const int averageVisitors = 50;

        DateTime startDate = DateTime.Now;
        List<DateTime> holidays = new List<DateTime> { new DateTime(2015, 4, 8), new DateTime(2015, 4, 16), new DateTime(2015, 5, 24), new DateTime(2015, 9, 6), new DateTime(2015, 5, 1) };
        

        public void ticketSales(DateTime date)
        {
            int visitors = 50;
            //The most people will come if its a holiday and weekday at the same time. Then if its a holiday, then if its a weekday, and them if its a working day
            if (holidays.Contains(date) && (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday))
            {
                visitors = 50 * 4;
            }
            else if (holidays.Contains(date))
            {
                visitors = 50 * 3;
            }
            else if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                visitors = 50 * 2;
            }



            //visitors * ticket price + type of visitor
            decimal dailyTicketSales = (visitors * visitorsReducedPercentage * ticketReduced) + (visitors * visitorsAdultPercentage * ticketAdult);
            BudgetInfo.Budget.Instance.AddIncome("Tickets" + date, dailyTicketSales);
        }

        
    }
}
