using AdminPanelBlazor.Interfaces;

namespace AdminPanelBlazor.Services
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
            if(NavigetionParamsStack.Count>0)
                return NavigetionParamsStack.Pop();
             
            return new Dictionary<string, string>();
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
