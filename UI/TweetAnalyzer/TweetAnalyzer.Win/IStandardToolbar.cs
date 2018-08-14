using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetAnalyzer.Win
{
    interface IStandardToolbar
    {
        void AddItem();
        void DeleteItem();
        void EditItem();
        void ViewItem();
        void RefreshList();

        bool CanAddItem { get; }
        bool CanDeleteItem { get; }
        bool CanEditItem { get; }
        bool CanViewItem { get; }
        bool CanRefreshList { get; }
    }
}
