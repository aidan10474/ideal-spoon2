using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using CSGenio.business;
using CSGenio.framework;
using CSGenio.persistence;
using GenioMVC.Helpers;
using GenioMVC.Models.Navigation;
using Quidgest.Persistence;
using Quidgest.Persistence.GenericQuery;

using SelectList = Microsoft.AspNetCore.Mvc.Rendering.SelectList;
using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;

namespace GenioMVC.Models
{
	public class Property : ModelBase
	{
		[JsonIgnore]
		public CSGenioAproperty klass { get { return baseklass as CSGenioAproperty; } set { baseklass = value; } }

		[Key]
		/// <summary>Field : "Property" Tipo: "+" Formula:  ""</summary>
		[ShouldSerialize("Property.ValCodproperty")]
		public string ValCodproperty { get { return klass.ValCodproperty; } set { klass.ValCodproperty = value; } }

		[DisplayName("Agent")]
		/// <summary>Field : "Agent" Tipo: "CE" Formula:  ""</summary>
		[ShouldSerialize("Property.ValCodagent")]
		public string ValCodagent { get { return klass.ValCodagent; } set { klass.ValCodagent = value; } }

		private Broker _broker;
		[DisplayName("Broker")]
		[ShouldSerialize("Broker")]
		public virtual Broker Broker
		{
			get
			{
				if (!isEmptyModel && (_broker == null || (!string.IsNullOrEmpty(ValCodagent) && (_broker.isEmptyModel || _broker.klass.QPrimaryKey != ValCodagent))))
					_broker = Models.Broker.Find(ValCodagent, m_userContext, Identifier, _fieldsToSerialize);
				_broker ??= new Models.Broker(m_userContext, true, _fieldsToSerialize);
				return _broker;
			}
			set { _broker = value; }
		}

		[DisplayName("City")]
		/// <summary>Field : "City" Tipo: "CE" Formula:  ""</summary>
		[ShouldSerialize("Property.ValCodcity")]
		public string ValCodcity { get { return klass.ValCodcity; } set { klass.ValCodcity = value; } }

		private City _city;
		[DisplayName("City")]
		[ShouldSerialize("City")]
		public virtual City City
		{
			get
			{
				if (!isEmptyModel && (_city == null || (!string.IsNullOrEmpty(ValCodcity) && (_city.isEmptyModel || _city.klass.QPrimaryKey != ValCodcity))))
					_city = Models.City.Find(ValCodcity, m_userContext, Identifier, _fieldsToSerialize);
				_city ??= new Models.City(m_userContext, true, _fieldsToSerialize);
				return _city;
			}
			set { _city = value; }
		}

		[DisplayName("Main Photo")]
		/// <summary>Field : "Main Photo" Tipo: "IJ" Formula:  ""</summary>
		[ShouldSerialize("Property.ValMain_photo")]
		[ImageThumbnailJsonConverter(75, 75)]
		public ImageModel ValMain_photo { get { return new ImageModel(klass.ValMain_photo) { Ticket = ValMain_photoQTicket }; } set { klass.ValMain_photo = value; } }
		[JsonIgnore]
		public string ValMain_photoQTicket = null;

		[DisplayName("Title")]
		/// <summary>Field : "Title" Tipo: "C" Formula:  ""</summary>
		[ShouldSerialize("Property.ValTitle")]
		public string ValTitle { get { return klass.ValTitle; } set { klass.ValTitle = value; } }

		[DisplayName("Price 0000000000,00")]
		/// <summary>Field : "Price 0000000000,00" Tipo: "$" Formula:  ""</summary>
		[ShouldSerialize("Property.ValPrice")]
		[CurrencyAttribute("EUR", 4)]
		public decimal? ValPrice { get { return Convert.ToDecimal(GenFunctions.RoundQG(klass.ValPrice, 4)); } set { klass.ValPrice = Convert.ToDecimal(value); } }

		[DisplayName("Size")]
		/// <summary>Field : "Size" Tipo: "C" Formula:  ""</summary>
		[ShouldSerialize("Property.ValSize")]
		public string ValSize { get { return klass.ValSize; } set { klass.ValSize = value; } }

		[DisplayName("Bathrooms")]
		/// <summary>Field : "Bathrooms" Tipo: "C" Formula:  ""</summary>
		[ShouldSerialize("Property.ValBathroom_number")]
		public string ValBathroom_number { get { return klass.ValBathroom_number; } set { klass.ValBathroom_number = value; } }

		[DisplayName("Date")]
		/// <summary>Field : "Date" Tipo: "D" Formula:  ""</summary>
		[ShouldSerialize("Property.ValDate_construction")]
		[DataType(DataType.Date)]
		[DateAttribute("D")]
		public DateTime? ValDate_construction { get { return klass.ValDate_construction; } set { klass.ValDate_construction = value ?? DateTime.MinValue; } }

		[DisplayName("Description")]
		/// <summary>Field : "Description" Tipo: "C" Formula:  ""</summary>
		[ShouldSerialize("Property.ValDescription")]
		public string ValDescription { get { return klass.ValDescription; } set { klass.ValDescription = value; } }

		[DisplayName("Building type")]
		/// <summary>Field : "Building type" Tipo: "AC" Formula:  ""</summary>
		[ShouldSerialize("Property.ValBuildingtype")]
		[DataArray("Buildingtype", GenioMVC.Helpers.ArrayType.Character)]
		public string ValBuildingtype { get { return klass.ValBuildingtype; } set { klass.ValBuildingtype = value; } }
		[JsonIgnore]
		public SelectList ArrayValbuildingtype { get { return new SelectList(CSGenio.business.ArrayBuildingtype.GetDictionary(), "Key", "Value", ValBuildingtype); } set { ValBuildingtype = value.SelectedValue as string; } }

		[DisplayName("Typology")]
		/// <summary>Field : "Typology" Tipo: "AN" Formula:  ""</summary>
		[ShouldSerialize("Property.ValTypology")]
		[DataArray("Typology", GenioMVC.Helpers.ArrayType.Numeric)]
		public decimal ValTypology { get { return klass.ValTypology; } set { klass.ValTypology = value; } }
		[JsonIgnore]
		public SelectList ArrayValtypology { get { return new SelectList(CSGenio.business.ArrayTypology.GetDictionary(), "Key", "Value", ValTypology); } set { ValTypology = Convert.ToDecimal(value.SelectedValue); } }

		[DisplayName("ZZSTATE")]
		[ShouldSerialize("Property.ValZzstate")]
		/// <summary>Field: "ZZSTATE", Type: "INT", Formula: ""</summary>
		public virtual int ValZzstate { get { return klass.ValZzstate; } set { klass.ValZzstate = value; } }

		public Property(UserContext userContext, bool isEmpty = false, string[]? fieldsToSerialize = null) : base(userContext)
		{
			klass = new CSGenioAproperty(userContext.User);
			isEmptyModel = isEmpty;
			if (fieldsToSerialize != null)
				SetFieldsToSerialize(fieldsToSerialize);
		}

		public Property(UserContext userContext, CSGenioAproperty val, bool isEmpty = false, string[]? fieldsToSerialize = null) : base(userContext)
		{
			klass = val;
			isEmptyModel = isEmpty;
			if (fieldsToSerialize != null)
				SetFieldsToSerialize(fieldsToSerialize);
			FillRelatedAreas(val);
		}

		public void FillRelatedAreas(CSGenioAproperty csgenioa)
		{
			if (csgenioa == null)
				return;

			foreach (RequestedField Qfield in csgenioa.Fields.Values)
			{
				switch (Qfield.Area)
				{
					case "broker":
						_broker ??= new Broker(m_userContext, true, _fieldsToSerialize);
						_broker.klass.insertNameValueField(Qfield.FullName, Qfield.Value);
						break;
					case "city":
						_city ??= new City(m_userContext, true, _fieldsToSerialize);
						_city.klass.insertNameValueField(Qfield.FullName, Qfield.Value);
						break;
					default:
						break;
				}
			}
		}

		/// <summary>
		/// Search the row by key.
		/// </summary>
		/// <param name="id">The primary key.</param>
		/// <param name="userCtx">The user context.</param>
		/// <param name="identifier">The identifier.</param>
		/// <param name="fieldsToSerialize">The fields to serialize.</param>
		/// <param name="fieldsToQuery">The fields to query.</param>
		/// <returns>Model or NULL</returns>
		public static Property Find(string id, UserContext userCtx, string identifier = null, string[] fieldsToSerialize = null, string[] fieldsToQuery = null)
		{
			var record = Find<CSGenioAproperty>(id, userCtx, identifier, fieldsToQuery);
			return record == null ? null : new Property(userCtx, record, false, fieldsToSerialize) { Identifier = identifier };
		}

		public static List<Property> AllModel(UserContext userCtx, CriteriaSet args = null, string identifier = null)
		{
			return Where<CSGenioAproperty>(userCtx, false, args, numRegs: -1, identifier: identifier).RowsForViewModel<Property>((r) => new Property(userCtx, r));
		}

// USE /[MANUAL TRA MODEL PROPERTY]/
	}
}
