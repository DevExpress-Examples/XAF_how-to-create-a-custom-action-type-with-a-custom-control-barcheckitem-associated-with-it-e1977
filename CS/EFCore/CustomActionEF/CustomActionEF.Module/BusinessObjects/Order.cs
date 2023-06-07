using System;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Persistent.BaseImpl.EF;

namespace CustomActionControl.Module {
    [DefaultClassOptions]
    public class Order : BaseObject {
        public virtual string OrderNo { get; set; }
        public virtual bool Active { get; set; }
        public virtual DateTime Date { get; set; }
    }
}
