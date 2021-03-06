﻿using Nager.Date.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nager.Date.PublicHolidays
{
    public class SwedenProvider : CatholicBaseProvider
    {
        public override IEnumerable<PublicHoliday> Get(int year)
        {
            //Sweden
            //https://en.wikipedia.org/wiki/Public_holidays_in_Sweden

            var countryCode = CountryCode.SE;
            var easterSunday = base.EasterSunday(year);

            var midsummerDay = DateSystem.FindDay(year, 6, 20, DayOfWeek.Saturday);
            var allSaintsDay = DateSystem.FindDay(year, 10, 31, DayOfWeek.Saturday);

            var items = new List<PublicHoliday>();

            //Holidays on set dates
            items.Add(new PublicHoliday(year, 1, 1, "Nyårsdagen", "New Year's Day", countryCode));
            items.Add(new PublicHoliday(year, 1, 5, "Trettondagsafton", "Twelth night", countryCode));
            items.Add(new PublicHoliday(year, 1, 6, "Trettondedag jul", "Epiphany", countryCode));
            items.Add(new PublicHoliday(year, 2, 14, "Alla hjärtans dag", "Valentines Day", countryCode));
            items.Add(new PublicHoliday(year, 4, 30, "Valborgsmässoafton", "Walpurgis night", countryCode));
            items.Add(new PublicHoliday(year, 5, 1, "Första maj", "International Workers' Day", countryCode));
            items.Add(new PublicHoliday(year, 6, 6, "Nationaldagen", "National Day of Sweden", countryCode));
            items.Add(new PublicHoliday(year, 12, 24, "Julafton", "Christmas Eve", countryCode));
            items.Add(new PublicHoliday(year, 12, 25, "Juldagen", "Christmas Day", countryCode));
            items.Add(new PublicHoliday(year, 12, 26, "Annandag jul", "St. Stephen's Day", countryCode));
            items.Add(new PublicHoliday(year, 12, 31, "Nyårsafton", "New Year's Eve", countryCode));

            //Holidays related to Easter Sunday
            items.Add(new PublicHoliday(easterSunday.AddDays(-47), "Fettisdagen", "Shrove Tuesday", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(-46), "Askonsdagen", "Ash Wednesday", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(-7), "Palmsöndagen", "Palm Sunday", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(-4), "Dymmelonsdagen", "Holy Wednesday", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(-3), "Skärtorsdagen", "Maundy Thursday", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(-2), "Långfredagen", "Good Friday", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(-1), "Påskafton", "Easter Saturday", countryCode));
            items.Add(new PublicHoliday(easterSunday, "Påskdagen", "Easter Sunday", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(1), "Annandag påsk", "Easter Monday", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(39), "Kristi himmelsfärdsdag", "Ascension Day", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(48), "Pingstafton", "Whitsun Eve", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(49), "Pingstdagen", "Withsun Day", countryCode));

            //Holidays on set week days, with floating dates
            //According to the Swedish Church - the first Sunday between March 22 and 28. According to the Catholic Church - March 25 
            items.Add(new PublicHoliday(DateSystem.FindDay(year, 3, 22, DayOfWeek.Sunday), "Jungfru Marie bebådelsedag", "", countryCode));
            items.Add(new PublicHoliday(DateSystem.FindLastDay(year, 5, DayOfWeek.Sunday), "Mors dag", "Mother's Day", countryCode));
            items.Add(new PublicHoliday(midsummerDay.AddDays(-1), "Midsommarafton", "Midsummer Eve", countryCode));
            items.Add(new PublicHoliday(midsummerDay, "Midsommardagen", "Midsummer Day", countryCode));
            items.Add(new PublicHoliday(allSaintsDay.AddDays(-1), "Allhelgonaafton", "Saint's Eve", countryCode));
            items.Add(new PublicHoliday(allSaintsDay, "Alla helgons dag", "All Saints' Day", countryCode));
            items.Add(new PublicHoliday(DateSystem.FindDay(year, 11, DayOfWeek.Sunday, 2), "Fars dag", "Father's Day", countryCode));
            items.Add(new PublicHoliday(DateSystem.FindDay(year, 11, 27, DayOfWeek.Sunday), "Första advent", "Advent", countryCode));
            items.Add(new PublicHoliday(DateSystem.FindDay(year, 12, 4, DayOfWeek.Sunday), "Andra advent", "Second of Advent", countryCode));
            items.Add(new PublicHoliday(DateSystem.FindDay(year, 12, 11, DayOfWeek.Sunday), "Tredje advent", "Third of Advent", countryCode));
            items.Add(new PublicHoliday(DateSystem.FindDay(year, 12, 18, DayOfWeek.Sunday), "Fjärde advent", "Fourth of Advent", countryCode));

            return items.OrderBy(o => o.Date);
        }
    }
}
