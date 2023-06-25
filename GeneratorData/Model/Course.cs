using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneratorData.Model
{
    public class CourseJsonModel
    {
        // public string Advertiser { get; set; }
        // public string Category { get; set; }
        // public string ImageUrl { get; set; }
        // public string Link { get; set; }
        // public string LinkCode { get; set; }
        // public string LinkId { get; set; }
        public string Link_Name { get; set; }
        // public string PixelUrl { get; set; }
        // public decimal RetailPrice { get; set; }
    }

    public class RootCourseJson
    {
        public List<CourseJsonModel> Courses { get; set; }
    }
}