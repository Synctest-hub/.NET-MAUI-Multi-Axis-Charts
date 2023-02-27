using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_MultiAxis_Chart
{
   public class Temperature
    {
        public string Month { get; set; }
        public double Celsius { get; set; }
        public double Fahrenheit { get; set; }

        public Temperature(string month, double celsius, double fahrenheit)
        {
            Month = month;
            Celsius = celsius;
            Fahrenheit = fahrenheit;
        }
    }

    public class SalesByYear
    {
        public double MarketShare
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }
    }

    public class BlogDetail
    {
        public DateTime DateTime
        {
            get;
            set;
        }
        public double Likes
        {
            get;
            set;
        }

        public double Views
        {
            get;
            set;
        }

        public double Hits { get; set; }

        public BlogDetail(DateTime dateTime, double likes, double views, double hits)
        {
            DateTime = dateTime;
            Likes = likes;
            Views = views;
            Hits = hits;
        }
    }

    public class Model
    {
        public DateTime Month { get; set; }
        public double Sales { get; set; }
        public double Target { get; set; }

        public double YValue { get; set; }
        public double XValue { get; set; }


        public Model(DateTime months, double sales, double target)
        {
            Month = months;
            Sales = sales;
            Target = target;
        }

        public Model(double xValue, double yValue)
        {
            XValue = xValue;
            YValue = yValue;
        }   
    }

    public class Sales
    {
        public string Month { get; set; }
        public double SalesCount { get; set; }

        public double Revenue { get; set; }

        public double Profit { get; set; }

        public double Expenses { get; set; }

        public double CashFlow { get; set; }
        public Sales(string month, double salesValue, double revenue)
        {
            Month = month;
            SalesCount = salesValue;
            Revenue = revenue;
        }

        public Sales(string month, double revenue, double profit, double expenses, double cashFlow)
        {
            Month = month;
            Revenue=revenue;
            Profit = profit;
            Expenses = expenses;
            CashFlow = cashFlow;
        }
    }
}
