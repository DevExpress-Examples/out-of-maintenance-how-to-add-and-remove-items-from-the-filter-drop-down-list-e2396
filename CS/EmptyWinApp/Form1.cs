using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;

namespace EmptyWinApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            this.productReportsTableAdapter.Fill(this.productReports._ProductReports);
        }
        readonly object dummyItem = new object();
        private void pivotGridControl1_CustomFilterPopupItems(object sender,
                                            PivotCustomFilterPopupItemsEventArgs e) {
            if(object.ReferenceEquals(e.Field, fieldCategoryName)) {
                for(int i = e.Items.Count - 1; i >= 0; i--) {
                    if(object.Equals(e.Items[i].Value, "Beverages")) {
                        e.Items.RemoveAt(i);
                        break;
                    }
                }
                e.Items.Insert(0, new PivotGridFilterItem(dummyItem,
                                                          "Dummy Item",
                                                          e.Field.FilterValues.Contains(dummyItem)));
            }
        }
    }
}