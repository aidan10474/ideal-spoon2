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
		/// <summary>Field : "" Tipo: "+" Formula:  ""</summary>
		[ShouldSerialize("Property.ValPrimary_property")]
		public string ValPrimary_property { get { return klass.ValPrimary_property; } set { klass.ValPrimary_property = value; } }

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

		[DisplayName("Price")]
		/// <summary>Field : "Price" Tipo: "$" Formula:  ""</summary>
		[ShouldSerialize("Property.ValPrice")]
		[CurrencyAttribute("EUR", 4)]
		public decimal? ValPrice { get { return Convert.ToDecimal(GenFunctions.RoundQG(klass.ValPrice, 4)); } set { klass.ValPrice = Convert.ToDecimal(value); } }

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
