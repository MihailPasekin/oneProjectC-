using MudBlazorAdminPanel.Interfaces;

namespace MudBlazorAdminPanel.Services
{
    public class NavigatorService: INavigation
    {
        public Stack<Dictionary<string,string>> NavigetionParamsStack { get; set; }

        public NavigatorService()
        {
            NavigetionParamsStack = new Stack<Dictionary<string, string>>();
        }

        public Dictionary<string, string> GetPrevParams()
        {
            return NavigetionParamsStack.Pop();
        }

        public void SetPrevParams(Dictionary<string, string> keyValuePairs)
        {
            NavigetionParamsStack.Push(keyValuePairs);
        }

        public void ClearNavigationStack()
        {
            NavigetionParamsStack.Clear();
        }
    }
}
