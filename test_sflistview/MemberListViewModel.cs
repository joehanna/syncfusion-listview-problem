using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.DataSource;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace test_sflistview {

  public class MemberListViewModel : BaseViewModel {

    #region " Class Structures and Enum "

    #endregion

    #region " Private Members "

    #region " Private Properties "

    //public ObservableCollection<Grouping<string, HBTMember>> MembersGrouped { get; set; }
    ObservableCollection<HBTMember> member_list;

    List<HBTMember> dummy_data = new List<HBTMember>() {
                    new HBTMember( "Ocean", "887-1599 Nibh. Street", "Tamworth", "NSW", "2410" ),
                    new HBTMember( "Tara", "Ap #848-7499 At, Street", "Townsville", "QLD", "1069" ),
                    new HBTMember( "Stone", "P.O. Box 274, 5621 Lectus St.", "Gladstone", "QLD", "7942" ),
                    new HBTMember( "Keelie", "Ap #652-5781 Malesuada St.", "Redlands", "QLD", "3901" ),
                    new HBTMember( "Daquan", "641 Lorem Street", "Bathurst", "New South Wales", "9764" ),
                    new HBTMember( "Rahim", "P.O. Box 759, 2144 Imperdiet Street", "Cessnock", "NSW", "7978" ),
                    new HBTMember( "Vance", "Ap #744-8076 Lorem, St.", "Mount Gambier", "SA", "7480" ),
                    new HBTMember( "April", "330-3951 Donec Ave", "Goulburn", "NSW", "9367" ),
                    new HBTMember( "Shana", "693-3760 Non Road", "Newcastle", "New South Wales", "9099" ),
                    new HBTMember( "Ruby", "P.O. Box 905, 3935 Ac St.", "Launceston", "Tasmania", "8079" ),
                    new HBTMember( "Brody", "6552 Adipiscing Avenue", "Grafton", "New South Wales", "3451" ),
                    new HBTMember( "Chadwick", "P.O. Box 604, 1264 Semper Road", "Cairns", "QLD", "2201" ),
                    new HBTMember( "Ray", "Ap #446-5752 Morbi St.", "Sydney", "NSW", "2605" ),
                    new HBTMember( "Brandon", "518-1143 Turpis Rd.", "Belgrave", "Victoria", "6535" ),
                    new HBTMember( "Brianna", "P.O. Box 798, 1685 Tempor Rd.", "Frankston", "VIC", "3046" ),
                    new HBTMember( "Kylynn", "P.O. Box 266, 4266 Et Street", "Newcastle", "New South Wales", "3706" ),
                    new HBTMember( "Xena", "798-6751 Posuere Street", "Greater Hobart", "Tasmania", "1901" ),
                    new HBTMember( "Leo", "Ap #688-8480 Libero Road", "Campbelltown", "NSW", "5060" ),
                    new HBTMember( "Sybil", "5324 Neque St.", "Wodonga", "VIC", "6929" ),
                    new HBTMember( "Nero", "526-4651 A, Street", "Ararat", "VIC", "5741" ),
                    new HBTMember( "Xaviera", "8805 Sit Rd.", "Canberra", "ACT", "4394" ),
                    new HBTMember( "Myra", "P.O. Box 262, 7935 Ligula. Av.", "Newcastle", "New South Wales", "7704" ),
                    new HBTMember( "Heidi", "P.O. Box 632, 3693 Tempor Street", "Broken Hill", "NSW", "4903" ),
                    new HBTMember( "Keegan", "1403 Nullam Road", "Melville", "Western Australia", "7809" ),
                    new HBTMember( "Phillip", "Ap #397-1822 Vitae Avenue", "Goulburn", "NSW", "4048" ),
                    new HBTMember( "Ebony", "Ap #152-1830 Nonummy Rd.", "Whyalla", "South Australia", "4161" ),
                    new HBTMember( "Dolan", "Ap #802-6088 Ipsum Road", "Wodonga", "Victoria", "9715" ),
                    new HBTMember( "Leilani", "Ap #435-7120 Mi St.", "Mildura", "Victoria", "7871" ),
                    new HBTMember( "Winifred", "9196 Quis Avenue", "Campbelltown", "NSW", "1907" ),
                    new HBTMember( "Frances", "Ap #242-8481 Lectus. Road", "Queanbeyan", "New South Wales", "1358" ),
                    new HBTMember( "Roth", "945-4026 Quisque St.", "Canberra", "Australian Capital Territory", "5487" ),
                    new HBTMember( "Dean", "963-8505 Nisi. Rd.", "Moe", "Victoria", "8993" ),
                    new HBTMember( "Josiah", "2834 Vulputate, Street", "Hamilton", "Victoria", "2463" ),
                    new HBTMember( "Aphrodite", "941-4603 Sollicitudin St.", "Tamworth", "NSW", "9137" ),
                    new HBTMember( "Fulton", "P.O. Box 494, 9541 Amet Ave", "Frankston", "Victoria", "5100" ),
                    new HBTMember( "Jessica", "258-2987 Sed St.", "Bunbury", "Western Australia", "9070" ),
                    new HBTMember( "Illiana", "3612 Pellentesque. St.", "Blue Mountains", "NSW", "8605" ),
                    new HBTMember( "Zahir", "P.O. Box 902, 7579 Rutrum Avenue", "Swan Hill", "VIC", "8337" ),
                    new HBTMember( "Linus", "6088 Viverra. Av.", "Gold Coast", "QLD", "1719" ),
                    new HBTMember( "Cedric", "P.O. Box 667, 8472 Nulla St.", "Bairnsdale", "VIC", "8176" ),
                    new HBTMember( "Levi", "P.O. Box 658, 2877 Nulla St.", "Mount Isa", "QLD", "9509" ),
                    new HBTMember( "Scarlett", "P.O. Box 273, 6770 Turpis. Street", "South Perth", "WA", "9050" ),
                    new HBTMember( "Daniel", "P.O. Box 495, 4324 Sodales St.", "Port Lincoln", "SA", "3861" ),
                    new HBTMember( "Andrew", "Ap #893-4091 Dolor St.", "Wodonga", "Victoria", "5735" ),
                    new HBTMember( "Maxine", "122-6095 Elit. Avenue", "Blue Mountains", "NSW", "7919" ),
                    new HBTMember( "Colt", "Ap #172-7565 Conubia St.", "Gold Coast", "Queensland", "4171" ),
                    new HBTMember( "Clark", "401-9407 Velit Av.", "Brisbane", "QLD", "5323" ),
                    new HBTMember( "Mari", "6936 Lacinia Av.", "Melbourne", "Victoria", "4804" ),
                    new HBTMember( "Burton", "Ap #339-5969 Quis St.", "Wangaratta", "Victoria", "9801" ),
                    new HBTMember( "Omar", "Ap #860-8648 Porttitor Av.", "Gladstone", "QLD", "6243" ),
                    new HBTMember( "Halee", "P.O. Box 674, 5746 Non St.", "Gladstone", "QLD", "7465" ),
                    new HBTMember( "Linda", "Ap #172-2862 Vehicula Rd.", "Mount Isa", "Queensland", "6280" ),
                    new HBTMember( "Elaine", "Ap #957-8363 Velit. St.", "Melton", "Victoria", "3855" ),
                    new HBTMember( "Zelda", "588-2346 Aliquet St.", "Broken Hill", "NSW", "5511" ),
                    new HBTMember( "Callie", "Ap #722-4022 Eu, Rd.", "Penrith", "New South Wales", "1513" ),
                    new HBTMember( "Zeph", "590-7110 Integer St.", "Horsham", "VIC", "2026" ),
                    new HBTMember( "Gannon", "4122 Adipiscing Rd.", "Cairns", "Queensland", "2863" ),
                    new HBTMember( "Castor", "P.O. Box 402, 6836 Malesuada Road", "Geelong", "VIC", "6959" ),
                    new HBTMember( "Beverly", "7912 Mauris Street", "Frankston", "VIC", "6998" ),
                    new HBTMember( "Akeem", "Ap #504-2691 Arcu. Ave", "Greater Hobart", "Tasmania", "1313" ),
                    new HBTMember( "Keaton", "819-6261 Semper Road", "Ararat", "Victoria", "8296" ),
                    new HBTMember( "Mary", "4835 Nullam Rd.", "Bundaberg", "QLD", "5981" ),
                    new HBTMember( "Ashton", "Ap #850-3636 Blandit. Road", "Charters Towers", "Queensland", "2092" ),
                    new HBTMember( "Nissim", "543-531 Donec Street", "Hamilton", "VIC", "6096" ),
                    new HBTMember( "Robin", "1253 In Road", "Victor Harbor", "South Australia", "1661" ),
                    new HBTMember( "Yeo", "6221 Vulputate, St.", "Melbourne", "VIC", "7838" ),
                    new HBTMember( "Burke", "7729 Fermentum Avenue", "Cairns", "QLD", "6344" ),
                    new HBTMember( "Kay", "8338 Proin Road", "Nedlands", "WA", "3735" ),
                    new HBTMember( "Todd", "P.O. Box 346, 2665 Vel, Road", "Bendigo", "Victoria", "1238" ),
                    new HBTMember( "Stacey", "Ap #116-1304 Eros. Rd.", "Grafton", "NSW", "8745" ),
                    new HBTMember( "Galvin", "269-9546 Donec Av.", "Redcliffe", "Queensland", "8568" ),
                    new HBTMember( "Ralph", "389-3445 Neque. Ave", "Caloundra", "Queensland", "2337" ),
                    new HBTMember( "Talon", "P.O. Box 276, 1920 Primis Ave", "Fremantle", "Western Australia", "1960" ),
                    new HBTMember( "Neil", "2761 Sed Ave", "Gold Coast", "QLD", "7662" ),
                    new HBTMember( "Rebekah", "Ap #105-961 Eu Rd.", "Frankston", "VIC", "9540" ),
                    new HBTMember( "Ulric", "6884 Sodales. Avenue", "Frankston", "VIC", "3735" ),
                    new HBTMember( "Olga", "8835 In, Avenue", "Rockhampton", "QLD", "3738" ),
                    new HBTMember( "Jenette", "Ap #929-1968 Nascetur Road", "Gladstone", "QLD", "4731" ),
                    new HBTMember( "Christopher", "P.O. Box 343, 9194 Nulla Road", "Port Augusta", "SA", "6030" ),
                    new HBTMember( "Rogan", "Ap #125-2960 Mauris St.", "Cairns", "Queensland", "9640" ),
                    new HBTMember( "Cairo", "P.O. Box 729, 2212 Tristique St.", "Melton", "Victoria", "1375" ),
                    new HBTMember( "Gareth", "Ap #400-7136 Mollis. Rd.", "Geraldton-Greenough", "Western Australia", "1931" ),
                    new HBTMember( "Isaiah", "Ap #966-5517 Cras Rd.", "Port Augusta", "South Australia", "5899" ),
                    new HBTMember( "Galvin", "6631 Erat. Avenue", "Cairns", "QLD", "3623" ),
                    new HBTMember( "Len", "234-3785 Rhoncus Street", "Wollongong", "NSW", "1425" ),
                    new HBTMember( "Carter", "Ap #690-489 Lorem, St.", "Belgrave", "VIC", "9707" ),
                    new HBTMember( "Micah", "549-4018 Ac Road", "Geelong", "Victoria", "1018" ),
                    new HBTMember( "Nerea", "Ap #439-102 Justo Road", "Bathurst", "NSW", "1974" ),
                    new HBTMember( "Lucius", "P.O. Box 947, 880 Sed Rd.", "Murray Bridge", "South Australia", "2705" ),
                    new HBTMember( "Deacon", "5357 Tincidunt St.", "Darwin", "NT", "7881" ),
                    new HBTMember( "Michelle", "803 Consequat Road", "Grafton", "NSW", "3109" ),
                    new HBTMember( "Leilani", "313-715 Vel Rd.", "Orange", "NSW", "8529" ),
                    new HBTMember( "Bo", "819-252 Sit Ave", "Morwell", "VIC", "8129" ),
                    new HBTMember( "Randall", "846-3962 Eu Avenue", "Liverpool", "NSW", "5013" ),
                    new HBTMember( "Irma", "740-8088 Cum Avenue", "Stirling", "WA", "7076" ),
                    new HBTMember( "Emerald", "4916 Congue. Avenue", "Sale", "Victoria", "4649" ),
                    new HBTMember( "Isabella", "2183 Vel Ave", "Geelong", "Victoria", "8549" ),
                    new HBTMember( "Luke", "3798 Et St.", "Gladstone", "Queensland", "7902" ),
                    new HBTMember( "Hollee", "P.O. Box 671, 5370 Amet St.", "Wodonga", "Victoria", "6425" ),
                    new HBTMember( "Christen", "Ap #719-4522 Tellus Street", "Liverpool", "New South Wales", "3286")
                  };

    #endregion

    #region " Private Events "

    #endregion

    #region " Private Functions "

    #endregion

    #endregion

    #region " Public Members "

    #region " Public Constructors and Destructors "

    public MemberListViewModel() {

      Title = "Member List";

      member_list = new ObservableCollection<HBTMember>(dummy_data.OrderBy(m => m.Owner));

    }

    //public MemberListViewModel(IVantageAppContext app_context) : this() {
    //  this.app_context = app_context;

    //  LoadData();
    //}

    #endregion

    #region " Public Properties "

    public ObservableCollection<HBTMember> MemberList { get { return member_list; } set { member_list = value; } }

    #endregion

    #region " Public Events "

    #endregion

    #region " Public Functions "

    #endregion

    #endregion

  }

  #region " Local classes "

  #region " GroupingBehavior "

  //[Preserve(AllMembers = true)]
  public class SfListViewGroupingBehavior : Behavior<Syncfusion.ListView.XForms.SfListView> {

    MemberListViewModel member_grouping_view_model;

    Syncfusion.ListView.XForms.SfListView list_view;



    async void Member_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e) {

      if (e.ItemData == null) {
        return;
      }

      var member = (HBTMember)e.ItemData;
      //member.SetAppContext(app_context);

      ////lvMemberList.SelectedItem = null;

      //var member_detail = new MemberDetailPage(app_context, member);

      //await Application.Current.MainPage.Navigation.PushAsync(new NavigationPage(member_detail), true);

    }


    protected override void OnAttachedTo(Syncfusion.ListView.XForms.SfListView bindable) {

      list_view = bindable;

      member_grouping_view_model = new MemberListViewModel();

      list_view.ItemsSource = member_grouping_view_model.MemberList;

      list_view.DataSource.SortDescriptors.Add(new SortDescriptor("Owner"));

      list_view.DataSource.GroupDescriptors.Add(new GroupDescriptor() {
        PropertyName = "TradingName",
        KeySelector = (object obj1) => {
          var member = (obj1 as HBTMember);
          return member.NameSort;
        },
      });

      list_view.ItemTapped += Member_ItemTapped;

      base.OnAttachedTo(bindable);
    }

    protected override void OnDetachingFrom(Syncfusion.ListView.XForms.SfListView bindable) {
      list_view = null;

      list_view.ItemTapped -= Member_ItemTapped;

      base.OnDetachingFrom(bindable);
    }

  }

  #endregion

  #endregion

}
