Console.WriteLine("Введите количество пройденых месяцев: ");
string passed_months = Console.ReadLine();
try
{
    int n = Convert.ToInt32(passed_months);
    if (n > 2500)
    {
        Console.WriteLine("\n Произошла ошибка. \n Введите заново количество пройденых месяцев.");
    }
    else
    {
        string first_date = "01.01.1990";
        string[] first_date_split = first_date.Split('.', 3);
        int day = Convert.ToInt32(first_date_split[0]);
        int month = Convert.ToInt32(first_date_split[1]);
        int year_int = Convert.ToInt32(first_date_split[2]);
        while (n >= 12)
        {
            n -= 12;
            year_int += 1;
        }
        month += n;
        int month_code = 0;
        int calc_year_code = 0;
        string year_str = Convert.ToString(year_int);
        string last_year_num = Convert.ToString(year_str[1]);
        string[] year_partit = year_str.Split(last_year_num, 2);
        if (Convert.ToInt32(last_year_num) == 9)
        {
            calc_year_code = 0;
        }
        if (Convert.ToInt32(last_year_num) == 0)
        {
            calc_year_code = 6;
        }
        if (Convert.ToInt32(last_year_num) == 1)
        {
            calc_year_code = 4;
        }
        int year_code = (calc_year_code + Convert.ToInt32(year_partit[1]) + Convert.ToInt32(year_partit[1]) / 4) % 7;
        Console.WriteLine("Ответ: ");
        switch (month)
        {
            case 1:
                {
                    Console.WriteLine("Январь");
                    if (DateTime.IsLeapYear(year_int) == true)
                    {
                        month_code = 0;
                    }
                    else
                    {
                        month_code = 1;
                    }
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Февраль");
                    if (DateTime.IsLeapYear(year_int) == true)
                    {
                        month_code = 3;
                    }
                    else
                    {
                        month_code = 4;
                    }
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Март");
                    month_code = 4;
                    break;
                }
            case 4:
                {
                    Console.WriteLine("Апрель");
                    month_code = 0;
                    break;
                }
            case 5:
                {
                    Console.WriteLine("Май");
                    month_code = 2;
                    break;
                }
            case 6:
                {
                    Console.WriteLine("Июнь");
                    month_code = 5;
                    break;
                }
            case 7:
                {
                    Console.WriteLine("Июль");
                    month_code = 0;
                    break;
                }
            case 8:
                {
                    Console.WriteLine("Август");
                    month_code = 3;
                    break;
                }
            case 9:
                {
                    Console.WriteLine("Сентябрь");
                    month_code = 6;
                    break;
                }
            case 10:
                {
                    Console.WriteLine("Октябрь");
                    month_code = 1;
                    break;
                }
            case 11:
                {
                    Console.WriteLine("Ноябрь");
                    month_code = 4;
                    break;
                }
            case 12:
                {
                    Console.WriteLine("Декабрь");
                    month_code = 6;
                    break;
                }
        }
        if (day < 10)
        {
            Console.Write("0");
        }
        Console.Write(day + ".");
        if (month < 10)
        {
            Console.Write("0");
        }
        Console.Write(month + ".");
        Console.Write(year_int + "\n");
        int DotW = (day + month_code + year_code) % 7;
        Console.WriteLine("День недели: ");
        switch (DotW)
        {
            case 0: 
                Console.WriteLine("Суббота"); break;
            case 1:
                Console.WriteLine("Воскресенье"); break;
            case 2:
                Console.WriteLine("Понедельник"); break;
            case 3:
                Console.WriteLine("Вторник"); break;
            case 4:
                Console.WriteLine("Среда"); break;
            case 5:
                Console.WriteLine("Четверг"); break;
            case 6:
                Console.WriteLine("Пятница"); break;

        }
        if (DateTime.IsLeapYear(year_int) == true)
        {
            Console.WriteLine("Это високосный год");
        }
        else
        {
            Console.WriteLine("Это не високосный год");
        }
    }
}
catch (Exception)
{
    Console.WriteLine("\n Произошла ошибка. \n Введите заново количество пройденых месяцев.");
}
