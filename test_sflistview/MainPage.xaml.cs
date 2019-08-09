using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace test_sflistview {
  // Learn more about making custom code visible in the Xamarin.Forms previewer
  // by visiting https://aka.ms/xamarinforms-previewer
  [DesignTimeVisible(false)]
  public partial class MainPage : ContentPage {
    public MainPage() {
      InitializeComponent();

    }

    SearchBar searchBar = null;

    private void OnFilterTextChanged(object sender, TextChangedEventArgs e) {
      searchBar = (sender as SearchBar);
      if (lvMembers.DataSource != null) {
        lvMembers.DataSource.Filter = FilterMembers;
        lvMembers.DataSource.RefreshFilter();
      }
      System.Diagnostics.Debug.WriteLine($"_______________________________________");
    }

    private bool FilterMembers(object obj) {
      if (searchBar == null || string.IsNullOrWhiteSpace(searchBar.Text)) {
        //lvMembers.IsStickyGroupHeader = true;
        return true;
      }
      //lvMembers.IsStickyGroupHeader = false;

      var result = false;
      var member = obj as HBTMember;


      if (member.Owner.ToLower().Contains(searchBar.Text.ToLower())
           || member.StoreSuburb.ToLower().Contains(searchBar.Text.ToLower())
           ) {
        result = true;
        System.Diagnostics.Debug.WriteLine($"FilterMembers:  {member.Owner} {member.Address}");
      }
      return result;

    }
  }
}
