using System.Collections.Generic;
using System.IO;

namespace DXLayoutControlSample {
    public class DataSource {
        public List<TileItem> Items { get; set; }
        public DataSource() {
            Items = new List<TileItem>();
            Items.Add(new TileItem { Header = "UserManagment", Content = GetImage("UserManagment.png"), IsSmall = true, Category = TileItem.System });
            Items.Add(new TileItem { Header = "System", Content = GetImage("System.png"), IsSmall = true, Category = TileItem.System });
            Items.Add(new TileItem { Header = "Research", Content = GetImage("Research.png"), IsSmall = true, Category = TileItem.System });
            Items.Add(new TileItem { Header = "Statistics", Content = GetImage("Statistics.png"), IsNewGroup = true, Category = TileItem.Tools });
            Items.Add(new TileItem { Header = "Calc", Content = GetImage("Calc.png"), IsSmall = true, Category = TileItem.Tools });
            Items.Add(new TileItem { Header = "Rates", Content = GetImage("Rates.png"), IsSmall = true, Category = TileItem.Tools });
        }
        byte[] GetImage(string name) {
            return File.ReadAllBytes(@"Images\" + name);
        }
    }
    public class TileItem {
        public string Header { get; set; }
        public object Content { get; set; }
        public bool IsNewGroup { get; set; }
        public bool IsSmall { get; set; }
        public string Category { get; set; }

        public const string System = "System";
        public const string Tools = "Tools";
    }
}