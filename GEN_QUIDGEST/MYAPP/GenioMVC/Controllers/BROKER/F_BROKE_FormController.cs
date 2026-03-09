using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Dynamic;

using CSGenio.business;
using CSGenio.core.persistence;
using CSGenio.framework;
using CSGenio.persistence;
using CSGenio.reporting;
using GenioMVC.Helpers;
using GenioMVC.Models;
using GenioMVC.Models.Exception;
using GenioMVC.Models.Navigation;
using GenioMVC.Resources;
using GenioMVC.ViewModels;
using GenioMVC.ViewModels.Broker;
using Quidgest.Persistence.GenericQuery;

// USE /[MANUAL TRA INCLUDE_CONTROLLER BROKER]/

namespace GenioMVC.Controllers
{
	public partial class BrokerController : ControllerBase
	{
		#region NavigationLocation Names

		private static readonly NavigationLocation ACTION_F_BROKE_CANCEL = new("BROKER49181", "F_broke_Cancel", "Broker") { vueRouteName = "form-F_BROKE", mode = "CANCEL" };
		private static readonly NavigationLocation ACTION_F_BROKE_SHOW = new("BROKER49181", "F_broke_Show", "Broker") { vueRouteName = "form-F_BROKE", mode = "SHOW" };
		private static readonly NavigationLocation ACTION_F_BROKE_NEW = new("BROKER49181", "F_broke_New", "Broker") { vueRouteName = "form-F_BROKE", mode = "NEW" };
		private static readonly NavigationLocation ACTION_F_BROKE_EDIT = new("BROKER49181", "F_broke_Edit", "Broker") { vueRouteName = "form-F_BROKE", mode = "EDIT" };
		private static readonly NavigationLocation ACTION_F_BROKE_DUPLICATE = new("BROKER49181", "F_broke_Duplicate", "Broker") { vueRouteName = "form-F_BROKE", mode = "DUPLICATE" };
		private static readonly NavigationLocation ACTION_F_BROKE_DELETE = new("BROKER49181", "F_broke_Delete", "Broker") { vueRouteName = "form-F_BROKE", mode = "DELETE" };

		#endregion

		#region F_broke private

		private void FormHistoryLimits_F_broke()
		{

		}

		#endregion

		#region F_broke_Show

// USE /[MANUAL TRA CONTROLLER_SHOW F_BROKE]/

		[HttpPost]
		public ActionResult F_broke_Show_GET([FromBody] RequestIdModel requestModel)
		{
			string id = requestModel.Id;
			F_broke_ViewModel model = new(UserContext.Current);
			EventSink eventSink = new()
			{
				MethodName = "F_broke_Show_GET",
				AreaName = "broker",
				Location = ACTION_F_BROKE_SHOW,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_F_broke();
// USE /[MANUAL TRA BEFORE_LOAD_SHOW F_BROKE]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL TRA AFTER_LOAD_SHOW F_BROKE]/
				}
			};

			return GenericHandleGetFormShow(eventSink, model, id);
		}

		#endregion

		#region F_broke_New

// USE /[MANUAL TRA CONTROLLER_NEW_GET F_BROKE]/
		[HttpPost]
		public ActionResult F_broke_New_GET([FromBody] RequestNewGetModel requestModel)
		{
			string id = requestModel.Id;
			bool isNewLocation = requestModel.IsNewLocation;
			var prefillValues = requestModel.PrefillValues;

			F_broke_ViewModel model = new(UserContext.Current);
			EventSink eventSink = new()
			{
				MethodName = "F_broke_New_GET",
				AreaName = "broker",
				FormName = "F_BROKE",
				Location = ACTION_F_BROKE_NEW,
				BeforeAll = (sink, sp) =>
				{
					FormHistoryLimits_F_broke();
				},
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL TRA BEFORE_LOAD_NEW F_BROKE]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL TRA AFTER_LOAD_NEW F_BROKE]/
				}
			};

			return GenericHandleGetFormNew(eventSink, model, id, isNewLocation, prefillValues);
		}

		//
		// POST: /Broker/F_broke_New
// USE /[MANUAL TRA CONTROLLER_NEW_POST F_BROKE]/
		[HttpPost]
		public ActionResult F_broke_New([FromBody]F_broke_ViewModel model, [FromQuery]bool redirect = true)
		{
			EventSink eventSink = new()
			{
				MethodName = "F_broke_New",
				ViewName = "F_broke",
				AreaName = "broker",
				Location = ACTION_F_BROKE_NEW,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL TRA BEFORE_SAVE_NEW F_BROKE]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL TRA AFTER_SAVE_NEW F_BROKE]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL TRA BEFORE_LOAD_NEW_EX F_BROKE]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL TRA AFTER_LOAD_NEW_EX F_BROKE]/
				}
			};

			return GenericHandlePostFormNew(eventSink, model);
		}

		#endregion

		#region F_broke_Edit

// USE /[MANUAL TRA CONTROLLER_EDIT_GET F_BROKE]/
		[HttpPost]
		public ActionResult F_broke_Edit_GET([FromBody] RequestIdModel requestModel)
		{
			string id = requestModel.Id;
			F_broke_ViewModel model = new(UserContext.Current);
			EventSink eventSink = new()
			{
				MethodName = "F_broke_Edit_GET",
				AreaName = "broker",
				FormName = "F_BROKE",
				Location = ACTION_F_BROKE_EDIT,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_F_broke();
// USE /[MANUAL TRA BEFORE_LOAD_EDIT F_BROKE]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL TRA AFTER_LOAD_EDIT F_BROKE]/
				}
			};

			return GenericHandleGetFormEdit(eventSink, model, id);
		}

		//
		// POST: /Broker/F_broke_Edit
// USE /[MANUAL TRA CONTROLLER_EDIT_POST F_BROKE]/
		[HttpPost]
		public ActionResult F_broke_Edit([FromBody]F_broke_ViewModel model, [FromQuery]bool redirect)
		{
			EventSink eventSink = new()
			{
				MethodName = "F_broke_Edit",
				ViewName = "F_broke",
				AreaName = "broker",
				Location = ACTION_F_BROKE_EDIT,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL TRA BEFORE_SAVE_EDIT F_BROKE]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL TRA AFTER_SAVE_EDIT F_BROKE]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL TRA BEFORE_LOAD_EDIT_EX F_BROKE]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL TRA AFTER_LOAD_EDIT_EX F_BROKE]/
				}
			};

			return GenericHandlePostFormEdit(eventSink, model);
		}

		#endregion

		#region F_broke_Delete

// USE /[MANUAL TRA CONTROLLER_DELETE_GET F_BROKE]/
		[HttpPost]
		public ActionResult F_broke_Delete_GET([FromBody] RequestIdModel requestModel)
		{
			string id = requestModel.Id;
			F_broke_ViewModel model = new(UserContext.Current);
			EventSink eventSink = new()
			{
				MethodName = "F_broke_Delete_GET",
				AreaName = "broker",
				FormName = "F_BROKE",
				Location = ACTION_F_BROKE_DELETE,
				BeforeOp = (sink, sp) =>
				{
					FormHistoryLimits_F_broke();
// USE /[MANUAL TRA BEFORE_LOAD_DELETE F_BROKE]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL TRA AFTER_LOAD_DELETE F_BROKE]/
				}
			};

			return GenericHandleGetFormDelete(eventSink, model, id);
		}

		//
		// POST: /Broker/F_broke_Delete
// USE /[MANUAL TRA CONTROLLER_DELETE_POST F_BROKE]/
		[HttpPost]
		public ActionResult F_broke_Delete([FromBody] RequestIdModel requestModel)
		{
			string id = requestModel.Id;
			F_broke_ViewModel model = new(UserContext.Current, id);
			model.MapFromModel();

			EventSink eventSink = new()
			{
				MethodName = "F_broke_Delete",
				ViewName = "F_broke",
				AreaName = "broker",
				Location = ACTION_F_BROKE_DELETE,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL TRA BEFORE_DESTROY_DELETE F_BROKE]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL TRA AFTER_DESTROY_DELETE F_BROKE]/
				}
			};

			return GenericHandlePostFormDelete(eventSink, model);
		}

		public ActionResult F_broke_Delete_Redirect()
		{
			//FOR: FORM MENU GO BACK
			return RedirectToFormMenuGoBack("F_BROKE");
		}

		#endregion

		#region F_broke_Duplicate

// USE /[MANUAL TRA CONTROLLER_DUPLICATE_GET F_BROKE]/

		[HttpPost]
		public ActionResult F_broke_Duplicate_GET([FromBody] RequestNewGetModel requestModel)
		{
			string id = requestModel.Id;
			bool isNewLocation = requestModel.IsNewLocation;

			F_broke_ViewModel model = new(UserContext.Current);
			EventSink eventSink = new()
			{
				MethodName = "F_broke_Duplicate_GET",
				AreaName = "broker",
				FormName = "F_BROKE",
				Location = ACTION_F_BROKE_DUPLICATE,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL TRA BEFORE_LOAD_DUPLICATE F_BROKE]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL TRA AFTER_LOAD_DUPLICATE F_BROKE]/
				}
			};

			return GenericHandleGetFormDuplicate(eventSink, model, id, isNewLocation);
		}

		//
		// POST: /Broker/F_broke_Duplicate
// USE /[MANUAL TRA CONTROLLER_DUPLICATE_POST F_BROKE]/
		[HttpPost]
		public ActionResult F_broke_Duplicate([FromBody]F_broke_ViewModel model, [FromQuery]bool redirect = true)
		{
			EventSink eventSink = new()
			{
				MethodName = "F_broke_Duplicate",
				ViewName = "F_broke",
				AreaName = "broker",
				Location = ACTION_F_BROKE_DUPLICATE,
				Redirect = redirect,
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL TRA BEFORE_SAVE_DUPLICATE F_BROKE]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL TRA AFTER_SAVE_DUPLICATE F_BROKE]/
				},
				BeforeException = (sink, sp) =>
				{
// USE /[MANUAL TRA BEFORE_LOAD_DUPLICATE_EX F_BROKE]/
				},
				AfterException = (sink, sp) =>
				{
// USE /[MANUAL TRA AFTER_LOAD_DUPLICATE_EX F_BROKE]/
				}
			};

			return GenericHandlePostFormDuplicate(eventSink, model);
		}

		#endregion

		#region F_broke_Cancel

		//
		// GET: /Broker/F_broke_Cancel
// USE /[MANUAL TRA CONTROLLER_CANCEL_GET F_BROKE]/
		public ActionResult F_broke_Cancel()
		{
			if (Navigation.CurrentLevel.FormMode == FormMode.New || Navigation.CurrentLevel.FormMode == FormMode.Duplicate)
			{
				PersistentSupport sp = UserContext.Current.PersistentSupport;
				try
				{
					GenioMVC.Models.Broker model = new(UserContext.Current);
					model.klass.QPrimaryKey = Navigation.GetStrValue("broker");

// USE /[MANUAL TRA BEFORE_CANCEL F_BROKE]/

					sp.openTransaction();
					model.Destroy();
					sp.closeTransaction();

// USE /[MANUAL TRA AFTER_CANCEL F_BROKE]/

				}
				catch (Exception e)
				{
					sp.rollbackTransaction();
					sp.closeConnection();

					var exceptionUserMessage = Resources.Resources.PEDIMOS_DESCULPA__OC63848;
					if (e is GenioException && (e as GenioException).UserMessage != null)
						exceptionUserMessage = Translations.Get((e as GenioException).UserMessage, UserContext.Current.User.Language);
					return JsonERROR(exceptionUserMessage);
				}

				Navigation.SetValue("ForcePrimaryRead_broker", "true", true);
			}

			Navigation.ClearValue("broker");

			return JsonOK(new { Success = true, currentNavigationLevel = Navigation.CurrentLevel.Level });
		}

		#endregion


		// POST: /Broker/F_broke_SaveEdit
		[HttpPost]
		public ActionResult F_broke_SaveEdit([FromBody] F_broke_ViewModel model)
		{
			EventSink eventSink = new()
			{
				MethodName = "F_broke_SaveEdit",
				ViewName = "F_broke",
				AreaName = "broker",
				BeforeOp = (sink, sp) =>
				{
// USE /[MANUAL TRA BEFORE_APPLY_EDIT F_BROKE]/
				},
				AfterOp = (sink, sp) =>
				{
// USE /[MANUAL TRA AFTER_APPLY_EDIT F_BROKE]/
				}
			};

			return GenericHandlePostFormApply(eventSink, model);
		}

		public class F_brokeDocumValidateTickets : RequestDocumValidateTickets
		{
			public F_broke_ViewModel Model { get; set; }
		}

		/// <summary>
		/// Checks if the model is valid and, if so, updates the specified tickets with write permissions
		/// </summary>
		/// <param name="requestModel">The request model with a list of tickets and the form model</param>
		/// <returns>A JSON response with the result of the operation</returns>
		public ActionResult UpdateFilesTicketsF_broke([FromBody] F_brokeDocumValidateTickets requestModel)
		{
			requestModel.Model.Init(UserContext.Current);
			return UpdateFilesTickets(requestModel.Tickets, requestModel.Model, requestModel.IsApply);
		}
	}
}
