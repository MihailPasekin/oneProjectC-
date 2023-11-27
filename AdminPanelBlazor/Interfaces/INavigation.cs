namespace AdminPanelBlazor.Interfaces
{
    public interface INavigation
    {
        Dictionary<string, string> GetPrevParams();
        void SetPrevParams(Dictionary<string, string> keyValuePairs);
        void ClearNavigationStack();
    }
}
