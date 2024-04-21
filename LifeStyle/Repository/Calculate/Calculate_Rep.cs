using LifeStyle.Interface.Calculate;
using MD.PersianDateTime;

namespace LifeStyle.Repository.Calculate
{
    public class Calculate_Rep : ICalculate
    {
        public int NumberOfDay(PersianDateTime StartDate)
        {
            // Get current Persian date
            PersianDateTime currentDate = new PersianDateTime(DateTime.Now);

            // Calculate time difference
            TimeSpan timeSpan = currentDate.Subtract(StartDate);

            // Extract days
            int daysElapsed = timeSpan.Days;

            return daysElapsed;
        }

        public int NumberOfMonth(PersianDateTime StartDate)
        {
            // Get current Persian date
            PersianDateTime currentDate = new PersianDateTime(DateTime.Now);

            // Calculate year difference
            int yearDiff = currentDate.Year - StartDate.Year;

            // Calculate month difference considering year changes
            int monthDiff = currentDate.Month - StartDate.Month;

            // Handle cases where current month is less than start month (meaning a year has passed)
            if (monthDiff < 0)
            {
                yearDiff--;
                monthDiff += 12;
            }

            // Return total number of months elapsed
            return yearDiff * 12 + monthDiff;
        }


        public int NumberOfThreeMonth(PersianDateTime StartDate)
        {
            // Get current Persian date
            PersianDateTime currentDate = new PersianDateTime(DateTime.Now);

            // Calculate year difference
            int yearDiff = currentDate.Year - StartDate.Year;

            // Calculate month difference considering year changes
            int monthDiff = currentDate.Month - StartDate.Month;

            // Handle cases where current month is less than start month (meaning a year has passed)
            if (monthDiff < 0)
            {
                yearDiff--;
                monthDiff += 12;
            }

            // Calculate quarters considering month difference
            int quarters = yearDiff * 4; // Quarters in a year

            // Adjust quarters based on month difference
            switch (monthDiff)
            {
                case 0: // Current month same as start month
                case 1: // or one month more
                case 2: // or two months more
                    quarters += 0; // No additional quarters
                    break;
                case 3: // or three months more (1st quarter)
                case 4: // or four months more (1st and 2nd quarter)
                case 5: // or five months more (1st, 2nd and 3rd quarter)
                    quarters += 1; // Add 1 quarter
                    break;
                default: // Any other month difference (past the 3rd quarter of the current year)
                    quarters += 2; // Add 2 quarters
                    break;
            }

            return quarters;
        }


        public int NumberOfWeek(PersianDateTime StartDate)
        {
            // Get current Persian date
            PersianDateTime currentDate = new PersianDateTime(DateTime.Now);

            // Calculate the difference in days
            TimeSpan timeSpan = currentDate.Subtract(StartDate);
            int totalDays = timeSpan.Days;

            // Calculate weeks (assuming 7 days per week)
            int weeks = totalDays / 7;

            // Handle cases where there are remaining days (incomplete week)
            if (totalDays % 7 > 0)
            {
                weeks++;
            }

            return weeks;
        }


        public int NumberOfYear(PersianDateTime StartDate)
        {
            // Get current Persian date
            PersianDateTime currentDate = new PersianDateTime(DateTime.Now);

            // Calculate year difference
            int yearDiff = currentDate.Year - StartDate.Year;

            // Handle cases where current month is less than start month (meaning a year has passed but not complete)
            if (currentDate.Month < StartDate.Month)
            {
                yearDiff--;
            }

            return yearDiff;
        }

    }
}
