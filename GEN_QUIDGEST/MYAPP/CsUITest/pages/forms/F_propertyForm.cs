using quidgest.uitests.pages.forms.core;

#nullable enable

namespace quidgest.uitests.pages.forms;

[System.CodeDom.Compiler.GeneratedCode("Genio", "")]
public class F_propertyForm : Form
{
	/// <summary>
	/// ID
	/// </summary>
	public BaseInputControl PropertyId => new BaseInputControl(driver, ContainerLocator, "container-F_PROPERTY__PROPERTY__ID", "#F_PROPERTY__PROPERTY__ID");

	/// <summary>
	/// MAIN INFO
	/// </summary>
	public CollapsibleZoneControl PseudNewgrp01 => new CollapsibleZoneControl(driver, ContainerLocator, "#F_PROPERTY__PSEUD__NEWGRP01-container");

	/// <summary>
	/// Main Photo
	/// </summary>
	public BaseInputControl PropertyMain_photo => new BaseInputControl(driver, ContainerLocator, "container-F_PROPERTY__PROPERTY__MAIN_PHOTO", "#F_PROPERTY__PROPERTY__MAIN_PHOTO");

	/// <summary>
	/// Title
	/// </summary>
	public BaseInputControl PropertyTitle => new BaseInputControl(driver, ContainerLocator, "container-F_PROPERTY__PROPERTY__TITLE", "#F_PROPERTY__PROPERTY__TITLE");

	/// <summary>
	/// Price 0000000000,00
	/// </summary>
	public BaseInputControl PropertyPrice => new BaseInputControl(driver, ContainerLocator, "container-F_PROPERTY__PROPERTY__PRICE", "#F_PROPERTY__PROPERTY__PRICE");

	/// <summary>
	/// Description
	/// </summary>
	public BaseInputControl PropertyDescription => new BaseInputControl(driver, ContainerLocator, "container-F_PROPERTY__PROPERTY__DESCRIPTION", "#F_PROPERTY__PROPERTY__DESCRIPTION");

	/// <summary>
	/// New Group
	/// </summary>
	public IWebElement PseudNewgrp05 => throw new NotImplementedException();

	/// <summary>
	/// brokers information
	/// </summary>
	public CollapsibleZoneControl PseudNewgrp04 => new CollapsibleZoneControl(driver, ContainerLocator, "#F_PROPERTY__PSEUD__NEWGRP04-container");

	/// <summary>
	/// Broker.name
	/// </summary>
	public LookupControl BrokerName => new LookupControl(driver, ContainerLocator, "container-F_PROPERTY__BROKER__NAME");
	public SeeMorePage BrokerNameSeeMorePage => new SeeMorePage(driver, "F_PROPERTY", "F_PROPERTY__BROKER__NAME");

	/// <summary>
	/// Email
	/// </summary>
	public IWebElement BrokerEmail => throw new NotImplementedException();

	/// <summary>
	/// Photo
	/// </summary>
	public IWebElement BrokerPhoto => throw new NotImplementedException();

	/// <summary>
	/// Localization
	/// </summary>
	public CollapsibleZoneControl PseudNewgrp03 => new CollapsibleZoneControl(driver, ContainerLocator, "#F_PROPERTY__PSEUD__NEWGRP03-container");

	/// <summary>
	/// City
	/// </summary>
	public LookupControl CityCity => new LookupControl(driver, ContainerLocator, "container-F_PROPERTY__CITY__CITY");
	public SeeMorePage CityCitySeeMorePage => new SeeMorePage(driver, "F_PROPERTY", "F_PROPERTY__CITY__CITY");

	/// <summary>
	/// Country
	/// </summary>
	public IWebElement CountryCountry => throw new NotImplementedException();

	/// <summary>
	/// details
	/// </summary>
	public CollapsibleZoneControl PseudNewgrp02 => new CollapsibleZoneControl(driver, ContainerLocator, "#F_PROPERTY__PSEUD__NEWGRP02-container");

	/// <summary>
	/// Date
	/// </summary>
	public DateInputControl PropertyDateconstruction => new DateInputControl(driver, ContainerLocator, "#F_PROPERTY__PROPERTY__DATECONSTRUCTION");

	/// <summary>
	/// Building age
	/// </summary>
	public BaseInputControl PropertyBuildingage => new BaseInputControl(driver, ContainerLocator, "container-F_PROPERTY__PROPERTY__BUILDINGAGE", "#F_PROPERTY__PROPERTY__BUILDINGAGE");

	/// <summary>
	/// Building type
	/// </summary>
	public EnumControl PropertyBuildingtype => new EnumControl(driver, ContainerLocator, "container-F_PROPERTY__PROPERTY__BUILDINGTYPE");

	/// <summary>
	/// Bathrooms
	/// </summary>
	public BaseInputControl PropertyBathroomsnumber => new BaseInputControl(driver, ContainerLocator, "container-F_PROPERTY__PROPERTY__BATHROOMSNUMBER", "#F_PROPERTY__PROPERTY__BATHROOMSNUMBER");

	/// <summary>
	/// Typology
	/// </summary>
	public RadiobuttonControl PropertyTypology => new RadiobuttonControl(driver, ContainerLocator, "container-F_PROPERTY__PROPERTY__TYPOLOGY");

	/// <summary>
	/// Size
	/// </summary>
	public BaseInputControl PropertySize => new BaseInputControl(driver, ContainerLocator, "container-F_PROPERTY__PROPERTY__SIZE", "#F_PROPERTY__PROPERTY__SIZE");

	/// <summary>
	/// Properties
	/// </summary>
	public ListControl PseudProperty_grid => new ListControl(driver, ContainerLocator, "#F_PROPERTY__PSEUD__PROPERTY_GRID");

	/// <summary>
	/// Contacts
	/// </summary>
	public ListControl PseudContact_grid => new ListControl(driver, ContainerLocator, "#F_PROPERTY__PSEUD__CONTACT_GRID");

	public F_propertyForm(IWebDriver driver, FORM_MODE mode, By? containerLocator = null)
		: base(driver, mode, "F_PROPERTY", containerLocator: containerLocator) { }
}
