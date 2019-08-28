//------------------------------------------------------------------------------
// 
//------------------------------------------------------------------------------

#pragma warning disable 1591

namespace com_war_air.com.WARPRO.DB {
    
    
    /// <summary>
    ///
    ///</summary>
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("Bookings_And_payments_DataSet_appData")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class Bookings_And_payments_DataSet_appData : global::System.Data.DataSet {
        
        private PayableToCompanyDataTable tablePayableToCompany;
        
        private BookingsDataTable tableBookings;
        
        private BillsDataTable tableBills;
        
        private LedgerFromPayableDataTable tableLedgerFromPayable;
        
        private TransecDataTable tableTransec;
        
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public Bookings_And_payments_DataSet_appData() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected Bookings_And_payments_DataSet_appData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["PayableToCompany"] != null)) {
                    base.Tables.Add(new PayableToCompanyDataTable(ds.Tables["PayableToCompany"]));
                }
                if ((ds.Tables["Bookings"] != null)) {
                    base.Tables.Add(new BookingsDataTable(ds.Tables["Bookings"]));
                }
                if ((ds.Tables["Bills"] != null)) {
                    base.Tables.Add(new BillsDataTable(ds.Tables["Bills"]));
                }
                if ((ds.Tables["LedgerFromPayable"] != null)) {
                    base.Tables.Add(new LedgerFromPayableDataTable(ds.Tables["LedgerFromPayable"]));
                }
                if ((ds.Tables["Transec"] != null)) {
                    base.Tables.Add(new TransecDataTable(ds.Tables["Transec"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public PayableToCompanyDataTable PayableToCompany {
            get {
                return this.tablePayableToCompany;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public BookingsDataTable Bookings {
            get {
                return this.tableBookings;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public BillsDataTable Bills {
            get {
                return this.tableBills;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public LedgerFromPayableDataTable LedgerFromPayable {
            get {
                return this.tableLedgerFromPayable;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public TransecDataTable Transec {
            get {
                return this.tableTransec;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public override global::System.Data.DataSet Clone() {
            Bookings_And_payments_DataSet_appData cln = ((Bookings_And_payments_DataSet_appData)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["PayableToCompany"] != null)) {
                    base.Tables.Add(new PayableToCompanyDataTable(ds.Tables["PayableToCompany"]));
                }
                if ((ds.Tables["Bookings"] != null)) {
                    base.Tables.Add(new BookingsDataTable(ds.Tables["Bookings"]));
                }
                if ((ds.Tables["Bills"] != null)) {
                    base.Tables.Add(new BillsDataTable(ds.Tables["Bills"]));
                }
                if ((ds.Tables["LedgerFromPayable"] != null)) {
                    base.Tables.Add(new LedgerFromPayableDataTable(ds.Tables["LedgerFromPayable"]));
                }
                if ((ds.Tables["Transec"] != null)) {
                    base.Tables.Add(new TransecDataTable(ds.Tables["Transec"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        internal void InitVars(bool initTable) {
            this.tablePayableToCompany = ((PayableToCompanyDataTable)(base.Tables["PayableToCompany"]));
            if ((initTable == true)) {
                if ((this.tablePayableToCompany != null)) {
                    this.tablePayableToCompany.InitVars();
                }
            }
            this.tableBookings = ((BookingsDataTable)(base.Tables["Bookings"]));
            if ((initTable == true)) {
                if ((this.tableBookings != null)) {
                    this.tableBookings.InitVars();
                }
            }
            this.tableBills = ((BillsDataTable)(base.Tables["Bills"]));
            if ((initTable == true)) {
                if ((this.tableBills != null)) {
                    this.tableBills.InitVars();
                }
            }
            this.tableLedgerFromPayable = ((LedgerFromPayableDataTable)(base.Tables["LedgerFromPayable"]));
            if ((initTable == true)) {
                if ((this.tableLedgerFromPayable != null)) {
                    this.tableLedgerFromPayable.InitVars();
                }
            }
            this.tableTransec = ((TransecDataTable)(base.Tables["Transec"]));
            if ((initTable == true)) {
                if ((this.tableTransec != null)) {
                    this.tableTransec.InitVars();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitClass() {
            this.DataSetName = "Bookings_And_payments_DataSet_appData";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/Bookings_And_payments_DataSet_appData.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tablePayableToCompany = new PayableToCompanyDataTable();
            base.Tables.Add(this.tablePayableToCompany);
            this.tableBookings = new BookingsDataTable();
            base.Tables.Add(this.tableBookings);
            this.tableBills = new BillsDataTable();
            base.Tables.Add(this.tableBills);
            this.tableLedgerFromPayable = new LedgerFromPayableDataTable();
            base.Tables.Add(this.tableLedgerFromPayable);
            this.tableTransec = new TransecDataTable();
            base.Tables.Add(this.tableTransec);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private bool ShouldSerializePayableToCompany() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private bool ShouldSerializeBookings() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private bool ShouldSerializeBills() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private bool ShouldSerializeLedgerFromPayable() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private bool ShouldSerializeTransec() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            Bookings_And_payments_DataSet_appData ds = new Bookings_And_payments_DataSet_appData();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public delegate void PayableToCompanyRowChangeEventHandler(object sender, PayableToCompanyRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public delegate void BookingsRowChangeEventHandler(object sender, BookingsRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public delegate void BillsRowChangeEventHandler(object sender, BillsRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public delegate void LedgerFromPayableRowChangeEventHandler(object sender, LedgerFromPayableRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public delegate void TransecRowChangeEventHandler(object sender, TransecRowChangeEvent e);
        
        /// <summary>
        ///
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class PayableToCompanyDataTable : global::System.Data.TypedTableBase<PayableToCompanyRow> {
            
            private global::System.Data.DataColumn columnPAYABLE_ID;
            
            private global::System.Data.DataColumn columnCOMPANY_ID;
            
            private global::System.Data.DataColumn columnBOOKING_ID;
            
            private global::System.Data.DataColumn columnDATE;
            
            private global::System.Data.DataColumn columnPAYABLE_AMOUNT;
            
            private global::System.Data.DataColumn columnPAID_AMOUNT;
            
            private global::System.Data.DataColumn columnREMAINING_AMOUNT;
            
            private global::System.Data.DataColumn columnIsPAID_FULL;
            
            private global::System.Data.DataColumn columnDEAL_STATUS;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public PayableToCompanyDataTable() {
                this.TableName = "PayableToCompany";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal PayableToCompanyDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected PayableToCompanyDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn PAYABLE_IDColumn {
                get {
                    return this.columnPAYABLE_ID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn COMPANY_IDColumn {
                get {
                    return this.columnCOMPANY_ID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn BOOKING_IDColumn {
                get {
                    return this.columnBOOKING_ID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn DATEColumn {
                get {
                    return this.columnDATE;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn PAYABLE_AMOUNTColumn {
                get {
                    return this.columnPAYABLE_AMOUNT;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn PAID_AMOUNTColumn {
                get {
                    return this.columnPAID_AMOUNT;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn REMAINING_AMOUNTColumn {
                get {
                    return this.columnREMAINING_AMOUNT;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn IsPAID_FULLColumn {
                get {
                    return this.columnIsPAID_FULL;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn DEAL_STATUSColumn {
                get {
                    return this.columnDEAL_STATUS;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public PayableToCompanyRow this[int index] {
                get {
                    return ((PayableToCompanyRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event PayableToCompanyRowChangeEventHandler PayableToCompanyRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event PayableToCompanyRowChangeEventHandler PayableToCompanyRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event PayableToCompanyRowChangeEventHandler PayableToCompanyRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event PayableToCompanyRowChangeEventHandler PayableToCompanyRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void AddPayableToCompanyRow(PayableToCompanyRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public PayableToCompanyRow AddPayableToCompanyRow(long COMPANY_ID, long BOOKING_ID, System.DateTime DATE, decimal PAYABLE_AMOUNT, decimal PAID_AMOUNT, decimal REMAINING_AMOUNT, bool IsPAID_FULL, bool DEAL_STATUS) {
                PayableToCompanyRow rowPayableToCompanyRow = ((PayableToCompanyRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        COMPANY_ID,
                        BOOKING_ID,
                        DATE,
                        PAYABLE_AMOUNT,
                        PAID_AMOUNT,
                        REMAINING_AMOUNT,
                        IsPAID_FULL,
                        DEAL_STATUS};
                rowPayableToCompanyRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowPayableToCompanyRow);
                return rowPayableToCompanyRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public PayableToCompanyRow FindByPAYABLE_ID(long PAYABLE_ID) {
                return ((PayableToCompanyRow)(this.Rows.Find(new object[] {
                            PAYABLE_ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                PayableToCompanyDataTable cln = ((PayableToCompanyDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new PayableToCompanyDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal void InitVars() {
                this.columnPAYABLE_ID = base.Columns["PAYABLE_ID"];
                this.columnCOMPANY_ID = base.Columns["COMPANY_ID"];
                this.columnBOOKING_ID = base.Columns["BOOKING_ID"];
                this.columnDATE = base.Columns["DATE"];
                this.columnPAYABLE_AMOUNT = base.Columns["PAYABLE_AMOUNT"];
                this.columnPAID_AMOUNT = base.Columns["PAID_AMOUNT"];
                this.columnREMAINING_AMOUNT = base.Columns["REMAINING_AMOUNT"];
                this.columnIsPAID_FULL = base.Columns["IsPAID_FULL"];
                this.columnDEAL_STATUS = base.Columns["DEAL_STATUS"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            private void InitClass() {
                this.columnPAYABLE_ID = new global::System.Data.DataColumn("PAYABLE_ID", typeof(long), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPAYABLE_ID);
                this.columnCOMPANY_ID = new global::System.Data.DataColumn("COMPANY_ID", typeof(long), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCOMPANY_ID);
                this.columnBOOKING_ID = new global::System.Data.DataColumn("BOOKING_ID", typeof(long), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnBOOKING_ID);
                this.columnDATE = new global::System.Data.DataColumn("DATE", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDATE);
                this.columnPAYABLE_AMOUNT = new global::System.Data.DataColumn("PAYABLE_AMOUNT", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPAYABLE_AMOUNT);
                this.columnPAID_AMOUNT = new global::System.Data.DataColumn("PAID_AMOUNT", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPAID_AMOUNT);
                this.columnREMAINING_AMOUNT = new global::System.Data.DataColumn("REMAINING_AMOUNT", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnREMAINING_AMOUNT);
                this.columnIsPAID_FULL = new global::System.Data.DataColumn("IsPAID_FULL", typeof(bool), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnIsPAID_FULL);
                this.columnDEAL_STATUS = new global::System.Data.DataColumn("DEAL_STATUS", typeof(bool), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDEAL_STATUS);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnPAYABLE_ID}, true));
                this.columnPAYABLE_ID.AutoIncrement = true;
                this.columnPAYABLE_ID.AutoIncrementSeed = -1;
                this.columnPAYABLE_ID.AutoIncrementStep = -1;
                this.columnPAYABLE_ID.AllowDBNull = false;
                this.columnPAYABLE_ID.ReadOnly = true;
                this.columnPAYABLE_ID.Unique = true;
                this.columnCOMPANY_ID.AllowDBNull = false;
                this.columnBOOKING_ID.AllowDBNull = false;
                this.columnPAYABLE_AMOUNT.AllowDBNull = false;
                this.columnPAID_AMOUNT.AllowDBNull = false;
                this.columnREMAINING_AMOUNT.AllowDBNull = false;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public PayableToCompanyRow NewPayableToCompanyRow() {
                return ((PayableToCompanyRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new PayableToCompanyRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(PayableToCompanyRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.PayableToCompanyRowChanged != null)) {
                    this.PayableToCompanyRowChanged(this, new PayableToCompanyRowChangeEvent(((PayableToCompanyRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.PayableToCompanyRowChanging != null)) {
                    this.PayableToCompanyRowChanging(this, new PayableToCompanyRowChangeEvent(((PayableToCompanyRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.PayableToCompanyRowDeleted != null)) {
                    this.PayableToCompanyRowDeleted(this, new PayableToCompanyRowChangeEvent(((PayableToCompanyRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.PayableToCompanyRowDeleting != null)) {
                    this.PayableToCompanyRowDeleting(this, new PayableToCompanyRowChangeEvent(((PayableToCompanyRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void RemovePayableToCompanyRow(PayableToCompanyRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                Bookings_And_payments_DataSet_appData ds = new Bookings_And_payments_DataSet_appData();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "PayableToCompanyDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class BookingsDataTable : global::System.Data.TypedTableBase<BookingsRow> {
            
            private global::System.Data.DataColumn columnBOOKING_ID;
            
            private global::System.Data.DataColumn columnREFERENCE_TYPE;
            
            private global::System.Data.DataColumn columnREFERENCE_CODE;
            
            private global::System.Data.DataColumn columnBOOKING_DATE;
            
            private global::System.Data.DataColumn columnPACKAGE_CODE;
            
            private global::System.Data.DataColumn columnFOR_NO_OF_PERSONS;
            
            private global::System.Data.DataColumn columnBILL_ID;
            
            private global::System.Data.DataColumn columnBOOKING_STATUS;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public BookingsDataTable() {
                this.TableName = "Bookings";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal BookingsDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected BookingsDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn BOOKING_IDColumn {
                get {
                    return this.columnBOOKING_ID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn REFERENCE_TYPEColumn {
                get {
                    return this.columnREFERENCE_TYPE;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn REFERENCE_CODEColumn {
                get {
                    return this.columnREFERENCE_CODE;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn BOOKING_DATEColumn {
                get {
                    return this.columnBOOKING_DATE;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn PACKAGE_CODEColumn {
                get {
                    return this.columnPACKAGE_CODE;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn FOR_NO_OF_PERSONSColumn {
                get {
                    return this.columnFOR_NO_OF_PERSONS;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn BILL_IDColumn {
                get {
                    return this.columnBILL_ID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn BOOKING_STATUSColumn {
                get {
                    return this.columnBOOKING_STATUS;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public BookingsRow this[int index] {
                get {
                    return ((BookingsRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event BookingsRowChangeEventHandler BookingsRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event BookingsRowChangeEventHandler BookingsRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event BookingsRowChangeEventHandler BookingsRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event BookingsRowChangeEventHandler BookingsRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void AddBookingsRow(BookingsRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public BookingsRow AddBookingsRow(int REFERENCE_TYPE, long REFERENCE_CODE, System.DateTime BOOKING_DATE, long PACKAGE_CODE, int FOR_NO_OF_PERSONS, long BILL_ID, bool BOOKING_STATUS) {
                BookingsRow rowBookingsRow = ((BookingsRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        REFERENCE_TYPE,
                        REFERENCE_CODE,
                        BOOKING_DATE,
                        PACKAGE_CODE,
                        FOR_NO_OF_PERSONS,
                        BILL_ID,
                        BOOKING_STATUS};
                rowBookingsRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowBookingsRow);
                return rowBookingsRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public BookingsRow FindByBOOKING_ID(long BOOKING_ID) {
                return ((BookingsRow)(this.Rows.Find(new object[] {
                            BOOKING_ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                BookingsDataTable cln = ((BookingsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new BookingsDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal void InitVars() {
                this.columnBOOKING_ID = base.Columns["BOOKING_ID"];
                this.columnREFERENCE_TYPE = base.Columns["REFERENCE_TYPE"];
                this.columnREFERENCE_CODE = base.Columns["REFERENCE_CODE"];
                this.columnBOOKING_DATE = base.Columns["BOOKING_DATE"];
                this.columnPACKAGE_CODE = base.Columns["PACKAGE_CODE"];
                this.columnFOR_NO_OF_PERSONS = base.Columns["FOR_NO_OF_PERSONS"];
                this.columnBILL_ID = base.Columns["BILL_ID"];
                this.columnBOOKING_STATUS = base.Columns["BOOKING_STATUS"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            private void InitClass() {
                this.columnBOOKING_ID = new global::System.Data.DataColumn("BOOKING_ID", typeof(long), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnBOOKING_ID);
                this.columnREFERENCE_TYPE = new global::System.Data.DataColumn("REFERENCE_TYPE", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnREFERENCE_TYPE);
                this.columnREFERENCE_CODE = new global::System.Data.DataColumn("REFERENCE_CODE", typeof(long), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnREFERENCE_CODE);
                this.columnBOOKING_DATE = new global::System.Data.DataColumn("BOOKING_DATE", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnBOOKING_DATE);
                this.columnPACKAGE_CODE = new global::System.Data.DataColumn("PACKAGE_CODE", typeof(long), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPACKAGE_CODE);
                this.columnFOR_NO_OF_PERSONS = new global::System.Data.DataColumn("FOR_NO_OF_PERSONS", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnFOR_NO_OF_PERSONS);
                this.columnBILL_ID = new global::System.Data.DataColumn("BILL_ID", typeof(long), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnBILL_ID);
                this.columnBOOKING_STATUS = new global::System.Data.DataColumn("BOOKING_STATUS", typeof(bool), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnBOOKING_STATUS);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnBOOKING_ID}, true));
                this.columnBOOKING_ID.AutoIncrement = true;
                this.columnBOOKING_ID.AutoIncrementSeed = -1;
                this.columnBOOKING_ID.AutoIncrementStep = -1;
                this.columnBOOKING_ID.AllowDBNull = false;
                this.columnBOOKING_ID.ReadOnly = true;
                this.columnBOOKING_ID.Unique = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public BookingsRow NewBookingsRow() {
                return ((BookingsRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new BookingsRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(BookingsRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.BookingsRowChanged != null)) {
                    this.BookingsRowChanged(this, new BookingsRowChangeEvent(((BookingsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.BookingsRowChanging != null)) {
                    this.BookingsRowChanging(this, new BookingsRowChangeEvent(((BookingsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.BookingsRowDeleted != null)) {
                    this.BookingsRowDeleted(this, new BookingsRowChangeEvent(((BookingsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.BookingsRowDeleting != null)) {
                    this.BookingsRowDeleting(this, new BookingsRowChangeEvent(((BookingsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void RemoveBookingsRow(BookingsRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                Bookings_And_payments_DataSet_appData ds = new Bookings_And_payments_DataSet_appData();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "BookingsDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class BillsDataTable : global::System.Data.TypedTableBase<BillsRow> {
            
            private global::System.Data.DataColumn columnBILL_ID;
            
            private global::System.Data.DataColumn columnREFERENCE_TYPE;
            
            private global::System.Data.DataColumn columnREFERENCE_CODE;
            
            private global::System.Data.DataColumn columnBOOKING_ID_NO;
            
            private global::System.Data.DataColumn columnBILL_DATE;
            
            private global::System.Data.DataColumn columnTOTAL_ORIGNAL_AMOUNT;
            
            private global::System.Data.DataColumn columnSPECIAL_OFFER_DISCOUNT;
            
            private global::System.Data.DataColumn columnEXTRA_DISCOUNT;
            
            private global::System.Data.DataColumn columnTOTAL_DISCOUNT;
            
            private global::System.Data.DataColumn columnPAID_AMOUNT;
            
            private global::System.Data.DataColumn columnREMAINING_AMOUNT;
            
            private global::System.Data.DataColumn columnIsPAID_FULL;
            
            private global::System.Data.DataColumn columnIsREFUNDED;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public BillsDataTable() {
                this.TableName = "Bills";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal BillsDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected BillsDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn BILL_IDColumn {
                get {
                    return this.columnBILL_ID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn REFERENCE_TYPEColumn {
                get {
                    return this.columnREFERENCE_TYPE;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn REFERENCE_CODEColumn {
                get {
                    return this.columnREFERENCE_CODE;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn BOOKING_ID_NOColumn {
                get {
                    return this.columnBOOKING_ID_NO;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn BILL_DATEColumn {
                get {
                    return this.columnBILL_DATE;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn TOTAL_ORIGNAL_AMOUNTColumn {
                get {
                    return this.columnTOTAL_ORIGNAL_AMOUNT;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn SPECIAL_OFFER_DISCOUNTColumn {
                get {
                    return this.columnSPECIAL_OFFER_DISCOUNT;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn EXTRA_DISCOUNTColumn {
                get {
                    return this.columnEXTRA_DISCOUNT;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn TOTAL_DISCOUNTColumn {
                get {
                    return this.columnTOTAL_DISCOUNT;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn PAID_AMOUNTColumn {
                get {
                    return this.columnPAID_AMOUNT;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn REMAINING_AMOUNTColumn {
                get {
                    return this.columnREMAINING_AMOUNT;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn IsPAID_FULLColumn {
                get {
                    return this.columnIsPAID_FULL;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn IsREFUNDEDColumn {
                get {
                    return this.columnIsREFUNDED;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public BillsRow this[int index] {
                get {
                    return ((BillsRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event BillsRowChangeEventHandler BillsRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event BillsRowChangeEventHandler BillsRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event BillsRowChangeEventHandler BillsRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event BillsRowChangeEventHandler BillsRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void AddBillsRow(BillsRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public BillsRow AddBillsRow(int REFERENCE_TYPE, long REFERENCE_CODE, long BOOKING_ID_NO, System.DateTime BILL_DATE, decimal TOTAL_ORIGNAL_AMOUNT, decimal SPECIAL_OFFER_DISCOUNT, decimal EXTRA_DISCOUNT, decimal TOTAL_DISCOUNT, decimal PAID_AMOUNT, decimal REMAINING_AMOUNT, bool IsPAID_FULL, bool IsREFUNDED) {
                BillsRow rowBillsRow = ((BillsRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        REFERENCE_TYPE,
                        REFERENCE_CODE,
                        BOOKING_ID_NO,
                        BILL_DATE,
                        TOTAL_ORIGNAL_AMOUNT,
                        SPECIAL_OFFER_DISCOUNT,
                        EXTRA_DISCOUNT,
                        TOTAL_DISCOUNT,
                        PAID_AMOUNT,
                        REMAINING_AMOUNT,
                        IsPAID_FULL,
                        IsREFUNDED};
                rowBillsRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowBillsRow);
                return rowBillsRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public BillsRow FindByBILL_ID(long BILL_ID) {
                return ((BillsRow)(this.Rows.Find(new object[] {
                            BILL_ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                BillsDataTable cln = ((BillsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new BillsDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal void InitVars() {
                this.columnBILL_ID = base.Columns["BILL_ID"];
                this.columnREFERENCE_TYPE = base.Columns["REFERENCE_TYPE"];
                this.columnREFERENCE_CODE = base.Columns["REFERENCE_CODE"];
                this.columnBOOKING_ID_NO = base.Columns["BOOKING_ID_NO"];
                this.columnBILL_DATE = base.Columns["BILL_DATE"];
                this.columnTOTAL_ORIGNAL_AMOUNT = base.Columns["TOTAL_ORIGNAL_AMOUNT"];
                this.columnSPECIAL_OFFER_DISCOUNT = base.Columns["SPECIAL_OFFER_DISCOUNT"];
                this.columnEXTRA_DISCOUNT = base.Columns["EXTRA_DISCOUNT"];
                this.columnTOTAL_DISCOUNT = base.Columns["TOTAL_DISCOUNT"];
                this.columnPAID_AMOUNT = base.Columns["PAID_AMOUNT"];
                this.columnREMAINING_AMOUNT = base.Columns["REMAINING_AMOUNT"];
                this.columnIsPAID_FULL = base.Columns["IsPAID_FULL"];
                this.columnIsREFUNDED = base.Columns["IsREFUNDED"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            private void InitClass() {
                this.columnBILL_ID = new global::System.Data.DataColumn("BILL_ID", typeof(long), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnBILL_ID);
                this.columnREFERENCE_TYPE = new global::System.Data.DataColumn("REFERENCE_TYPE", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnREFERENCE_TYPE);
                this.columnREFERENCE_CODE = new global::System.Data.DataColumn("REFERENCE_CODE", typeof(long), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnREFERENCE_CODE);
                this.columnBOOKING_ID_NO = new global::System.Data.DataColumn("BOOKING_ID_NO", typeof(long), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnBOOKING_ID_NO);
                this.columnBILL_DATE = new global::System.Data.DataColumn("BILL_DATE", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnBILL_DATE);
                this.columnTOTAL_ORIGNAL_AMOUNT = new global::System.Data.DataColumn("TOTAL_ORIGNAL_AMOUNT", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnTOTAL_ORIGNAL_AMOUNT);
                this.columnSPECIAL_OFFER_DISCOUNT = new global::System.Data.DataColumn("SPECIAL_OFFER_DISCOUNT", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnSPECIAL_OFFER_DISCOUNT);
                this.columnEXTRA_DISCOUNT = new global::System.Data.DataColumn("EXTRA_DISCOUNT", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnEXTRA_DISCOUNT);
                this.columnTOTAL_DISCOUNT = new global::System.Data.DataColumn("TOTAL_DISCOUNT", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnTOTAL_DISCOUNT);
                this.columnPAID_AMOUNT = new global::System.Data.DataColumn("PAID_AMOUNT", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPAID_AMOUNT);
                this.columnREMAINING_AMOUNT = new global::System.Data.DataColumn("REMAINING_AMOUNT", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnREMAINING_AMOUNT);
                this.columnIsPAID_FULL = new global::System.Data.DataColumn("IsPAID_FULL", typeof(bool), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnIsPAID_FULL);
                this.columnIsREFUNDED = new global::System.Data.DataColumn("IsREFUNDED", typeof(bool), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnIsREFUNDED);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnBILL_ID}, true));
                this.columnBILL_ID.AutoIncrement = true;
                this.columnBILL_ID.AutoIncrementSeed = -1;
                this.columnBILL_ID.AutoIncrementStep = -1;
                this.columnBILL_ID.AllowDBNull = false;
                this.columnBILL_ID.ReadOnly = true;
                this.columnBILL_ID.Unique = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public BillsRow NewBillsRow() {
                return ((BillsRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new BillsRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(BillsRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.BillsRowChanged != null)) {
                    this.BillsRowChanged(this, new BillsRowChangeEvent(((BillsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.BillsRowChanging != null)) {
                    this.BillsRowChanging(this, new BillsRowChangeEvent(((BillsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.BillsRowDeleted != null)) {
                    this.BillsRowDeleted(this, new BillsRowChangeEvent(((BillsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.BillsRowDeleting != null)) {
                    this.BillsRowDeleting(this, new BillsRowChangeEvent(((BillsRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void RemoveBillsRow(BillsRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                Bookings_And_payments_DataSet_appData ds = new Bookings_And_payments_DataSet_appData();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "BillsDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class LedgerFromPayableDataTable : global::System.Data.TypedTableBase<LedgerFromPayableRow> {
            
            private global::System.Data.DataColumn columnCUSTOMER_ID;
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnAGAINST;
            
            private global::System.Data.DataColumn columnTOTALFACE;
            
            private global::System.Data.DataColumn columnPAID;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public LedgerFromPayableDataTable() {
                this.TableName = "LedgerFromPayable";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal LedgerFromPayableDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected LedgerFromPayableDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn CUSTOMER_IDColumn {
                get {
                    return this.columnCUSTOMER_ID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn AGAINSTColumn {
                get {
                    return this.columnAGAINST;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn TOTALFACEColumn {
                get {
                    return this.columnTOTALFACE;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn PAIDColumn {
                get {
                    return this.columnPAID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public LedgerFromPayableRow this[int index] {
                get {
                    return ((LedgerFromPayableRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event LedgerFromPayableRowChangeEventHandler LedgerFromPayableRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event LedgerFromPayableRowChangeEventHandler LedgerFromPayableRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event LedgerFromPayableRowChangeEventHandler LedgerFromPayableRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event LedgerFromPayableRowChangeEventHandler LedgerFromPayableRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void AddLedgerFromPayableRow(LedgerFromPayableRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public LedgerFromPayableRow AddLedgerFromPayableRow(long CUSTOMER_ID, string ID, string AGAINST, decimal TOTALFACE, decimal PAID) {
                LedgerFromPayableRow rowLedgerFromPayableRow = ((LedgerFromPayableRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        CUSTOMER_ID,
                        ID,
                        AGAINST,
                        TOTALFACE,
                        PAID};
                rowLedgerFromPayableRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowLedgerFromPayableRow);
                return rowLedgerFromPayableRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public LedgerFromPayableRow FindByID(string ID) {
                return ((LedgerFromPayableRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                LedgerFromPayableDataTable cln = ((LedgerFromPayableDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new LedgerFromPayableDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal void InitVars() {
                this.columnCUSTOMER_ID = base.Columns["CUSTOMER_ID"];
                this.columnID = base.Columns["ID"];
                this.columnAGAINST = base.Columns["AGAINST"];
                this.columnTOTALFACE = base.Columns["TOTALFACE"];
                this.columnPAID = base.Columns["PAID"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            private void InitClass() {
                this.columnCUSTOMER_ID = new global::System.Data.DataColumn("CUSTOMER_ID", typeof(long), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCUSTOMER_ID);
                this.columnID = new global::System.Data.DataColumn("ID", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnAGAINST = new global::System.Data.DataColumn("AGAINST", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnAGAINST);
                this.columnTOTALFACE = new global::System.Data.DataColumn("TOTALFACE", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnTOTALFACE);
                this.columnPAID = new global::System.Data.DataColumn("PAID", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPAID);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrementSeed = -1;
                this.columnID.AutoIncrementStep = -1;
                this.columnID.AllowDBNull = false;
                this.columnID.ReadOnly = true;
                this.columnID.Unique = true;
                this.columnID.MaxLength = 100;
                this.columnAGAINST.ReadOnly = true;
                this.columnAGAINST.MaxLength = 7;
                this.columnTOTALFACE.ReadOnly = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public LedgerFromPayableRow NewLedgerFromPayableRow() {
                return ((LedgerFromPayableRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new LedgerFromPayableRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(LedgerFromPayableRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.LedgerFromPayableRowChanged != null)) {
                    this.LedgerFromPayableRowChanged(this, new LedgerFromPayableRowChangeEvent(((LedgerFromPayableRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.LedgerFromPayableRowChanging != null)) {
                    this.LedgerFromPayableRowChanging(this, new LedgerFromPayableRowChangeEvent(((LedgerFromPayableRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.LedgerFromPayableRowDeleted != null)) {
                    this.LedgerFromPayableRowDeleted(this, new LedgerFromPayableRowChangeEvent(((LedgerFromPayableRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.LedgerFromPayableRowDeleting != null)) {
                    this.LedgerFromPayableRowDeleting(this, new LedgerFromPayableRowChangeEvent(((LedgerFromPayableRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void RemoveLedgerFromPayableRow(LedgerFromPayableRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                Bookings_And_payments_DataSet_appData ds = new Bookings_And_payments_DataSet_appData();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "LedgerFromPayableDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class TransecDataTable : global::System.Data.TypedTableBase<TransecRow> {
            
            private global::System.Data.DataColumn columnID;
            
            private global::System.Data.DataColumn columnSERVICE_ID;
            
            private global::System.Data.DataColumn columnCUSTOMER_ID;
            
            private global::System.Data.DataColumn columnDATE;
            
            private global::System.Data.DataColumn columnORIGNAL_RECIEVABLE;
            
            private global::System.Data.DataColumn columnT_RECIEVED;
            
            private global::System.Data.DataColumn columnREMAINING;
            
            private global::System.Data.DataColumn columnSERVICE_NAME;
            
            private global::System.Data.DataColumn columnSTATUS;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public TransecDataTable() {
                this.TableName = "Transec";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal TransecDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected TransecDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn SERVICE_IDColumn {
                get {
                    return this.columnSERVICE_ID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn CUSTOMER_IDColumn {
                get {
                    return this.columnCUSTOMER_ID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn DATEColumn {
                get {
                    return this.columnDATE;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn ORIGNAL_RECIEVABLEColumn {
                get {
                    return this.columnORIGNAL_RECIEVABLE;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn T_RECIEVEDColumn {
                get {
                    return this.columnT_RECIEVED;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn REMAININGColumn {
                get {
                    return this.columnREMAINING;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn SERVICE_NAMEColumn {
                get {
                    return this.columnSERVICE_NAME;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn STATUSColumn {
                get {
                    return this.columnSTATUS;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public TransecRow this[int index] {
                get {
                    return ((TransecRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event TransecRowChangeEventHandler TransecRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event TransecRowChangeEventHandler TransecRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event TransecRowChangeEventHandler TransecRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event TransecRowChangeEventHandler TransecRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void AddTransecRow(TransecRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public TransecRow AddTransecRow(string SERVICE_ID, long CUSTOMER_ID, System.DateTime DATE, decimal ORIGNAL_RECIEVABLE, decimal T_RECIEVED, decimal REMAINING, string SERVICE_NAME, bool STATUS) {
                TransecRow rowTransecRow = ((TransecRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        SERVICE_ID,
                        CUSTOMER_ID,
                        DATE,
                        ORIGNAL_RECIEVABLE,
                        T_RECIEVED,
                        REMAINING,
                        SERVICE_NAME,
                        STATUS};
                rowTransecRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowTransecRow);
                return rowTransecRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public TransecRow FindByID(long ID) {
                return ((TransecRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                TransecDataTable cln = ((TransecDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new TransecDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal void InitVars() {
                this.columnID = base.Columns["ID"];
                this.columnSERVICE_ID = base.Columns["SERVICE_ID"];
                this.columnCUSTOMER_ID = base.Columns["CUSTOMER_ID"];
                this.columnDATE = base.Columns["DATE"];
                this.columnORIGNAL_RECIEVABLE = base.Columns["ORIGNAL_RECIEVABLE"];
                this.columnT_RECIEVED = base.Columns["T_RECIEVED"];
                this.columnREMAINING = base.Columns["REMAINING"];
                this.columnSERVICE_NAME = base.Columns["SERVICE_NAME"];
                this.columnSTATUS = base.Columns["STATUS"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            private void InitClass() {
                this.columnID = new global::System.Data.DataColumn("ID", typeof(long), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnID);
                this.columnSERVICE_ID = new global::System.Data.DataColumn("SERVICE_ID", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnSERVICE_ID);
                this.columnCUSTOMER_ID = new global::System.Data.DataColumn("CUSTOMER_ID", typeof(long), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCUSTOMER_ID);
                this.columnDATE = new global::System.Data.DataColumn("DATE", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDATE);
                this.columnORIGNAL_RECIEVABLE = new global::System.Data.DataColumn("ORIGNAL_RECIEVABLE", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnORIGNAL_RECIEVABLE);
                this.columnT_RECIEVED = new global::System.Data.DataColumn("T_RECIEVED", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnT_RECIEVED);
                this.columnREMAINING = new global::System.Data.DataColumn("REMAINING", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnREMAINING);
                this.columnSERVICE_NAME = new global::System.Data.DataColumn("SERVICE_NAME", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnSERVICE_NAME);
                this.columnSTATUS = new global::System.Data.DataColumn("STATUS", typeof(bool), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnSTATUS);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnID}, true));
                this.columnID.AutoIncrement = true;
                this.columnID.AutoIncrementSeed = -1;
                this.columnID.AutoIncrementStep = -1;
                this.columnID.AllowDBNull = false;
                this.columnID.ReadOnly = true;
                this.columnID.Unique = true;
                this.columnSERVICE_ID.MaxLength = 50;
                this.columnSERVICE_NAME.MaxLength = 50;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public TransecRow NewTransecRow() {
                return ((TransecRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new TransecRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(TransecRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.TransecRowChanged != null)) {
                    this.TransecRowChanged(this, new TransecRowChangeEvent(((TransecRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.TransecRowChanging != null)) {
                    this.TransecRowChanging(this, new TransecRowChangeEvent(((TransecRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.TransecRowDeleted != null)) {
                    this.TransecRowDeleted(this, new TransecRowChangeEvent(((TransecRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.TransecRowDeleting != null)) {
                    this.TransecRowDeleting(this, new TransecRowChangeEvent(((TransecRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void RemoveTransecRow(TransecRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                Bookings_And_payments_DataSet_appData ds = new Bookings_And_payments_DataSet_appData();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "TransecDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class PayableToCompanyRow : global::System.Data.DataRow {
            
            private PayableToCompanyDataTable tablePayableToCompany;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal PayableToCompanyRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tablePayableToCompany = ((PayableToCompanyDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public long PAYABLE_ID {
                get {
                    return ((long)(this[this.tablePayableToCompany.PAYABLE_IDColumn]));
                }
                set {
                    this[this.tablePayableToCompany.PAYABLE_IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public long COMPANY_ID {
                get {
                    return ((long)(this[this.tablePayableToCompany.COMPANY_IDColumn]));
                }
                set {
                    this[this.tablePayableToCompany.COMPANY_IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public long BOOKING_ID {
                get {
                    return ((long)(this[this.tablePayableToCompany.BOOKING_IDColumn]));
                }
                set {
                    this[this.tablePayableToCompany.BOOKING_IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public System.DateTime DATE {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tablePayableToCompany.DATEColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'DATE\' in table \'PayableToCompany\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablePayableToCompany.DATEColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public decimal PAYABLE_AMOUNT {
                get {
                    return ((decimal)(this[this.tablePayableToCompany.PAYABLE_AMOUNTColumn]));
                }
                set {
                    this[this.tablePayableToCompany.PAYABLE_AMOUNTColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public decimal PAID_AMOUNT {
                get {
                    return ((decimal)(this[this.tablePayableToCompany.PAID_AMOUNTColumn]));
                }
                set {
                    this[this.tablePayableToCompany.PAID_AMOUNTColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public decimal REMAINING_AMOUNT {
                get {
                    return ((decimal)(this[this.tablePayableToCompany.REMAINING_AMOUNTColumn]));
                }
                set {
                    this[this.tablePayableToCompany.REMAINING_AMOUNTColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsPAID_FULL {
                get {
                    try {
                        return ((bool)(this[this.tablePayableToCompany.IsPAID_FULLColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'IsPAID_FULL\' in table \'PayableToCompany\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablePayableToCompany.IsPAID_FULLColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool DEAL_STATUS {
                get {
                    try {
                        return ((bool)(this[this.tablePayableToCompany.DEAL_STATUSColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'DEAL_STATUS\' in table \'PayableToCompany\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablePayableToCompany.DEAL_STATUSColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsDATENull() {
                return this.IsNull(this.tablePayableToCompany.DATEColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetDATENull() {
                this[this.tablePayableToCompany.DATEColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsIsPAID_FULLNull() {
                return this.IsNull(this.tablePayableToCompany.IsPAID_FULLColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetIsPAID_FULLNull() {
                this[this.tablePayableToCompany.IsPAID_FULLColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsDEAL_STATUSNull() {
                return this.IsNull(this.tablePayableToCompany.DEAL_STATUSColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetDEAL_STATUSNull() {
                this[this.tablePayableToCompany.DEAL_STATUSColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class BookingsRow : global::System.Data.DataRow {
            
            private BookingsDataTable tableBookings;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal BookingsRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableBookings = ((BookingsDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public long BOOKING_ID {
                get {
                    return ((long)(this[this.tableBookings.BOOKING_IDColumn]));
                }
                set {
                    this[this.tableBookings.BOOKING_IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public int REFERENCE_TYPE {
                get {
                    try {
                        return ((int)(this[this.tableBookings.REFERENCE_TYPEColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'REFERENCE_TYPE\' in table \'Bookings\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBookings.REFERENCE_TYPEColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public long REFERENCE_CODE {
                get {
                    try {
                        return ((long)(this[this.tableBookings.REFERENCE_CODEColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'REFERENCE_CODE\' in table \'Bookings\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBookings.REFERENCE_CODEColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public System.DateTime BOOKING_DATE {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableBookings.BOOKING_DATEColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'BOOKING_DATE\' in table \'Bookings\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBookings.BOOKING_DATEColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public long PACKAGE_CODE {
                get {
                    try {
                        return ((long)(this[this.tableBookings.PACKAGE_CODEColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'PACKAGE_CODE\' in table \'Bookings\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBookings.PACKAGE_CODEColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public int FOR_NO_OF_PERSONS {
                get {
                    try {
                        return ((int)(this[this.tableBookings.FOR_NO_OF_PERSONSColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'FOR_NO_OF_PERSONS\' in table \'Bookings\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBookings.FOR_NO_OF_PERSONSColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public long BILL_ID {
                get {
                    try {
                        return ((long)(this[this.tableBookings.BILL_IDColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'BILL_ID\' in table \'Bookings\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBookings.BILL_IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool BOOKING_STATUS {
                get {
                    try {
                        return ((bool)(this[this.tableBookings.BOOKING_STATUSColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'BOOKING_STATUS\' in table \'Bookings\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBookings.BOOKING_STATUSColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsREFERENCE_TYPENull() {
                return this.IsNull(this.tableBookings.REFERENCE_TYPEColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetREFERENCE_TYPENull() {
                this[this.tableBookings.REFERENCE_TYPEColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsREFERENCE_CODENull() {
                return this.IsNull(this.tableBookings.REFERENCE_CODEColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetREFERENCE_CODENull() {
                this[this.tableBookings.REFERENCE_CODEColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsBOOKING_DATENull() {
                return this.IsNull(this.tableBookings.BOOKING_DATEColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetBOOKING_DATENull() {
                this[this.tableBookings.BOOKING_DATEColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsPACKAGE_CODENull() {
                return this.IsNull(this.tableBookings.PACKAGE_CODEColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetPACKAGE_CODENull() {
                this[this.tableBookings.PACKAGE_CODEColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsFOR_NO_OF_PERSONSNull() {
                return this.IsNull(this.tableBookings.FOR_NO_OF_PERSONSColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetFOR_NO_OF_PERSONSNull() {
                this[this.tableBookings.FOR_NO_OF_PERSONSColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsBILL_IDNull() {
                return this.IsNull(this.tableBookings.BILL_IDColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetBILL_IDNull() {
                this[this.tableBookings.BILL_IDColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsBOOKING_STATUSNull() {
                return this.IsNull(this.tableBookings.BOOKING_STATUSColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetBOOKING_STATUSNull() {
                this[this.tableBookings.BOOKING_STATUSColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class BillsRow : global::System.Data.DataRow {
            
            private BillsDataTable tableBills;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal BillsRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableBills = ((BillsDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public long BILL_ID {
                get {
                    return ((long)(this[this.tableBills.BILL_IDColumn]));
                }
                set {
                    this[this.tableBills.BILL_IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public int REFERENCE_TYPE {
                get {
                    try {
                        return ((int)(this[this.tableBills.REFERENCE_TYPEColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'REFERENCE_TYPE\' in table \'Bills\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBills.REFERENCE_TYPEColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public long REFERENCE_CODE {
                get {
                    try {
                        return ((long)(this[this.tableBills.REFERENCE_CODEColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'REFERENCE_CODE\' in table \'Bills\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBills.REFERENCE_CODEColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public long BOOKING_ID_NO {
                get {
                    try {
                        return ((long)(this[this.tableBills.BOOKING_ID_NOColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'BOOKING_ID_NO\' in table \'Bills\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBills.BOOKING_ID_NOColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public System.DateTime BILL_DATE {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableBills.BILL_DATEColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'BILL_DATE\' in table \'Bills\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBills.BILL_DATEColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public decimal TOTAL_ORIGNAL_AMOUNT {
                get {
                    try {
                        return ((decimal)(this[this.tableBills.TOTAL_ORIGNAL_AMOUNTColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'TOTAL_ORIGNAL_AMOUNT\' in table \'Bills\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBills.TOTAL_ORIGNAL_AMOUNTColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public decimal SPECIAL_OFFER_DISCOUNT {
                get {
                    try {
                        return ((decimal)(this[this.tableBills.SPECIAL_OFFER_DISCOUNTColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'SPECIAL_OFFER_DISCOUNT\' in table \'Bills\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBills.SPECIAL_OFFER_DISCOUNTColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public decimal EXTRA_DISCOUNT {
                get {
                    try {
                        return ((decimal)(this[this.tableBills.EXTRA_DISCOUNTColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'EXTRA_DISCOUNT\' in table \'Bills\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBills.EXTRA_DISCOUNTColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public decimal TOTAL_DISCOUNT {
                get {
                    try {
                        return ((decimal)(this[this.tableBills.TOTAL_DISCOUNTColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'TOTAL_DISCOUNT\' in table \'Bills\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBills.TOTAL_DISCOUNTColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public decimal PAID_AMOUNT {
                get {
                    try {
                        return ((decimal)(this[this.tableBills.PAID_AMOUNTColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'PAID_AMOUNT\' in table \'Bills\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBills.PAID_AMOUNTColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public decimal REMAINING_AMOUNT {
                get {
                    try {
                        return ((decimal)(this[this.tableBills.REMAINING_AMOUNTColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'REMAINING_AMOUNT\' in table \'Bills\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBills.REMAINING_AMOUNTColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsPAID_FULL {
                get {
                    try {
                        return ((bool)(this[this.tableBills.IsPAID_FULLColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'IsPAID_FULL\' in table \'Bills\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBills.IsPAID_FULLColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsREFUNDED {
                get {
                    try {
                        return ((bool)(this[this.tableBills.IsREFUNDEDColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'IsREFUNDED\' in table \'Bills\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableBills.IsREFUNDEDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsREFERENCE_TYPENull() {
                return this.IsNull(this.tableBills.REFERENCE_TYPEColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetREFERENCE_TYPENull() {
                this[this.tableBills.REFERENCE_TYPEColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsREFERENCE_CODENull() {
                return this.IsNull(this.tableBills.REFERENCE_CODEColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetREFERENCE_CODENull() {
                this[this.tableBills.REFERENCE_CODEColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsBOOKING_ID_NONull() {
                return this.IsNull(this.tableBills.BOOKING_ID_NOColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetBOOKING_ID_NONull() {
                this[this.tableBills.BOOKING_ID_NOColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsBILL_DATENull() {
                return this.IsNull(this.tableBills.BILL_DATEColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetBILL_DATENull() {
                this[this.tableBills.BILL_DATEColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsTOTAL_ORIGNAL_AMOUNTNull() {
                return this.IsNull(this.tableBills.TOTAL_ORIGNAL_AMOUNTColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetTOTAL_ORIGNAL_AMOUNTNull() {
                this[this.tableBills.TOTAL_ORIGNAL_AMOUNTColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsSPECIAL_OFFER_DISCOUNTNull() {
                return this.IsNull(this.tableBills.SPECIAL_OFFER_DISCOUNTColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetSPECIAL_OFFER_DISCOUNTNull() {
                this[this.tableBills.SPECIAL_OFFER_DISCOUNTColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsEXTRA_DISCOUNTNull() {
                return this.IsNull(this.tableBills.EXTRA_DISCOUNTColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetEXTRA_DISCOUNTNull() {
                this[this.tableBills.EXTRA_DISCOUNTColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsTOTAL_DISCOUNTNull() {
                return this.IsNull(this.tableBills.TOTAL_DISCOUNTColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetTOTAL_DISCOUNTNull() {
                this[this.tableBills.TOTAL_DISCOUNTColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsPAID_AMOUNTNull() {
                return this.IsNull(this.tableBills.PAID_AMOUNTColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetPAID_AMOUNTNull() {
                this[this.tableBills.PAID_AMOUNTColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsREMAINING_AMOUNTNull() {
                return this.IsNull(this.tableBills.REMAINING_AMOUNTColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetREMAINING_AMOUNTNull() {
                this[this.tableBills.REMAINING_AMOUNTColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsIsPAID_FULLNull() {
                return this.IsNull(this.tableBills.IsPAID_FULLColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetIsPAID_FULLNull() {
                this[this.tableBills.IsPAID_FULLColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsIsREFUNDEDNull() {
                return this.IsNull(this.tableBills.IsREFUNDEDColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetIsREFUNDEDNull() {
                this[this.tableBills.IsREFUNDEDColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class LedgerFromPayableRow : global::System.Data.DataRow {
            
            private LedgerFromPayableDataTable tableLedgerFromPayable;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal LedgerFromPayableRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableLedgerFromPayable = ((LedgerFromPayableDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public long CUSTOMER_ID {
                get {
                    try {
                        return ((long)(this[this.tableLedgerFromPayable.CUSTOMER_IDColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'CUSTOMER_ID\' in table \'LedgerFromPayable\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableLedgerFromPayable.CUSTOMER_IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public string ID {
                get {
                    return ((string)(this[this.tableLedgerFromPayable.IDColumn]));
                }
                set {
                    this[this.tableLedgerFromPayable.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public string AGAINST {
                get {
                    try {
                        return ((string)(this[this.tableLedgerFromPayable.AGAINSTColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'AGAINST\' in table \'LedgerFromPayable\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableLedgerFromPayable.AGAINSTColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public decimal TOTALFACE {
                get {
                    try {
                        return ((decimal)(this[this.tableLedgerFromPayable.TOTALFACEColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'TOTALFACE\' in table \'LedgerFromPayable\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableLedgerFromPayable.TOTALFACEColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public decimal PAID {
                get {
                    try {
                        return ((decimal)(this[this.tableLedgerFromPayable.PAIDColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'PAID\' in table \'LedgerFromPayable\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableLedgerFromPayable.PAIDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsCUSTOMER_IDNull() {
                return this.IsNull(this.tableLedgerFromPayable.CUSTOMER_IDColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetCUSTOMER_IDNull() {
                this[this.tableLedgerFromPayable.CUSTOMER_IDColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsAGAINSTNull() {
                return this.IsNull(this.tableLedgerFromPayable.AGAINSTColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetAGAINSTNull() {
                this[this.tableLedgerFromPayable.AGAINSTColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsTOTALFACENull() {
                return this.IsNull(this.tableLedgerFromPayable.TOTALFACEColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetTOTALFACENull() {
                this[this.tableLedgerFromPayable.TOTALFACEColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsPAIDNull() {
                return this.IsNull(this.tableLedgerFromPayable.PAIDColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetPAIDNull() {
                this[this.tableLedgerFromPayable.PAIDColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class TransecRow : global::System.Data.DataRow {
            
            private TransecDataTable tableTransec;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal TransecRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableTransec = ((TransecDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public long ID {
                get {
                    return ((long)(this[this.tableTransec.IDColumn]));
                }
                set {
                    this[this.tableTransec.IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public string SERVICE_ID {
                get {
                    try {
                        return ((string)(this[this.tableTransec.SERVICE_IDColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'SERVICE_ID\' in table \'Transec\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableTransec.SERVICE_IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public long CUSTOMER_ID {
                get {
                    try {
                        return ((long)(this[this.tableTransec.CUSTOMER_IDColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'CUSTOMER_ID\' in table \'Transec\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableTransec.CUSTOMER_IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public System.DateTime DATE {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableTransec.DATEColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'DATE\' in table \'Transec\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableTransec.DATEColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public decimal ORIGNAL_RECIEVABLE {
                get {
                    try {
                        return ((decimal)(this[this.tableTransec.ORIGNAL_RECIEVABLEColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'ORIGNAL_RECIEVABLE\' in table \'Transec\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableTransec.ORIGNAL_RECIEVABLEColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public decimal T_RECIEVED {
                get {
                    try {
                        return ((decimal)(this[this.tableTransec.T_RECIEVEDColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'T_RECIEVED\' in table \'Transec\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableTransec.T_RECIEVEDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public decimal REMAINING {
                get {
                    try {
                        return ((decimal)(this[this.tableTransec.REMAININGColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'REMAINING\' in table \'Transec\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableTransec.REMAININGColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public string SERVICE_NAME {
                get {
                    try {
                        return ((string)(this[this.tableTransec.SERVICE_NAMEColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'SERVICE_NAME\' in table \'Transec\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableTransec.SERVICE_NAMEColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool STATUS {
                get {
                    try {
                        return ((bool)(this[this.tableTransec.STATUSColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'STATUS\' in table \'Transec\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableTransec.STATUSColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsSERVICE_IDNull() {
                return this.IsNull(this.tableTransec.SERVICE_IDColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetSERVICE_IDNull() {
                this[this.tableTransec.SERVICE_IDColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsCUSTOMER_IDNull() {
                return this.IsNull(this.tableTransec.CUSTOMER_IDColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetCUSTOMER_IDNull() {
                this[this.tableTransec.CUSTOMER_IDColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsDATENull() {
                return this.IsNull(this.tableTransec.DATEColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetDATENull() {
                this[this.tableTransec.DATEColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsORIGNAL_RECIEVABLENull() {
                return this.IsNull(this.tableTransec.ORIGNAL_RECIEVABLEColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetORIGNAL_RECIEVABLENull() {
                this[this.tableTransec.ORIGNAL_RECIEVABLEColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsT_RECIEVEDNull() {
                return this.IsNull(this.tableTransec.T_RECIEVEDColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetT_RECIEVEDNull() {
                this[this.tableTransec.T_RECIEVEDColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsREMAININGNull() {
                return this.IsNull(this.tableTransec.REMAININGColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetREMAININGNull() {
                this[this.tableTransec.REMAININGColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsSERVICE_NAMENull() {
                return this.IsNull(this.tableTransec.SERVICE_NAMEColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetSERVICE_NAMENull() {
                this[this.tableTransec.SERVICE_NAMEColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsSTATUSNull() {
                return this.IsNull(this.tableTransec.STATUSColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetSTATUSNull() {
                this[this.tableTransec.STATUSColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public class PayableToCompanyRowChangeEvent : global::System.EventArgs {
            
            private PayableToCompanyRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public PayableToCompanyRowChangeEvent(PayableToCompanyRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public PayableToCompanyRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public class BookingsRowChangeEvent : global::System.EventArgs {
            
            private BookingsRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public BookingsRowChangeEvent(BookingsRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public BookingsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public class BillsRowChangeEvent : global::System.EventArgs {
            
            private BillsRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public BillsRowChangeEvent(BillsRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public BillsRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public class LedgerFromPayableRowChangeEvent : global::System.EventArgs {
            
            private LedgerFromPayableRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public LedgerFromPayableRowChangeEvent(LedgerFromPayableRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public LedgerFromPayableRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public class TransecRowChangeEvent : global::System.EventArgs {
            
            private TransecRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public TransecRowChangeEvent(TransecRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public TransecRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
namespace com_war_air.com.WARPRO.DB.Bookings_And_payments_DataSet_appDataTableAdapters {
    
    
    /// <summary>
    ///
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class PayableToCompanyTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;
        
        private global::System.Data.SqlClient.SqlConnection _connection;
        
        private global::System.Data.SqlClient.SqlTransaction _transaction;
        
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public PayableToCompanyTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "PayableToCompany";
            tableMapping.ColumnMappings.Add("PAYABLE_ID", "PAYABLE_ID");
            tableMapping.ColumnMappings.Add("COMPANY_ID", "COMPANY_ID");
            tableMapping.ColumnMappings.Add("BOOKING_ID", "BOOKING_ID");
            tableMapping.ColumnMappings.Add("DATE", "DATE");
            tableMapping.ColumnMappings.Add("PAYABLE_AMOUNT", "PAYABLE_AMOUNT");
            tableMapping.ColumnMappings.Add("PAID_AMOUNT", "PAID_AMOUNT");
            tableMapping.ColumnMappings.Add("REMAINING_AMOUNT", "REMAINING_AMOUNT");
            tableMapping.ColumnMappings.Add("IsPAID_FULL", "IsPAID_FULL");
            tableMapping.ColumnMappings.Add("DEAL_STATUS", "DEAL_STATUS");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM [dbo].[PayableToCompany] WHERE (([PAYABLE_ID] = @Original_PAYABLE_ID) AND ([COMPANY_ID] = @Original_COMPANY_ID) AND ([BOOKING_ID] = @Original_BOOKING_ID) AND ((@IsNull_DATE = 1 AND [DATE] IS NULL) OR ([DATE] = @Original_DATE)) AND ([PAYABLE_AMOUNT] = @Original_PAYABLE_AMOUNT) AND ([PAID_AMOUNT] = @Original_PAID_AMOUNT) AND ([REMAINING_AMOUNT] = @Original_REMAINING_AMOUNT) AND ((@IsNull_IsPAID_FULL = 1 AND [IsPAID_FULL] IS NULL) OR ([IsPAID_FULL] = @Original_IsPAID_FULL)) AND ((@IsNull_DEAL_STATUS = 1 AND [DEAL_STATUS] IS NULL) OR ([DEAL_STATUS] = @Original_DEAL_STATUS)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_PAYABLE_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "PAYABLE_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_COMPANY_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "COMPANY_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BOOKING_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_DATE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DATE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_DATE", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DATE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_PAYABLE_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "PAYABLE_AMOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_PAID_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "PAID_AMOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_REMAINING_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "REMAINING_AMOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_IsPAID_FULL", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsPAID_FULL", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_IsPAID_FULL", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsPAID_FULL", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_DEAL_STATUS", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DEAL_STATUS", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_DEAL_STATUS", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DEAL_STATUS", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = @"INSERT INTO [dbo].[PayableToCompany] ([COMPANY_ID], [BOOKING_ID], [DATE], [PAYABLE_AMOUNT], [PAID_AMOUNT], [REMAINING_AMOUNT], [IsPAID_FULL], [DEAL_STATUS]) VALUES (@COMPANY_ID, @BOOKING_ID, @DATE, @PAYABLE_AMOUNT, @PAID_AMOUNT, @REMAINING_AMOUNT, @IsPAID_FULL, @DEAL_STATUS);
SELECT PAYABLE_ID, COMPANY_ID, BOOKING_ID, DATE, PAYABLE_AMOUNT, PAID_AMOUNT, REMAINING_AMOUNT, IsPAID_FULL, DEAL_STATUS FROM PayableToCompany WHERE (PAYABLE_ID = SCOPE_IDENTITY())";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@COMPANY_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "COMPANY_ID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BOOKING_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_ID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DATE", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DATE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@PAYABLE_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "PAYABLE_AMOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@PAID_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "PAID_AMOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REMAINING_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "REMAINING_AMOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsPAID_FULL", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsPAID_FULL", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DEAL_STATUS", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DEAL_STATUS", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[PayableToCompany] SET [COMPANY_ID] = @COMPANY_ID, [BOOKING_ID] = @BOOKING_ID, [DATE] = @DATE, [PAYABLE_AMOUNT] = @PAYABLE_AMOUNT, [PAID_AMOUNT] = @PAID_AMOUNT, [REMAINING_AMOUNT] = @REMAINING_AMOUNT, [IsPAID_FULL] = @IsPAID_FULL, [DEAL_STATUS] = @DEAL_STATUS WHERE (([PAYABLE_ID] = @Original_PAYABLE_ID) AND ([COMPANY_ID] = @Original_COMPANY_ID) AND ([BOOKING_ID] = @Original_BOOKING_ID) AND ((@IsNull_DATE = 1 AND [DATE] IS NULL) OR ([DATE] = @Original_DATE)) AND ([PAYABLE_AMOUNT] = @Original_PAYABLE_AMOUNT) AND ([PAID_AMOUNT] = @Original_PAID_AMOUNT) AND ([REMAINING_AMOUNT] = @Original_REMAINING_AMOUNT) AND ((@IsNull_IsPAID_FULL = 1 AND [IsPAID_FULL] IS NULL) OR ([IsPAID_FULL] = @Original_IsPAID_FULL)) AND ((@IsNull_DEAL_STATUS = 1 AND [DEAL_STATUS] IS NULL) OR ([DEAL_STATUS] = @Original_DEAL_STATUS)));
SELECT PAYABLE_ID, COMPANY_ID, BOOKING_ID, DATE, PAYABLE_AMOUNT, PAID_AMOUNT, REMAINING_AMOUNT, IsPAID_FULL, DEAL_STATUS FROM PayableToCompany WHERE (PAYABLE_ID = @PAYABLE_ID)";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@COMPANY_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "COMPANY_ID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BOOKING_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_ID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DATE", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DATE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@PAYABLE_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "PAYABLE_AMOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@PAID_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "PAID_AMOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REMAINING_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "REMAINING_AMOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsPAID_FULL", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsPAID_FULL", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DEAL_STATUS", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DEAL_STATUS", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_PAYABLE_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "PAYABLE_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_COMPANY_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "COMPANY_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BOOKING_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_DATE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DATE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_DATE", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DATE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_PAYABLE_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "PAYABLE_AMOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_PAID_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "PAID_AMOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_REMAINING_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "REMAINING_AMOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_IsPAID_FULL", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsPAID_FULL", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_IsPAID_FULL", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsPAID_FULL", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_DEAL_STATUS", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DEAL_STATUS", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_DEAL_STATUS", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DEAL_STATUS", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@PAYABLE_ID", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 0, 0, "PAYABLE_ID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::com_war_air.Properties.Settings.Default.Customers__And_AgentsConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[4];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT PAYABLE_ID, COMPANY_ID, BOOKING_ID, DATE, PAYABLE_AMOUNT, PAID_AMOUNT, REM" +
                "AINING_AMOUNT, IsPAID_FULL, DEAL_STATUS FROM dbo.PayableToCompany";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[1] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[1].Connection = this.Connection;
            this._commandCollection[1].CommandText = "dbo.SelectQuery_PayableRowBy_BookingId_StoreProcedure";
            this._commandCollection[1].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@OrignalBookingNo", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[2].Connection = this.Connection;
            this._commandCollection[2].CommandText = "dbo.UpdateQuery_Payable_Deal_Status_StoreProcedure";
            this._commandCollection[2].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DEAL_STATUS", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BOOKING_ID", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[3].Connection = this.Connection;
            this._commandCollection[3].CommandText = "dbo.UpdateQuery_Payable_Pay_By_BookingID_StoreProcedure";
            this._commandCollection[3].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@PAID_AMOUNT", global::System.Data.SqlDbType.Decimal, 9, global::System.Data.ParameterDirection.Input, 18, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REMAINING_AMOUNT", global::System.Data.SqlDbType.Decimal, 9, global::System.Data.ParameterDirection.Input, 18, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsPAID_FULL", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@OrignalBookingID", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(Bookings_And_payments_DataSet_appData.PayableToCompanyDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual Bookings_And_payments_DataSet_appData.PayableToCompanyDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            Bookings_And_payments_DataSet_appData.PayableToCompanyDataTable dataTable = new Bookings_And_payments_DataSet_appData.PayableToCompanyDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, false)]
        public virtual int FillBy_PayableRowBy_BookingId_StoreProcedure(Bookings_And_payments_DataSet_appData.PayableToCompanyDataTable dataTable, global::System.Nullable<long> OrignalBookingNo) {
            this.Adapter.SelectCommand = this.CommandCollection[1];
            if ((OrignalBookingNo.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[1].Value = ((long)(OrignalBookingNo.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, false)]
        public virtual Bookings_And_payments_DataSet_appData.PayableToCompanyDataTable GetDataBy_PayableRowBy_BookingId_StoreProcedure(global::System.Nullable<long> OrignalBookingNo) {
            this.Adapter.SelectCommand = this.CommandCollection[1];
            if ((OrignalBookingNo.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[1].Value = ((long)(OrignalBookingNo.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            Bookings_And_payments_DataSet_appData.PayableToCompanyDataTable dataTable = new Bookings_And_payments_DataSet_appData.PayableToCompanyDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(Bookings_And_payments_DataSet_appData.PayableToCompanyDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(Bookings_And_payments_DataSet_appData dataSet) {
            return this.Adapter.Update(dataSet, "PayableToCompany");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(long Original_PAYABLE_ID, long Original_COMPANY_ID, long Original_BOOKING_ID, global::System.Nullable<global::System.DateTime> Original_DATE, decimal Original_PAYABLE_AMOUNT, decimal Original_PAID_AMOUNT, decimal Original_REMAINING_AMOUNT, global::System.Nullable<bool> Original_IsPAID_FULL, global::System.Nullable<bool> Original_DEAL_STATUS) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((long)(Original_PAYABLE_ID));
            this.Adapter.DeleteCommand.Parameters[1].Value = ((long)(Original_COMPANY_ID));
            this.Adapter.DeleteCommand.Parameters[2].Value = ((long)(Original_BOOKING_ID));
            if ((Original_DATE.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((System.DateTime)(Original_DATE.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            this.Adapter.DeleteCommand.Parameters[5].Value = ((decimal)(Original_PAYABLE_AMOUNT));
            this.Adapter.DeleteCommand.Parameters[6].Value = ((decimal)(Original_PAID_AMOUNT));
            this.Adapter.DeleteCommand.Parameters[7].Value = ((decimal)(Original_REMAINING_AMOUNT));
            if ((Original_IsPAID_FULL.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[8].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[9].Value = ((bool)(Original_IsPAID_FULL.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[8].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            if ((Original_DEAL_STATUS.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[10].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[11].Value = ((bool)(Original_DEAL_STATUS.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[10].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[11].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(long COMPANY_ID, long BOOKING_ID, global::System.Nullable<global::System.DateTime> DATE, decimal PAYABLE_AMOUNT, decimal PAID_AMOUNT, decimal REMAINING_AMOUNT, global::System.Nullable<bool> IsPAID_FULL, global::System.Nullable<bool> DEAL_STATUS) {
            this.Adapter.InsertCommand.Parameters[0].Value = ((long)(COMPANY_ID));
            this.Adapter.InsertCommand.Parameters[1].Value = ((long)(BOOKING_ID));
            if ((DATE.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[2].Value = ((System.DateTime)(DATE.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            this.Adapter.InsertCommand.Parameters[3].Value = ((decimal)(PAYABLE_AMOUNT));
            this.Adapter.InsertCommand.Parameters[4].Value = ((decimal)(PAID_AMOUNT));
            this.Adapter.InsertCommand.Parameters[5].Value = ((decimal)(REMAINING_AMOUNT));
            if ((IsPAID_FULL.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[6].Value = ((bool)(IsPAID_FULL.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((DEAL_STATUS.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[7].Value = ((bool)(DEAL_STATUS.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    long COMPANY_ID, 
                    long BOOKING_ID, 
                    global::System.Nullable<global::System.DateTime> DATE, 
                    decimal PAYABLE_AMOUNT, 
                    decimal PAID_AMOUNT, 
                    decimal REMAINING_AMOUNT, 
                    global::System.Nullable<bool> IsPAID_FULL, 
                    global::System.Nullable<bool> DEAL_STATUS, 
                    long Original_PAYABLE_ID, 
                    long Original_COMPANY_ID, 
                    long Original_BOOKING_ID, 
                    global::System.Nullable<global::System.DateTime> Original_DATE, 
                    decimal Original_PAYABLE_AMOUNT, 
                    decimal Original_PAID_AMOUNT, 
                    decimal Original_REMAINING_AMOUNT, 
                    global::System.Nullable<bool> Original_IsPAID_FULL, 
                    global::System.Nullable<bool> Original_DEAL_STATUS, 
                    long PAYABLE_ID) {
            this.Adapter.UpdateCommand.Parameters[0].Value = ((long)(COMPANY_ID));
            this.Adapter.UpdateCommand.Parameters[1].Value = ((long)(BOOKING_ID));
            if ((DATE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((System.DateTime)(DATE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[3].Value = ((decimal)(PAYABLE_AMOUNT));
            this.Adapter.UpdateCommand.Parameters[4].Value = ((decimal)(PAID_AMOUNT));
            this.Adapter.UpdateCommand.Parameters[5].Value = ((decimal)(REMAINING_AMOUNT));
            if ((IsPAID_FULL.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((bool)(IsPAID_FULL.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((DEAL_STATUS.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[7].Value = ((bool)(DEAL_STATUS.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[8].Value = ((long)(Original_PAYABLE_ID));
            this.Adapter.UpdateCommand.Parameters[9].Value = ((long)(Original_COMPANY_ID));
            this.Adapter.UpdateCommand.Parameters[10].Value = ((long)(Original_BOOKING_ID));
            if ((Original_DATE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[12].Value = ((System.DateTime)(Original_DATE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[13].Value = ((decimal)(Original_PAYABLE_AMOUNT));
            this.Adapter.UpdateCommand.Parameters[14].Value = ((decimal)(Original_PAID_AMOUNT));
            this.Adapter.UpdateCommand.Parameters[15].Value = ((decimal)(Original_REMAINING_AMOUNT));
            if ((Original_IsPAID_FULL.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[17].Value = ((bool)(Original_IsPAID_FULL.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[17].Value = global::System.DBNull.Value;
            }
            if ((Original_DEAL_STATUS.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[18].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[19].Value = ((bool)(Original_DEAL_STATUS.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[18].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[19].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[20].Value = ((long)(PAYABLE_ID));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    long COMPANY_ID, 
                    long BOOKING_ID, 
                    global::System.Nullable<global::System.DateTime> DATE, 
                    decimal PAYABLE_AMOUNT, 
                    decimal PAID_AMOUNT, 
                    decimal REMAINING_AMOUNT, 
                    global::System.Nullable<bool> IsPAID_FULL, 
                    global::System.Nullable<bool> DEAL_STATUS, 
                    long Original_PAYABLE_ID, 
                    long Original_COMPANY_ID, 
                    long Original_BOOKING_ID, 
                    global::System.Nullable<global::System.DateTime> Original_DATE, 
                    decimal Original_PAYABLE_AMOUNT, 
                    decimal Original_PAID_AMOUNT, 
                    decimal Original_REMAINING_AMOUNT, 
                    global::System.Nullable<bool> Original_IsPAID_FULL, 
                    global::System.Nullable<bool> Original_DEAL_STATUS) {
            return this.Update(COMPANY_ID, BOOKING_ID, DATE, PAYABLE_AMOUNT, PAID_AMOUNT, REMAINING_AMOUNT, IsPAID_FULL, DEAL_STATUS, Original_PAYABLE_ID, Original_COMPANY_ID, Original_BOOKING_ID, Original_DATE, Original_PAYABLE_AMOUNT, Original_PAID_AMOUNT, Original_REMAINING_AMOUNT, Original_IsPAID_FULL, Original_DEAL_STATUS, Original_PAYABLE_ID);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, false)]
        public virtual int UpdateQuery_Payable_Deal_Status_StoreProcedure_Func(global::System.Nullable<bool> DEAL_STATUS, global::System.Nullable<long> Original_BOOKING_ID) {
            global::System.Data.SqlClient.SqlCommand command = this.CommandCollection[2];
            if ((DEAL_STATUS.HasValue == true)) {
                command.Parameters[1].Value = ((bool)(DEAL_STATUS.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((Original_BOOKING_ID.HasValue == true)) {
                command.Parameters[2].Value = ((long)(Original_BOOKING_ID.Value));
            }
            else {
                command.Parameters[2].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            int returnValue;
            try {
                returnValue = command.ExecuteNonQuery();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, false)]
        public virtual int UpdateQuery_Payable_Pay_By_BookingID_StoreProcedure_Func(global::System.Nullable<decimal> PAID_AMOUNT, global::System.Nullable<decimal> REMAINING_AMOUNT, global::System.Nullable<bool> IsPAID_FULL, global::System.Nullable<long> OrignalBookingID) {
            global::System.Data.SqlClient.SqlCommand command = this.CommandCollection[3];
            if ((PAID_AMOUNT.HasValue == true)) {
                command.Parameters[1].Value = ((decimal)(PAID_AMOUNT.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((REMAINING_AMOUNT.HasValue == true)) {
                command.Parameters[2].Value = ((decimal)(REMAINING_AMOUNT.Value));
            }
            else {
                command.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((IsPAID_FULL.HasValue == true)) {
                command.Parameters[3].Value = ((bool)(IsPAID_FULL.Value));
            }
            else {
                command.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((OrignalBookingID.HasValue == true)) {
                command.Parameters[4].Value = ((long)(OrignalBookingID.Value));
            }
            else {
                command.Parameters[4].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            int returnValue;
            try {
                returnValue = command.ExecuteNonQuery();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
    }
    
    /// <summary>
    ///
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class BookingsTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;
        
        private global::System.Data.SqlClient.SqlConnection _connection;
        
        private global::System.Data.SqlClient.SqlTransaction _transaction;
        
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public BookingsTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Bookings";
            tableMapping.ColumnMappings.Add("BOOKING_ID", "BOOKING_ID");
            tableMapping.ColumnMappings.Add("REFERENCE_TYPE", "REFERENCE_TYPE");
            tableMapping.ColumnMappings.Add("REFERENCE_CODE", "REFERENCE_CODE");
            tableMapping.ColumnMappings.Add("BOOKING_DATE", "BOOKING_DATE");
            tableMapping.ColumnMappings.Add("PACKAGE_CODE", "PACKAGE_CODE");
            tableMapping.ColumnMappings.Add("FOR_NO_OF_PERSONS", "FOR_NO_OF_PERSONS");
            tableMapping.ColumnMappings.Add("BILL_ID", "BILL_ID");
            tableMapping.ColumnMappings.Add("BOOKING_STATUS", "BOOKING_STATUS");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM [dbo].[Bookings] WHERE (([BOOKING_ID] = @Original_BOOKING_ID) AND ((@IsNull_REFERENCE_TYPE = 1 AND [REFERENCE_TYPE] IS NULL) OR ([REFERENCE_TYPE] = @Original_REFERENCE_TYPE)) AND ((@IsNull_REFERENCE_CODE = 1 AND [REFERENCE_CODE] IS NULL) OR ([REFERENCE_CODE] = @Original_REFERENCE_CODE)) AND ((@IsNull_BOOKING_DATE = 1 AND [BOOKING_DATE] IS NULL) OR ([BOOKING_DATE] = @Original_BOOKING_DATE)) AND ((@IsNull_PACKAGE_CODE = 1 AND [PACKAGE_CODE] IS NULL) OR ([PACKAGE_CODE] = @Original_PACKAGE_CODE)) AND ((@IsNull_FOR_NO_OF_PERSONS = 1 AND [FOR_NO_OF_PERSONS] IS NULL) OR ([FOR_NO_OF_PERSONS] = @Original_FOR_NO_OF_PERSONS)) AND ((@IsNull_BILL_ID = 1 AND [BILL_ID] IS NULL) OR ([BILL_ID] = @Original_BILL_ID)) AND ((@IsNull_BOOKING_STATUS = 1 AND [BOOKING_STATUS] IS NULL) OR ([BOOKING_STATUS] = @Original_BOOKING_STATUS)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BOOKING_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_REFERENCE_TYPE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_TYPE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_REFERENCE_TYPE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_TYPE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_REFERENCE_CODE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_CODE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_REFERENCE_CODE", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_CODE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_BOOKING_DATE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_DATE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BOOKING_DATE", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_DATE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_PACKAGE_CODE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "PACKAGE_CODE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_PACKAGE_CODE", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "PACKAGE_CODE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_FOR_NO_OF_PERSONS", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FOR_NO_OF_PERSONS", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_FOR_NO_OF_PERSONS", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FOR_NO_OF_PERSONS", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_BILL_ID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BILL_ID", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BILL_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BILL_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_BOOKING_STATUS", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_STATUS", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BOOKING_STATUS", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_STATUS", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = @"INSERT INTO [dbo].[Bookings] ([REFERENCE_TYPE], [REFERENCE_CODE], [BOOKING_DATE], [PACKAGE_CODE], [FOR_NO_OF_PERSONS], [BILL_ID], [BOOKING_STATUS]) VALUES (@REFERENCE_TYPE, @REFERENCE_CODE, @BOOKING_DATE, @PACKAGE_CODE, @FOR_NO_OF_PERSONS, @BILL_ID, @BOOKING_STATUS);
SELECT BOOKING_ID, REFERENCE_TYPE, REFERENCE_CODE, BOOKING_DATE, PACKAGE_CODE, FOR_NO_OF_PERSONS, BILL_ID, BOOKING_STATUS FROM Bookings WHERE (BOOKING_ID = SCOPE_IDENTITY())";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REFERENCE_TYPE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_TYPE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REFERENCE_CODE", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_CODE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BOOKING_DATE", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_DATE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@PACKAGE_CODE", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "PACKAGE_CODE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@FOR_NO_OF_PERSONS", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FOR_NO_OF_PERSONS", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BILL_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BILL_ID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BOOKING_STATUS", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_STATUS", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[Bookings] SET [REFERENCE_TYPE] = @REFERENCE_TYPE, [REFERENCE_CODE] = @REFERENCE_CODE, [BOOKING_DATE] = @BOOKING_DATE, [PACKAGE_CODE] = @PACKAGE_CODE, [FOR_NO_OF_PERSONS] = @FOR_NO_OF_PERSONS, [BILL_ID] = @BILL_ID, [BOOKING_STATUS] = @BOOKING_STATUS WHERE (([BOOKING_ID] = @Original_BOOKING_ID) AND ((@IsNull_REFERENCE_TYPE = 1 AND [REFERENCE_TYPE] IS NULL) OR ([REFERENCE_TYPE] = @Original_REFERENCE_TYPE)) AND ((@IsNull_REFERENCE_CODE = 1 AND [REFERENCE_CODE] IS NULL) OR ([REFERENCE_CODE] = @Original_REFERENCE_CODE)) AND ((@IsNull_BOOKING_DATE = 1 AND [BOOKING_DATE] IS NULL) OR ([BOOKING_DATE] = @Original_BOOKING_DATE)) AND ((@IsNull_PACKAGE_CODE = 1 AND [PACKAGE_CODE] IS NULL) OR ([PACKAGE_CODE] = @Original_PACKAGE_CODE)) AND ((@IsNull_FOR_NO_OF_PERSONS = 1 AND [FOR_NO_OF_PERSONS] IS NULL) OR ([FOR_NO_OF_PERSONS] = @Original_FOR_NO_OF_PERSONS)) AND ((@IsNull_BILL_ID = 1 AND [BILL_ID] IS NULL) OR ([BILL_ID] = @Original_BILL_ID)) AND ((@IsNull_BOOKING_STATUS = 1 AND [BOOKING_STATUS] IS NULL) OR ([BOOKING_STATUS] = @Original_BOOKING_STATUS)));
SELECT BOOKING_ID, REFERENCE_TYPE, REFERENCE_CODE, BOOKING_DATE, PACKAGE_CODE, FOR_NO_OF_PERSONS, BILL_ID, BOOKING_STATUS FROM Bookings WHERE (BOOKING_ID = @BOOKING_ID)";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REFERENCE_TYPE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_TYPE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REFERENCE_CODE", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_CODE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BOOKING_DATE", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_DATE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@PACKAGE_CODE", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "PACKAGE_CODE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@FOR_NO_OF_PERSONS", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FOR_NO_OF_PERSONS", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BILL_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BILL_ID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BOOKING_STATUS", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_STATUS", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BOOKING_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_REFERENCE_TYPE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_TYPE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_REFERENCE_TYPE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_TYPE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_REFERENCE_CODE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_CODE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_REFERENCE_CODE", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_CODE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_BOOKING_DATE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_DATE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BOOKING_DATE", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_DATE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_PACKAGE_CODE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "PACKAGE_CODE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_PACKAGE_CODE", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "PACKAGE_CODE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_FOR_NO_OF_PERSONS", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FOR_NO_OF_PERSONS", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_FOR_NO_OF_PERSONS", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FOR_NO_OF_PERSONS", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_BILL_ID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BILL_ID", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BILL_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BILL_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_BOOKING_STATUS", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_STATUS", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BOOKING_STATUS", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_STATUS", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BOOKING_ID", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_ID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::com_war_air.Properties.Settings.Default.Customers__And_AgentsConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[5];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT BOOKING_ID, REFERENCE_TYPE, REFERENCE_CODE, BOOKING_DATE, PACKAGE_CODE, FO" +
                "R_NO_OF_PERSONS, BILL_ID, BOOKING_STATUS FROM dbo.Bookings";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[1] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[1].Connection = this.Connection;
            this._commandCollection[1].CommandText = "dbo.SelectQuery_Bookig_Row_By_Booking_ID_StoreProcedure";
            this._commandCollection[1].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@OrignalBookingId", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[2].Connection = this.Connection;
            this._commandCollection[2].CommandText = "dbo.insertQuery_AddNew_Bookings_Bill_StoreProcedure";
            this._commandCollection[2].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REFERENCE_TYPE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REFERENCE_CODE", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BOOKING_DATE", global::System.Data.SqlDbType.Date, 3, global::System.Data.ParameterDirection.Input, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@PACKAGE_CODE", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@FOR_NO_OF_PERSONS", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BILL_DATE", global::System.Data.SqlDbType.Date, 3, global::System.Data.ParameterDirection.Input, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@TOTAL_ORIGNAL_AMOUNT", global::System.Data.SqlDbType.Decimal, 9, global::System.Data.ParameterDirection.Input, 18, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@SPECIAL_OFFER_DISCOUNT", global::System.Data.SqlDbType.Decimal, 9, global::System.Data.ParameterDirection.Input, 18, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@EXTRA_DISCOUNT", global::System.Data.SqlDbType.Decimal, 9, global::System.Data.ParameterDirection.Input, 18, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@TOTAL_DISCOUNT", global::System.Data.SqlDbType.Decimal, 9, global::System.Data.ParameterDirection.Input, 18, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@PAID_AMOUNT", global::System.Data.SqlDbType.Decimal, 9, global::System.Data.ParameterDirection.Input, 18, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REMAINING_AMOUNT", global::System.Data.SqlDbType.Decimal, 9, global::System.Data.ParameterDirection.Input, 18, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsPAID_FULL", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@isREFUNDED", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BOOKING_STATUS", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@CompanyID", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ISpaidFullPayableFalse", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DealStatusPayableTrue", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@payableAmount", global::System.Data.SqlDbType.Decimal, 9, global::System.Data.ParameterDirection.Input, 18, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[3].Connection = this.Connection;
            this._commandCollection[3].CommandText = "dbo.ScalarQuery_GetLast_BookingID";
            this._commandCollection[3].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[4].Connection = this.Connection;
            this._commandCollection[4].CommandText = "dbo.UpdateQuery_booking_Status_Update_StoreProcedure";
            this._commandCollection[4].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BOOKING_STATUS", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BOOKING_ID", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(Bookings_And_payments_DataSet_appData.BookingsDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual Bookings_And_payments_DataSet_appData.BookingsDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            Bookings_And_payments_DataSet_appData.BookingsDataTable dataTable = new Bookings_And_payments_DataSet_appData.BookingsDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, false)]
        public virtual int FillBy_Row_Booking_ID(Bookings_And_payments_DataSet_appData.BookingsDataTable dataTable, global::System.Nullable<long> OrignalBookingId) {
            this.Adapter.SelectCommand = this.CommandCollection[1];
            if ((OrignalBookingId.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[1].Value = ((long)(OrignalBookingId.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, false)]
        public virtual Bookings_And_payments_DataSet_appData.BookingsDataTable GetDataBy_Row_Booking_ID(global::System.Nullable<long> OrignalBookingId) {
            this.Adapter.SelectCommand = this.CommandCollection[1];
            if ((OrignalBookingId.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[1].Value = ((long)(OrignalBookingId.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            Bookings_And_payments_DataSet_appData.BookingsDataTable dataTable = new Bookings_And_payments_DataSet_appData.BookingsDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(Bookings_And_payments_DataSet_appData.BookingsDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(Bookings_And_payments_DataSet_appData dataSet) {
            return this.Adapter.Update(dataSet, "Bookings");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(long Original_BOOKING_ID, global::System.Nullable<int> Original_REFERENCE_TYPE, global::System.Nullable<long> Original_REFERENCE_CODE, global::System.Nullable<global::System.DateTime> Original_BOOKING_DATE, global::System.Nullable<long> Original_PACKAGE_CODE, global::System.Nullable<int> Original_FOR_NO_OF_PERSONS, global::System.Nullable<long> Original_BILL_ID, global::System.Nullable<bool> Original_BOOKING_STATUS) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((long)(Original_BOOKING_ID));
            if ((Original_REFERENCE_TYPE.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((int)(Original_REFERENCE_TYPE.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((Original_REFERENCE_CODE.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((long)(Original_REFERENCE_CODE.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Original_BOOKING_DATE.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[6].Value = ((System.DateTime)(Original_BOOKING_DATE.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Original_PACKAGE_CODE.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[8].Value = ((long)(Original_PACKAGE_CODE.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((Original_FOR_NO_OF_PERSONS.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[10].Value = ((int)(Original_FOR_NO_OF_PERSONS.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((Original_BILL_ID.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[12].Value = ((long)(Original_BILL_ID.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            if ((Original_BOOKING_STATUS.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[14].Value = ((bool)(Original_BOOKING_STATUS.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(global::System.Nullable<int> REFERENCE_TYPE, global::System.Nullable<long> REFERENCE_CODE, global::System.Nullable<global::System.DateTime> BOOKING_DATE, global::System.Nullable<long> PACKAGE_CODE, global::System.Nullable<int> FOR_NO_OF_PERSONS, global::System.Nullable<long> BILL_ID, global::System.Nullable<bool> BOOKING_STATUS) {
            if ((REFERENCE_TYPE.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[0].Value = ((int)(REFERENCE_TYPE.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            if ((REFERENCE_CODE.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[1].Value = ((long)(REFERENCE_CODE.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((BOOKING_DATE.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[2].Value = ((System.DateTime)(BOOKING_DATE.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((PACKAGE_CODE.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[3].Value = ((long)(PACKAGE_CODE.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((FOR_NO_OF_PERSONS.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[4].Value = ((int)(FOR_NO_OF_PERSONS.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((BILL_ID.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[5].Value = ((long)(BILL_ID.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((BOOKING_STATUS.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[6].Value = ((bool)(BOOKING_STATUS.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    global::System.Nullable<int> REFERENCE_TYPE, 
                    global::System.Nullable<long> REFERENCE_CODE, 
                    global::System.Nullable<global::System.DateTime> BOOKING_DATE, 
                    global::System.Nullable<long> PACKAGE_CODE, 
                    global::System.Nullable<int> FOR_NO_OF_PERSONS, 
                    global::System.Nullable<long> BILL_ID, 
                    global::System.Nullable<bool> BOOKING_STATUS, 
                    long Original_BOOKING_ID, 
                    global::System.Nullable<int> Original_REFERENCE_TYPE, 
                    global::System.Nullable<long> Original_REFERENCE_CODE, 
                    global::System.Nullable<global::System.DateTime> Original_BOOKING_DATE, 
                    global::System.Nullable<long> Original_PACKAGE_CODE, 
                    global::System.Nullable<int> Original_FOR_NO_OF_PERSONS, 
                    global::System.Nullable<long> Original_BILL_ID, 
                    global::System.Nullable<bool> Original_BOOKING_STATUS, 
                    long BOOKING_ID) {
            if ((REFERENCE_TYPE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((int)(REFERENCE_TYPE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            if ((REFERENCE_CODE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((long)(REFERENCE_CODE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((BOOKING_DATE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((System.DateTime)(BOOKING_DATE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((PACKAGE_CODE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((long)(PACKAGE_CODE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((FOR_NO_OF_PERSONS.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((int)(FOR_NO_OF_PERSONS.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((BILL_ID.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((long)(BILL_ID.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((BOOKING_STATUS.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((bool)(BOOKING_STATUS.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[7].Value = ((long)(Original_BOOKING_ID));
            if ((Original_REFERENCE_TYPE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[9].Value = ((int)(Original_REFERENCE_TYPE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            if ((Original_REFERENCE_CODE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[11].Value = ((long)(Original_REFERENCE_CODE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[11].Value = global::System.DBNull.Value;
            }
            if ((Original_BOOKING_DATE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[12].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[13].Value = ((System.DateTime)(Original_BOOKING_DATE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[12].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[13].Value = global::System.DBNull.Value;
            }
            if ((Original_PACKAGE_CODE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[15].Value = ((long)(Original_PACKAGE_CODE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[15].Value = global::System.DBNull.Value;
            }
            if ((Original_FOR_NO_OF_PERSONS.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[17].Value = ((int)(Original_FOR_NO_OF_PERSONS.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[17].Value = global::System.DBNull.Value;
            }
            if ((Original_BILL_ID.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[18].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[19].Value = ((long)(Original_BILL_ID.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[18].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[19].Value = global::System.DBNull.Value;
            }
            if ((Original_BOOKING_STATUS.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[20].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[21].Value = ((bool)(Original_BOOKING_STATUS.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[20].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[21].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[22].Value = ((long)(BOOKING_ID));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(global::System.Nullable<int> REFERENCE_TYPE, global::System.Nullable<long> REFERENCE_CODE, global::System.Nullable<global::System.DateTime> BOOKING_DATE, global::System.Nullable<long> PACKAGE_CODE, global::System.Nullable<int> FOR_NO_OF_PERSONS, global::System.Nullable<long> BILL_ID, global::System.Nullable<bool> BOOKING_STATUS, long Original_BOOKING_ID, global::System.Nullable<int> Original_REFERENCE_TYPE, global::System.Nullable<long> Original_REFERENCE_CODE, global::System.Nullable<global::System.DateTime> Original_BOOKING_DATE, global::System.Nullable<long> Original_PACKAGE_CODE, global::System.Nullable<int> Original_FOR_NO_OF_PERSONS, global::System.Nullable<long> Original_BILL_ID, global::System.Nullable<bool> Original_BOOKING_STATUS) {
            return this.Update(REFERENCE_TYPE, REFERENCE_CODE, BOOKING_DATE, PACKAGE_CODE, FOR_NO_OF_PERSONS, BILL_ID, BOOKING_STATUS, Original_BOOKING_ID, Original_REFERENCE_TYPE, Original_REFERENCE_CODE, Original_BOOKING_DATE, Original_PACKAGE_CODE, Original_FOR_NO_OF_PERSONS, Original_BILL_ID, Original_BOOKING_STATUS, Original_BOOKING_ID);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int insertQuery_AddNew_Bookings_Bill_StoreProcedure_Func(
                    global::System.Nullable<int> REFERENCE_TYPE, 
                    global::System.Nullable<long> REFERENCE_CODE, 
                    global::System.Nullable<global::System.DateTime> BOOKING_DATE, 
                    global::System.Nullable<long> PACKAGE_CODE, 
                    global::System.Nullable<int> FOR_NO_OF_PERSONS, 
                    global::System.Nullable<global::System.DateTime> BILL_DATE, 
                    global::System.Nullable<decimal> TOTAL_ORIGNAL_AMOUNT, 
                    global::System.Nullable<decimal> SPECIAL_OFFER_DISCOUNT, 
                    global::System.Nullable<decimal> EXTRA_DISCOUNT, 
                    global::System.Nullable<decimal> TOTAL_DISCOUNT, 
                    global::System.Nullable<decimal> PAID_AMOUNT, 
                    global::System.Nullable<decimal> REMAINING_AMOUNT, 
                    global::System.Nullable<bool> IsPAID_FULL, 
                    global::System.Nullable<bool> isREFUNDED, 
                    global::System.Nullable<bool> BOOKING_STATUS, 
                    global::System.Nullable<long> CompanyID, 
                    global::System.Nullable<bool> ISpaidFullPayableFalse, 
                    global::System.Nullable<bool> DealStatusPayableTrue, 
                    global::System.Nullable<decimal> payableAmount) {
            global::System.Data.SqlClient.SqlCommand command = this.CommandCollection[2];
            if ((REFERENCE_TYPE.HasValue == true)) {
                command.Parameters[1].Value = ((int)(REFERENCE_TYPE.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((REFERENCE_CODE.HasValue == true)) {
                command.Parameters[2].Value = ((long)(REFERENCE_CODE.Value));
            }
            else {
                command.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((BOOKING_DATE.HasValue == true)) {
                command.Parameters[3].Value = ((System.DateTime)(BOOKING_DATE.Value));
            }
            else {
                command.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((PACKAGE_CODE.HasValue == true)) {
                command.Parameters[4].Value = ((long)(PACKAGE_CODE.Value));
            }
            else {
                command.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((FOR_NO_OF_PERSONS.HasValue == true)) {
                command.Parameters[5].Value = ((int)(FOR_NO_OF_PERSONS.Value));
            }
            else {
                command.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((BILL_DATE.HasValue == true)) {
                command.Parameters[6].Value = ((System.DateTime)(BILL_DATE.Value));
            }
            else {
                command.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((TOTAL_ORIGNAL_AMOUNT.HasValue == true)) {
                command.Parameters[7].Value = ((decimal)(TOTAL_ORIGNAL_AMOUNT.Value));
            }
            else {
                command.Parameters[7].Value = global::System.DBNull.Value;
            }
            if ((SPECIAL_OFFER_DISCOUNT.HasValue == true)) {
                command.Parameters[8].Value = ((decimal)(SPECIAL_OFFER_DISCOUNT.Value));
            }
            else {
                command.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((EXTRA_DISCOUNT.HasValue == true)) {
                command.Parameters[9].Value = ((decimal)(EXTRA_DISCOUNT.Value));
            }
            else {
                command.Parameters[9].Value = global::System.DBNull.Value;
            }
            if ((TOTAL_DISCOUNT.HasValue == true)) {
                command.Parameters[10].Value = ((decimal)(TOTAL_DISCOUNT.Value));
            }
            else {
                command.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((PAID_AMOUNT.HasValue == true)) {
                command.Parameters[11].Value = ((decimal)(PAID_AMOUNT.Value));
            }
            else {
                command.Parameters[11].Value = global::System.DBNull.Value;
            }
            if ((REMAINING_AMOUNT.HasValue == true)) {
                command.Parameters[12].Value = ((decimal)(REMAINING_AMOUNT.Value));
            }
            else {
                command.Parameters[12].Value = global::System.DBNull.Value;
            }
            if ((IsPAID_FULL.HasValue == true)) {
                command.Parameters[13].Value = ((bool)(IsPAID_FULL.Value));
            }
            else {
                command.Parameters[13].Value = global::System.DBNull.Value;
            }
            if ((isREFUNDED.HasValue == true)) {
                command.Parameters[14].Value = ((bool)(isREFUNDED.Value));
            }
            else {
                command.Parameters[14].Value = global::System.DBNull.Value;
            }
            if ((BOOKING_STATUS.HasValue == true)) {
                command.Parameters[15].Value = ((bool)(BOOKING_STATUS.Value));
            }
            else {
                command.Parameters[15].Value = global::System.DBNull.Value;
            }
            if ((CompanyID.HasValue == true)) {
                command.Parameters[16].Value = ((long)(CompanyID.Value));
            }
            else {
                command.Parameters[16].Value = global::System.DBNull.Value;
            }
            if ((ISpaidFullPayableFalse.HasValue == true)) {
                command.Parameters[17].Value = ((bool)(ISpaidFullPayableFalse.Value));
            }
            else {
                command.Parameters[17].Value = global::System.DBNull.Value;
            }
            if ((DealStatusPayableTrue.HasValue == true)) {
                command.Parameters[18].Value = ((bool)(DealStatusPayableTrue.Value));
            }
            else {
                command.Parameters[18].Value = global::System.DBNull.Value;
            }
            if ((payableAmount.HasValue == true)) {
                command.Parameters[19].Value = ((decimal)(payableAmount.Value));
            }
            else {
                command.Parameters[19].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            int returnValue;
            try {
                returnValue = command.ExecuteNonQuery();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual object ScalarQuery_GetLast_BookingID_Func() {
            global::System.Data.SqlClient.SqlCommand command = this.CommandCollection[3];
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return null;
            }
            else {
                return ((object)(returnValue));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, false)]
        public virtual int UpdateQuery_booking_Status_Update_StoreProcedure_Func(global::System.Nullable<bool> BOOKING_STATUS, global::System.Nullable<long> Original_BOOKING_ID) {
            global::System.Data.SqlClient.SqlCommand command = this.CommandCollection[4];
            if ((BOOKING_STATUS.HasValue == true)) {
                command.Parameters[1].Value = ((bool)(BOOKING_STATUS.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((Original_BOOKING_ID.HasValue == true)) {
                command.Parameters[2].Value = ((long)(Original_BOOKING_ID.Value));
            }
            else {
                command.Parameters[2].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            int returnValue;
            try {
                returnValue = command.ExecuteNonQuery();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
    }
    
    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class BillsTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;
        
        private global::System.Data.SqlClient.SqlConnection _connection;
        
        private global::System.Data.SqlClient.SqlTransaction _transaction;
        
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public BillsTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Bills";
            tableMapping.ColumnMappings.Add("BILL_ID", "BILL_ID");
            tableMapping.ColumnMappings.Add("REFERENCE_TYPE", "REFERENCE_TYPE");
            tableMapping.ColumnMappings.Add("REFERENCE_CODE", "REFERENCE_CODE");
            tableMapping.ColumnMappings.Add("BOOKING_ID_NO", "BOOKING_ID_NO");
            tableMapping.ColumnMappings.Add("BILL_DATE", "BILL_DATE");
            tableMapping.ColumnMappings.Add("TOTAL_ORIGNAL_AMOUNT", "TOTAL_ORIGNAL_AMOUNT");
            tableMapping.ColumnMappings.Add("SPECIAL_OFFER_DISCOUNT", "SPECIAL_OFFER_DISCOUNT");
            tableMapping.ColumnMappings.Add("EXTRA_DISCOUNT", "EXTRA_DISCOUNT");
            tableMapping.ColumnMappings.Add("TOTAL_DISCOUNT", "TOTAL_DISCOUNT");
            tableMapping.ColumnMappings.Add("PAID_AMOUNT", "PAID_AMOUNT");
            tableMapping.ColumnMappings.Add("REMAINING_AMOUNT", "REMAINING_AMOUNT");
            tableMapping.ColumnMappings.Add("IsPAID_FULL", "IsPAID_FULL");
            tableMapping.ColumnMappings.Add("IsREFUNDED", "IsREFUNDED");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM [dbo].[Bills] WHERE (([BILL_ID] = @Original_BILL_ID) AND ((@IsNull_REFERENCE_TYPE = 1 AND [REFERENCE_TYPE] IS NULL) OR ([REFERENCE_TYPE] = @Original_REFERENCE_TYPE)) AND ((@IsNull_REFERENCE_CODE = 1 AND [REFERENCE_CODE] IS NULL) OR ([REFERENCE_CODE] = @Original_REFERENCE_CODE)) AND ((@IsNull_BOOKING_ID_NO = 1 AND [BOOKING_ID_NO] IS NULL) OR ([BOOKING_ID_NO] = @Original_BOOKING_ID_NO)) AND ((@IsNull_BILL_DATE = 1 AND [BILL_DATE] IS NULL) OR ([BILL_DATE] = @Original_BILL_DATE)) AND ((@IsNull_TOTAL_ORIGNAL_AMOUNT = 1 AND [TOTAL_ORIGNAL_AMOUNT] IS NULL) OR ([TOTAL_ORIGNAL_AMOUNT] = @Original_TOTAL_ORIGNAL_AMOUNT)) AND ((@IsNull_SPECIAL_OFFER_DISCOUNT = 1 AND [SPECIAL_OFFER_DISCOUNT] IS NULL) OR ([SPECIAL_OFFER_DISCOUNT] = @Original_SPECIAL_OFFER_DISCOUNT)) AND ((@IsNull_EXTRA_DISCOUNT = 1 AND [EXTRA_DISCOUNT] IS NULL) OR ([EXTRA_DISCOUNT] = @Original_EXTRA_DISCOUNT)) AND ((@IsNull_TOTAL_DISCOUNT = 1 AND [TOTAL_DISCOUNT] IS NULL) OR ([TOTAL_DISCOUNT] = @Original_TOTAL_DISCOUNT)) AND ((@IsNull_PAID_AMOUNT = 1 AND [PAID_AMOUNT] IS NULL) OR ([PAID_AMOUNT] = @Original_PAID_AMOUNT)) AND ((@IsNull_REMAINING_AMOUNT = 1 AND [REMAINING_AMOUNT] IS NULL) OR ([REMAINING_AMOUNT] = @Original_REMAINING_AMOUNT)) AND ((@IsNull_IsPAID_FULL = 1 AND [IsPAID_FULL] IS NULL) OR ([IsPAID_FULL] = @Original_IsPAID_FULL)) AND ((@IsNull_IsREFUNDED = 1 AND [IsREFUNDED] IS NULL) OR ([IsREFUNDED] = @Original_IsREFUNDED)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BILL_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BILL_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_REFERENCE_TYPE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_TYPE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_REFERENCE_TYPE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_TYPE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_REFERENCE_CODE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_CODE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_REFERENCE_CODE", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_CODE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_BOOKING_ID_NO", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_ID_NO", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BOOKING_ID_NO", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_ID_NO", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_BILL_DATE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BILL_DATE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BILL_DATE", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BILL_DATE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_TOTAL_ORIGNAL_AMOUNT", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "TOTAL_ORIGNAL_AMOUNT", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_TOTAL_ORIGNAL_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "TOTAL_ORIGNAL_AMOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_SPECIAL_OFFER_DISCOUNT", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "SPECIAL_OFFER_DISCOUNT", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_SPECIAL_OFFER_DISCOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "SPECIAL_OFFER_DISCOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_EXTRA_DISCOUNT", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "EXTRA_DISCOUNT", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_EXTRA_DISCOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "EXTRA_DISCOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_TOTAL_DISCOUNT", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "TOTAL_DISCOUNT", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_TOTAL_DISCOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "TOTAL_DISCOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_PAID_AMOUNT", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "PAID_AMOUNT", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_PAID_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "PAID_AMOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_REMAINING_AMOUNT", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REMAINING_AMOUNT", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_REMAINING_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "REMAINING_AMOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_IsPAID_FULL", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsPAID_FULL", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_IsPAID_FULL", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsPAID_FULL", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_IsREFUNDED", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsREFUNDED", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_IsREFUNDED", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsREFUNDED", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = @"INSERT INTO [dbo].[Bills] ([REFERENCE_TYPE], [REFERENCE_CODE], [BOOKING_ID_NO], [BILL_DATE], [TOTAL_ORIGNAL_AMOUNT], [SPECIAL_OFFER_DISCOUNT], [EXTRA_DISCOUNT], [TOTAL_DISCOUNT], [PAID_AMOUNT], [REMAINING_AMOUNT], [IsPAID_FULL], [IsREFUNDED]) VALUES (@REFERENCE_TYPE, @REFERENCE_CODE, @BOOKING_ID_NO, @BILL_DATE, @TOTAL_ORIGNAL_AMOUNT, @SPECIAL_OFFER_DISCOUNT, @EXTRA_DISCOUNT, @TOTAL_DISCOUNT, @PAID_AMOUNT, @REMAINING_AMOUNT, @IsPAID_FULL, @IsREFUNDED);
SELECT BILL_ID, REFERENCE_TYPE, REFERENCE_CODE, BOOKING_ID_NO, BILL_DATE, TOTAL_ORIGNAL_AMOUNT, SPECIAL_OFFER_DISCOUNT, EXTRA_DISCOUNT, TOTAL_DISCOUNT, PAID_AMOUNT, REMAINING_AMOUNT, IsPAID_FULL, IsREFUNDED FROM Bills WHERE (BILL_ID = SCOPE_IDENTITY())";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REFERENCE_TYPE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_TYPE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REFERENCE_CODE", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_CODE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BOOKING_ID_NO", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_ID_NO", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BILL_DATE", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BILL_DATE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@TOTAL_ORIGNAL_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "TOTAL_ORIGNAL_AMOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@SPECIAL_OFFER_DISCOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "SPECIAL_OFFER_DISCOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@EXTRA_DISCOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "EXTRA_DISCOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@TOTAL_DISCOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "TOTAL_DISCOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@PAID_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "PAID_AMOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REMAINING_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "REMAINING_AMOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsPAID_FULL", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsPAID_FULL", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsREFUNDED", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsREFUNDED", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[Bills] SET [REFERENCE_TYPE] = @REFERENCE_TYPE, [REFERENCE_CODE] = @" +
                "REFERENCE_CODE, [BOOKING_ID_NO] = @BOOKING_ID_NO, [BILL_DATE] = @BILL_DATE, [TOT" +
                "AL_ORIGNAL_AMOUNT] = @TOTAL_ORIGNAL_AMOUNT, [SPECIAL_OFFER_DISCOUNT] = @SPECIAL_" +
                "OFFER_DISCOUNT, [EXTRA_DISCOUNT] = @EXTRA_DISCOUNT, [TOTAL_DISCOUNT] = @TOTAL_DI" +
                "SCOUNT, [PAID_AMOUNT] = @PAID_AMOUNT, [REMAINING_AMOUNT] = @REMAINING_AMOUNT, [I" +
                "sPAID_FULL] = @IsPAID_FULL, [IsREFUNDED] = @IsREFUNDED WHERE (([BILL_ID] = @Orig" +
                "inal_BILL_ID) AND ((@IsNull_REFERENCE_TYPE = 1 AND [REFERENCE_TYPE] IS NULL) OR " +
                "([REFERENCE_TYPE] = @Original_REFERENCE_TYPE)) AND ((@IsNull_REFERENCE_CODE = 1 " +
                "AND [REFERENCE_CODE] IS NULL) OR ([REFERENCE_CODE] = @Original_REFERENCE_CODE)) " +
                "AND ((@IsNull_BOOKING_ID_NO = 1 AND [BOOKING_ID_NO] IS NULL) OR ([BOOKING_ID_NO]" +
                " = @Original_BOOKING_ID_NO)) AND ((@IsNull_BILL_DATE = 1 AND [BILL_DATE] IS NULL" +
                ") OR ([BILL_DATE] = @Original_BILL_DATE)) AND ((@IsNull_TOTAL_ORIGNAL_AMOUNT = 1" +
                " AND [TOTAL_ORIGNAL_AMOUNT] IS NULL) OR ([TOTAL_ORIGNAL_AMOUNT] = @Original_TOTA" +
                "L_ORIGNAL_AMOUNT)) AND ((@IsNull_SPECIAL_OFFER_DISCOUNT = 1 AND [SPECIAL_OFFER_D" +
                "ISCOUNT] IS NULL) OR ([SPECIAL_OFFER_DISCOUNT] = @Original_SPECIAL_OFFER_DISCOUN" +
                "T)) AND ((@IsNull_EXTRA_DISCOUNT = 1 AND [EXTRA_DISCOUNT] IS NULL) OR ([EXTRA_DI" +
                "SCOUNT] = @Original_EXTRA_DISCOUNT)) AND ((@IsNull_TOTAL_DISCOUNT = 1 AND [TOTAL" +
                "_DISCOUNT] IS NULL) OR ([TOTAL_DISCOUNT] = @Original_TOTAL_DISCOUNT)) AND ((@IsN" +
                "ull_PAID_AMOUNT = 1 AND [PAID_AMOUNT] IS NULL) OR ([PAID_AMOUNT] = @Original_PAI" +
                "D_AMOUNT)) AND ((@IsNull_REMAINING_AMOUNT = 1 AND [REMAINING_AMOUNT] IS NULL) OR" +
                " ([REMAINING_AMOUNT] = @Original_REMAINING_AMOUNT)) AND ((@IsNull_IsPAID_FULL = " +
                "1 AND [IsPAID_FULL] IS NULL) OR ([IsPAID_FULL] = @Original_IsPAID_FULL)) AND ((@" +
                "IsNull_IsREFUNDED = 1 AND [IsREFUNDED] IS NULL) OR ([IsREFUNDED] = @Original_IsR" +
                "EFUNDED)));\r\nSELECT BILL_ID, REFERENCE_TYPE, REFERENCE_CODE, BOOKING_ID_NO, BILL" +
                "_DATE, TOTAL_ORIGNAL_AMOUNT, SPECIAL_OFFER_DISCOUNT, EXTRA_DISCOUNT, TOTAL_DISCO" +
                "UNT, PAID_AMOUNT, REMAINING_AMOUNT, IsPAID_FULL, IsREFUNDED FROM Bills WHERE (BI" +
                "LL_ID = @BILL_ID)";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REFERENCE_TYPE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_TYPE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REFERENCE_CODE", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_CODE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BOOKING_ID_NO", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_ID_NO", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BILL_DATE", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BILL_DATE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@TOTAL_ORIGNAL_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "TOTAL_ORIGNAL_AMOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@SPECIAL_OFFER_DISCOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "SPECIAL_OFFER_DISCOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@EXTRA_DISCOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "EXTRA_DISCOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@TOTAL_DISCOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "TOTAL_DISCOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@PAID_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "PAID_AMOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REMAINING_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "REMAINING_AMOUNT", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsPAID_FULL", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsPAID_FULL", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsREFUNDED", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsREFUNDED", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BILL_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BILL_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_REFERENCE_TYPE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_TYPE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_REFERENCE_TYPE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_TYPE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_REFERENCE_CODE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_CODE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_REFERENCE_CODE", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REFERENCE_CODE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_BOOKING_ID_NO", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_ID_NO", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BOOKING_ID_NO", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BOOKING_ID_NO", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_BILL_DATE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BILL_DATE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BILL_DATE", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "BILL_DATE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_TOTAL_ORIGNAL_AMOUNT", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "TOTAL_ORIGNAL_AMOUNT", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_TOTAL_ORIGNAL_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "TOTAL_ORIGNAL_AMOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_SPECIAL_OFFER_DISCOUNT", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "SPECIAL_OFFER_DISCOUNT", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_SPECIAL_OFFER_DISCOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "SPECIAL_OFFER_DISCOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_EXTRA_DISCOUNT", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "EXTRA_DISCOUNT", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_EXTRA_DISCOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "EXTRA_DISCOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_TOTAL_DISCOUNT", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "TOTAL_DISCOUNT", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_TOTAL_DISCOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "TOTAL_DISCOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_PAID_AMOUNT", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "PAID_AMOUNT", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_PAID_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "PAID_AMOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_REMAINING_AMOUNT", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REMAINING_AMOUNT", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_REMAINING_AMOUNT", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "REMAINING_AMOUNT", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_IsPAID_FULL", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsPAID_FULL", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_IsPAID_FULL", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsPAID_FULL", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_IsREFUNDED", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsREFUNDED", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_IsREFUNDED", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "IsREFUNDED", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BILL_ID", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 0, 0, "BILL_ID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::com_war_air.Properties.Settings.Default.Customers__And_AgentsConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[5];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT BILL_ID, REFERENCE_TYPE, REFERENCE_CODE, BOOKING_ID_NO, BILL_DATE, TOTAL_O" +
                "RIGNAL_AMOUNT, SPECIAL_OFFER_DISCOUNT, EXTRA_DISCOUNT, TOTAL_DISCOUNT, PAID_AMOU" +
                "NT, REMAINING_AMOUNT, IsPAID_FULL, IsREFUNDED FROM dbo.Bills";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[1] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[1].Connection = this.Connection;
            this._commandCollection[1].CommandText = "dbo.SelectQuery_Bill_Row_by_Bill_ID_StoreProcedure";
            this._commandCollection[1].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Orignal_BillID", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[2].Connection = this.Connection;
            this._commandCollection[2].CommandText = "dbo.ScalarQuery_Get_Last_Added_Bill_ID_Store_Procedure";
            this._commandCollection[2].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[3].Connection = this.Connection;
            this._commandCollection[3].CommandText = "dbo.UpdateQuery_Bill_Status_IsRfunded_StoreProcedure";
            this._commandCollection[3].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsREFUNDED", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_BOOKING_ID_NO", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[4].Connection = this.Connection;
            this._commandCollection[4].CommandText = "dbo.UpdateQuery_Remaining_amount_StoreProcedure";
            this._commandCollection[4].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@NewPaid_Amount", global::System.Data.SqlDbType.Decimal, 9, global::System.Data.ParameterDirection.Input, 18, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@NewRemaining_Amount", global::System.Data.SqlDbType.Decimal, 9, global::System.Data.ParameterDirection.Input, 18, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IspaidFull", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Orignal_Bill_ID", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(Bookings_And_payments_DataSet_appData.BillsDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual Bookings_And_payments_DataSet_appData.BillsDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            Bookings_And_payments_DataSet_appData.BillsDataTable dataTable = new Bookings_And_payments_DataSet_appData.BillsDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, false)]
        public virtual int FillBy_Row_Bill_by_Id(Bookings_And_payments_DataSet_appData.BillsDataTable dataTable, global::System.Nullable<long> Orignal_BillID) {
            this.Adapter.SelectCommand = this.CommandCollection[1];
            if ((Orignal_BillID.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[1].Value = ((long)(Orignal_BillID.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, false)]
        public virtual Bookings_And_payments_DataSet_appData.BillsDataTable GetDataBy_Row_Bill_by_Id(global::System.Nullable<long> Orignal_BillID) {
            this.Adapter.SelectCommand = this.CommandCollection[1];
            if ((Orignal_BillID.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[1].Value = ((long)(Orignal_BillID.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            Bookings_And_payments_DataSet_appData.BillsDataTable dataTable = new Bookings_And_payments_DataSet_appData.BillsDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(Bookings_And_payments_DataSet_appData.BillsDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(Bookings_And_payments_DataSet_appData dataSet) {
            return this.Adapter.Update(dataSet, "Bills");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(long Original_BILL_ID, global::System.Nullable<int> Original_REFERENCE_TYPE, global::System.Nullable<long> Original_REFERENCE_CODE, global::System.Nullable<long> Original_BOOKING_ID_NO, global::System.Nullable<global::System.DateTime> Original_BILL_DATE, global::System.Nullable<decimal> Original_TOTAL_ORIGNAL_AMOUNT, global::System.Nullable<decimal> Original_SPECIAL_OFFER_DISCOUNT, global::System.Nullable<decimal> Original_EXTRA_DISCOUNT, global::System.Nullable<decimal> Original_TOTAL_DISCOUNT, global::System.Nullable<decimal> Original_PAID_AMOUNT, global::System.Nullable<decimal> Original_REMAINING_AMOUNT, global::System.Nullable<bool> Original_IsPAID_FULL, global::System.Nullable<bool> Original_IsREFUNDED) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((long)(Original_BILL_ID));
            if ((Original_REFERENCE_TYPE.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((int)(Original_REFERENCE_TYPE.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((Original_REFERENCE_CODE.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((long)(Original_REFERENCE_CODE.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Original_BOOKING_ID_NO.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[6].Value = ((long)(Original_BOOKING_ID_NO.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Original_BILL_DATE.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[8].Value = ((System.DateTime)(Original_BILL_DATE.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((Original_TOTAL_ORIGNAL_AMOUNT.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[10].Value = ((decimal)(Original_TOTAL_ORIGNAL_AMOUNT.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((Original_SPECIAL_OFFER_DISCOUNT.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[12].Value = ((decimal)(Original_SPECIAL_OFFER_DISCOUNT.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            if ((Original_EXTRA_DISCOUNT.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[14].Value = ((decimal)(Original_EXTRA_DISCOUNT.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            if ((Original_TOTAL_DISCOUNT.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[15].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[16].Value = ((decimal)(Original_TOTAL_DISCOUNT.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[15].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[16].Value = global::System.DBNull.Value;
            }
            if ((Original_PAID_AMOUNT.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[17].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[18].Value = ((decimal)(Original_PAID_AMOUNT.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[17].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[18].Value = global::System.DBNull.Value;
            }
            if ((Original_REMAINING_AMOUNT.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[19].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[20].Value = ((decimal)(Original_REMAINING_AMOUNT.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[19].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[20].Value = global::System.DBNull.Value;
            }
            if ((Original_IsPAID_FULL.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[21].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[22].Value = ((bool)(Original_IsPAID_FULL.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[21].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[22].Value = global::System.DBNull.Value;
            }
            if ((Original_IsREFUNDED.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[23].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[24].Value = ((bool)(Original_IsREFUNDED.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[23].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[24].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(global::System.Nullable<int> REFERENCE_TYPE, global::System.Nullable<long> REFERENCE_CODE, global::System.Nullable<long> BOOKING_ID_NO, global::System.Nullable<global::System.DateTime> BILL_DATE, global::System.Nullable<decimal> TOTAL_ORIGNAL_AMOUNT, global::System.Nullable<decimal> SPECIAL_OFFER_DISCOUNT, global::System.Nullable<decimal> EXTRA_DISCOUNT, global::System.Nullable<decimal> TOTAL_DISCOUNT, global::System.Nullable<decimal> PAID_AMOUNT, global::System.Nullable<decimal> REMAINING_AMOUNT, global::System.Nullable<bool> IsPAID_FULL, global::System.Nullable<bool> IsREFUNDED) {
            if ((REFERENCE_TYPE.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[0].Value = ((int)(REFERENCE_TYPE.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            if ((REFERENCE_CODE.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[1].Value = ((long)(REFERENCE_CODE.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((BOOKING_ID_NO.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[2].Value = ((long)(BOOKING_ID_NO.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((BILL_DATE.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[3].Value = ((System.DateTime)(BILL_DATE.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((TOTAL_ORIGNAL_AMOUNT.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[4].Value = ((decimal)(TOTAL_ORIGNAL_AMOUNT.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((SPECIAL_OFFER_DISCOUNT.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[5].Value = ((decimal)(SPECIAL_OFFER_DISCOUNT.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((EXTRA_DISCOUNT.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[6].Value = ((decimal)(EXTRA_DISCOUNT.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((TOTAL_DISCOUNT.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[7].Value = ((decimal)(TOTAL_DISCOUNT.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            if ((PAID_AMOUNT.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[8].Value = ((decimal)(PAID_AMOUNT.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((REMAINING_AMOUNT.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[9].Value = ((decimal)(REMAINING_AMOUNT.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            if ((IsPAID_FULL.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[10].Value = ((bool)(IsPAID_FULL.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((IsREFUNDED.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[11].Value = ((bool)(IsREFUNDED.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[11].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    global::System.Nullable<int> REFERENCE_TYPE, 
                    global::System.Nullable<long> REFERENCE_CODE, 
                    global::System.Nullable<long> BOOKING_ID_NO, 
                    global::System.Nullable<global::System.DateTime> BILL_DATE, 
                    global::System.Nullable<decimal> TOTAL_ORIGNAL_AMOUNT, 
                    global::System.Nullable<decimal> SPECIAL_OFFER_DISCOUNT, 
                    global::System.Nullable<decimal> EXTRA_DISCOUNT, 
                    global::System.Nullable<decimal> TOTAL_DISCOUNT, 
                    global::System.Nullable<decimal> PAID_AMOUNT, 
                    global::System.Nullable<decimal> REMAINING_AMOUNT, 
                    global::System.Nullable<bool> IsPAID_FULL, 
                    global::System.Nullable<bool> IsREFUNDED, 
                    long Original_BILL_ID, 
                    global::System.Nullable<int> Original_REFERENCE_TYPE, 
                    global::System.Nullable<long> Original_REFERENCE_CODE, 
                    global::System.Nullable<long> Original_BOOKING_ID_NO, 
                    global::System.Nullable<global::System.DateTime> Original_BILL_DATE, 
                    global::System.Nullable<decimal> Original_TOTAL_ORIGNAL_AMOUNT, 
                    global::System.Nullable<decimal> Original_SPECIAL_OFFER_DISCOUNT, 
                    global::System.Nullable<decimal> Original_EXTRA_DISCOUNT, 
                    global::System.Nullable<decimal> Original_TOTAL_DISCOUNT, 
                    global::System.Nullable<decimal> Original_PAID_AMOUNT, 
                    global::System.Nullable<decimal> Original_REMAINING_AMOUNT, 
                    global::System.Nullable<bool> Original_IsPAID_FULL, 
                    global::System.Nullable<bool> Original_IsREFUNDED, 
                    long BILL_ID) {
            if ((REFERENCE_TYPE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((int)(REFERENCE_TYPE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            if ((REFERENCE_CODE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((long)(REFERENCE_CODE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((BOOKING_ID_NO.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((long)(BOOKING_ID_NO.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((BILL_DATE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((System.DateTime)(BILL_DATE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((TOTAL_ORIGNAL_AMOUNT.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((decimal)(TOTAL_ORIGNAL_AMOUNT.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((SPECIAL_OFFER_DISCOUNT.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((decimal)(SPECIAL_OFFER_DISCOUNT.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((EXTRA_DISCOUNT.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((decimal)(EXTRA_DISCOUNT.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((TOTAL_DISCOUNT.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[7].Value = ((decimal)(TOTAL_DISCOUNT.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            if ((PAID_AMOUNT.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((decimal)(PAID_AMOUNT.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((REMAINING_AMOUNT.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[9].Value = ((decimal)(REMAINING_AMOUNT.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            if ((IsPAID_FULL.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((bool)(IsPAID_FULL.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((IsREFUNDED.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[11].Value = ((bool)(IsREFUNDED.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[11].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[12].Value = ((long)(Original_BILL_ID));
            if ((Original_REFERENCE_TYPE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[14].Value = ((int)(Original_REFERENCE_TYPE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            if ((Original_REFERENCE_CODE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[15].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[16].Value = ((long)(Original_REFERENCE_CODE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[15].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[16].Value = global::System.DBNull.Value;
            }
            if ((Original_BOOKING_ID_NO.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[17].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[18].Value = ((long)(Original_BOOKING_ID_NO.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[17].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[18].Value = global::System.DBNull.Value;
            }
            if ((Original_BILL_DATE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[19].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[20].Value = ((System.DateTime)(Original_BILL_DATE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[19].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[20].Value = global::System.DBNull.Value;
            }
            if ((Original_TOTAL_ORIGNAL_AMOUNT.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[21].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[22].Value = ((decimal)(Original_TOTAL_ORIGNAL_AMOUNT.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[21].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[22].Value = global::System.DBNull.Value;
            }
            if ((Original_SPECIAL_OFFER_DISCOUNT.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[23].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[24].Value = ((decimal)(Original_SPECIAL_OFFER_DISCOUNT.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[23].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[24].Value = global::System.DBNull.Value;
            }
            if ((Original_EXTRA_DISCOUNT.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[25].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[26].Value = ((decimal)(Original_EXTRA_DISCOUNT.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[25].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[26].Value = global::System.DBNull.Value;
            }
            if ((Original_TOTAL_DISCOUNT.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[27].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[28].Value = ((decimal)(Original_TOTAL_DISCOUNT.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[27].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[28].Value = global::System.DBNull.Value;
            }
            if ((Original_PAID_AMOUNT.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[29].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[30].Value = ((decimal)(Original_PAID_AMOUNT.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[29].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[30].Value = global::System.DBNull.Value;
            }
            if ((Original_REMAINING_AMOUNT.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[31].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[32].Value = ((decimal)(Original_REMAINING_AMOUNT.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[31].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[32].Value = global::System.DBNull.Value;
            }
            if ((Original_IsPAID_FULL.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[33].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[34].Value = ((bool)(Original_IsPAID_FULL.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[33].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[34].Value = global::System.DBNull.Value;
            }
            if ((Original_IsREFUNDED.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[35].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[36].Value = ((bool)(Original_IsREFUNDED.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[35].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[36].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[37].Value = ((long)(BILL_ID));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    global::System.Nullable<int> REFERENCE_TYPE, 
                    global::System.Nullable<long> REFERENCE_CODE, 
                    global::System.Nullable<long> BOOKING_ID_NO, 
                    global::System.Nullable<global::System.DateTime> BILL_DATE, 
                    global::System.Nullable<decimal> TOTAL_ORIGNAL_AMOUNT, 
                    global::System.Nullable<decimal> SPECIAL_OFFER_DISCOUNT, 
                    global::System.Nullable<decimal> EXTRA_DISCOUNT, 
                    global::System.Nullable<decimal> TOTAL_DISCOUNT, 
                    global::System.Nullable<decimal> PAID_AMOUNT, 
                    global::System.Nullable<decimal> REMAINING_AMOUNT, 
                    global::System.Nullable<bool> IsPAID_FULL, 
                    global::System.Nullable<bool> IsREFUNDED, 
                    long Original_BILL_ID, 
                    global::System.Nullable<int> Original_REFERENCE_TYPE, 
                    global::System.Nullable<long> Original_REFERENCE_CODE, 
                    global::System.Nullable<long> Original_BOOKING_ID_NO, 
                    global::System.Nullable<global::System.DateTime> Original_BILL_DATE, 
                    global::System.Nullable<decimal> Original_TOTAL_ORIGNAL_AMOUNT, 
                    global::System.Nullable<decimal> Original_SPECIAL_OFFER_DISCOUNT, 
                    global::System.Nullable<decimal> Original_EXTRA_DISCOUNT, 
                    global::System.Nullable<decimal> Original_TOTAL_DISCOUNT, 
                    global::System.Nullable<decimal> Original_PAID_AMOUNT, 
                    global::System.Nullable<decimal> Original_REMAINING_AMOUNT, 
                    global::System.Nullable<bool> Original_IsPAID_FULL, 
                    global::System.Nullable<bool> Original_IsREFUNDED) {
            return this.Update(REFERENCE_TYPE, REFERENCE_CODE, BOOKING_ID_NO, BILL_DATE, TOTAL_ORIGNAL_AMOUNT, SPECIAL_OFFER_DISCOUNT, EXTRA_DISCOUNT, TOTAL_DISCOUNT, PAID_AMOUNT, REMAINING_AMOUNT, IsPAID_FULL, IsREFUNDED, Original_BILL_ID, Original_REFERENCE_TYPE, Original_REFERENCE_CODE, Original_BOOKING_ID_NO, Original_BILL_DATE, Original_TOTAL_ORIGNAL_AMOUNT, Original_SPECIAL_OFFER_DISCOUNT, Original_EXTRA_DISCOUNT, Original_TOTAL_DISCOUNT, Original_PAID_AMOUNT, Original_REMAINING_AMOUNT, Original_IsPAID_FULL, Original_IsREFUNDED, Original_BILL_ID);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual object ScalarQuery_Get_Last_Added_Bill_ID_Store_Procedure_Func() {
            global::System.Data.SqlClient.SqlCommand command = this.CommandCollection[2];
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return null;
            }
            else {
                return ((object)(returnValue));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, false)]
        public virtual int UpdateQuery_Bill_Status_IsRfunded_StoreProcedure_Func(global::System.Nullable<bool> IsREFUNDED, global::System.Nullable<long> Original_BOOKING_ID_NO) {
            global::System.Data.SqlClient.SqlCommand command = this.CommandCollection[3];
            if ((IsREFUNDED.HasValue == true)) {
                command.Parameters[1].Value = ((bool)(IsREFUNDED.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((Original_BOOKING_ID_NO.HasValue == true)) {
                command.Parameters[2].Value = ((long)(Original_BOOKING_ID_NO.Value));
            }
            else {
                command.Parameters[2].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            int returnValue;
            try {
                returnValue = command.ExecuteNonQuery();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int UpdateQuery_Remaining_amount_StoreProcedure_Func(global::System.Nullable<decimal> NewPaid_Amount, global::System.Nullable<decimal> NewRemaining_Amount, global::System.Nullable<bool> IspaidFull, global::System.Nullable<long> Orignal_Bill_ID) {
            global::System.Data.SqlClient.SqlCommand command = this.CommandCollection[4];
            if ((NewPaid_Amount.HasValue == true)) {
                command.Parameters[1].Value = ((decimal)(NewPaid_Amount.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((NewRemaining_Amount.HasValue == true)) {
                command.Parameters[2].Value = ((decimal)(NewRemaining_Amount.Value));
            }
            else {
                command.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((IspaidFull.HasValue == true)) {
                command.Parameters[3].Value = ((bool)(IspaidFull.Value));
            }
            else {
                command.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((Orignal_Bill_ID.HasValue == true)) {
                command.Parameters[4].Value = ((long)(Orignal_Bill_ID.Value));
            }
            else {
                command.Parameters[4].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            int returnValue;
            try {
                returnValue = command.ExecuteNonQuery();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
    }
    
    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class LedgerFromPayableTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;
        
        private global::System.Data.SqlClient.SqlConnection _connection;
        
        private global::System.Data.SqlClient.SqlTransaction _transaction;
        
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public LedgerFromPayableTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "LedgerFromPayable";
            tableMapping.ColumnMappings.Add("CUSTOMER_ID", "CUSTOMER_ID");
            tableMapping.ColumnMappings.Add("ID", "ID");
            tableMapping.ColumnMappings.Add("AGAINST", "AGAINST");
            tableMapping.ColumnMappings.Add("TOTALFACE", "TOTALFACE");
            tableMapping.ColumnMappings.Add("PAID", "PAID");
            this._adapter.TableMappings.Add(tableMapping);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::com_war_air.Properties.Settings.Default.Customers__And_AgentsConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "dbo.SelectQuery_CustomerLedgerFromPayable_StoreProcedure";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[0].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[0].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@OrignalCustomeriD", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[0].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@FalseIsRefended", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill_CustomerBookingsLedger(Bookings_And_payments_DataSet_appData.LedgerFromPayableDataTable dataTable, global::System.Nullable<long> OrignalCustomeriD, global::System.Nullable<bool> FalseIsRefended) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((OrignalCustomeriD.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[1].Value = ((long)(OrignalCustomeriD.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((FalseIsRefended.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[2].Value = ((bool)(FalseIsRefended.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual Bookings_And_payments_DataSet_appData.LedgerFromPayableDataTable GetData_CustomerBookingsLedger(global::System.Nullable<long> OrignalCustomeriD, global::System.Nullable<bool> FalseIsRefended) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((OrignalCustomeriD.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[1].Value = ((long)(OrignalCustomeriD.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((FalseIsRefended.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[2].Value = ((bool)(FalseIsRefended.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            Bookings_And_payments_DataSet_appData.LedgerFromPayableDataTable dataTable = new Bookings_And_payments_DataSet_appData.LedgerFromPayableDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
    }
    
    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class TransecTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;
        
        private global::System.Data.SqlClient.SqlConnection _connection;
        
        private global::System.Data.SqlClient.SqlTransaction _transaction;
        
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public TransecTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Transec";
            tableMapping.ColumnMappings.Add("ID", "ID");
            tableMapping.ColumnMappings.Add("CUSTOMER_ID", "CUSTOMER_ID");
            tableMapping.ColumnMappings.Add("DATE", "DATE");
            tableMapping.ColumnMappings.Add("ORIGNAL_RECIEVABLE", "ORIGNAL_RECIEVABLE");
            tableMapping.ColumnMappings.Add("T_RECIEVED", "T_RECIEVED");
            tableMapping.ColumnMappings.Add("REMAINING", "REMAINING");
            tableMapping.ColumnMappings.Add("SERVICE_NAME", "SERVICE_NAME");
            tableMapping.ColumnMappings.Add("STATUS", "STATUS");
            tableMapping.ColumnMappings.Add("SERVICE_ID", "SERVICE_ID");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM [Transec] WHERE (([ID] = @Original_ID) AND ((@IsNull_SERVICE_ID = 1 AND [SERVICE_ID] IS NULL) OR ([SERVICE_ID] = @Original_SERVICE_ID)) AND ((@IsNull_CUSTOMER_ID = 1 AND [CUSTOMER_ID] IS NULL) OR ([CUSTOMER_ID] = @Original_CUSTOMER_ID)) AND ((@IsNull_DATE = 1 AND [DATE] IS NULL) OR ([DATE] = @Original_DATE)) AND ((@IsNull_ORIGNAL_RECIEVABLE = 1 AND [ORIGNAL_RECIEVABLE] IS NULL) OR ([ORIGNAL_RECIEVABLE] = @Original_ORIGNAL_RECIEVABLE)) AND ((@IsNull_T_RECIEVED = 1 AND [T_RECIEVED] IS NULL) OR ([T_RECIEVED] = @Original_T_RECIEVED)) AND ((@IsNull_REMAINING = 1 AND [REMAINING] IS NULL) OR ([REMAINING] = @Original_REMAINING)) AND ((@IsNull_SERVICE_NAME = 1 AND [SERVICE_NAME] IS NULL) OR ([SERVICE_NAME] = @Original_SERVICE_NAME)) AND ((@IsNull_STATUS = 1 AND [STATUS] IS NULL) OR ([STATUS] = @Original_STATUS)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_SERVICE_ID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "SERVICE_ID", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_SERVICE_ID", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "SERVICE_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_CUSTOMER_ID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CUSTOMER_ID", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_CUSTOMER_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CUSTOMER_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_DATE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DATE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_DATE", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DATE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_ORIGNAL_RECIEVABLE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "ORIGNAL_RECIEVABLE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_ORIGNAL_RECIEVABLE", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "ORIGNAL_RECIEVABLE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_T_RECIEVED", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "T_RECIEVED", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_T_RECIEVED", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "T_RECIEVED", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_REMAINING", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REMAINING", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_REMAINING", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "REMAINING", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_SERVICE_NAME", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "SERVICE_NAME", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_SERVICE_NAME", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "SERVICE_NAME", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_STATUS", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "STATUS", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_STATUS", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "STATUS", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = @"INSERT INTO [Transec] ([SERVICE_ID], [CUSTOMER_ID], [DATE], [ORIGNAL_RECIEVABLE], [T_RECIEVED], [REMAINING], [SERVICE_NAME], [STATUS]) VALUES (@SERVICE_ID, @CUSTOMER_ID, @DATE, @ORIGNAL_RECIEVABLE, @T_RECIEVED, @REMAINING, @SERVICE_NAME, @STATUS);
SELECT ID, SERVICE_ID, CUSTOMER_ID, DATE, ORIGNAL_RECIEVABLE, T_RECIEVED, REMAINING, SERVICE_NAME, STATUS FROM Transec WHERE (ID = SCOPE_IDENTITY())";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@SERVICE_ID", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "SERVICE_ID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@CUSTOMER_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CUSTOMER_ID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DATE", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DATE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ORIGNAL_RECIEVABLE", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "ORIGNAL_RECIEVABLE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@T_RECIEVED", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "T_RECIEVED", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REMAINING", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "REMAINING", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@SERVICE_NAME", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "SERVICE_NAME", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@STATUS", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "STATUS", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE [Transec] SET [SERVICE_ID] = @SERVICE_ID, [CUSTOMER_ID] = @CUSTOMER_ID, [DATE] = @DATE, [ORIGNAL_RECIEVABLE] = @ORIGNAL_RECIEVABLE, [T_RECIEVED] = @T_RECIEVED, [REMAINING] = @REMAINING, [SERVICE_NAME] = @SERVICE_NAME, [STATUS] = @STATUS WHERE (([ID] = @Original_ID) AND ((@IsNull_SERVICE_ID = 1 AND [SERVICE_ID] IS NULL) OR ([SERVICE_ID] = @Original_SERVICE_ID)) AND ((@IsNull_CUSTOMER_ID = 1 AND [CUSTOMER_ID] IS NULL) OR ([CUSTOMER_ID] = @Original_CUSTOMER_ID)) AND ((@IsNull_DATE = 1 AND [DATE] IS NULL) OR ([DATE] = @Original_DATE)) AND ((@IsNull_ORIGNAL_RECIEVABLE = 1 AND [ORIGNAL_RECIEVABLE] IS NULL) OR ([ORIGNAL_RECIEVABLE] = @Original_ORIGNAL_RECIEVABLE)) AND ((@IsNull_T_RECIEVED = 1 AND [T_RECIEVED] IS NULL) OR ([T_RECIEVED] = @Original_T_RECIEVED)) AND ((@IsNull_REMAINING = 1 AND [REMAINING] IS NULL) OR ([REMAINING] = @Original_REMAINING)) AND ((@IsNull_SERVICE_NAME = 1 AND [SERVICE_NAME] IS NULL) OR ([SERVICE_NAME] = @Original_SERVICE_NAME)) AND ((@IsNull_STATUS = 1 AND [STATUS] IS NULL) OR ([STATUS] = @Original_STATUS)));
SELECT ID, SERVICE_ID, CUSTOMER_ID, DATE, ORIGNAL_RECIEVABLE, T_RECIEVED, REMAINING, SERVICE_NAME, STATUS FROM Transec WHERE (ID = @ID)";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@SERVICE_ID", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "SERVICE_ID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@CUSTOMER_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CUSTOMER_ID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DATE", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DATE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ORIGNAL_RECIEVABLE", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "ORIGNAL_RECIEVABLE", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@T_RECIEVED", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "T_RECIEVED", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@REMAINING", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "REMAINING", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@SERVICE_NAME", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "SERVICE_NAME", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@STATUS", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "STATUS", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_SERVICE_ID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "SERVICE_ID", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_SERVICE_ID", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "SERVICE_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_CUSTOMER_ID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CUSTOMER_ID", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_CUSTOMER_ID", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CUSTOMER_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_DATE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DATE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_DATE", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DATE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_ORIGNAL_RECIEVABLE", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "ORIGNAL_RECIEVABLE", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_ORIGNAL_RECIEVABLE", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "ORIGNAL_RECIEVABLE", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_T_RECIEVED", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "T_RECIEVED", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_T_RECIEVED", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "T_RECIEVED", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_REMAINING", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "REMAINING", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_REMAINING", global::System.Data.SqlDbType.Decimal, 0, global::System.Data.ParameterDirection.Input, 18, 0, "REMAINING", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_SERVICE_NAME", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "SERVICE_NAME", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_SERVICE_NAME", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "SERVICE_NAME", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_STATUS", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "STATUS", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_STATUS", global::System.Data.SqlDbType.Bit, 0, global::System.Data.ParameterDirection.Input, 0, 0, "STATUS", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ID", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 0, 0, "ID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::com_war_air.Properties.Settings.Default.Customers__And_AgentsConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[9];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT ID, SERVICE_ID, CUSTOMER_ID, DATE, ORIGNAL_RECIEVABLE, T_RECIEVED, REMAINI" +
                "NG, SERVICE_NAME, STATUS FROM Transec";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[1] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[1].Connection = this.Connection;
            this._commandCollection[1].CommandText = "dbo.SelectQuery_TransecRow_StoreProcedure";
            this._commandCollection[1].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@OriginalService_ID", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[2].Connection = this.Connection;
            this._commandCollection[2].CommandText = "dbo.SelectQuery_TransecForLedgCustomer_StoreProcedure";
            this._commandCollection[2].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@OrgnalCustomerid", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@OrignalStatusDefTrue", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[3].Connection = this.Connection;
            this._commandCollection[3].CommandText = "dbo.SelectQuery_TransecForLedgAgent_StoreProcedure";
            this._commandCollection[3].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@OrgnalAgentid", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@OrignalStatusDefTrue", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsRefferedbyTRUEDef", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[4].Connection = this.Connection;
            this._commandCollection[4].CommandText = "dbo.ScalarQuery_TransecAgent_T_ReceivedSum_StoreProcedure";
            this._commandCollection[4].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@OrignalAgentid", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[5].Connection = this.Connection;
            this._commandCollection[5].CommandText = "dbo.ScalarQuery_TransecAgentRecieveableTotal_StoreProcedure";
            this._commandCollection[5].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@OrignalAgentID", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[6] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[6].Connection = this.Connection;
            this._commandCollection[6].CommandText = "dbo.ScalarQuery_TransecRecieveableTotal_StoreProcedure";
            this._commandCollection[6].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[6].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[6].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@OrignalCustomerID", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[7] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[7].Connection = this.Connection;
            this._commandCollection[7].CommandText = "dbo.ScalarQuery_TransecT_ReceivedSum_StoreProcedure";
            this._commandCollection[7].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[7].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[7].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@OrignalCustomerid", global::System.Data.SqlDbType.BigInt, 8, global::System.Data.ParameterDirection.Input, 19, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[8].Connection = this.Connection;
            this._commandCollection[8].CommandText = "dbo.UpdateQuery_Transec_Status_by_ServiceID_StoreProcedure";
            this._commandCollection[8].CommandType = global::System.Data.CommandType.StoredProcedure;
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@STATUS", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_ServiceID", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(Bookings_And_payments_DataSet_appData.TransecDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual Bookings_And_payments_DataSet_appData.TransecDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            Bookings_And_payments_DataSet_appData.TransecDataTable dataTable = new Bookings_And_payments_DataSet_appData.TransecDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, false)]
        public virtual int FillBy_Transec_RowByServiceID(Bookings_And_payments_DataSet_appData.TransecDataTable dataTable, string OriginalService_ID) {
            this.Adapter.SelectCommand = this.CommandCollection[1];
            if ((OriginalService_ID == null)) {
                this.Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.SelectCommand.Parameters[1].Value = ((string)(OriginalService_ID));
            }
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, false)]
        public virtual Bookings_And_payments_DataSet_appData.TransecDataTable GetDataBy_Transec_RowByServiceID(string OriginalService_ID) {
            this.Adapter.SelectCommand = this.CommandCollection[1];
            if ((OriginalService_ID == null)) {
                this.Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.SelectCommand.Parameters[1].Value = ((string)(OriginalService_ID));
            }
            Bookings_And_payments_DataSet_appData.TransecDataTable dataTable = new Bookings_And_payments_DataSet_appData.TransecDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, false)]
        public virtual int FillBy_TransecForLedgCustomer_StoreProcedure(Bookings_And_payments_DataSet_appData.TransecDataTable dataTable, global::System.Nullable<long> OrgnalCustomerid, global::System.Nullable<bool> OrignalStatusDefTrue) {
            this.Adapter.SelectCommand = this.CommandCollection[2];
            if ((OrgnalCustomerid.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[1].Value = ((long)(OrgnalCustomerid.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((OrignalStatusDefTrue.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[2].Value = ((bool)(OrignalStatusDefTrue.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, false)]
        public virtual Bookings_And_payments_DataSet_appData.TransecDataTable GetDataBy_TransecForLedgCustomer_StoreProcedure(global::System.Nullable<long> OrgnalCustomerid, global::System.Nullable<bool> OrignalStatusDefTrue) {
            this.Adapter.SelectCommand = this.CommandCollection[2];
            if ((OrgnalCustomerid.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[1].Value = ((long)(OrgnalCustomerid.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((OrignalStatusDefTrue.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[2].Value = ((bool)(OrignalStatusDefTrue.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            Bookings_And_payments_DataSet_appData.TransecDataTable dataTable = new Bookings_And_payments_DataSet_appData.TransecDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, false)]
        public virtual int FillByFillBy_TransecForLedgAgent_StoreProcedure(Bookings_And_payments_DataSet_appData.TransecDataTable dataTable, global::System.Nullable<long> OrgnalAgentid, global::System.Nullable<bool> OrignalStatusDefTrue, global::System.Nullable<bool> IsRefferedbyTRUEDef) {
            this.Adapter.SelectCommand = this.CommandCollection[3];
            if ((OrgnalAgentid.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[1].Value = ((long)(OrgnalAgentid.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((OrignalStatusDefTrue.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[2].Value = ((bool)(OrignalStatusDefTrue.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((IsRefferedbyTRUEDef.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[3].Value = ((bool)(IsRefferedbyTRUEDef.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, false)]
        public virtual Bookings_And_payments_DataSet_appData.TransecDataTable GetDataBy_TransecForLedgAgent_StoreProcedure(global::System.Nullable<long> OrgnalAgentid, global::System.Nullable<bool> OrignalStatusDefTrue, global::System.Nullable<bool> IsRefferedbyTRUEDef) {
            this.Adapter.SelectCommand = this.CommandCollection[3];
            if ((OrgnalAgentid.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[1].Value = ((long)(OrgnalAgentid.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((OrignalStatusDefTrue.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[2].Value = ((bool)(OrignalStatusDefTrue.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((IsRefferedbyTRUEDef.HasValue == true)) {
                this.Adapter.SelectCommand.Parameters[3].Value = ((bool)(IsRefferedbyTRUEDef.Value));
            }
            else {
                this.Adapter.SelectCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            Bookings_And_payments_DataSet_appData.TransecDataTable dataTable = new Bookings_And_payments_DataSet_appData.TransecDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(Bookings_And_payments_DataSet_appData.TransecDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(Bookings_And_payments_DataSet_appData dataSet) {
            return this.Adapter.Update(dataSet, "Transec");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(long Original_ID, string Original_SERVICE_ID, global::System.Nullable<long> Original_CUSTOMER_ID, global::System.Nullable<global::System.DateTime> Original_DATE, global::System.Nullable<decimal> Original_ORIGNAL_RECIEVABLE, global::System.Nullable<decimal> Original_T_RECIEVED, global::System.Nullable<decimal> Original_REMAINING, string Original_SERVICE_NAME, global::System.Nullable<bool> Original_STATUS) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((long)(Original_ID));
            if ((Original_SERVICE_ID == null)) {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((string)(Original_SERVICE_ID));
            }
            if ((Original_CUSTOMER_ID.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((long)(Original_CUSTOMER_ID.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Original_DATE.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[6].Value = ((System.DateTime)(Original_DATE.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Original_ORIGNAL_RECIEVABLE.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[8].Value = ((decimal)(Original_ORIGNAL_RECIEVABLE.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((Original_T_RECIEVED.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[10].Value = ((decimal)(Original_T_RECIEVED.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((Original_REMAINING.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[12].Value = ((decimal)(Original_REMAINING.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            if ((Original_SERVICE_NAME == null)) {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[14].Value = ((string)(Original_SERVICE_NAME));
            }
            if ((Original_STATUS.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[15].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[16].Value = ((bool)(Original_STATUS.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[15].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[16].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string SERVICE_ID, global::System.Nullable<long> CUSTOMER_ID, global::System.Nullable<global::System.DateTime> DATE, global::System.Nullable<decimal> ORIGNAL_RECIEVABLE, global::System.Nullable<decimal> T_RECIEVED, global::System.Nullable<decimal> REMAINING, string SERVICE_NAME, global::System.Nullable<bool> STATUS) {
            if ((SERVICE_ID == null)) {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(SERVICE_ID));
            }
            if ((CUSTOMER_ID.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[1].Value = ((long)(CUSTOMER_ID.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((DATE.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[2].Value = ((System.DateTime)(DATE.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((ORIGNAL_RECIEVABLE.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[3].Value = ((decimal)(ORIGNAL_RECIEVABLE.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((T_RECIEVED.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[4].Value = ((decimal)(T_RECIEVED.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((REMAINING.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[5].Value = ((decimal)(REMAINING.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((SERVICE_NAME == null)) {
                this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[6].Value = ((string)(SERVICE_NAME));
            }
            if ((STATUS.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[7].Value = ((bool)(STATUS.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    string SERVICE_ID, 
                    global::System.Nullable<long> CUSTOMER_ID, 
                    global::System.Nullable<global::System.DateTime> DATE, 
                    global::System.Nullable<decimal> ORIGNAL_RECIEVABLE, 
                    global::System.Nullable<decimal> T_RECIEVED, 
                    global::System.Nullable<decimal> REMAINING, 
                    string SERVICE_NAME, 
                    global::System.Nullable<bool> STATUS, 
                    long Original_ID, 
                    string Original_SERVICE_ID, 
                    global::System.Nullable<long> Original_CUSTOMER_ID, 
                    global::System.Nullable<global::System.DateTime> Original_DATE, 
                    global::System.Nullable<decimal> Original_ORIGNAL_RECIEVABLE, 
                    global::System.Nullable<decimal> Original_T_RECIEVED, 
                    global::System.Nullable<decimal> Original_REMAINING, 
                    string Original_SERVICE_NAME, 
                    global::System.Nullable<bool> Original_STATUS, 
                    long ID) {
            if ((SERVICE_ID == null)) {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(SERVICE_ID));
            }
            if ((CUSTOMER_ID.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((long)(CUSTOMER_ID.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((DATE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((System.DateTime)(DATE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((ORIGNAL_RECIEVABLE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((decimal)(ORIGNAL_RECIEVABLE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((T_RECIEVED.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((decimal)(T_RECIEVED.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((REMAINING.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((decimal)(REMAINING.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((SERVICE_NAME == null)) {
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((string)(SERVICE_NAME));
            }
            if ((STATUS.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[7].Value = ((bool)(STATUS.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[8].Value = ((long)(Original_ID));
            if ((Original_SERVICE_ID == null)) {
                this.Adapter.UpdateCommand.Parameters[9].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[10].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[9].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[10].Value = ((string)(Original_SERVICE_ID));
            }
            if ((Original_CUSTOMER_ID.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[12].Value = ((long)(Original_CUSTOMER_ID.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            if ((Original_DATE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[14].Value = ((System.DateTime)(Original_DATE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            if ((Original_ORIGNAL_RECIEVABLE.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[15].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[16].Value = ((decimal)(Original_ORIGNAL_RECIEVABLE.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[15].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[16].Value = global::System.DBNull.Value;
            }
            if ((Original_T_RECIEVED.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[17].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[18].Value = ((decimal)(Original_T_RECIEVED.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[17].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[18].Value = global::System.DBNull.Value;
            }
            if ((Original_REMAINING.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[19].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[20].Value = ((decimal)(Original_REMAINING.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[19].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[20].Value = global::System.DBNull.Value;
            }
            if ((Original_SERVICE_NAME == null)) {
                this.Adapter.UpdateCommand.Parameters[21].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[22].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[21].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[22].Value = ((string)(Original_SERVICE_NAME));
            }
            if ((Original_STATUS.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[23].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[24].Value = ((bool)(Original_STATUS.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[23].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[24].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[25].Value = ((long)(ID));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    string SERVICE_ID, 
                    global::System.Nullable<long> CUSTOMER_ID, 
                    global::System.Nullable<global::System.DateTime> DATE, 
                    global::System.Nullable<decimal> ORIGNAL_RECIEVABLE, 
                    global::System.Nullable<decimal> T_RECIEVED, 
                    global::System.Nullable<decimal> REMAINING, 
                    string SERVICE_NAME, 
                    global::System.Nullable<bool> STATUS, 
                    long Original_ID, 
                    string Original_SERVICE_ID, 
                    global::System.Nullable<long> Original_CUSTOMER_ID, 
                    global::System.Nullable<global::System.DateTime> Original_DATE, 
                    global::System.Nullable<decimal> Original_ORIGNAL_RECIEVABLE, 
                    global::System.Nullable<decimal> Original_T_RECIEVED, 
                    global::System.Nullable<decimal> Original_REMAINING, 
                    string Original_SERVICE_NAME, 
                    global::System.Nullable<bool> Original_STATUS) {
            return this.Update(SERVICE_ID, CUSTOMER_ID, DATE, ORIGNAL_RECIEVABLE, T_RECIEVED, REMAINING, SERVICE_NAME, STATUS, Original_ID, Original_SERVICE_ID, Original_CUSTOMER_ID, Original_DATE, Original_ORIGNAL_RECIEVABLE, Original_T_RECIEVED, Original_REMAINING, Original_SERVICE_NAME, Original_STATUS, Original_ID);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual object ScalarQuery_TransecAgent_T_ReceivedSum_StoreProcedure_Func(global::System.Nullable<long> OrignalAgentid) {
            global::System.Data.SqlClient.SqlCommand command = this.CommandCollection[4];
            if ((OrignalAgentid.HasValue == true)) {
                command.Parameters[1].Value = ((long)(OrignalAgentid.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return null;
            }
            else {
                return ((object)(returnValue));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual object ScalarQuery_TransecAgentRecieveableTotal_StoreProcedure_Func(global::System.Nullable<long> OrignalAgentID) {
            global::System.Data.SqlClient.SqlCommand command = this.CommandCollection[5];
            if ((OrignalAgentID.HasValue == true)) {
                command.Parameters[1].Value = ((long)(OrignalAgentID.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return null;
            }
            else {
                return ((object)(returnValue));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual object ScalarQuery_TransecRecieveableTotal_StoreProcedure_Func(global::System.Nullable<long> OrignalCustomerID) {
            global::System.Data.SqlClient.SqlCommand command = this.CommandCollection[6];
            if ((OrignalCustomerID.HasValue == true)) {
                command.Parameters[1].Value = ((long)(OrignalCustomerID.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return null;
            }
            else {
                return ((object)(returnValue));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual object ScalarQuery_TransecT_ReceivedSum_StoreProcedure_Func(global::System.Nullable<long> OrignalCustomerid) {
            global::System.Data.SqlClient.SqlCommand command = this.CommandCollection[7];
            if ((OrignalCustomerid.HasValue == true)) {
                command.Parameters[1].Value = ((long)(OrignalCustomerid.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return null;
            }
            else {
                return ((object)(returnValue));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, false)]
        public virtual int UpdateQuery_Transec_Status_by_ServiceID_StoreProcedure_Func(global::System.Nullable<bool> STATUS, string Original_ServiceID) {
            global::System.Data.SqlClient.SqlCommand command = this.CommandCollection[8];
            if ((STATUS.HasValue == true)) {
                command.Parameters[1].Value = ((bool)(STATUS.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((Original_ServiceID == null)) {
                command.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                command.Parameters[2].Value = ((string)(Original_ServiceID));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            int returnValue;
            try {
                returnValue = command.ExecuteNonQuery();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
    }
    
    /// <summary>
    ///
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSD" +
        "esigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapterManager")]
    public partial class TableAdapterManager : global::System.ComponentModel.Component {
        
        private UpdateOrderOption _updateOrder;
        
        private PayableToCompanyTableAdapter _payableToCompanyTableAdapter;
        
        private BookingsTableAdapter _bookingsTableAdapter;
        
        private BillsTableAdapter _billsTableAdapter;
        
        private TransecTableAdapter _transecTableAdapter;
        
        private bool _backupDataSetBeforeUpdate;
        
        private global::System.Data.IDbConnection _connection;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public UpdateOrderOption UpdateOrder {
            get {
                return this._updateOrder;
            }
            set {
                this._updateOrder = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public PayableToCompanyTableAdapter PayableToCompanyTableAdapter {
            get {
                return this._payableToCompanyTableAdapter;
            }
            set {
                this._payableToCompanyTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public BookingsTableAdapter BookingsTableAdapter {
            get {
                return this._bookingsTableAdapter;
            }
            set {
                this._bookingsTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public BillsTableAdapter BillsTableAdapter {
            get {
                return this._billsTableAdapter;
            }
            set {
                this._billsTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public TransecTableAdapter TransecTableAdapter {
            get {
                return this._transecTableAdapter;
            }
            set {
                this._transecTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public bool BackupDataSetBeforeUpdate {
            get {
                return this._backupDataSetBeforeUpdate;
            }
            set {
                this._backupDataSetBeforeUpdate = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public global::System.Data.IDbConnection Connection {
            get {
                if ((this._connection != null)) {
                    return this._connection;
                }
                if (((this._payableToCompanyTableAdapter != null) 
                            && (this._payableToCompanyTableAdapter.Connection != null))) {
                    return this._payableToCompanyTableAdapter.Connection;
                }
                if (((this._bookingsTableAdapter != null) 
                            && (this._bookingsTableAdapter.Connection != null))) {
                    return this._bookingsTableAdapter.Connection;
                }
                if (((this._billsTableAdapter != null) 
                            && (this._billsTableAdapter.Connection != null))) {
                    return this._billsTableAdapter.Connection;
                }
                if (((this._transecTableAdapter != null) 
                            && (this._transecTableAdapter.Connection != null))) {
                    return this._transecTableAdapter.Connection;
                }
                return null;
            }
            set {
                this._connection = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public int TableAdapterInstanceCount {
            get {
                int count = 0;
                if ((this._payableToCompanyTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._bookingsTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._billsTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._transecTableAdapter != null)) {
                    count = (count + 1);
                }
                return count;
            }
        }
        
        /// <summary>
        ///Update rows in top-down order.
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private int UpdateUpdatedRows(Bookings_And_payments_DataSet_appData dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            int result = 0;
            if ((this._payableToCompanyTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.PayableToCompany.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._payableToCompanyTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._bookingsTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.Bookings.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._bookingsTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._billsTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.Bills.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._billsTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._transecTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.Transec.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._transecTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            return result;
        }
        
        /// <summary>
        ///Insert rows in top-down order.
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private int UpdateInsertedRows(Bookings_And_payments_DataSet_appData dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            int result = 0;
            if ((this._payableToCompanyTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.PayableToCompany.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._payableToCompanyTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._bookingsTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.Bookings.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._bookingsTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._billsTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.Bills.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._billsTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._transecTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.Transec.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._transecTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            return result;
        }
        
        /// <summary>
        ///Delete rows in bottom-up order.
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private int UpdateDeletedRows(Bookings_And_payments_DataSet_appData dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows) {
            int result = 0;
            if ((this._transecTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.Transec.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._transecTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._billsTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.Bills.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._billsTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._bookingsTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.Bookings.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._bookingsTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._payableToCompanyTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.PayableToCompany.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._payableToCompanyTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            return result;
        }
        
        /// <summary>
        ///Remove inserted rows that become updated rows after calling TableAdapter.Update(inserted rows) first
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private global::System.Data.DataRow[] GetRealUpdatedRows(global::System.Data.DataRow[] updatedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            if (((updatedRows == null) 
                        || (updatedRows.Length < 1))) {
                return updatedRows;
            }
            if (((allAddedRows == null) 
                        || (allAddedRows.Count < 1))) {
                return updatedRows;
            }
            global::System.Collections.Generic.List<global::System.Data.DataRow> realUpdatedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            for (int i = 0; (i < updatedRows.Length); i = (i + 1)) {
                global::System.Data.DataRow row = updatedRows[i];
                if ((allAddedRows.Contains(row) == false)) {
                    realUpdatedRows.Add(row);
                }
            }
            return realUpdatedRows.ToArray();
        }
        
        /// <summary>
        ///Update all changes to the dataset.
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public virtual int UpdateAll(Bookings_And_payments_DataSet_appData dataSet) {
            if ((dataSet == null)) {
                throw new global::System.ArgumentNullException("dataSet");
            }
            if ((dataSet.HasChanges() == false)) {
                return 0;
            }
            if (((this._payableToCompanyTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._payableToCompanyTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._bookingsTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._bookingsTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._billsTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._billsTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._transecTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._transecTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            global::System.Data.IDbConnection workConnection = this.Connection;
            if ((workConnection == null)) {
                throw new global::System.ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterMana" +
                        "ger TableAdapter property to a valid TableAdapter instance.");
            }
            bool workConnOpened = false;
            if (((workConnection.State & global::System.Data.ConnectionState.Broken) 
                        == global::System.Data.ConnectionState.Broken)) {
                workConnection.Close();
            }
            if ((workConnection.State == global::System.Data.ConnectionState.Closed)) {
                workConnection.Open();
                workConnOpened = true;
            }
            global::System.Data.IDbTransaction workTransaction = workConnection.BeginTransaction();
            if ((workTransaction == null)) {
                throw new global::System.ApplicationException("The transaction cannot begin. The current data connection does not support transa" +
                        "ctions or the current state is not allowing the transaction to begin.");
            }
            global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter> adaptersWithAcceptChangesDuringUpdate = new global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter>();
            global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection> revertConnections = new global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection>();
            int result = 0;
            global::System.Data.DataSet backupDataSet = null;
            if (this.BackupDataSetBeforeUpdate) {
                backupDataSet = new global::System.Data.DataSet();
                backupDataSet.Merge(dataSet);
            }
            try {
                // ---- Prepare for update -----------
                //
                if ((this._payableToCompanyTableAdapter != null)) {
                    revertConnections.Add(this._payableToCompanyTableAdapter, this._payableToCompanyTableAdapter.Connection);
                    this._payableToCompanyTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                    this._payableToCompanyTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                    if (this._payableToCompanyTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._payableToCompanyTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._payableToCompanyTableAdapter.Adapter);
                    }
                }
                if ((this._bookingsTableAdapter != null)) {
                    revertConnections.Add(this._bookingsTableAdapter, this._bookingsTableAdapter.Connection);
                    this._bookingsTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                    this._bookingsTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                    if (this._bookingsTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._bookingsTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._bookingsTableAdapter.Adapter);
                    }
                }
                if ((this._billsTableAdapter != null)) {
                    revertConnections.Add(this._billsTableAdapter, this._billsTableAdapter.Connection);
                    this._billsTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                    this._billsTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                    if (this._billsTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._billsTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._billsTableAdapter.Adapter);
                    }
                }
                if ((this._transecTableAdapter != null)) {
                    revertConnections.Add(this._transecTableAdapter, this._transecTableAdapter.Connection);
                    this._transecTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                    this._transecTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                    if (this._transecTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._transecTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._transecTableAdapter.Adapter);
                    }
                }
                // 
                //---- Perform updates -----------
                //
                if ((this.UpdateOrder == UpdateOrderOption.UpdateInsertDelete)) {
                    result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                    result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                }
                else {
                    result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                    result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                }
                result = (result + this.UpdateDeletedRows(dataSet, allChangedRows));
                // 
                //---- Commit updates -----------
                //
                workTransaction.Commit();
                if ((0 < allAddedRows.Count)) {
                    global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                    allAddedRows.CopyTo(rows);
                    for (int i = 0; (i < rows.Length); i = (i + 1)) {
                        global::System.Data.DataRow row = rows[i];
                        row.AcceptChanges();
                    }
                }
                if ((0 < allChangedRows.Count)) {
                    global::System.Data.DataRow[] rows = new System.Data.DataRow[allChangedRows.Count];
                    allChangedRows.CopyTo(rows);
                    for (int i = 0; (i < rows.Length); i = (i + 1)) {
                        global::System.Data.DataRow row = rows[i];
                        row.AcceptChanges();
                    }
                }
            }
            catch (global::System.Exception ex) {
                workTransaction.Rollback();
                // ---- Restore the dataset -----------
                if (this.BackupDataSetBeforeUpdate) {
                    global::System.Diagnostics.Debug.Assert((backupDataSet != null));
                    dataSet.Clear();
                    dataSet.Merge(backupDataSet);
                }
                else {
                    if ((0 < allAddedRows.Count)) {
                        global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                        allAddedRows.CopyTo(rows);
                        for (int i = 0; (i < rows.Length); i = (i + 1)) {
                            global::System.Data.DataRow row = rows[i];
                            row.AcceptChanges();
                            row.SetAdded();
                        }
                    }
                }
                throw ex;
            }
            finally {
                if (workConnOpened) {
                    workConnection.Close();
                }
                if ((this._payableToCompanyTableAdapter != null)) {
                    this._payableToCompanyTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._payableToCompanyTableAdapter]));
                    this._payableToCompanyTableAdapter.Transaction = null;
                }
                if ((this._bookingsTableAdapter != null)) {
                    this._bookingsTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._bookingsTableAdapter]));
                    this._bookingsTableAdapter.Transaction = null;
                }
                if ((this._billsTableAdapter != null)) {
                    this._billsTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._billsTableAdapter]));
                    this._billsTableAdapter.Transaction = null;
                }
                if ((this._transecTableAdapter != null)) {
                    this._transecTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._transecTableAdapter]));
                    this._transecTableAdapter.Transaction = null;
                }
                if ((0 < adaptersWithAcceptChangesDuringUpdate.Count)) {
                    global::System.Data.Common.DataAdapter[] adapters = new System.Data.Common.DataAdapter[adaptersWithAcceptChangesDuringUpdate.Count];
                    adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters);
                    for (int i = 0; (i < adapters.Length); i = (i + 1)) {
                        global::System.Data.Common.DataAdapter adapter = adapters[i];
                        adapter.AcceptChangesDuringUpdate = true;
                    }
                }
            }
            return result;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected virtual void SortSelfReferenceRows(global::System.Data.DataRow[] rows, global::System.Data.DataRelation relation, bool childFirst) {
            global::System.Array.Sort<global::System.Data.DataRow>(rows, new SelfReferenceComparer(relation, childFirst));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected virtual bool MatchTableAdapterConnection(global::System.Data.IDbConnection inputConnection) {
            if ((this._connection != null)) {
                return true;
            }
            if (((this.Connection == null) 
                        || (inputConnection == null))) {
                return true;
            }
            if (string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, global::System.StringComparison.Ordinal)) {
                return true;
            }
            return false;
        }
        
        /// <summary>
        ///Update Order Option
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public enum UpdateOrderOption {
            
            InsertUpdateDelete = 0,
            
            UpdateInsertDelete = 1,
        }
        
        /// <summary>
        ///Used to sort self-referenced table's rows
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private class SelfReferenceComparer : object, global::System.Collections.Generic.IComparer<global::System.Data.DataRow> {
            
            private global::System.Data.DataRelation _relation;
            
            private int _childFirst;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal SelfReferenceComparer(global::System.Data.DataRelation relation, bool childFirst) {
                this._relation = relation;
                if (childFirst) {
                    this._childFirst = -1;
                }
                else {
                    this._childFirst = 1;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            private global::System.Data.DataRow GetRoot(global::System.Data.DataRow row, out int distance) {
                global::System.Diagnostics.Debug.Assert((row != null));
                global::System.Data.DataRow root = row;
                distance = 0;

                global::System.Collections.Generic.IDictionary<global::System.Data.DataRow, global::System.Data.DataRow> traversedRows = new global::System.Collections.Generic.Dictionary<global::System.Data.DataRow, global::System.Data.DataRow>();
                traversedRows[row] = row;

                global::System.Data.DataRow parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                for (
                ; ((parent != null) 
                            && (traversedRows.ContainsKey(parent) == false)); 
                ) {
                    distance = (distance + 1);
                    root = parent;
                    traversedRows[parent] = parent;
                    parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                }

                if ((distance == 0)) {
                    traversedRows.Clear();
                    traversedRows[row] = row;
                    parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                    for (
                    ; ((parent != null) 
                                && (traversedRows.ContainsKey(parent) == false)); 
                    ) {
                        distance = (distance + 1);
                        root = parent;
                        traversedRows[parent] = parent;
                        parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                    }
                }

                return root;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public int Compare(global::System.Data.DataRow row1, global::System.Data.DataRow row2) {
                if (object.ReferenceEquals(row1, row2)) {
                    return 0;
                }
                if ((row1 == null)) {
                    return -1;
                }
                if ((row2 == null)) {
                    return 1;
                }

                int distance1 = 0;
                global::System.Data.DataRow root1 = this.GetRoot(row1, out distance1);

                int distance2 = 0;
                global::System.Data.DataRow root2 = this.GetRoot(row2, out distance2);

                if (object.ReferenceEquals(root1, root2)) {
                    return (this._childFirst * distance1.CompareTo(distance2));
                }
                else {
                    global::System.Diagnostics.Debug.Assert(((root1.Table != null) 
                                    && (root2.Table != null)));
                    if ((root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2))) {
                        return -1;
                    }
                    else {
                        return 1;
                    }
                }
            }
        }
    }
}

#pragma warning restore 1591