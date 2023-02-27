using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_MultiAxis_Chart
{
    public class TemperatureDetails
    {
        public ObservableCollection<Temperature> TemperatureData { get; set; }
        public TemperatureDetails()
        {
            TemperatureData = new ObservableCollection<Temperature>
            {
                 new Temperature("Jan", 9,48),
                 new Temperature("Feb", 9,48),
                 new Temperature("Mar", 12, 54),
                 new Temperature("Apr", 15, 59),
                 new Temperature("May", 18, 64),
                 new Temperature("Jun", 21, 70),
                 new Temperature("Jul", 23, 73),
                 new Temperature("Aug", 23, 73),
                 new Temperature("Sep", 20, 68),
                 new Temperature("Oct", 16, 61),
                 new Temperature("Nov", 12, 54),
                 new Temperature("Dec", 9, 48),
            };
        }
    }

    public class SalesDetails
    {
        public ObservableCollection<Sales> SalesData { get; set; }
        public ObservableCollection<SalesByYear> SalesCollection1
        {
            get;
            set;
        }

        public ObservableCollection<SalesByYear> SalesCollection2
        {
            get;
            set;
        }

        public ObservableCollection<Sales> SalesData2 { get; set; }
        public SalesDetails()
        {
            SalesData = new ObservableCollection<Sales>
            {
                 new Sales("Jan", 10, 100),
                 new Sales("Feb", 12, 120),
                 new Sales("Mar", 15, 150),
                 new Sales("Apr", 18, 180),
                 new Sales("May", 20, 200),
                 new Sales("Jun", 12, 120),
                 new Sales("Jul", 25, 250),
                 new Sales("Aug", 18, 180),
                 new Sales("Sep", 30, 300),
                 new Sales("Oct", 22, 220),
                 new Sales("Nov", 35, 350),
                 new Sales("Dec", 18, 180),
            };

            SalesCollection1 = new ObservableCollection<SalesByYear>();
            SalesCollection1.Add(new SalesByYear() { Category = "Samsung", MarketShare = 32.5 });
            SalesCollection1.Add(new SalesByYear() { Category = "Apple", MarketShare = 16.6 });
            SalesCollection1.Add(new SalesByYear() { Category = "Sony", MarketShare = 8.1 });
            SalesCollection1.Add(new SalesByYear() { Category = "LG", MarketShare = 24.3 });
            SalesCollection1.Add(new SalesByYear() { Category = "ZTE", MarketShare = 13.2 });

            SalesCollection2 = new ObservableCollection<SalesByYear>();
            SalesCollection2.Add(new SalesByYear() { Category = "Samsung1", MarketShare = -78.0 });
            SalesCollection2.Add(new SalesByYear() { Category = "Apple2", MarketShare = -116.4 });
            SalesCollection2.Add(new SalesByYear() { Category = "Sony", MarketShare = -83.9 });
            SalesCollection2.Add(new SalesByYear() { Category = "LG", MarketShare = -66.0 });
            SalesCollection2.Add(new SalesByYear() { Category = "ZTE", MarketShare = -73.1 });

            SalesData2 = new ObservableCollection<Sales>();
            SalesData2.Add(new Sales("Jan", 100000, 70000, 30000, 10000));
            SalesData2.Add(new Sales("Feb", 120000, 75000, 45000, 20000));
            SalesData2.Add(new Sales("Mar", 110000, 90000, 30000, 30000));  
            SalesData2.Add(new Sales("Apr", 95000, 100000, 60000, 40000));
            SalesData2.Add(new Sales("May", 115000, 650000, 70000, 50000));
            SalesData2.Add(new Sales("Jun", 120000, 85000, 40000, 20000));

        }
    }

    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ObservableCollection<Model> CrossAxisData { get; set; }

        public ViewModel()
        {
            DateTime date = new DateTime(2022, 01, 01);
            Data = new ObservableCollection<Model>();

            Data.Add(new Model(date, 15000, 58));
            Data.Add(new Model(date.AddMonths(1), 18000, 83));
            Data.Add(new Model(date.AddMonths(2), 13000, 35));
            Data.Add(new Model(date.AddMonths(3), 17000, 73));
            Data.Add(new Model(date.AddMonths(4), 22000, 95));
            Data.Add(new Model(date.AddMonths(5), 12000, 65));

            CrossAxisData = new ObservableCollection<Model>()
            {
                new Model( -7,  -3),
                new Model( -4.5,  -2),
                new Model( -3.5,  0),
                new Model( -3,  2),
                new Model( 0,  7),
                new Model( 3,  2),
                new Model( 3.5,  0),
                new Model( 4.5,  -2),
                new Model( 7,  -3),
            };
        }
    }

    public class BlogDetails
    {
        public ObservableCollection<BlogDetail> BlogData { get; set; }
        public BlogDetails()
        {
            BlogData = new ObservableCollection<BlogDetail>
            {
                 new BlogDetail(new DateTime(2015, 1, 1), 4100, 9300, 2300),
                 new BlogDetail(new DateTime(2015, 2, 1), 4120, 8340, 2360),
                 new BlogDetail(new DateTime(2015, 3, 1), 4150, 8400, 2450),
                 new BlogDetail(new DateTime(2015, 4, 1), 4180, 8460, 2540),
                 new BlogDetail(new DateTime(2015, 5, 1), 4200, 8500, 2600),
                 new BlogDetail(new DateTime(2015, 6, 1), 4120, 8340, 2360),
                 new BlogDetail(new DateTime(2015, 7, 1), 4250, 8600, 2750),
                 new BlogDetail(new DateTime(2015, 8, 1), 4180, 8460, 2540),
                 new BlogDetail(new DateTime(2015, 9, 1), 4300, 8700, 2900),
                 new BlogDetail(new DateTime(2015, 10, 1), 4220, 8540, 2660),
                 new BlogDetail(new DateTime(2015, 11, 1), 4350, 8800, 2050),
                 new BlogDetail(new DateTime(2015, 12, 1), 4180, 6460, 2540),
            };
        }
    }
    
}
