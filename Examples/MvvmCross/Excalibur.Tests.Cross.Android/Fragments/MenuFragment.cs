using System;
using System.Threading.Tasks;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Excalibur.Tests.Cross.Core.ViewModels;
using Excalibur.Tests.Cross.Droid.Activities;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;

namespace Excalibur.Tests.Cross.Droid.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.menu_frame)]
    [Register("Excalibur.Tests.Cross.Droid.Fragments.MenuFragment")]
    public class MenuFragment : MvxFragment<MenuViewModel>, NavigationView.IOnNavigationItemSelectedListener
    {
        private NavigationView _menuView;
        private IMenuItem _previousMenuItem;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.fragment_menu, null);

            _menuView = view.FindViewById<NavigationView>(Resource.Id.menuView);
            _menuView.SetNavigationItemSelectedListener(this);
            _menuView.Menu.FindItem(Resource.Id.nav_home).SetChecked(true);

            var headerView = _menuView.GetHeaderView(0);
            headerView.Click += HeaderViewOnClick;

            //var userName = (TextView)headerView.FindViewById(Resource.Id.userName);
            //userName.Text = "name";

            return view;
        }

        private void HeaderViewOnClick(object sender, EventArgs eventArgs)
        {
            _previousMenuItem?.SetChecked(false);

            ViewModel.ShowCurrentUserCommand.Execute();
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            if (item != _previousMenuItem)
            {
                _previousMenuItem?.SetChecked(false);
            }

            item.SetCheckable(true);
            item.SetChecked(true);

            _previousMenuItem = item;

            Navigate(item.ItemId);

            return true;
        }

        private async Task Navigate(int itemId)
        {
            ((MainActivity)Activity).DrawerLayout.CloseDrawers();

            // add a small delay to prevent any UI issues
            await Task.Delay(TimeSpan.FromMilliseconds(250));

            switch (itemId)
            {
                case Resource.Id.nav_home:
                    ViewModel.PopToRootCommand.Execute();
                    break;
                case Resource.Id.nav_users:
                    ViewModel.ShowUsersCommand.Execute();
                    break;
                case Resource.Id.nav_todo:
                    ViewModel.ShowTodosCommand.Execute();
                    break;
            }
        }
    }
}