namespace BSWebtoon.Front.Models.ViewModel.Loginoption
{
    public class LoginOptionViewModel
    {
        public string DisplayName { get; set; }
        public string Scheme { get; set; }
        public string Icon { get; set; }
        //可自行擴充 背景色，Icon...等

        public LoginOptionViewModel(string icon, string scheme)
        {
            Icon = icon;
            Scheme = scheme;
        }
    }
}
