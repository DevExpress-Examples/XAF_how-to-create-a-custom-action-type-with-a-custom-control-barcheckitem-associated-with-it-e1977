using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace CustomActionControl.Module {
    [DefaultClassOptions]
    public class Order : BaseObject {
        public Order(Session session)
            : base(session) {
        }
        private string _OrderNo;
        public string OrderNo {
            get { return _OrderNo; }
            set { SetPropertyValue("OrderNo", ref _OrderNo, value); }
        }
        private bool _Active;
        public bool Active {
            get { return _Active; }
            set { SetPropertyValue("Active", ref _Active, value); }
        }
        private DateTime _Date;
        public DateTime Date {
            get { return _Date; }
            set { SetPropertyValue("Date", ref _Date, value); }
        }
    }
}
