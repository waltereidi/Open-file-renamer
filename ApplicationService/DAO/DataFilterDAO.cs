using ApplicationService.Interfaces;

namespace ApplicationService.DAO
{
    public enum DataFilterOption
    {
        Contains,
        BiggerThan,
        SmallerThan,
        Extension
    }
    public class DataFilterDAO : IDataFilter
    {
        private string Text { get; set; }
        private DataFilterOption FilterOption { get; set; }
        public DataFilterOption GetFilterOption()
            => FilterOption;
        public DataFilterDAO(string text, string filterOption)
        {
            Text = String.IsNullOrEmpty(text)
                ? ""
                : text;
            FilterOption = String.IsNullOrEmpty(filterOption)
                ? 0
                : SetDataFilterOption(filterOption);
        }

        private DataFilterOption SetDataFilterOption(string option)
        {
            switch (option)
            {
                case "Contains": return DataFilterOption.Contains;
                case "BiggerThan": return DataFilterOption.BiggerThan;
                case "SmallerThan": return DataFilterOption.SmallerThan;
                case "Extension": return DataFilterOption.Extension;
                default: return DataFilterOption.Contains;
            }
        }
        private int GetInt(string text)
        {
            if (int.TryParse(text, out int result))
                return result;
            return 0;
        }
        public Func<string, bool> GetPerdicate()
        {
            switch (FilterOption)
            {

                case DataFilterOption.Contains:
                    return x => x.Contains(Text);
                case DataFilterOption.BiggerThan:
                    return x => GetInt(x) >= GetInt(Text);
                case DataFilterOption.SmallerThan:
                    return x => GetInt(x) <= GetInt(Text);
                case DataFilterOption.Extension:
                    return x => x.Contains(Text);
                default:
                    return x => true;
            }
        }
    }
}
