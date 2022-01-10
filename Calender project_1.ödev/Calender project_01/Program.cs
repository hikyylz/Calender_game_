using System;       // Halil İBRAHİM KAAN YILDIZ--2020510074

namespace Calender_project
{
    class Program
    {
        static public void Main(string[] args)
        {
            string strday1, strmonth1, stryear1, strday2, strmonth2, stryear2;
            bool isCalenderOn = true;

            Console.WriteLine("You will give me two dates that are different and later than 01.01.2015");
            while (isCalenderOn)
            {
                Console.WriteLine("Now, please enter the day of the first date as a number (i.e 15)");
                strday1 = Console.ReadLine();
                if (strday1 == "1" || strday1 == "2" || strday1 == "3" || strday1 == "4" || strday1 == "5" || strday1 == "6" || strday1 == "7" || strday1 == "8" || strday1 == "9" || strday1 == "10" || strday1 == "11" || strday1 == "12" || strday1 == "13" || strday1 == "14" || strday1 == "15" || strday1 == "16" || strday1 == "17" || strday1 == "18" || strday1 == "19" || strday1 == "20" || strday1 == "21" || strday1 == "22" || strday1 == "23" || strday1 == "24" || strday1 == "25" || strday1 == "26" || strday1 == "27" || strday1 == "28" || strday1 == "29" || strday1 == "30" || strday1 == "31")
                {
                    int day1, year1, day2, year2, n;
                    day1 = Convert.ToInt32(strday1); //string olan inputu integer yaptm.
                    Console.WriteLine("Now, please enter the month of the first date ");
                    strmonth1 = Console.ReadLine();
                    strmonth1 = strmonth1.ToLower();

                    if (strmonth1 == "january" || strmonth1 == "february" || strmonth1 == "march" || strmonth1 == "april" || strmonth1 == "may" || strmonth1 == "june" || strmonth1 == "july" || strmonth1 == "august" || strmonth1 == "september" || strmonth1 == "october" || strmonth1 == "november" || strmonth1 == "december")
                    {
                        switch (day1)
                        {
                            case 29:    
                                break;
                            case 30:
                                if (strmonth1 == "february")
                                {
                                    do
                                    {
                                        Console.WriteLine("cannot enter february if you entred a number greatter than 29.");
                                        Console.WriteLine("Now, please enter the month of the first date ");
                                        strmonth1 = Console.ReadLine();
                                    } while (strmonth1 == "february");
                                    break;
                                }
                                break;

                            case 31:
                                if (strmonth1 == "february" || strmonth1 == "april" || strmonth1 == "june" || strmonth1 == "september" || strmonth1 == "november")
                                {
                                    do
                                    {
                                        Console.WriteLine("you entered unvalid month name, try again");
                                        Console.WriteLine("Now, please enter the month of the first date ");
                                        strmonth1 = Console.ReadLine();
                                    } while (strmonth1 == "february" || strmonth1 == "april" || strmonth1 == "june" || strmonth1 == "september" || strmonth1 == "november");
                                    break;
                                }
                                break;

                            default:
                                break;
                        }

                        Console.WriteLine("Now, please enter the year of the first date as a number");

                        bool flag = true;
                        do
                        {
                            stryear1 = Console.ReadLine();
                            if (int.TryParse(stryear1, out year1))
                            {
                                if (year1 < 2015)
                                {
                                    Console.WriteLine(" Please enter a year as a number later than 1.1.2015 .");
                                    continue;
                                }
                                else
                                    flag = false;
                            }
                            else
                                Console.WriteLine(" Please enter a year as a number.");

                        } while (flag);

                        int kalan = year1 - 2016;
                        if (year1 >= 2015)
                        {
                            if (day1 == 29 && strmonth1 == "february")
                            {
                                if (kalan % 4 == 0) // artık yıl ise gir.
                                {
                                }
                                else
                                {
                                    do
                                    {
                                        Console.WriteLine(" Please enter a Leap Year if you insist to continue with 29 February. ");
                                        Console.WriteLine(" Now, please enter the year of the first date as a number");
                                        flag = true;
                                        do
                                        {
                                            stryear1 = Console.ReadLine();
                                            if (int.TryParse(stryear1, out year1))
                                            {
                                                if (year1 < 2015)
                                                {
                                                    Console.WriteLine(" Please enter a year as a number.");
                                                    continue;
                                                }
                                                else
                                                    flag = false;
                                            }
                                            else
                                                Console.WriteLine(" Please enter a year as a number.");

                                        } while (flag);

                                        kalan = year1 - 2016;
                                    } while (kalan % 4 != 0);
                                }
                            }

                            Console.WriteLine("congratulations, now enter the second date");    // ilk tarih oluşturuldu.
                            Console.WriteLine("Now, please enter the day of the second date as a number (i.e 9 )");

                            strday2 = Console.ReadLine();
                            if (strday2 == "1" || strday2 == "2" || strday2 == "3" || strday2 == "4" || strday2 == "5" || strday2 == "6" || strday2 == "7" || strday2 == "8" || strday2 == "9" || strday2 == "10" || strday2 == "11" || strday2 == "12" || strday2 == "13" || strday2 == "14" || strday2 == "15" || strday2 == "16" || strday2 == "17" || strday2 == "18" || strday2 == "19" || strday2 == "20" || strday2 == "21" || strday2 == "22" || strday2 == "23" || strday2 == "24" || strday2 == "25" || strday2 == "26" || strday2 == "27" || strday2 == "28" || strday2 == "29" || strday2 == "30" || strday2 == "31")
                            {
                                day2 = Convert.ToInt32(strday2); //string olan inputu integer yaptm.
                                Console.WriteLine("Now, please enter the month of the second date ");
                                strmonth2 = Console.ReadLine();
                                strmonth2 = strmonth2.ToLower();

                                if (strmonth2 == "january" || strmonth2 == "february" || strmonth2 == "march" || strmonth2 == "april" || strmonth2 == "may" || strmonth2 == "june" || strmonth2 == "july" || strmonth2 == "august" || strmonth2 == "september" || strmonth2 == "october" || strmonth2 == "november" || strmonth2 == "december")
                                {
                                    switch (day2)
                                    {
                                        case 29:
                                            break;
                                        case 30:
                                            if (strmonth2 == "february")
                                            {
                                                do
                                                {
                                                    Console.WriteLine("cannot enter february if you entred a number greatter than 29.");
                                                    Console.WriteLine("Now, please enter the month of the second date ");
                                                    strmonth2 = Console.ReadLine();
                                                } while (strmonth2 == "february");
                                                break;
                                            }
                                            break;

                                        case 31:
                                            if (strmonth2 == "february" || strmonth2 == "april" || strmonth2 == "june" || strmonth2 == "september" || strmonth2 == "november")
                                            {
                                                do
                                                {
                                                    Console.WriteLine("you entered unvalid month name, try again");
                                                    Console.WriteLine("Now, please enter the month of the second date ");
                                                    strmonth2 = Console.ReadLine();
                                                } while (strmonth2 == "february" || strmonth2 == "april" || strmonth2 == "june" || strmonth2 == "september" || strmonth2 == "november");
                                                break;
                                            }
                                            break;

                                        default:
                                            break;
                                    }

                                    Console.WriteLine("Now, please enter the year of the second date as a number");

                                    bool flagForYear = true;
                                    do
                                    {
                                        stryear2 = Console.ReadLine();
                                        if (int.TryParse(stryear2, out year2))
                                        {
                                            flagForYear = false;
                                        }
                                        else
                                            Console.WriteLine(" Please enter a year as a number.");

                                    } while (flagForYear);

                                    kalan = year2 - 2016;
                                    if (year2 >= 2015)
                                    {
                                        if (day2 == 29 && strmonth2 == "february")
                                        {
                                            if (kalan % 4 == 0) // artık yıl ise gir.
                                            {
                                            }
                                            else
                                            {
                                                do
                                                {
                                                    Console.WriteLine(" Please enter a Leap Year if you insist to continue with 29 February. ");
                                                    Console.WriteLine(" Now, please enter the year of the second date as a number");
                                                    flag = true;
                                                    do
                                                    {
                                                        stryear2 = Console.ReadLine();
                                                        if (int.TryParse(stryear2, out year2))
                                                        {
                                                            if (year2 < 2015)
                                                            {
                                                                Console.WriteLine(" Please enter a year as a number.");
                                                                continue;
                                                            }
                                                            else
                                                                flag = false;
                                                        }
                                                        else
                                                            Console.WriteLine(" Please enter a year as a number.");

                                                    } while (flag);

                                                    kalan = year2 - 2016;
                                                } while (kalan % 4 != 0);
                                            }
                                        }
                                        Console.Clear();
                                        Console.WriteLine("congratulations again, you have successfully entered dates");

                                        flag = true;
                                        do
                                        {
                                            Console.WriteLine("Please enter a positive integer to continue our mission");
                                            do
                                            {
                                                string strn = Console.ReadLine();
                                                if (int.TryParse(strn, out n))
                                                {
                                                    if (n > 0)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("congratulations again, you have successfully entered n :) \n ");
                                                        Console.WriteLine("enter any button to continue \n");
                                                        Console.ReadKey();
                                                        flag = false;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Enter positive integer !! ");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Enter positive integer !! ");
                                                }
                                            } while (flag);

                                        } while (n <= 0);



                                        int monthInt1 = 0;
                                        switch (strmonth1)
                                        {
                                            case "january": monthInt1 = 1; break;
                                            case "february": monthInt1 = 2; break;
                                            case "march": monthInt1 = 3; break;
                                            case "april": monthInt1 = 4; break;
                                            case "may": monthInt1 = 5; break;
                                            case "june": monthInt1 = 6; break;
                                            case "july": monthInt1 = 7; break;
                                            case "august": monthInt1 = 8; break;
                                            case "september": monthInt1 = 9; break;
                                            case "october": monthInt1 = 10; break;
                                            case "november": monthInt1 = 11; break;
                                            case "december": monthInt1 = 12; break;
                                        }

                                        int monthInt2 = 0;
                                        switch (strmonth2)
                                        {
                                            case "january": monthInt2 = 1; break;
                                            case "february": monthInt2 = 2; break;
                                            case "march": monthInt2 = 3; break;
                                            case "april": monthInt2 = 4; break;
                                            case "may": monthInt2 = 5; break;
                                            case "june": monthInt2 = 6; break;
                                            case "july": monthInt2 = 7; break;
                                            case "august": monthInt2 = 8; break;
                                            case "september": monthInt2 = 9; break;
                                            case "october": monthInt2 = 10; break;
                                            case "november": monthInt2 = 11; break;
                                            case "december": monthInt2 = 12; break;
                                        }


                                        if (year1 < year2)
                                        {
                                            //  ilk girilen küçük tarih.
                                            Console.WriteLine("your selected number is: " + n);
                                            string date1 = strday1 + "." + strmonth1 + "." + stryear1;
                                            Console.WriteLine("First date is " + date1);
                                            string date2 = strday2 + "." + strmonth2 + "." + stryear2;
                                            Console.WriteLine("Second date is " + date2);

                                            Console.ReadKey();
                                        }
                                        else if (year2 < year1)
                                        {
                                            //   ikinci girilen tarih küçük , değerler yer değiştirmeli.
                                            Console.WriteLine("your selected number is: " + n);
                                            string date1 = strday2 + "." + strmonth2 + "." + stryear2;
                                            Console.WriteLine("First date is " + date1);
                                            string date2 = strday1 + "." + strmonth1 + "." + stryear1;
                                            Console.WriteLine("Second date is " + date2);

                                            int trans = monthInt2;  // ayları yazdırırken sayı lazım olursa diye ayların tanımlandığı ayları değiştirdim.
                                            monthInt2 = monthInt1;
                                            monthInt1 = trans;

                                            int trans1 = year2;
                                            year2 = year1;
                                            year1 = trans1;

                                            int trans2 = day2;
                                            day2 = day1;
                                            day1 = trans2;

                                            Console.ReadKey();
                                        }

                                        else if (year1 == year2)
                                        {

                                            if (monthInt1 < monthInt2)
                                            {
                                                //  ilk girilen küçük tarih.
                                                Console.WriteLine("your selected number is: " + n);
                                                string date1 = strday1 + "." + strmonth1 + "." + stryear1;
                                                Console.WriteLine("First date is " + date1);
                                                string date2 = strday2 + "." + strmonth2 + "." + stryear2;
                                                Console.WriteLine("Second date is " + date2);

                                                Console.ReadKey();
                                            }
                                            else if (monthInt2 < monthInt1)
                                            {
                                                //   ikinci girilen tarih küçük, değerler yer değiştirmeli.
                                                Console.WriteLine("your selected number is: " + n);
                                                string date1 = strday2 + "." + strmonth2 + "." + stryear2;
                                                Console.WriteLine("First date is " + date1);
                                                string date2 = strday1 + "." + strmonth1 + "." + stryear1;
                                                Console.WriteLine("Second date is " + date2);

                                                int trans = monthInt2;  // ayları yazdırırken sayı lazım olursa diye ayların tanımlandığı ayları değiştirdim.
                                                monthInt2 = monthInt1;
                                                monthInt1 = trans;

                                                int trans2 = day2;
                                                day2 = day1;
                                                day1 = trans2;

                                                Console.ReadKey();
                                            }

                                            else if (monthInt1 == monthInt2)
                                            {
                                                if (day1 < day2)
                                                {
                                                    //  ilk girilen küçük tarih.
                                                    Console.WriteLine("your selected number is: " + n);
                                                    string date1 = strday1 + "." + strmonth1 + "." + stryear1;
                                                    Console.WriteLine("First date is " + date1);
                                                    string date2 = strday2 + "." + strmonth2 + "." + stryear2;
                                                    Console.WriteLine("Second date is " + date2);

                                                    Console.ReadKey();
                                                }
                                                else if (day2 < day1)
                                                {
                                                    //   ikinci girilen tarih küçük, değerler yer değiştirmeli.
                                                    Console.WriteLine("your selected number is: " + n);
                                                    string date1 = strday2 + "." + strmonth2 + "." + stryear2;
                                                    Console.WriteLine("First date is " + date1);
                                                    string date2 = strday1 + "." + strmonth1 + "." + stryear1;
                                                    Console.WriteLine("Second date is " + date2);

                                                    int trans2 = day2;
                                                    day2 = day1;
                                                    day1 = trans2;

                                                    Console.ReadKey();
                                                }
                                                else if (day1 == day2)
                                                {
                                                    Console.WriteLine("Please do not enter same dates !!! \nTRY AGAIN");
                                                    Console.WriteLine("press any button to return to start.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    continue;
                                                    // tarihler aynı , oyun yeniden başlar.
                                                }
                                            }
                                        }

                                        // tarih girerken hiçbir sorun yok gün, ay , yıl sayılarla tanımlanıyor.
                                        // ayları monthInt 1 , 2 gibi değerlerde saklıyorum.

                                        if (monthInt1 == 1)// january seçti user
                                            monthInt1 = 13;
                                        else if (monthInt1 == 2)//february şeçti user.
                                            monthInt1 = 14;
                                        else
                                        { }

                                        if (monthInt2 == 1)// january seçti user
                                            monthInt2 = 13;

                                        else if (monthInt2 == 2)//february şeçti user.
                                            monthInt2 = 14;

                                        else
                                        { }

                                        Console.WriteLine();
                                        Console.WriteLine("Your selected number is: " + n);
                                        Console.WriteLine("FIRST DAY : " + day1);
                                        Console.WriteLine("SECOND DAY : " + day2);
                                        Console.WriteLine("NUMERIC VALUE OF THE FIRST MONTH : " + monthInt1);
                                        Console.WriteLine("NUMERIC VALUE OF THE SECOND MONTH : " + monthInt2);
                                        Console.WriteLine("FIRST YEAR : " + year1);
                                        Console.WriteLine("SECOND YEAR : " + year2 + "\n");   // bu değerleri kullanacağım.

                                        int lenthOfmonthInt1 = 0;
                                        int x = 0;   // ayları, date1 eşitbüyük mü date2 ye bakmak için tanımladım.
                                                     // x ile karşılaştırmam gereken değişken :  monthInt2 .
                                        do
                                        {               // ESAS hesaplamanın olduğu kısım. 
                                            switch (monthInt1)
                                            {
                                                case 13: strmonth1 = "january"; break;
                                                case 14: strmonth1 = "february"; break;
                                                case 3: strmonth1 = "march"; break;
                                                case 4: strmonth1 = "april"; break;
                                                case 5: strmonth1 = "may"; break;
                                                case 6: strmonth1 = "june"; break;
                                                case 7: strmonth1 = "july"; break;
                                                case 8: strmonth1 = "august"; break;
                                                case 9: strmonth1 = "september"; break;
                                                case 10: strmonth1 = "october"; break;
                                                case 11: strmonth1 = "november"; break;
                                                case 12: strmonth1 = "december"; break;
                                            }

                                            if ((monthInt1 == 12 || monthInt1 == 13 || monthInt1 == 14))
                                                Console.WriteLine("WİNTER");
                                            
                                            else if ((monthInt1 == 3 || monthInt1 == 4 || monthInt1 == 5))
                                                Console.WriteLine("SPRING");
                                            
                                            else if ((monthInt1 == 6 || monthInt1 == 7 || monthInt1 == 8))
                                                Console.WriteLine("SUMMER");
                                            
                                            else if ((monthInt1 == 9 || monthInt1 == 10 || monthInt1 == 11))
                                                Console.WriteLine("AUTUMN");
                                            


                                            Console.Write(day1 + " " + strmonth1 + " " + year1 );

                                            if (monthInt1 == 13 || monthInt1 == 14)
                                                year1--;

                                            double year1Bölü100 = year1 / 100;
                                            int mathRound = (int)year1Bölü100;
                                            int yılınilkikibas = (int)(mathRound / 4);
                                            int ayKısmı = (int)(13 * (monthInt1 + 1) / 5);
                                            int yılınsonikibas = (int)((year1 % 100) / 4);

                                            double h = (day1 + ayKısmı + (year1 % 100) + yılınsonikibas + yılınilkikibas + 5 * mathRound) % 7 ;

                                            switch (h)
                                            {
                                                case 5: Console.WriteLine(" Thursday \n"); break;
                                                case 6: Console.WriteLine(" Friday \n"); break;
                                                case 0: Console.WriteLine(" Saturday \n"); break;
                                                case 1: Console.WriteLine(" Sunday \n"); break;
                                                case 2: Console.WriteLine(" Monday \n"); break;
                                                case 3: Console.WriteLine(" Tuesday \n"); break;
                                                case 4: Console.WriteLine(" Wednesday \n"); break;
                                            }
                                            if (monthInt1 == 13 || monthInt1 == 14)
                                                year1++;

                                            day1 += n;

                                            switch (strmonth1)
                                            {
                                                case "january": lenthOfmonthInt1 = 31; break;
                                                case "february":
                                                    {
                                                        if (year1 % 4 == 0)
                                                        {
                                                            lenthOfmonthInt1 = 29; break;
                                                        }
                                                        else
                                                            lenthOfmonthInt1 = 28; break;
                                                    }
                                                case "march": lenthOfmonthInt1 = 31; break;
                                                case "april": lenthOfmonthInt1 = 30; break;
                                                case "may": lenthOfmonthInt1 = 31; break;
                                                case "june": lenthOfmonthInt1 = 30; break;
                                                case "july": lenthOfmonthInt1 = 31; break;
                                                case "august": lenthOfmonthInt1 = 31; break;
                                                case "september": lenthOfmonthInt1 = 30; break;
                                                case "october": lenthOfmonthInt1 = 31; break;
                                                case "november": lenthOfmonthInt1 = 30; break;
                                                case "december": lenthOfmonthInt1 = 31; break;
                                            }

                                            do
                                            {
                                                if (day1 > lenthOfmonthInt1)
                                                {
                                                    day1 = day1 - lenthOfmonthInt1;
                                                    monthInt1++;

                                                    if (monthInt1 >= 15)
                                                    {
                                                        monthInt1 = 3;
                                                        strmonth1 = "march";
                                                    }
                                                    else if (monthInt1 == 13)
                                                    {
                                                        year1++;
                                                        strmonth1 = "january";
                                                    }

                                                    switch (monthInt1)
                                                    {
                                                        case 13: strmonth1 = "january"; break;
                                                        case 14: strmonth1 = "february"; break;
                                                        case 3: strmonth1 = "march"; break;
                                                        case 4: strmonth1 = "april"; break;
                                                        case 5: strmonth1 = "may"; break;
                                                        case 6: strmonth1 = "june"; break;
                                                        case 7: strmonth1 = "july"; break;
                                                        case 8: strmonth1 = "august"; break;
                                                        case 9: strmonth1 = "september"; break;
                                                        case 10: strmonth1 = "october"; break;
                                                        case 11: strmonth1 = "november"; break;
                                                        case 12: strmonth1 = "december"; break;
                                                    }
                                                    switch (strmonth1)
                                                    {
                                                        case "january": lenthOfmonthInt1 = 31; break;
                                                        case "february":
                                                            {
                                                                if (year1 % 4 == 0)
                                                                {
                                                                    lenthOfmonthInt1 = 29; break;
                                                                }
                                                                else
                                                                    lenthOfmonthInt1 = 28; break;
                                                            }
                                                        case "march": lenthOfmonthInt1 = 31; break;
                                                        case "april": lenthOfmonthInt1 = 30; break;
                                                        case "may": lenthOfmonthInt1 = 31; break;
                                                        case "june": lenthOfmonthInt1 = 30; break;
                                                        case "july": lenthOfmonthInt1 = 31; break;
                                                        case "august": lenthOfmonthInt1 = 31; break;
                                                        case "september": lenthOfmonthInt1 = 30; break;
                                                        case "october": lenthOfmonthInt1 = 31; break;
                                                        case "november": lenthOfmonthInt1 = 30; break;
                                                        case "december": lenthOfmonthInt1 = 31; break;
                                                    }

                                                    if (day1 > lenthOfmonthInt1)
                                                        continue;
                                                    
                                                }
                                                else
                                                { }

                                            } while (day1 > lenthOfmonthInt1);

                                            switch (strmonth1)
                                            {
                                                case "january": x = 01; break;
                                                case "february": x = 02; break;
                                                case "march": x = 03; break;
                                                case "april": x = 04; break;
                                                case "may": x = 05; break;
                                                case "june": x = 06; break;
                                                case "july": x = 07; break;
                                                case "august": x = 08; break;
                                                case "september": x = 09; break;
                                                case "october": x = 10; break;
                                                case "november": x = 11; break;
                                                case "december": x = 12; break;
                                            }

                                        } while (year1 < year2 || (x < monthInt2 && year1 == year2) || (day1 < day2 && x == monthInt2 && year1 == year2));

                                        Console.WriteLine("press any button to close the calender.");
                                        Console.ReadKey();

                                        isCalenderOn = false;

                                    }
                                    else
                                    {
                                        Console.WriteLine("please enter a year later than 2015 (included).  \nEnter any buton to return to the start.");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                else
                                    Console.WriteLine("please enter a name of month (i.e. April )");
                            }
                            else
                                Console.WriteLine("please enter a day of month !");
                        }
                        else
                        {
                            Console.WriteLine("please enter a year later than 2015 (included). \nEnter any buton to return to the start.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                        Console.WriteLine("please enter a name of month (i.e. January )");
                }
                else
                {
                    Console.WriteLine("please enter a day of month !");
                }
            }
        }
    }
}