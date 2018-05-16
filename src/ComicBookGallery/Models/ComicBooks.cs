using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBooks
    {
        public int ID { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artists[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayTest
        {
            get
            {
                return SeriesTitle + " #" + IssueNumber;
            }

        }

        //series-title-issuenumber.jpg
        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ","-")
                    .ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }
}