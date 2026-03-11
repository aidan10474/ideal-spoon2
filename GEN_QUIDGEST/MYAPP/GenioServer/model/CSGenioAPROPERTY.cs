
 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using CSGenio.framework;
using CSGenio.persistence;
using Quidgest.Persistence;
using Quidgest.Persistence.GenericQuery;
using System.Linq;

namespace CSGenio.business
{
	/// <summary>
	/// Property
	/// </summary>
	public class CSGenioAproperty : DbArea
	{
		/// <summary>
		/// Meta-information on this area
		/// </summary>
		protected readonly static AreaInfo informacao = InicializaAreaInfo();

		public CSGenioAproperty(User user, string module)
		{
            this.user = user;
            this.module = module;
			// USE /[MANUAL TRA CONSTRUTOR PROPERTY]/
		}

		public CSGenioAproperty(User user) : this(user, user.CurrentModule)
		{
		}

		/// <summary>
		/// Initializes the metadata relative to the fields of this area
		/// </summary>
		private static void InicializaCampos(AreaInfo info)
		{
			Field Qfield = null;
#pragma warning disable CS0168, S1481 // Variable is declared but never used
			List<ByAreaArguments> argumentsListByArea;
#pragma warning restore CS0168, S1481 // Variable is declared but never used
			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "codproperty", FieldType.KEY_INT);
			Qfield.FieldDescription = "Property";
			Qfield.FieldSize =  8;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "PROPERTY43977";

			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "codagent", FieldType.KEY_INT);
			Qfield.FieldDescription = "Agent";
			Qfield.FieldSize =  8;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "AGENT00994";

			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "codcity", FieldType.KEY_INT);
			Qfield.FieldDescription = "City";
			Qfield.FieldSize =  8;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "CITY42505";

			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "main_photo", FieldType.IMAGE);
			Qfield.FieldDescription = "Main Photo";
			Qfield.FieldSize =  3;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "MAIN_PHOTO18723";

			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "title", FieldType.TEXT);
			Qfield.FieldDescription = "Title";
			Qfield.FieldSize =  80;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "TITLE21885";

            Qfield.NotNull = true;
			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "price", FieldType.CURRENCY);
			Qfield.FieldDescription = "Price 0000000000,00";
			Qfield.FieldSize =  15;
			Qfield.MQueue = false;
			Qfield.IntegerDigits = 10;
			Qfield.Decimals = 4;
			Qfield.CavDesignation = "PRICE_0000000000_0058065";

			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "size", FieldType.TEXT);
			Qfield.FieldDescription = "Size";
			Qfield.FieldSize =  50;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "SIZE10299";

			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "bathroom_number", FieldType.TEXT);
			Qfield.FieldDescription = "Bathrooms";
			Qfield.FieldSize =  50;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "BATHROOMS54249";

			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "date_construction", FieldType.DATE);
			Qfield.FieldDescription = "Date";
			Qfield.FieldSize =  8;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "DATE18475";

			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "description", FieldType.TEXT);
			Qfield.FieldDescription = "Description";
			Qfield.FieldSize =  50;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "DESCRIPTION07383";

			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "buildingtype", FieldType.ARRAY_TEXT);
			Qfield.FieldDescription = "Building type";
			Qfield.FieldSize =  1;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "BUILDING_TYPE57152";

			Qfield.Dupmsg = "";
            Qfield.ArrayName = "dbo.GetValArrayCbuildingtype";
            Qfield.ArrayClassName = "Buildingtype";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "typology", FieldType.ARRAY_NUMERIC);
			Qfield.FieldDescription = "Typology";
			Qfield.FieldSize =  1;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "TYPOLOGY11991";

			Qfield.Dupmsg = "";
			Qfield.ArrayName = "dbo.GetValArrayNtypology";
            Qfield.ArrayClassName = "Typology";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "id", FieldType.NUMERIC);
			Qfield.FieldDescription = "ID";
			Qfield.FieldSize =  10;
			Qfield.MQueue = false;
			Qfield.IntegerDigits = 10;
			Qfield.CavDesignation = "ID48520";

			Qfield.Dupmsg = "";
			Qfield.DefaultValue = new DefaultValue(DefaultValue.getGreaterPlus1_int, "id");
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "buildingage", FieldType.NUMERIC);
			Qfield.FieldDescription = "Building age";
			Qfield.FieldSize =  10;
			Qfield.MQueue = false;
			Qfield.IntegerDigits = 10;
			Qfield.CavDesignation = "BUILDING_AGE27311";

			Qfield.Dupmsg = "";
			argumentsListByArea = new List<ByAreaArguments>();
			argumentsListByArea.Add(new ByAreaArguments(new string[] {"date_construction"}, new int[] {0}, "property", "codproperty"));
			Qfield.Formula = new InternalOperationFormula(argumentsListByArea, 1, delegate(object[] args, User user, string module, PersistentSupport sp) {
				return GenFunctions.Year(DateTime.Today)-GenFunctions.Year(((DateTime)args[0]));
			});
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "groundsize", FieldType.NUMERIC);
			Qfield.FieldDescription = "Ground size";
			Qfield.FieldSize =  6;
			Qfield.MQueue = false;
			Qfield.IntegerDigits = 6;
			Qfield.CavDesignation = "GROUND_SIZE01563";

			Qfield.Dupmsg = "";
			argumentsListByArea = new List<ByAreaArguments>();
			argumentsListByArea.Add(new ByAreaArguments(new string[] {"buildingtype"}, new int[] {0}, "property", "codproperty"));
			Qfield.ShowWhen = new ConditionFormula(argumentsListByArea, 1, delegate(object[] args, User user, string module, PersistentSupport sp) {
				return ((string)args[0])=="H";
			});
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "floornumber", FieldType.NUMERIC);
			Qfield.FieldDescription = "Floor number";
			Qfield.FieldSize =  3;
			Qfield.MQueue = false;
			Qfield.IntegerDigits = 3;
			Qfield.CavDesignation = "FLOOR_NUMBER26169";

			Qfield.Dupmsg = "";
			argumentsListByArea = new List<ByAreaArguments>();
			argumentsListByArea.Add(new ByAreaArguments(new string[] {"buildingtype"}, new int[] {0}, "property", "codproperty"));
			Qfield.ShowWhen = new ConditionFormula(argumentsListByArea, 1, delegate(object[] args, User user, string module, PersistentSupport sp) {
				return ((string)args[0])=="A";
			});
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "sold", FieldType.LOGIC);
			Qfield.FieldDescription = "Sold";
			Qfield.FieldSize =  1;
			Qfield.MQueue = false;
			Qfield.CavDesignation = "SOLD59824";

			Qfield.Dupmsg = "";
			info.RegisterFieldDB(Qfield);

			//- - - - - - - - - - - - - - - - - - -
			Qfield = new Field(info.Alias, "zzstate", FieldType.INTEGER);
			Qfield.FieldDescription = "Estado da ficha";
			info.RegisterFieldDB(Qfield);

		}

		/// <summary>
		/// Initializes metadata for paths direct to other areas
		/// </summary>
		private static void InicializaRelacoes(AreaInfo info)
		{
			// Daughters Relations
			//------------------------------
			info.ChildTable = new ChildRelation[2];
			info.ChildTable[0]= new ChildRelation("photo_album", new String[] {"codproperty"}, DeleteProc.NA);
			info.ChildTable[1]= new ChildRelation("contact", new String[] {"codproperty"}, DeleteProc.NA);

			// Mother Relations
			//------------------------------
			info.ParentTables = new Dictionary<string, Relation>();
			info.ParentTables.Add("broker", new Relation("TRA", "traproperty", "property", "codproperty", "codagent", "TRA", "trabroker", "broker", "codbroker", "codbroker"));
			info.ParentTables.Add("city", new Relation("TRA", "traproperty", "property", "codproperty", "codcity", "TRA", "tracity", "city", "codcity", "codcity"));
		}

		/// <summary>
		/// Initializes metadata for indirect paths to other areas
		/// </summary>
		private static void InicializaCaminhos(AreaInfo info)
		{
			// Pathways
			//------------------------------
			info.Pathways = new Dictionary<string, string>(3);
			info.Pathways.Add("broker","broker");
			info.Pathways.Add("city","city");
			info.Pathways.Add("country","city");
		}

		/// <summary>
		/// Initializes metadata for triggers and formula arguments
		/// </summary>
		private static void InicializaFormulas(AreaInfo info)
		{
			// Formulas
			//------------------------------



			info.InternalOperationFields = new string[] {
			 "buildingage"
			};

			info.SequentialDefaultValues = new string[] {
			 "id"
			};





			//Write conditions
			List<ConditionFormula> conditions = new List<ConditionFormula>();

			// [PROPERTY->PRICE]>0
			{
			List<ByAreaArguments> argumentsListByArea = new List<ByAreaArguments>();
			argumentsListByArea= new List<ByAreaArguments>();
			argumentsListByArea.Add(new ByAreaArguments(new string[] {"price"},new int[] {0},"property","codproperty"));
			ConditionFormula writeCondition = new ConditionFormula(argumentsListByArea, 1, delegate(object []args,User user,string module,PersistentSupport sp) {
				return ((decimal)args[0])>0;
			});
			writeCondition.ErrorWarning = "You cannot save a property without a price";
            writeCondition.Type =  ConditionType.ERROR;
            writeCondition.Validate = true;
			writeCondition.Field = info.DBFields["price"];
			conditions.Add(writeCondition);
			}
			info.WriteConditions = conditions.Where(c=> c.IsWriteCondition()).ToList();
			info.CrudConditions = conditions.Where(c=> c.IsCrudCondition()).ToList();

		}

		/// <summary>
		/// static CSGenioAproperty()
		/// </summary>
		private static AreaInfo InicializaAreaInfo()
		{
			AreaInfo info = new AreaInfo();

			// Area meta-information
			info.QSystem="TRA";
			info.TableName="traproperty";
			info.ShadowTabName="";
			info.ShadowTabKeyName="";

			info.PrimaryKeyName="codproperty";
			info.HumanKeyName="title,price,".TrimEnd(',');
			info.Alias="property";
			info.IsDomain = true;
			info.PersistenceType = PersistenceType.Database;
			info.AreaDesignation="Property";
			info.AreaPluralDesignation="Properties";
			info.DescriptionCav="PROPERTY43977";

			//sincronização
			info.SyncIncrementalDateStart = TimeSpan.FromHours(8);
			info.SyncIncrementalDateEnd = TimeSpan.FromHours(23);
			info.SyncCompleteHour = TimeSpan.FromHours(0.5);
			info.SyncIncrementalPeriod = TimeSpan.FromHours(1);
			info.BatchSync = 100;
			info.SyncType = SyncType.Central;
            info.SolrList = new List<string>();
        	info.QueuesList = new List<GenioServer.business.QueueGenio>();





			//RS 22.03.2011 I separated in submetodos due to performance problems with the JIT in 64bits
			// that in very large projects took 2 minutes on the first call.
			// After a Microsoft analysis of the JIT algortimo it was revealed that it has a
			// complexity O(n*m) where n are the lines of code and m the number of variables of a function.
			// Tests have revealed that splitting into subfunctions cuts the JIT time by more than half by 64-bit.
			//------------------------------
			InicializaCampos(info);

			//------------------------------
			InicializaRelacoes(info);

			//------------------------------
			InicializaCaminhos(info);

			//------------------------------
			InicializaFormulas(info);

			// Automatic audit stamps in BD
            //------------------------------

            // Documents in DB
            //------------------------------

            // Historics
            //------------------------------

			// Duplication
			//------------------------------

			// Ephs
			//------------------------------
			info.Ephs=new Hashtable();

			// Table minimum roles and access levels
			//------------------------------
            info.QLevel = new QLevel();
            info.QLevel.Query = Role.AUTHORIZED;
            info.QLevel.Create = Role.AUTHORIZED;
            info.QLevel.AlterAlways = Role.AUTHORIZED;
            info.QLevel.RemoveAlways = Role.AUTHORIZED;

      		return info;
		}

		/// <summary>
		/// Meta-information about this area
		/// </summary>
		public override AreaInfo Information
		{
			get { return informacao; }
		}
		/// <summary>
		/// Meta-information about this area
		/// </summary>
		public static AreaInfo GetInformation()
		{
			return informacao;
		}

		/// <summary>Field : "Property" Tipo: "+" Formula:  ""</summary>
		public static FieldRef FldCodproperty { get { return m_fldCodproperty; } }
		private static FieldRef m_fldCodproperty = new FieldRef("property", "codproperty");

		/// <summary>Field : "Property" Tipo: "+" Formula:  ""</summary>
		public string ValCodproperty
		{
			get { return (string)returnValueField(FldCodproperty); }
			set { insertNameValueField(FldCodproperty, value); }
		}

		/// <summary>Field : "Agent" Tipo: "CE" Formula:  ""</summary>
		public static FieldRef FldCodagent { get { return m_fldCodagent; } }
		private static FieldRef m_fldCodagent = new FieldRef("property", "codagent");

		/// <summary>Field : "Agent" Tipo: "CE" Formula:  ""</summary>
		public string ValCodagent
		{
			get { return (string)returnValueField(FldCodagent); }
			set { insertNameValueField(FldCodagent, value); }
		}

		/// <summary>Field : "City" Tipo: "CE" Formula:  ""</summary>
		public static FieldRef FldCodcity { get { return m_fldCodcity; } }
		private static FieldRef m_fldCodcity = new FieldRef("property", "codcity");

		/// <summary>Field : "City" Tipo: "CE" Formula:  ""</summary>
		public string ValCodcity
		{
			get { return (string)returnValueField(FldCodcity); }
			set { insertNameValueField(FldCodcity, value); }
		}

		/// <summary>Field : "Main Photo" Tipo: "IJ" Formula:  ""</summary>
		public static FieldRef FldMain_photo { get { return m_fldMain_photo; } }
		private static FieldRef m_fldMain_photo = new FieldRef("property", "main_photo");

		/// <summary>Field : "Main Photo" Tipo: "IJ" Formula:  ""</summary>
		public byte[] ValMain_photo
		{
			get { return (byte[])returnValueField(FldMain_photo); }
			set { insertNameValueField(FldMain_photo, value); }
		}

		/// <summary>Field : "Title" Tipo: "C" Formula:  ""</summary>
		public static FieldRef FldTitle { get { return m_fldTitle; } }
		private static FieldRef m_fldTitle = new FieldRef("property", "title");

		/// <summary>Field : "Title" Tipo: "C" Formula:  ""</summary>
		public string ValTitle
		{
			get { return (string)returnValueField(FldTitle); }
			set { insertNameValueField(FldTitle, value); }
		}

		/// <summary>Field : "Price 0000000000,00" Tipo: "$" Formula:  ""</summary>
		public static FieldRef FldPrice { get { return m_fldPrice; } }
		private static FieldRef m_fldPrice = new FieldRef("property", "price");

		/// <summary>Field : "Price 0000000000,00" Tipo: "$" Formula:  ""</summary>
		public decimal ValPrice
		{
			get { return (decimal)returnValueField(FldPrice); }
			set { insertNameValueField(FldPrice, value); }
		}

		/// <summary>Field : "Size" Tipo: "C" Formula:  ""</summary>
		public static FieldRef FldSize { get { return m_fldSize; } }
		private static FieldRef m_fldSize = new FieldRef("property", "size");

		/// <summary>Field : "Size" Tipo: "C" Formula:  ""</summary>
		public string ValSize
		{
			get { return (string)returnValueField(FldSize); }
			set { insertNameValueField(FldSize, value); }
		}

		/// <summary>Field : "Bathrooms" Tipo: "C" Formula:  ""</summary>
		public static FieldRef FldBathroom_number { get { return m_fldBathroom_number; } }
		private static FieldRef m_fldBathroom_number = new FieldRef("property", "bathroom_number");

		/// <summary>Field : "Bathrooms" Tipo: "C" Formula:  ""</summary>
		public string ValBathroom_number
		{
			get { return (string)returnValueField(FldBathroom_number); }
			set { insertNameValueField(FldBathroom_number, value); }
		}

		/// <summary>Field : "Date" Tipo: "D" Formula:  ""</summary>
		public static FieldRef FldDate_construction { get { return m_fldDate_construction; } }
		private static FieldRef m_fldDate_construction = new FieldRef("property", "date_construction");

		/// <summary>Field : "Date" Tipo: "D" Formula:  ""</summary>
		public DateTime ValDate_construction
		{
			get { return (DateTime)returnValueField(FldDate_construction); }
			set { insertNameValueField(FldDate_construction, value); }
		}

		/// <summary>Field : "Description" Tipo: "C" Formula:  ""</summary>
		public static FieldRef FldDescription { get { return m_fldDescription; } }
		private static FieldRef m_fldDescription = new FieldRef("property", "description");

		/// <summary>Field : "Description" Tipo: "C" Formula:  ""</summary>
		public string ValDescription
		{
			get { return (string)returnValueField(FldDescription); }
			set { insertNameValueField(FldDescription, value); }
		}

		/// <summary>Field : "Building type" Tipo: "AC" Formula:  ""</summary>
		public static FieldRef FldBuildingtype { get { return m_fldBuildingtype; } }
		private static FieldRef m_fldBuildingtype = new FieldRef("property", "buildingtype");

		/// <summary>Field : "Building type" Tipo: "AC" Formula:  ""</summary>
		public string ValBuildingtype
		{
			get { return (string)returnValueField(FldBuildingtype); }
			set { insertNameValueField(FldBuildingtype, value); }
		}

		/// <summary>Field : "Typology" Tipo: "AN" Formula:  ""</summary>
		public static FieldRef FldTypology { get { return m_fldTypology; } }
		private static FieldRef m_fldTypology = new FieldRef("property", "typology");

		/// <summary>Field : "Typology" Tipo: "AN" Formula:  ""</summary>
		public decimal ValTypology
		{
			get { return (decimal)returnValueField(FldTypology); }
			set { insertNameValueField(FldTypology, value); }
		}

		/// <summary>Field : "ID" Tipo: "N" Formula:  ""</summary>
		public static FieldRef FldId { get { return m_fldId; } }
		private static FieldRef m_fldId = new FieldRef("property", "id");

		/// <summary>Field : "ID" Tipo: "N" Formula:  ""</summary>
		public decimal ValId
		{
			get { return (decimal)returnValueField(FldId); }
			set { insertNameValueField(FldId, value); }
		}

		/// <summary>Field : "Building age" Tipo: "N" Formula: + "Year([Today]) - Year([PROPERTY->DATECONSTRUCTION])"</summary>
		public static FieldRef FldBuildingage { get { return m_fldBuildingage; } }
		private static FieldRef m_fldBuildingage = new FieldRef("property", "buildingage");

		/// <summary>Field : "Building age" Tipo: "N" Formula: + "Year([Today]) - Year([PROPERTY->DATECONSTRUCTION])"</summary>
		public decimal ValBuildingage
		{
			get { return (decimal)returnValueField(FldBuildingage); }
			set { insertNameValueField(FldBuildingage, value); }
		}

		/// <summary>Field : "Ground size" Tipo: "N" Formula:  ""</summary>
		public static FieldRef FldGroundsize { get { return m_fldGroundsize; } }
		private static FieldRef m_fldGroundsize = new FieldRef("property", "groundsize");

		/// <summary>Field : "Ground size" Tipo: "N" Formula:  ""</summary>
		public decimal ValGroundsize
		{
			get { return (decimal)returnValueField(FldGroundsize); }
			set { insertNameValueField(FldGroundsize, value); }
		}

		/// <summary>Field : "Floor number" Tipo: "N" Formula:  ""</summary>
		public static FieldRef FldFloornumber { get { return m_fldFloornumber; } }
		private static FieldRef m_fldFloornumber = new FieldRef("property", "floornumber");

		/// <summary>Field : "Floor number" Tipo: "N" Formula:  ""</summary>
		public decimal ValFloornumber
		{
			get { return (decimal)returnValueField(FldFloornumber); }
			set { insertNameValueField(FldFloornumber, value); }
		}

		/// <summary>Field : "Sold" Tipo: "L" Formula:  ""</summary>
		public static FieldRef FldSold { get { return m_fldSold; } }
		private static FieldRef m_fldSold = new FieldRef("property", "sold");

		/// <summary>Field : "Sold" Tipo: "L" Formula:  ""</summary>
		public int ValSold
		{
			get { return (int)returnValueField(FldSold); }
			set { insertNameValueField(FldSold, value); }
		}

		/// <summary>Field : "ZZSTATE" Type: "INT" Formula:  ""</summary>
		public static FieldRef FldZzstate { get { return m_fldZzstate; } }
		private static FieldRef m_fldZzstate = new FieldRef("property", "zzstate");



		/// <summary>Field : "ZZSTATE" Type: "INT"</summary>
		public int ValZzstate
		{
			get { return (int)returnValueField(FldZzstate); }
			set { insertNameValueField(FldZzstate, value); }
		}

        /// <summary>
        /// Obtains a partially populated area with the record corresponding to a primary key
        /// </summary>
        /// <param name="sp">Persistent support from where to get the registration</param>
        /// <param name="key">The value of the primary key</param>
        /// <param name="user">The context of the user</param>
        /// <param name="fields">The fields to be filled in the area</param>
		/// <param name="forUpdate">True if you are preparing to update this record, false otherwise</param>
        /// <returns>An area with the fields requests of the record read or null if the key does not exist</returns>
        /// <remarks>Persistence operations should not be used on a partially positioned register</remarks>
        public static CSGenioAproperty search(PersistentSupport sp, string key, User user, string[] fields = null, bool forUpdate = false)
        {
			if (string.IsNullOrEmpty(key))
				return null;

		    CSGenioAproperty area = new CSGenioAproperty(user, user.CurrentModule);

            if (sp.getRecord(area, key, fields, forUpdate))
                return area;
			return null;
        }


		public static string GetkeyFromControlledRecord(PersistentSupport sp, string ID, User user)
		{
			if (informacao.ControlledRecords != null)
				return informacao.ControlledRecords.GetPrimaryKeyFromControlledRecord(sp, user, ID);
			return String.Empty;
		}


        /// <summary>
        /// Search for all records of this area that comply with a condition
        /// </summary>
        /// <param name="sp">Persistent support from where to get the list</param>
        /// <param name="user">The context of the user</param>
        /// <param name="where">The search condition for the records. Use null to get all records</param>
        /// <param name="fields">The fields to be filled in the area</param>
        /// <param name="distinct">Get distinct from fields</param>
        /// <param name="noLock">NOLOCK</param>
        /// <returns>A list of area records with all fields populated</returns>
        /// <remarks>Persistence operations should not be used on a partially positioned register</remarks>
        public static List<CSGenioAproperty> searchList(PersistentSupport sp, User user, CriteriaSet where, string[] fields = null, bool distinct = false, bool noLock = false)
        {
				return sp.searchListWhere<CSGenioAproperty>(where, user, fields, distinct, noLock);
        }



       	/// <summary>
        /// Search for all records of this area that comply with a condition
        /// </summary>
        /// <param name="sp">Persistent support from where to get the list</param>
        /// <param name="user">The context of the user</param>
        /// <param name="where">The search condition for the records. Use null to get all records</param>
        /// <param name="listing">List configuration</param>
        /// <returns>A list of area records with all fields populated</returns>
        /// <remarks>Persistence operations should not be used on a partially positioned register</remarks>
        public static void searchListAdvancedWhere(PersistentSupport sp, User user, CriteriaSet where, ListingMVC<CSGenioAproperty> listing)
        {
			sp.searchListAdvancedWhere<CSGenioAproperty>(where, listing);
        }




		/// <summary>
		/// Check if a record exist
		/// </summary>
		/// <param name="key">Record key</param>
		/// <param name="sp">DB conecntion</param>
		/// <returns>True if the record exist</returns>
		public static bool RecordExist(string key, PersistentSupport sp) => DbArea.RecordExist(key, informacao, sp);








		// USE /[MANUAL TRA TABAUX PROPERTY]/

 
                  

	}
}
