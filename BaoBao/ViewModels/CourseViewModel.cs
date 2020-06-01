using BaoBao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaoBao.ViewModels
{
    public class CourseViewModel
    {
        [Require]
        public string Placce { get; set; }
        [Require]
        public string Date { get; set; }
        [Require]
        public string Time { get; set; }
        [Require]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Place { get; internal set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}