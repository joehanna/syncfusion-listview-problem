using System.ComponentModel;

namespace test_sflistview {

  public class HBTMember {

    #region " Class Structures and Enum "

    #endregion

    #region " Private Members "

    #region " Private Properties "

    string owner = "";
    string store_address = "";
    string store_suburb = "";
    string store_state = "";
    string store_post_code = "";
    string phone = "";
    string abn = "";
    string company = "";
    string contact_name = "";
    string contact_email = "";

    #endregion

    #region " Private Events "

    #endregion

    #region " Private Functions "

    void RaisePropertyChanged(string name) {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    #endregion

    #endregion

    #region " Public Members "

    #region " Public Constructors and Destructors "

    public HBTMember(string owner, string store_address, string store_suburb, string store_state, string store_post_code) : base() {
      this.owner = owner;
      this.store_address = store_address;
      this.store_suburb = store_suburb;
      this.store_post_code = store_post_code;
    }

    #endregion

    #region " Public Properties "

    public string Owner {
      get { return owner; }
      set {
        owner = value;
        RaisePropertyChanged(nameof(Owner));
      }
    }

    public string Address {
      get {
        return $"{store_address} {store_suburb} {store_state} {store_post_code}".Trim();
      }
    }

    public string StoreAddress {
      get { return store_address; }
      set {
        store_address = value;
        RaisePropertyChanged(nameof(StoreAddress));
      }
    }

    public string StoreSuburb {
      get { return store_suburb; }
      set {
        store_suburb = value;
        RaisePropertyChanged(nameof(StoreSuburb));
      }
    }

    public string StoreState {
      get { return store_state; }
      set {
        store_address = value;
        RaisePropertyChanged(nameof(StoreState));
      }
    }

    public string StorePostCode {
      get { return store_post_code; }
      set {
        store_post_code = value;
        RaisePropertyChanged(nameof(StorePostCode));
      }
    }

    public string Phone {
      get { return phone; }
      set {
        phone = value;
        RaisePropertyChanged(nameof(Phone));
      }
    }

    public string ABN {
      get { return abn; }
      set {
        abn = value;
        RaisePropertyChanged(nameof(ABN));
      }
    }

    public string Company {
      get { return company; }
      set {
        company = value;
        RaisePropertyChanged(nameof(Company));
      }
    }

    public string ContactName {
      get { return contact_name; }
      set {
        contact_name = value;
        RaisePropertyChanged(nameof(ContactName));
      }
    }

    public string ContactEmail {
      get { return contact_email; }
      set {
        contact_email = value;
        RaisePropertyChanged(nameof(ContactEmail));
      }
    }

    public string NameSort => (string.IsNullOrWhiteSpace(Owner) ? "" : Owner[0].ToString().ToUpper());

    #endregion

    #region " Public Events "

    public event PropertyChangedEventHandler PropertyChanged;

    #endregion

    #region " Public Functions "


    #endregion

    #endregion
  }
}
