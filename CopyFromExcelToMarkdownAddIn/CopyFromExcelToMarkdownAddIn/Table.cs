﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyFromExcelToMarkdownAddIn
{
    public class Table
    {
        public GridRow Header { get; }
        public IList<GridRow> Rows { get; } = new List<GridRow>();
    }
}
