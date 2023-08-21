using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCData
{
    public class TrainingProductManager
    {
        public TrainingProductManager()
        {
            ValidationErrors = new List<KeyValuePair<string, string>>();
        }
        public List<KeyValuePair<string, string>> ValidationErrors { get; set; }
        public bool Validate(TrainingProduct entity)
        {
            ValidationErrors.Clear();
            if (!string.IsNullOrEmpty(entity.ProductName))
            {
                if (entity.ProductName.ToLower() == entity.ProductName)
                {
                    ValidationErrors.Add(new KeyValuePair<string, string>("Product Name", "Product Name must not be all lower case."));
                }
            }

            return ValidationErrors.Count == 0;
        }

        public bool Insert(TrainingProduct entity)
        {
            bool ret = false;

            ret = Validate(entity);
            
            if(ret)
            {
                //TODO: Create Insert code here
            }

            return ret;
        }

        public List<TrainingProduct> Get(TrainingProduct entity)
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();

            // TODO: Add your data access method here

            ret = CreateMockData();

            if (!string.IsNullOrEmpty(entity.ProductName))
            {
                ret = ret.FindAll(p => p.ProductName.ToLower().StartsWith(entity.ProductName, StringComparison.CurrentCultureIgnoreCase));
            }


            return ret;
        }
        private List<TrainingProduct> CreateMockData()
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();

            ret.Add(new TrainingProduct()
            {
                ProductId = 1,
                ProductName = "Extending",
                IntroductionDate = Convert.ToDateTime("6/11/2015"),
                Url = "http://bit.ly/lSNz0i",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 2,
                ProductName = "Advanced Web Development",
                IntroductionDate = Convert.ToDateTime("8/2/2016"),
                Url = "http://bit.ly/2U7RwtM",
                Price = Convert.ToDecimal(49.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 3,
                ProductName = "Data Science Fundamentals",
                IntroductionDate = Convert.ToDateTime("4/5/2017"),
                Url = "http://bit.ly/2k95NML",
                Price = Convert.ToDecimal(59.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 4,
                ProductName = "Mobile App Design",
                IntroductionDate = Convert.ToDateTime("1/10/2018"),
                Url = "http://bit.ly/2V9Yd0v",
                Price = Convert.ToDecimal(39.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 5,
                ProductName = "Introduction to AI",
                IntroductionDate = Convert.ToDateTime("9/3/2019"),
                Url = "http://bit.ly/3fBd6eH",
                Price = Convert.ToDecimal(69.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 6,
                ProductName = "JavaScript Fundamentals",
                IntroductionDate = Convert.ToDateTime("3/2/2020"),
                Url = "http://bit.ly/3wUEaYw",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 7,
                ProductName = "Database Management",
                IntroductionDate = Convert.ToDateTime("7/8/2021"),
                Url = "http://bit.ly/3yhix3U",
                Price = Convert.ToDecimal(49.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 8,
                ProductName = "Responsive Web Design",
                IntroductionDate = Convert.ToDateTime("11/1/2022"),
                Url = "http://bit.ly/3e0ujka",
                Price = Convert.ToDecimal(39.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 9,
                ProductName = "Cybersecurity Essentials",
                IntroductionDate = Convert.ToDateTime("2/8/2023"),
                Url = "http://bit.ly/3xI7U5K",
                Price = Convert.ToDecimal(59.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 10,
                ProductName = "Python Programming",
                IntroductionDate = Convert.ToDateTime("6/5/2024"),
                Url = "http://bit.ly/2Vs5CrD",
                Price = Convert.ToDecimal(29.00)
            });

            return ret;
        }
    }
}
