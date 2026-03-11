using CSGenio.business;
using CSGenio.framework;
using CSGenio.persistence;
using GenioMVC.Helpers;
using GenioMVC.Models.Exception;
using GenioMVC.Models.Navigation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Quidgest.Persistence;
using Quidgest.Persistence.GenericQuery;

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Text.Json.Serialization;

namespace GenioMVC.ViewModels.Contact
{
	public class F_contact_ViewModel : FormViewModel<Models.Contact>, IPreparableForSerialization
	{
		[JsonIgnore]
		public override bool HasWriteConditions { get => false; }

		/// <summary>
		/// Reference for the Models MsqActive property
		/// </summary>
		[JsonIgnore]
		public bool MsqActive { get; set; } = false;

		#region Foreign keys
		/// <summary>
		/// Title: "Title" | Type: "CE"
		/// </summary>
		public string ValCodproperty { get; set; }

		#endregion
		/// <summary>
		/// Title: "Title" | Type: "C"
		/// </summary>
		[ValidateSetAccess]
		public TableDBEdit<GenioMVC.Models.Property> TablePropertyTitle { get; set; }
		/// <summary>
		/// Title: "Date" | Type: "D"
		/// </summary>
		public DateTime? ValDate { get; set; }
		/// <summary>
		/// Title: "Name" | Type: "C"
		/// </summary>
		public string ValClient_name { get; set; }
		/// <summary>
		/// Title: "Email" | Type: "C"
		/// </summary>
		public string ValEmail_contact { get; set; }
		/// <summary>
		/// Title: "Phone Contact" | Type: "N"
		/// </summary>
		public decimal? ValPhone_contact { get; set; }
		/// <summary>
		/// Title: "Description" | Type: "C"
		/// </summary>
		public string ValDescription { get; set; }

		#region Navigations
		#endregion

		#region Auxiliar Keys for Image controls



		#endregion

		#region Extra database fields



		#endregion

		#region Fields for formulas


		#endregion

		public string ValCodcontact { get; set; }


		/// <summary>
		/// FOR DESERIALIZATION ONLY
		/// A call to Init() needs to be manually invoked after this constructor
		/// </summary>
		[Obsolete("For deserialization only")]
		public F_contact_ViewModel() : base(null!) { }

		public F_contact_ViewModel(UserContext userContext, bool nestedForm = false) : base(userContext, "FF_CONTACT", nestedForm) { }

		public F_contact_ViewModel(UserContext userContext, Models.Contact row, bool nestedForm = false) : base(userContext, "FF_CONTACT", row, nestedForm) { }

		public F_contact_ViewModel(UserContext userContext, string id, bool nestedForm = false, string[]? fieldsToLoad = null) : this(userContext, nestedForm)
		{
			this.Navigation.SetValue("contact", id);
			Model = Models.Contact.Find(id, userContext, "FF_CONTACT", fieldsToQuery: fieldsToLoad);
			if (Model == null)
				throw new ModelNotFoundException("Model not found");
			InitModel();
		}

		protected override void InitLevels()
		{
			this.RoleToShow = CSGenio.framework.Role.ROLE_1;
			this.RoleToEdit = CSGenio.framework.Role.ROLE_1;
		}

		#region Form conditions

		public override StatusMessage InsertConditions()
		{
			return InsertConditions(m_userContext);
		}

		public static StatusMessage InsertConditions(UserContext userContext)
		{
			var m_userContext = userContext;
			StatusMessage result = new StatusMessage(Status.OK, "");
			Models.Contact model = new Models.Contact(userContext) { Identifier = "FF_CONTACT" };

			var navigation = m_userContext.CurrentNavigation;
			// The "LoadKeysFromHistory" must be after the "LoadEPH" because the PHE's in the tree mark Foreign Keys to null
			// (since they cannot assign multiple values to a single field) and thus the value that comes from Navigation is lost.
			// And this makes it more like the order of loading the model when opening the form.
			model.LoadEPH("FF_CONTACT");
			if (navigation != null)
				model.LoadKeysFromHistory(navigation, navigation.CurrentLevel.Level);

			var tableResult = model.EvaluateTableConditions(ConditionType.INSERT);
			result.MergeStatusMessage(tableResult);
			return result;
		}

		public override StatusMessage UpdateConditions()
		{
			StatusMessage result = new StatusMessage(Status.OK, "");
			var model = Model;

			var tableResult = model.EvaluateTableConditions(ConditionType.UPDATE);
			result.MergeStatusMessage(tableResult);
			return result;
		}

		public override StatusMessage DeleteConditions()
		{
			StatusMessage result = new StatusMessage(Status.OK, "");
			var model = Model;

			var tableResult = model.EvaluateTableConditions(ConditionType.DELETE);
			result.MergeStatusMessage(tableResult);
			return result;
		}

		public override StatusMessage ViewConditions()
		{
			var model = Model;
			StatusMessage result = model.EvaluateTableConditions(ConditionType.VIEW);
			var tableResult = model.EvaluateTableConditions(ConditionType.VIEW);
			result.MergeStatusMessage(tableResult);
			return result;
		}

		public override StatusMessage EvaluateWriteConditions(bool isApply)
		{
			StatusMessage result = new StatusMessage(Status.OK, "");
			return result;
		}

		public StatusMessage EvaluateTableConditions(ConditionType type)
		{
			return Model.EvaluateTableConditions(type);
		}

		#endregion

		#region Mapper

		/// <inheritdoc />
		public override void MapFromModel(Models.Contact m)
		{
			if (m == null)
			{
				CSGenio.framework.Log.Error("Map Model (Contact) to ViewModel (F_contact) - Model is a null reference");
				throw new ModelNotFoundException("Model not found");
			}

			try
			{
				ValCodproperty = ViewModelConversion.ToString(m.ValCodproperty);
				ValDate = ViewModelConversion.ToDateTime(m.ValDate);
				ValClient_name = ViewModelConversion.ToString(m.ValClient_name);
				ValEmail_contact = ViewModelConversion.ToString(m.ValEmail_contact);
				ValPhone_contact = ViewModelConversion.ToNumeric(m.ValPhone_contact);
				ValDescription = ViewModelConversion.ToString(m.ValDescription);
				ValCodcontact = ViewModelConversion.ToString(m.ValCodcontact);
			}
			catch (Exception)
			{
				CSGenio.framework.Log.Error("Map Model (Contact) to ViewModel (F_contact) - Error during mapping");
				throw;
			}
		}

		/// <inheritdoc />
		public override void MapToModel()
		{
			MapToModel(this.Model);
		}

		/// <inheritdoc />
		public override void MapToModel(Models.Contact m)
		{
			if (m == null)
			{
				CSGenio.framework.Log.Error("Map ViewModel (F_contact) to Model (Contact) - Model is a null reference");
				throw new ModelNotFoundException("Model not found");
			}

			try
			{
				m.ValCodproperty = ViewModelConversion.ToString(ValCodproperty);
				m.ValDate = ViewModelConversion.ToDateTime(ValDate);
				m.ValClient_name = ViewModelConversion.ToString(ValClient_name);
				m.ValEmail_contact = ViewModelConversion.ToString(ValEmail_contact);
				m.ValPhone_contact = ViewModelConversion.ToNumeric(ValPhone_contact);
				// Block When condition(s)
				if (HasDisabledUserValuesSecurity || !(Logical)((((decimal)m.ValPhone_contact) == "")))
				{
					m.ValDescription = ViewModelConversion.ToString(ValDescription);
				}
				m.ValCodcontact = ViewModelConversion.ToString(ValCodcontact);
			}
			catch (Exception)
			{
				CSGenio.framework.Log.Error($"Map ViewModel (F_contact) to Model (Contact) - Error during mapping. All user values: {HasDisabledUserValuesSecurity}");
				throw;
			}
		}

		/// <summary>
		/// Sets the value of a single property of the view model based on the provided table and field names.
		/// </summary>
		/// <param name="fullFieldName">The full field name in the format "table.field".</param>
		/// <param name="value">The field value.</param>
		/// <exception cref="ArgumentNullException">Thrown if <paramref name="fullFieldName"/> is null.</exception>
		public override void SetViewModelValue(string fullFieldName, object value)
		{
			try
			{
				ArgumentNullException.ThrowIfNull(fullFieldName);
				// Obtain a valid value from JsonValueKind that can come from "prefillValues" during the pre-filling of fields during insertion
				var _value = ViewModelConversion.ToRawValue(value);

				switch (fullFieldName)
				{
					case "contact.codproperty":
						this.ValCodproperty = ViewModelConversion.ToString(_value);
						break;
					case "contact.date":
						this.ValDate = ViewModelConversion.ToDateTime(_value);
						break;
					case "contact.client_name":
						this.ValClient_name = ViewModelConversion.ToString(_value);
						break;
					case "contact.email_contact":
						this.ValEmail_contact = ViewModelConversion.ToString(_value);
						break;
					case "contact.phone_contact":
						this.ValPhone_contact = ViewModelConversion.ToNumeric(_value);
						break;
					case "contact.description":
						this.ValDescription = ViewModelConversion.ToString(_value);
						break;
					case "contact.codcontact":
						this.ValCodcontact = ViewModelConversion.ToString(_value);
						break;
					default:
						Log.Error($"SetViewModelValue (F_contact) - Unexpected field identifier {fullFieldName}");
						break;
				}
			}
			catch (Exception ex)
			{
				throw new FrameworkException(Resources.Resources.PEDIMOS_DESCULPA__OC63848, "SetViewModelValue (F_contact)", "Unexpected error", ex);
			}
		}

		#endregion

		/// <summary>
		/// Reads the Model from the database based on the key that is in the history or that was passed through the parameter
		/// </summary>
		/// <param name="id">The primary key of the record that needs to be read from the database. Leave NULL to use the value from the History.</param>
		public override void LoadModel(string id = null)
		{
			try { Model = Models.Contact.Find(id ?? Navigation.GetStrValue("contact"), m_userContext, "FF_CONTACT"); }
			finally { Model ??= new Models.Contact(m_userContext) { Identifier = "FF_CONTACT" }; }

			base.LoadModel();
		}

		public override void Load(NameValueCollection qs, bool editable, bool ajaxRequest = false, bool lazyLoad = false)
		{
			this.editable = editable;
			CSGenio.business.Area oldvalues = null;

			// TODO: Deve ser substituido por search do CSGenioA
			try
			{
				Model = Models.Contact.Find(Navigation.GetStrValue("contact"), m_userContext, "FF_CONTACT");
			}
			finally
			{
				if (Model == null)
					throw new ModelNotFoundException("Model not found");

				if (Navigation.CurrentLevel.FormMode == FormMode.New || Navigation.CurrentLevel.FormMode == FormMode.Duplicate)
					LoadDefaultValues();
				else
					oldvalues = Model.klass;
			}

			Model.Identifier = "FF_CONTACT";
			InitModel(qs, lazyLoad);

			if (Navigation.CurrentLevel.FormMode == FormMode.New || Navigation.CurrentLevel.FormMode == FormMode.Edit || Navigation.CurrentLevel.FormMode == FormMode.Duplicate)
			{
				// MH - Voltar calcular as formulas to "atualizar" os Qvalues dos fields fixos
				// Conexão deve estar aberta de fora. Podem haver formulas que utilizam funções "manuais".
				// TODO: It needs to be analyzed whether we should disable the security of field filling here. If there is any case where the field with the block condition can only be calculated after the double calculation of the formulas.
				MapToModel(Model);

				// If it's inserting or duplicating, needs to fill the default values.
				if (Navigation.CurrentLevel.FormMode == FormMode.New || Navigation.CurrentLevel.FormMode == FormMode.Duplicate)
				{
					FunctionType funcType = Navigation.CurrentLevel.FormMode == FormMode.New
						? FunctionType.INS
						: FunctionType.DUP;

					Model.baseklass.fillValuesDefault(m_userContext.PersistentSupport, funcType);
				}

				// Preencher operações internas
				Model.klass.fillInternalOperations(m_userContext.PersistentSupport, oldvalues);
				MapFromModel(Model);
			}

			// Load just the selected row primary keys for checklists.
			// Needed for submitting forms incase checklists are in collapsible zones that have not been expanded to load the checklist data.
			LoadChecklistsSelectedIDs();
		}

		protected override void FillExtraProperties()
		{
		}
		
		protected override void LoadDocumentsProperties(Models.Contact row)
		{
		}

		/// <summary>
		/// Load Partial
		/// </summary>
		/// <param name="lazyLoad">Lazy loading of dropdown items</param>
		public override void LoadPartial(NameValueCollection qs, bool lazyLoad = false)
		{
			// MH [bugfix] - Quando o POST da ficha falha, ao recaregar a view os documentos na BD perdem alguma informação (ex: name do file)
			if (Model == null)
			{
				// Precisamos fazer o Find to obter as chaves dos documentos que já foram anexados
				// TODO: Conseguir passar estas chaves no POST to poder retirar o Find.
				Model = Models.Contact.Find(Navigation.GetStrValue("contact"), m_userContext, "FF_CONTACT");
				if (Model == null)
				{
					Model = new Models.Contact(m_userContext) { Identifier = "FF_CONTACT" };
					Model.klass.QPrimaryKey = Navigation.GetStrValue("contact");
				}
				MapToModel(Model);
				LoadDocumentsProperties(Model);
			}
			// Add characteristics
			Characs = new List<string>();

			Load_F_contact__property__title(qs, lazyLoad);

// USE /[MANUAL TRA VIEWMODEL_LOADPARTIAL F_CONTACT]/
		}

// USE /[MANUAL TRA VIEWMODEL_NEW F_CONTACT]/

		// Preencher Qvalues default dos fields do form
		protected override void LoadDefaultValues()
		{
		}

		public override CrudViewModelValidationResult Validate()
		{
			CrudViewModelFieldValidator validator = new(m_userContext.User.Language);

			validator.StringLength("ValClient_name", Resources.Resources.NAME31974, ValClient_name, 50);

			validator.Required("ValClient_name", Resources.Resources.NAME31974, ViewModelConversion.ToString(ValClient_name), FieldType.TEXT.GetFormatting());
			validator.StringLength("ValEmail_contact", Resources.Resources.EMAIL25170, ValEmail_contact, 50);

			validator.Required("ValEmail_contact", Resources.Resources.EMAIL25170, ViewModelConversion.ToString(ValEmail_contact), FieldType.TEXT.GetFormatting());
			validator.StringLength("ValDescription", Resources.Resources.DESCRIPTION07383, ValDescription, 50);


			return validator.GetResult();
		}

		public override void Init(UserContext userContext)
		{
			base.Init(userContext);
		}
// USE /[MANUAL TRA VIEWMODEL_SAVE F_CONTACT]/
		public override void Save()
		{


			base.Save();
		}

// USE /[MANUAL TRA VIEWMODEL_APPLY F_CONTACT]/

// USE /[MANUAL TRA VIEWMODEL_DUPLICATE F_CONTACT]/

// USE /[MANUAL TRA VIEWMODEL_DESTROY F_CONTACT]/
		public override void Destroy(string id)
		{
			Model = Models.Contact.Find(id, m_userContext, "FF_CONTACT");
			if (Model == null)
				throw new ModelNotFoundException("Model not found");
			this.flashMessage = Model.Destroy();
		}

		/// <summary>
		/// Load selected row primary keys for all checklists
		/// </summary>
		public void LoadChecklistsSelectedIDs()
		{
		}

		/// <summary>
		/// TablePropertyTitle -> (DB)
		/// </summary>
		/// <param name="qs"></param>
		/// <param name="lazyLoad">Lazy loading of dropdown items</param>
		public void Load_F_contact__property__title(NameValueCollection qs, bool lazyLoad = false)
		{
			bool f_contact__property__titleDoLoad = true;
			CriteriaSet f_contact__property__titleConds = CriteriaSet.And();
			{
				object hValue = Navigation.GetValue("property", true);
				if (hValue != null && !(hValue is Array) && !string.IsNullOrEmpty(Convert.ToString(hValue)))
				{
					f_contact__property__titleConds.Equal(CSGenioAproperty.FldCodproperty, hValue);
					this.ValCodproperty = DBConversion.ToString(hValue);
				}
			}

			TablePropertyTitle = new TableDBEdit<Models.Property>
			{
				IsLazyLoad = lazyLoad
			};

			if (lazyLoad)
			{
				if (Navigation.CurrentLevel.GetEntry("RETURN_property") != null)
				{
					this.ValCodproperty = Navigation.GetStrValue("RETURN_property");
					Navigation.CurrentLevel.SetEntry("RETURN_property", null);
				}
				FillDependant_F_contactTablePropertyTitle(lazyLoad);
				return;
			}

			if (f_contact__property__titleDoLoad)
			{
				List<ColumnSort> sorts = [];
				ColumnSort requestedSort = GetRequestSort(TablePropertyTitle, "sTablePropertyTitle", "dTablePropertyTitle", qs, "property");
				if (requestedSort != null)
					sorts.Add(requestedSort);
				sorts.Add(new ColumnSort(new ColumnReference(CSGenioAproperty.FldTitle), SortOrder.Ascending));

				string query = "";
				if (!string.IsNullOrEmpty(qs["TablePropertyTitle_tableFilters"]))
					TablePropertyTitle.TableFilters = bool.Parse(qs["TablePropertyTitle_tableFilters"]);
				else
					TablePropertyTitle.TableFilters = false;

				query = qs["qTablePropertyTitle"];

				//RS 26.07.2016 O preenchimento da lista de ajuda dos Dbedits passa a basear-se apenas no campo do próprio DbEdit
				// O interface de pesquisa rápida não fica coerente quando se visualiza apenas uma coluna mas a pesquisa faz matching com 5 ou 6 colunas diferentes
				//  tornando confuso to o user porque determinada row foi devolvida quando o Qresult não mostra como o matching foi feito
				CriteriaSet search_filters = CriteriaSet.And();
				if (!string.IsNullOrEmpty(query))
				{
					search_filters.Like(CSGenioAproperty.FldTitle, query + "%");
				}
				f_contact__property__titleConds.SubSet(search_filters);

				string tryParsePage = qs["pTablePropertyTitle"] != null ? qs["pTablePropertyTitle"].ToString() : "1";
				int page = !string.IsNullOrEmpty(tryParsePage) ? int.Parse(tryParsePage) : 1;
				int numberItems = CSGenio.framework.Configuration.NrRegDBedit;
				int offset = (page - 1) * numberItems;

				FieldRef[] fields = [CSGenioAproperty.FldCodproperty, CSGenioAproperty.FldTitle, CSGenioAproperty.FldPrice, CSGenioAproperty.FldZzstate];

// USE /[MANUAL TRA OVERRQ F_CONTACT_PROPERTYTITLE]/

				// Limitation by Zzstate
				/*
					Records that are currently being inserted or duplicated will also be included.
					Client-side persistence will try to fill the "text" value of that option.
				*/
				if (Navigation.checkFormMode("property", FormMode.New) || Navigation.checkFormMode("property", FormMode.Duplicate))
					f_contact__property__titleConds.SubSet(CriteriaSet.Or()
						.Equal(CSGenioAproperty.FldZzstate, 0)
						.Equal(CSGenioAproperty.FldCodproperty, Navigation.GetStrValue("property")));
				else
					f_contact__property__titleConds.Criterias.Add(new Criteria(new ColumnReference(CSGenioAproperty.FldZzstate), CriteriaOperator.Equal, 0));

				FieldRef firstVisibleColumn = new FieldRef("property", "price");
				ListingMVC<CSGenioAproperty> listing = Models.ModelBase.Where<CSGenioAproperty>(m_userContext, false, f_contact__property__titleConds, fields, offset, numberItems, sorts, "LED_F_CONTACT__PROPERTY__TITLE", true, false, firstVisibleColumn: firstVisibleColumn);

				TablePropertyTitle.SetPagination(page, numberItems, listing.HasMore, listing.GetTotal, listing.TotalRecords);
				TablePropertyTitle.Query = query;
				TablePropertyTitle.Elements = listing.RowsForViewModel((r) => new GenioMVC.Models.Property(m_userContext, r, true, _fieldsToSerialize_F_CONTACT__PROPERTY__TITLE));

				//created by [ MH ] at [ 14.04.2016 ] - Foi alterada a forma de retornar a key do novo registo inserido / editado no form de apoio do DBEdit.
				//last update by [ MH ] at [ 10.05.2016 ] - Validação se key encontra-se no level atual, as chaves dos niveis anteriores devem ser ignorados.
				if (Navigation.CurrentLevel.GetEntry("RETURN_property") != null)
				{
					this.ValCodproperty = Navigation.GetStrValue("RETURN_property");
					Navigation.CurrentLevel.SetEntry("RETURN_property", null);
				}

				TablePropertyTitle.List = new SelectList(TablePropertyTitle.Elements.ToSelectList(x => x.ValTitle, x => x.ValCodproperty,  x => x.ValCodproperty == this.ValCodproperty), "Value", "Text", this.ValCodproperty);
				FillDependant_F_contactTablePropertyTitle();
			}
		}

		/// <summary>
		/// Get Dependant fields values -> TablePropertyTitle (DB)
		/// </summary>
		/// <param name="PKey">Primary Key of Property</param>
		public ConcurrentDictionary<string, object> GetDependant_F_contactTablePropertyTitle(string PKey)
		{
			FieldRef[] refDependantFields = [CSGenioAproperty.FldCodproperty, CSGenioAproperty.FldTitle];

			var returnEmptyDependants = false;
			CriteriaSet wherecodition = CriteriaSet.And();

			// Return default values
			if (GenFunctions.emptyG(PKey) == 1)
				returnEmptyDependants = true;

			// Check if the limit(s) is filled if exists
			// - - - - - - - - - - - - - - - - - - - - -

			if (returnEmptyDependants)
				return GetViewModelFieldValues(refDependantFields);

			PersistentSupport sp = m_userContext.PersistentSupport;
			User u = m_userContext.User;

			CSGenioAproperty tempArea = new(u);

			// Fields to select
			SelectQuery querySelect = new();
			querySelect.PageSize(1);
			foreach (FieldRef field in refDependantFields)
				querySelect.Select(field);

			querySelect.From(tempArea.QSystem, tempArea.TableName, tempArea.Alias)
				.Where(wherecodition.Equal(CSGenioAproperty.FldCodproperty, PKey));

			string[] dependantFields = refDependantFields.Select(f => f.FullName).ToArray();
			QueryUtils.SetInnerJoins(dependantFields, null, tempArea, querySelect);

			ArrayList values = sp.executeReaderOneRow(querySelect);
			bool useDefaults = values.Count == 0;

			if (useDefaults)
				return GetViewModelFieldValues(refDependantFields);
			return GetViewModelFieldValues(refDependantFields, values);
		}

		/// <summary>
		/// Fill Dependant fields values -> TablePropertyTitle (DB)
		/// </summary>
		/// <param name="lazyLoad">Lazy loading of dropdown items</param>
		public void FillDependant_F_contactTablePropertyTitle(bool lazyLoad = false)
		{
			var row = GetDependant_F_contactTablePropertyTitle(this.ValCodproperty);
			try
			{

				// Fill List fields
				this.ValCodproperty = ViewModelConversion.ToString(row["property.codproperty"]);
				TablePropertyTitle.Value = (string)row["property.title"];
				if (GenFunctions.emptyG(this.ValCodproperty) == 1)
				{
					this.ValCodproperty = "";
					TablePropertyTitle.Value = "";
					Navigation.ClearValue("property");
				}
				else if (lazyLoad)
				{
					TablePropertyTitle.SetPagination(1, 0, false, false, 1);
					TablePropertyTitle.List = new SelectList(new List<SelectListItem>()
					{
						new SelectListItem
						{
							Value = Convert.ToString(this.ValCodproperty),
							Text = Convert.ToString(TablePropertyTitle.Value),
							Selected = true
						}
					}, "Value", "Text", this.ValCodproperty);
				}

				TablePropertyTitle.Selected = this.ValCodproperty;
			}
			catch (Exception ex)
			{
				CSGenio.framework.Log.Error(string.Format("FillDependant_Error (TablePropertyTitle): {0}; {1}", ex.Message, ex.InnerException != null ? ex.InnerException.Message : ""));
			}
		}

		private readonly string[] _fieldsToSerialize_F_CONTACT__PROPERTY__TITLE = ["Property", "Property.ValCodproperty", "Property.ValZzstate", "Property.ValPrice", "Property.ValTitle"];

		protected override object GetViewModelValue(string identifier, object modelValue)
		{
			return identifier switch
			{
				"contact.codproperty" => ViewModelConversion.ToString(modelValue),
				"contact.date" => ViewModelConversion.ToDateTime(modelValue),
				"contact.client_name" => ViewModelConversion.ToString(modelValue),
				"contact.email_contact" => ViewModelConversion.ToString(modelValue),
				"contact.phone_contact" => ViewModelConversion.ToNumeric(modelValue),
				"contact.description" => ViewModelConversion.ToString(modelValue),
				"contact.codcontact" => ViewModelConversion.ToString(modelValue),
				"property.codproperty" => ViewModelConversion.ToString(modelValue),
				"property.title" => ViewModelConversion.ToString(modelValue),
				_ => modelValue
			};
		}

		#region Charts


		#endregion

		#region Custom code

// USE /[MANUAL TRA VIEWMODEL_CUSTOM F_CONTACT]/

		#endregion
	}
}
