
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;



namespace daolormdeuansystem
{
    public partial class DSReport
    {
        public partial class DTReserveDataTable
        {
            private void DTReserveDataTable_DTReserveRowChanging(object sender, DTReserveRowChangeEvent e)
            {

            }

        }

        public partial class DSBestSellByMonthDataTable
        {
            private void DSBestSellByMonthDataTable_DSBestSellByMonthRowChanging(object sender, DSBestSellByMonthRowChangeEvent e)
            {

            }

        }

        public partial class DSBestSellByYearDataTable
        {
            private void DSBestSellByYearDataTable_ColumnChanging(object sender, DataColumnChangeEventArgs e)
            {
                //  If (e.Column.ColumnName = Me.DataColumn1Column.ColumnName) Then
                //Add user code here
                //  End If

            }

        }

        public partial class DTReportYearDataTable
        {
            private void DTReportYearDataTable_DTReportYearRowChanging(object sender, DTReportYearRowChangeEvent e)
            {
            }

        }
    }

}
