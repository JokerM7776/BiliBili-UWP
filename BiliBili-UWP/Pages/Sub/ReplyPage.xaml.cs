﻿using BiliBili_Lib.Models.BiliBili;
using BiliBili_Lib.Service;
using BiliBili_UWP.Models.UI;
using BiliBili_UWP.Models.UI.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BiliBili_UWP.Pages.Sub
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReplyPage : Page, IRefreshPage
    {
        public List<IconItem> SortTypeList = IconItem.GetReplySortItems();
        private bool _isInit = false;
        private int mode = 3;
        private string oid = "";
        private int next = 0;
        private int total = 0;
        private string type = "1";
        private ObservableCollection<Reply> ReplyCollection = new ObservableCollection<Reply>();
        private BiliBiliClient _client = App.BiliViewModel._client;
        private bool _isRequesting = false;
        private bool isEnd = false;
        public ReplyPage()
        {
            this.InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Enabled;
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            App.AppViewModel.CurrentPagePanel.SubPageTitle = StaticString.REPLY_LIST;
            if (e.NavigationMode == NavigationMode.Back)
                return;
            if (e.Parameter != null && e.Parameter is Dictionary<string, string> param)
            {
                oid = param["oid"];
                type = param["type"];
                SortComboBox.SelectedIndex = 0;
                mode = 3;
                await Refresh();
            }
        }

        private void Reset()
        {
            _isInit = false;
            next = 0;
            total = 0;
            isEnd = false;
            ReplyCollection.Clear();
        }

        public async Task Refresh()
        {
            Reset();
            await LoadReplies();
            _isInit = true;
        }

        private async Task LoadReplies()
        {
            var replies = await _client.GetReplyAsync(oid, next, mode, type);
            if (replies != null)
            {
                total = replies.Item2;
                next = replies.Item1;
                if (replies.Item3!=null && replies.Item3.Count > 0)
                {
                    replies.Item3.ForEach(p => ReplyCollection.Add(p));
                }
                isEnd = replies.Item4;
                if (replies.Item5 != null)
                {
                    TopReplyContainer.Visibility = Visibility.Visible;
                    TopReplyControl.Data = replies.Item5;
                }
                else
                {
                    TopReplyContainer.Visibility = Visibility.Collapsed;
                }
            }
            HolderText.Visibility = ReplyCollection.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
        }

        private async void SortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!_isInit)
                return;
            var temp = Convert.ToInt32((SortComboBox.SelectedItem as IconItem).Param);
            if (mode != temp)
            {
                mode = temp;
                await Refresh();
            }
        }

        private async void ScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            if (_isRequesting)
                return;
            var ele = sender as ScrollViewer;
            if (ele.ExtentHeight - ele.ViewportHeight - ele.VerticalOffset < 50)
            {
                if (ReplyCollection.Count >= total || isEnd)
                    return;
                LoadingBar.Visibility = Visibility.Visible;
                _isRequesting = true;
                await LoadReplies();
                _isRequesting = false;
                LoadingBar.Visibility = Visibility.Collapsed;
            }
        }
    }
}
