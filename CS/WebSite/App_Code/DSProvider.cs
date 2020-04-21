using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;


public class MedalInfo {
    public int Gold { get; set; }
    public int Silver { get; set; }
    public int Bronze { get; set; }
}
public class CountryInfo {
    public string Name { get; set; }
    public MedalInfo Info { get; set; }
}

public class DSProvider {
    HttpSessionState Session {
        get { return HttpContext.Current.Session; }
    }
    const string SessionKey = "DSProviderData";

    public List<CountryInfo> GetList() {
        if (Session[SessionKey] == null)
            Session[SessionKey] = CreateData();
        return (List<CountryInfo>)Session[SessionKey];
    }
    List<CountryInfo> CreateData() {
        List<CountryInfo> list = new List<CountryInfo>();
        list.Add(new CountryInfo { Name = "USA", Info = new MedalInfo { Gold = 46, Silver = 37, Bronze = 38 } });
        list.Add(new CountryInfo { Name = "Britain", Info = new MedalInfo { Gold = 27, Silver = 23, Bronze = 17 } });
        list.Add(new CountryInfo { Name = "China", Info = new MedalInfo { Gold = 26, Silver = 18, Bronze = 26 } });
        list.Add(new CountryInfo { Name = "Russia", Info = new MedalInfo { Gold = 19, Silver = 17, Bronze = 19 } });
        list.Add(new CountryInfo { Name = "Germany", Info = new MedalInfo { Gold = 17, Silver = 10, Bronze = 15 } });
        list.Add(new CountryInfo { Name = "Japan", Info = new MedalInfo { Gold = 12, Silver = 8, Bronze = 21 } });
        return list;
    }
}