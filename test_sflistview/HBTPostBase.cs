using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace test_sflistview {

  public abstract class HBTPostBase : INotifyPropertyChanged {

    #region " Class Structures and Enum "

    #endregion

    #region " Private Members "

    #region " Private Properties "

    ImageSource image_source;

    #endregion

    #region " Private Events "

    #endregion

    #region " Private Functions "

    protected void RaisePropertyChanged(string name) {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    #endregion

    #endregion

    #region " Public Members "

    #region " Public Constructors and Destructors "

    public HBTPostBase() { }

    #endregion

    #region " Public Properties "

    public long ID { get; set; }

    public string PostName { get; set; } = "";

    public string PostTitle { get; set; }
    public string PostContent { get; set; } = "";
    public string PostExcerpt { get; set; } = "";

    public string PostContentTextOnly {
      get {
        //Finally add the Post Content
        var text_only = (string.IsNullOrWhiteSpace(PostExcerpt)) ? Regex.Replace(PostContent.Replace("<br>", "").Replace("\n", "").Trim(), "<.*?>", string.Empty) : PostExcerpt;
        if (text_only.Length > 80) {
          text_only = $"{text_only.Substring(0, 80)}...(more)";
        }
        //text_only.Append("<div class='content_div'>").Append(text).Append("</div>");

        //System.Diagnostics.Debug.WriteLine(text_only.ToString());

        return text_only.ToString();
      }
    }

    public string PostExcerptWithFeaturedImage {
      get {
        var html_with_css = new StringBuilder();

        //Insert the featured image if it exists
        if (!string.IsNullOrEmpty(FeaturedImage)) {
          html_with_css.Append("<div class='image_div'><img src='").Append(FeaturedImage).Append("' /></div>");
        }

        //Finally add the Post Content
        var text = (string.IsNullOrWhiteSpace(PostExcerpt)) ? Regex.Replace(PostContent.Replace("<br>", "").Replace("\n", "").Trim(), "<.*?>", string.Empty) : PostExcerpt;
        if (text.Length > 80) {
          text = $"{text.Substring(0, 80)}...(more)";
        }
        html_with_css.Append("<div class='content_div'>").Append(text).Append("</div>");

        //System.Diagnostics.Debug.WriteLine(html_with_css.ToString());

        return html_with_css.ToString();
      }
    }

    public string FeaturedImage { get; set; }

    public ImageSource FeaturedImageImageSource {
      get {
        image_source = ImageSource.FromUri(new Uri(FeaturedImage));
        return image_source;
      }
      set { image_source = value; }
    }

    public DateTime PostModified { get; set; }
    public string StartDateString { get; set; }

    public DateTime StartDate {
      get {
        DateTime start_date = DateTime.MinValue;
        string SourceDate = (string.IsNullOrWhiteSpace(StartDateString) ? PostModified.ToString("yyyyMMdd") : StartDateString);

        if ((!string.IsNullOrWhiteSpace(SourceDate)) && (SourceDate.Length == 8)) {
          var date_string = $"{SourceDate.Substring(0, 4)}-{SourceDate.Substring(4, 2)}-{SourceDate.Substring(6, 2)}";
          DateTime.TryParse(date_string, out start_date);
        }
        return start_date;
      }
    }

    public string ExpiryDateString { get; set; }

    public DateTime ExpiryDate {
      get {
        DateTime expiry_date = DateTime.MaxValue;
        if ((!string.IsNullOrWhiteSpace(ExpiryDateString)) && (ExpiryDateString.Length == 8)) {
          var date_string = $"{ExpiryDateString.Substring(0, 4)}-{ExpiryDateString.Substring(4, 2)}-{ExpiryDateString.Substring(6, 2)}";
          DateTime.TryParse(date_string, out expiry_date);
        }
        return expiry_date;
      }
    }

    #endregion

    #region " Public Events "

    public event PropertyChangedEventHandler PropertyChanged;

    #endregion

    #region " Public Functions "

    #endregion

    #endregion

  }

}
