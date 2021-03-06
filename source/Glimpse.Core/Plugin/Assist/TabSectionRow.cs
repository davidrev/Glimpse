using System;
using System.Collections.Generic;
using System.Linq;

namespace Glimpse.Core.Plugin.Assist
{
    public class TabSectionRow : ITabBuild, ITabStyleValue<TabSectionRow>, ITabStyleRow
    {
        private readonly List<TabColumn> columns = new List<TabColumn>();

        // TODO this might be able to go
        public IEnumerable<TabColumn> Columns
        {
            get { return columns; }
        }

        public TabSectionRow Column(object columnData)
        { 
            var column = new TabColumn(columnData);
            columns.Add(column);
            
            return this;
        }

        public object Build()
        {
            return columns.Select(x => x.Build());
        }

        public TabSectionRow ApplyValueStyle(string format)
        {
            var coloum = columns.Last();
            var formattedData = format.FormatWith(coloum.Data);
            coloum.OverrideData(formattedData);

            return this;
        }

        public void ApplyRowStyle(string style)
        {
            Column(style);
        }
    }
}